using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Domain;
using Booking.Services.Booking.Infrastructure.Database;
using Booking.Services.Common.Data.Maybe;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Booking.Infrastructure.Repositories;

public class ReservationRepository : ARepository<Reservation>, IReservationRepository
{
    public ReservationRepository(BookingContext context) : base(context) { }

    private BookingContext Context => (this.BaseContext as BookingContext)!;

    public async Task CreateAsync(Reservation reservation)
    {
        await Context.Reservations.AddAsync(reservation);
    }

    public Task Delete(Reservation reservation)
    {
        return Task.FromResult(Context.Reservations.Remove(reservation)); 
    }

    public async Task<List<Reservation>> GetAllAsync()
    {
        return await Context.Reservations.ToListAsync();
    }

    public async Task<Maybe<Reservation>> GetByIdAsync(Guid id)
    {
        var possibleReservation = await Context.Reservations.SingleOrDefaultAsync(r => r.Id == id);
        
        return new Maybe<Reservation>(possibleReservation);
    }
}