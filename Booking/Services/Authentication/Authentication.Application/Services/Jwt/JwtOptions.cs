namespace Booking.Services.Authentication.Application.Services.Jwt;
public class JwtOptions
{
    public const string ConfigurationSectionName = "JsonWebTokenConfiguration";

    public string TokenIssuer { get; set; } = string.Empty;

    public int DefaultIdentityTokenValidityInSeconds { get; set; }

    public int DefaultRefreshTokenValidityInSeconds { get; set; }
}