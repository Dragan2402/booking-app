using Booking.Services.Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Booking.Services.Common.Infrastructure;

public abstract class ADbContext<T> : DbContext
{
    public ADbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(T).Assembly);
        AddAuditPropertiesToAuditableEntities(modelBuilder);
        AddSoftDeletablePropertyToSoftDeletableEntities(modelBuilder);
        AddSoftDeleteQueryFilterToSoftDeletableEntities(modelBuilder);

    }

    public override int SaveChanges()
    {
        SetAuditProperties();
        SetSoftDeletableProperty();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SetAuditProperties();
        SetSoftDeletableProperty();
        return base.SaveChangesAsync();
    }

    private void AddSoftDeleteQueryFilterToSoftDeletableEntities(ModelBuilder modelBuilder)
    {
        Expression<Func<ISoftDeletable, bool>> expressionFilter = softDeletable => softDeletable.DeletedAt == null;

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsAssignableTo(typeof(ISoftDeletable)))
            {
                var parameter = Expression.Parameter(entityType.ClrType);
                var body = ReplacingExpressionVisitor.Replace(
                    expressionFilter.Parameters.First(),
                    parameter,
                    expressionFilter.Body);
                var lambdaExpression = Expression.Lambda(body, parameter);
                entityType.SetQueryFilter(lambdaExpression);
            }
        }
    }

    private void AddSoftDeletablePropertyToSoftDeletableEntities(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsAssignableTo(typeof(ISoftDeletable)))
            {
                entityType.GetProperty(nameof(ISoftDeletable.DeletedAt)).SetColumnType("datetimeoffset(2)");
            }
        }
    }

    private void AddAuditPropertiesToAuditableEntities(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsAssignableTo(typeof(IAuditable)))
            {
                entityType.GetProperty(nameof(IAuditable.CreatedAt)).SetColumnType("datetimeoffset(2)");
                entityType.GetProperty(nameof(IAuditable.UpdatedAt)).SetColumnType("datetimeoffset(2)");
            }
        }
    }


    private void SetAuditProperties()
    {
        var modifiedAuditableEntries = ChangeTracker.Entries()
            .Where(e => e.Entity is IAuditable &&
                        e.State is EntityState.Added or EntityState.Modified);

        foreach (EntityEntry entry in modifiedAuditableEntries)
        {
            var auditableEntity = (IAuditable)entry.Entity;
            var dateTimeNow = DateTimeOffset.UtcNow;
            switch (entry.State)
            {
                case EntityState.Added:
                    auditableEntity.CreatedAt = dateTimeNow;
                    auditableEntity.UpdatedAt = dateTimeNow;
                    break;

                case EntityState.Modified:
                    auditableEntity.UpdatedAt = dateTimeNow;
                    break;
            }
        }
    }

    private void SetSoftDeletableProperty()
    {
        var deletedSoftDeletableEntries = ChangeTracker.Entries()
            .Where(e => e.Entity is ISoftDeletable && e.State is EntityState.Deleted);

        foreach (EntityEntry entry in deletedSoftDeletableEntries)
        {
            var softDeletableEntity = (ISoftDeletable)entry.Entity;
            var dateTimeNow = DateTimeOffset.UtcNow;
            softDeletableEntity.DeletedAt = dateTimeNow;
            entry.State = EntityState.Modified;
        }
    }
}