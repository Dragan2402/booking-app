using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Domain;
using Booking.Services.Booking.Infrastructure.Database;
using Booking.Services.Common.Infrastructure;

namespace Booking.Services.Booking.Infrastructure.Repositories;

public class OfferRepository : ARepository<Offer>, IOfferRepository
{
    public OfferRepository(BookingContext context) : base(context) { }

    private BookingContext Context => (this.BaseContext as BookingContext)!;

}