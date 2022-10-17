namespace Booking.Gateway.Controllers.Authentication.Logins.Responses;

public class LoginGatewayResponse
{
    public string AccessToken { get; set; } = string.Empty;

    public string TokenType { get; set; } = string.Empty;

    public int ExpiresIn { get; set; }

    public string RefreshToken { get; set; } = string.Empty;    
}