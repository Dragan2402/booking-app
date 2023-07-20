using Booking.Grpc.AuthenticationContract.Interfaces;

namespace Booking.Gateway.Controllers.Authorization._Common;

public static class AuthorizationExtensions
{
    public static string ExtractOrigin(this HttpRequest request)
    {
        var originHeaders = request.Headers.Origin;
        if (originHeaders.Count != 1 || String.IsNullOrEmpty(originHeaders.Single()))
            throw new Exception("Origin header is malformed or missing");
        else
            return originHeaders.Single()!;
    }

    public static string ExtractToken(this HttpRequest request)
    {
        var authorizationHeaders = request.Headers.Authorization;
        if (authorizationHeaders.Count != 1
            || String.IsNullOrEmpty(authorizationHeaders.Single())
            || !authorizationHeaders.Single()!.StartsWith("Bearer "))
            throw new Exception("Authorization header is malformed or missing");
        else
            return authorizationHeaders.Single()![7..];
    }

    public static ITokenValidationService EnsureNotNull(this ITokenValidationService? service)
    {
        if (service == null)
        {
            throw new Exception("Token Validation Client was not found in registered services");
        }
        return service;
    }
}