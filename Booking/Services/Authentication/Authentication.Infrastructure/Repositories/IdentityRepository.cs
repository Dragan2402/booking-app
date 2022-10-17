using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Authentication.Infrastructure.Database;
using Booking.Services.Common.Data.Maybe;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Authentication.Infrastructure.Repositories;

public class IdentityRepository : ARepository<Identity>, IIdentityRepository
{
    public IdentityRepository(AuthenticationContext context) : base(context) { }

    private AuthenticationContext Context => (this.BaseContext as AuthenticationContext)!;

    public async Task<Maybe<Identity>> ReadByEmail(string email)
    {
        var possibleIdentity = await Context.Identities.AsNoTracking().SingleOrDefaultAsync(i => i.Email == email);
        return new Maybe<Identity>(possibleIdentity);
    }

    public async Task CreateAsync(Identity identity)
    {
        await Context.Identities.AddAsync(identity);
    }

    public async Task<Maybe<Identity>> GetByEmail(string email)
    {
        var possibleIdentity = await Context.Identities.Include(i => i.Credentials).SingleOrDefaultAsync(i => i.Email == email);
        return new Maybe<Identity>(possibleIdentity);
    }

    public async Task<Maybe<Identity>> GetByIdAsync(Guid id)
    {
        var possibleIdentity = await Context.Identities.FirstOrDefaultAsync(i => i.Id == id);
        return new Maybe<Identity>(possibleIdentity);
    }

    public async Task<bool> ExistsByIdAsync(Guid id)
    {
        return await Context.Identities.AnyAsync(i => i.Id == id);
    }

    public async Task<Maybe<Identity>> GetById(Guid id)
    {
        var possibleIdentity = await Context.Identities.Include(i => i.Credentials).SingleOrDefaultAsync(i => i.Id == id);
        return new Maybe<Identity>(possibleIdentity);
    }

    public Task Delete(Identity identity)
    {
        return Task.FromResult(Context.Identities.Remove(identity));
    }
}