namespace Booking.Services.Authentication.Application.Services.Jwt;

public class TokenValidationOutput
{
    public string Identity { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;   
}