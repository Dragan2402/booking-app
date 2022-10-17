using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain.Models;
using Booking.Services.UserCottage.Infrastructure.Database;

namespace Booking.Services.UserCottage.Infrastructure.Repositories;

public class AddressRepository : ARepository<Address>, IAddressRepository
{
    public AddressRepository(UserCottageContext context) : base(context) { }

    private UserCottageContext Context => (this.BaseContext as UserCottageContext)!;

    public Task Delete(Address address)
    {

        return Task.FromResult(Context.Addresses.Remove(address));
    }

    public Task UpdateAddress(Address address)
    {
        return Task.FromResult(Context.Addresses.Update(address));
    }
}