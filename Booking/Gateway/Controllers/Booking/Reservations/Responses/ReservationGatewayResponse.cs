namespace Booking.Gateway.Controllers.Booking.Reservations.Responses;

public class ReservationGatewayResponse
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid CottageId { get; set; }
    public DateTimeOffset DateFrom { get; set; }
    public DateTimeOffset DateTo { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}