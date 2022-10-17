using Booking.Services.Common.Data.Maybe;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.Repositories;

public interface IUserRepository
{
    Task CreateAsync(User user);
    Task Delete(User user);
    Task<List<User>> GetAllAsync();
    Task<Maybe<User>> GetById(Guid id);
    Task<Maybe<User>> ReadClientById(Guid id);
}