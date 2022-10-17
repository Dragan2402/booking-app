using Booking.Gateway.Controllers._Common.Validation;

namespace Booking.Gateway.Controllers.Booking.Reservations.Requests;

public class CreateReservationGatewayRequest
{
    [NonEmptyGuidAttribute(ErrorMessage ="{0} is required.")]
    public Guid CottageId { get; set; }

    [NonEmptyGuidAttribute(ErrorMessage = "{0} is required.")]
    public Guid ClientId { get; set; }

    [NonEmptyDateTimeOffset(ErrorMessage = "{0} is required.")]
    public DateTimeOffset DateFrom { get; set; }

    [NonEmptyDateTimeOffset(ErrorMessage = "{0} is required.")]
    public DateTimeOffset DateTo { get; set; }
}