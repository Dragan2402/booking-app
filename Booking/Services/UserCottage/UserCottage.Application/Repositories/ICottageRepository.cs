using Booking.Services.Common.Data.Maybe;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.Repositories;

public interface ICottageRepository
{
    Task CreateAsync(Cottage cottage);
    Task Delete(Cottage cottage);
    Task<List<Cottage>> GetAllAsync();
    Task<Maybe<Cottage>> GetById(Guid id);
    Task<Maybe<Cottage>> ReadById(Guid id);
    Task<Maybe<Cottage>> ReadByName(string name);
    Task UpdateCottage(Cottage cottageToUpdate);
}