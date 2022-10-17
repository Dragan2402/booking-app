using Booking.Services.Booking.Domain;
using Booking.Services.Common.Data.Maybe;

namespace Booking.Services.Booking.Application.Repositories;

public interface IReservationRepository
{
    Task CreateAsync(Reservation reservation);
    Task Delete(Reservation reservation);
    Task<List<Reservation>> GetAllAsync();
    Task<Maybe<Reservation>> GetByIdAsync(Guid id);
}