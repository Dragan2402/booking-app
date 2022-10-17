using Booking.Gateway.Controllers._Common.Requests;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Users.Requests;

public class UpdateUserGatewayRequest
{
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string LastName { get; set; } = string.Empty;

    public UpdateAddressGatewayRequest? Address { get; set; }
}