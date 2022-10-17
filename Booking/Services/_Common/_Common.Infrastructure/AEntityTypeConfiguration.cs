using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Common.Infrastructure;

public abstract class AEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        this.BuildModelConfiguration(builder);
    }

    protected abstract void BuildModelConfiguration(EntityTypeBuilder<TEntity> builder);
}
