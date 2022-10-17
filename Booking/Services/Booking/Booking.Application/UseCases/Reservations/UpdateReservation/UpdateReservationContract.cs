namespace Booking.Services.Booking.Application.UseCases.Reservations.UpdateReservation;

public class UpdateReservationContract
{
    public Guid Id { get; set; }

    public DateTimeOffset? DateFrom { get; set; }

    public DateTimeOffset? DateTo { get; set; }
}