using Booking.Gateway.Controllers._Common.Validation;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.UseCases.Logins.Login;

public class LoginContract
{
    public string Origin { get; set; } = string.Empty;

    public string GrantType { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string RefreshToken { get; set; } = string.Empty;
}