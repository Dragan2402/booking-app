namespace Booking.Services.Authentication.Application.UseCases.Logins._Common;

public static class LoginUtilities
{
    public static void UpdateLastLoginAt(Domain.Models.Identity identity)
    {
        identity.LastLoginAt = DateTimeOffset.UtcNow;
    }
}