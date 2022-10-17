using Booking.Gateway.Controllers._Common.Validation;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.Booking.Reservations.Requests;

public class UpdateReservationGatewayRequest
{
    [NonEmptyDateTimeOffset(ErrorMessage = "{0} is required.")]
    public DateTimeOffset DateFrom { get; set; }

    [NonEmptyDateTimeOffset(ErrorMessage = "{0} is required.")]
    public DateTimeOffset DateTo { get; set; }
}