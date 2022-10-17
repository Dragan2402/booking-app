namespace Booking.Services.Authentication.Application.UseCases.Logins.RefreshTokenLogin;

public class RefreshTokenLoginContract
{
    public string RefreshToken { get; set; } = string.Empty;

    public string Origin { get; set; } = string.Empty;
}