using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Data.Maybe;

namespace Booking.Services.Authentication.Application.Repositories;

public interface IIdentityRepository
{
    Task CreateAsync(Identity identity);
    Task<bool> ExistsByIdAsync(Guid id);
    Task<Maybe<Identity>> GetByEmail(string email);
    Task<Maybe<Identity>> GetByIdAsync(Guid id);
    Task Delete(Identity identity);
    Task<Maybe<Identity>> GetById(Guid id);
    Task<Maybe<Identity>> ReadByEmail(string email);
}
