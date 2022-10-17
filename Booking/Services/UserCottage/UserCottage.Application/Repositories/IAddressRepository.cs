using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Application.Repositories;

public interface IAddressRepository
{
    Task Delete(Address address);
    Task UpdateAddress(Address address);
}