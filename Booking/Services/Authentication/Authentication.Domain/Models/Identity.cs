using Booking.Services.Common.Data.Maybe;
using Booking.Services.Common.Domain;

namespace Booking.Services.Authentication.Domain.Models;

public class Identity : Entity, IAuditable, ISoftDeletable
{
    public Identity(Guid id, string email)
    {
        Id = id;
        Email = email;
        Role = default!;
    }

    private Identity()
    {
        Email = string.Empty;
        Role = default!;
    }

    public string Email { get; set; }
    public PasswordCredentials? Credentials { get; private set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public DateTimeOffset? LastLoginAt { get; set; }
    public void SetCredentials(string password, string salt)
    {
        if (Credentials == null)
            Credentials = new PasswordCredentials(this.Id, password, salt);
        else
            Credentials.SetCredentials(password, salt);
    }
    public Maybe<(string Password, string Salt)> TryGetPasswordCredentials()
    {
        if (Credentials != null)
            return new Maybe<(string Password, string Salt)>((Credentials.Password, Credentials.Salt));
        return new Maybe<(string Password, string Salt)>();
    }
}