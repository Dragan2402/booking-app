namespace Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;

public class CreateReservationContract
{
    public Guid ClientId { get; set; }

    public Guid CottageId { get; set; }

    public DateTimeOffset DateFrom { get; set; }

    public DateTimeOffset DateTo { get; set; }
}