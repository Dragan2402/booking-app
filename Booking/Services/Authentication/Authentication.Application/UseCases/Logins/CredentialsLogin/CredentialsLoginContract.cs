namespace Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;

public class CredentialsLoginContract
{
    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Origin { get; set; } = string.Empty;
}