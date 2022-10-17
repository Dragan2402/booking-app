namespace Booking.Services.Common.Domain;

public interface IRepository<TEntity> where TEntity : class
{
    public Task AddAsync(TEntity entity);
}