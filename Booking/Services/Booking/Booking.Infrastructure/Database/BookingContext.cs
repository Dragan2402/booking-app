using Booking.Services.Booking.Domain;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Booking.Infrastructure.Database;

public class BookingContext : ADbContext<BookingContext>
{
    public BookingContext(DbContextOptions<BookingContext> options) : base(options)
    {
    }
    public DbSet<Reservation> Reservations => this.Set<Reservation>();
    public DbSet<Offer> Offers => this.Set<Offer>();


}