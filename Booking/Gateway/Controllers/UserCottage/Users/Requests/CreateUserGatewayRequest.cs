using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Users.Requests;

public class CreateUserGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public CreateUserIdentityGatewayRequest CreateUserIdentityGatewayRequest { get; set; } = default!;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public UserGatewayRequest UserGatewayRequest { get; set; } = default!;
}