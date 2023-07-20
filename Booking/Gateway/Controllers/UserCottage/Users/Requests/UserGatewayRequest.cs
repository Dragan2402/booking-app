using Booking.Gateway.Controllers._Common.Requests;
using Booking.Grpc.UserCottageContract;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Users.Requests;

public class UserGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string FirstName { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string LastName { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public string Role { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public AddressGatewayRequest Address { get; set; } = default!;
}