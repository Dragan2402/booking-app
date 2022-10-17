using Booking.Services.Authentication.Application.Interfaces;
using Microsoft.Extensions.Options;
using JsonWebToken;
using Booking.Services.Common.Data;
using Encoding = System.Text.Encoding;
using Booking.Services.Common.Exception;

namespace Booking.Services.Authentication.Application.Services.Jwt;

public class JwtService : IJwtService, IDisposable
{
    private readonly string _issuer;

    private readonly int _defaultIdentityTokenValidityInSeconds;
    private readonly int _defaultRefreshTokenValidityInSeconds;

    private readonly JwtWriter _identityTokenWriter;
    private readonly JwtWriter _refreshTokenWriter;

    private readonly KeyVaultLinkedDictionary _domainKeys = new();

    public JwtService(IOptions<JwtOptions> options)
    {
        _defaultIdentityTokenValidityInSeconds = options.Value.DefaultIdentityTokenValidityInSeconds;
        _defaultRefreshTokenValidityInSeconds = options.Value.DefaultRefreshTokenValidityInSeconds;
        _issuer = options.Value.TokenIssuer;

        _identityTokenWriter = new JwtWriter
        {
            EnableHeaderCaching = true,
            GenerateIssuedTime = true,
            TokenLifetimeInSeconds = _defaultIdentityTokenValidityInSeconds
        };

        _refreshTokenWriter = new JwtWriter
        {
            EnableHeaderCaching = true,
            GenerateIssuedTime = true,
            TokenLifetimeInSeconds = _defaultRefreshTokenValidityInSeconds
        };
    }

    public (TokenMintingResult IdentityToken, TokenMintingResult RefreshToken) MintLoginTokens(string identity, string domain)
    {
        var identityTokenDescriptor = new JwsDescriptor(DomainKey(domain), SignatureAlgorithm.HS256)
        {
            Payload = new JwtPayload
            {
                { JwtClaimNames.Aud, domain },
                { JwtClaimNames.Iss, _issuer },
                { "type", TokenType.Access },
                { "sub", identity }
            }
        };

        var refreshTokenDescriptor = new JwsDescriptor(DomainKey(domain), SignatureAlgorithm.HS256)
        {
            Payload = new JwtPayload
            {
                { JwtClaimNames.Aud, domain },
                { JwtClaimNames.Iss, _issuer },
                { "type", TokenType.Refresh },
                { "sub", identity }
            }
        };

        TokenMintingResult identityToken = new TokenMintingResult()
        {
            Token = _identityTokenWriter.WriteTokenString(identityTokenDescriptor),
            ExpiresAt = NewIdentityTokenExpiresAt()
        };

        TokenMintingResult refreshToken = new TokenMintingResult()
        {
            Token = _refreshTokenWriter.WriteTokenString(refreshTokenDescriptor),
            ExpiresAt = NewRefreshTokenExpiresAt()
        };

        return (identityToken, refreshToken);
    }

    public TokenValidationOutput ValidateToken(string token, string origin)
    {
        var policy = new TokenValidationPolicyBuilder()
            .RequireSignature(_issuer, DomainKey(origin), SignatureAlgorithm.HS256)
            .RequireAudience(origin)
            .RequireClaim("sub")
            .RequireClaim("type")
            .Build();

        var parseSuccessful = JsonWebToken.Jwt.TryParse(token, policy, out var validated);

        try
        {
            if (parseSuccessful
                && validated.Payload != null
                && validated.Payload.TryGetClaim("sub", out var identity)
                && validated.Payload.TryGetClaim("type", out var type))
                return new TokenValidationOutput()
                {
                    Identity = identity.GetString() ?? throw new TokenValidationException(),
                    Type = type.GetString() ?? throw new TokenValidationException()
                };
            else
                throw new TokenValidationException();
        }
        finally
        {
            validated.Dispose();
        }
    }

    private DateTime NewRefreshTokenExpiresAt()
    {
        return DateTime.UtcNow.AddSeconds(_defaultRefreshTokenValidityInSeconds);
    }

    private DateTime NewIdentityTokenExpiresAt()
    {
        return DateTime.UtcNow.AddSeconds(_defaultIdentityTokenValidityInSeconds);
    }

    public void Dispose()
    {
        this._domainKeys.Dispose();
    }

    private SymmetricJwk DomainKey(string domain) =>
        SymmetricJwk.FromByteArray(Encoding.ASCII.GetBytes(
            _domainKeys.GetOrFetch(Convert.ToBase64String(Encoding.ASCII.GetBytes(domain)))
                       .Read()));


}