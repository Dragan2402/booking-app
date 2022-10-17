using Booking.Services.Common.Domain;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Common.Infrastructure;

public abstract class ARepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    public ARepository(DbContext context)
    {
        this.BaseContext = context;
    }

    protected DbContext BaseContext { get; set; }

    public virtual async Task AddAsync(TEntity entity) => await this.BaseContext.Set<TEntity>().AddAsync(entity);
}