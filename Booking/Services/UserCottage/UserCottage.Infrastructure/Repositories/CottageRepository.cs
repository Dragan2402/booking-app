using Booking.Services.Common.Data.Maybe;
using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.UserCottage.Infrastructure.Repositories;

public class CottageRepository : ARepository<Cottage>, ICottageRepository
{
    public CottageRepository(UserCottageContext context) : base(context) { }

    private UserCottageContext Context => (this.BaseContext as UserCottageContext)!;

    public async Task CreateAsync(Cottage cottage)
    {
        await Context.Cottages.AddAsync(cottage);
    }

    public Task Delete(Cottage cottage)
    {
        return Task.FromResult(Context.Cottages.Remove(cottage));
    }

    public async Task<List<Cottage>> GetAllAsync()
    {
        return await Context.Cottages.Include(c => c.Address).ToListAsync();
    }

    public async Task<Maybe<Cottage>> GetById(Guid id)
    {
        var query = Context.Cottages.Include(c => c.Address);
        var possibleCottage = await query.FirstOrDefaultAsync(c => c.Id == id);
        return new Maybe<Cottage>(possibleCottage);
    }

    public async Task<Maybe<Cottage>> ReadById(Guid id)
    {
        var query = Context.Cottages.Include(c => c.Address).AsNoTracking();
        var possibleCottage = await query.SingleOrDefaultAsync(c => c.Id == id);
        return new Maybe<Cottage>(possibleCottage);
    }

    public async Task<Maybe<Cottage>> ReadByName(string name)
    {
        var possibleCottage = await Context.Cottages.Include(c => c.Address).AsNoTracking().SingleOrDefaultAsync(c => c.Name == name);
        return new Maybe<Cottage>(possibleCottage);
    }

    public Task UpdateCottage(Cottage cottageToUpdate)
    {
        return Task.FromResult(Context.Cottages.Update(cottageToUpdate));
    }
}