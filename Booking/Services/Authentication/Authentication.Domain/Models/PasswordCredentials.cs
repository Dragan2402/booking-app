using Booking.Services.Common.Domain;

namespace Booking.Services.Authentication.Domain.Models;

public class PasswordCredentials : IAuditable
{
    public PasswordCredentials(Guid identityId, string password, string salt)
    {
        IdentityId = identityId;
        Password = password;
        Salt = salt;
    }

    private PasswordCredentials()
    {
        Password = string.Empty;
        Salt = string.Empty;
    }

    public Guid IdentityId { get; }
    public string Password { get; private set; }
    public string Salt { get; private set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public void SetCredentials(string password, string salt)
    {
        Password = password;
        Salt = salt;
    }

}