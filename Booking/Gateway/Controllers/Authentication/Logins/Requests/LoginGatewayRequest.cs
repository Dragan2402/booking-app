using Booking.Gateway.Controllers._Common.Validation;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.Authentication.Logins.Requests;

public class LoginGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public string GrantType { get; set; } = string.Empty;

    [RequiredIf(PropertyName = "GrantType", DesiredValue = "credentials", AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public string Email { get; set; } = string.Empty;

    [RequiredIf(PropertyName = "GrantType", DesiredValue = "credentials", AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public string Password { get; set; } = string.Empty;

    [RequiredIf(PropertyName = "GrantType", DesiredValue = "refresh_token", AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public string RefreshToken { get; set; } = string.Empty;
}