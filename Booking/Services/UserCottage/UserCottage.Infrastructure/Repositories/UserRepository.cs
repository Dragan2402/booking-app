using Booking.Services.Common.Data.Maybe;
using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.UserCottage.Infrastructure.Repositories;

public class UserRepository : ARepository<User>, IUserRepository
{
    public UserRepository(UserCottageContext context) : base(context) { }

    private UserCottageContext Context => (this.BaseContext as UserCottageContext)!;

    public async Task CreateAsync(User user)
    {
        await Context.Users.AddAsync(user);
    }

    public Task Delete(User user)
    {
        return Task.FromResult(Context.Users.Remove(user));
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await Context.Users.Include(c => c.Address).ThenInclude(a => a.City).ThenInclude(c => c.Country).ToListAsync();
    }

    public async Task<Maybe<User>> GetById(Guid id)
    {
        var query = Context.Users.Include(u => u.Address).ThenInclude(a => a.City).ThenInclude(c => c.Country);
        var possibleUser = await query.SingleOrDefaultAsync(u => u.Id == id);
        return new Maybe<User>(possibleUser);
    }

    public async Task<Maybe<User>> ReadClientById(Guid id)
    {
        var possibleClient = await Context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == id);
        return new Maybe<User>(possibleClient);
    }
}