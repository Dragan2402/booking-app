using Booking.Services.Authentication.Application.Services.Jwt;

namespace Booking.Services.Authentication.Application.UseCases.Logins._Common;

public class LoginResult
{
    public LoginResult((TokenMintingResult Identity, TokenMintingResult Refresh) tokens)
    {
        IdentityToken = tokens.Identity.Token;
        RefreshToken = tokens.Refresh.Token;
        ExpiresAt = tokens.Identity.ExpiresAt;
    }

    public string IdentityToken { get; }

    public string RefreshToken { get; }

    public DateTime ExpiresAt { get; }
}