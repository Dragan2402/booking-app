using Booking.Services.Authentication.Application.Services.Jwt;

namespace Booking.Services.Authentication.Application.Interfaces;

public interface IJwtService
{
    (TokenMintingResult IdentityToken, TokenMintingResult RefreshToken) MintLoginTokens(string identity, string domain);

    TokenValidationOutput ValidateToken(string token, string origin);
}