using Booking.Services.Common.Domain;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Domain;

public class User : Entity, IAuditable, ISoftDeletable
{
    public User(
        Guid id,
        string firstName,
        string lastName,
        Guid identityId
        ) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Picture = string.Empty;
        Address = default!;
        IdentityId = identityId;
        Cottages = new List<Cottage>();
    }
    public User()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Picture = string.Empty;
        Address = default!;
        Cottages = new List<Cottage>();
    }

    public User(Guid id)
    {
        Id = id;
        FirstName = string.Empty;
        LastName = string.Empty;
        Picture = string.Empty;
        Address = default!;
        Cottages = new List<Cottage>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Picture { set; get; }
    public Guid IdentityId { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public List<Cottage> Cottages { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

}
