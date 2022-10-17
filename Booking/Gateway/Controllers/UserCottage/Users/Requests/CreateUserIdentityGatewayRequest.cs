using Booking.Gateway.Controllers._Common.Validation;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Users.Requests;

public class CreateUserIdentityGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    [RegularExpression(RegexValidations.Email, ErrorMessage = "Invalid format of {0}")]
    public string Email { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string Password { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string ConfirmPassword { get; set; } = string.Empty;
}