namespace Booking.Services.Authentication.Application.Services.Jwt;

public class TokenMintingResult
{
    public string Token { get; set; } = string.Empty;

    public DateTime ExpiresAt { get; set; }
} 