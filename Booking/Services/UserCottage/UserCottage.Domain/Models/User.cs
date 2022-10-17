using Booking.Services.Common.Domain;
using Booking.Services.UserCottage.Domain.Models;
using Booking.Services.UserCottage.Domain.Models.Enum;

namespace Booking.Services.UserCottage.Domain;

public class User : Entity, IAuditable, ISoftDeletable
{
    public User(
        Guid id,
        string firstName,
        string lastName,
        Guid identityId,
        EUserType eUserType
        ) : base(id)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = default!;
        this.IdentityId = identityId;
        this.UserType = eUserType;
        this.Cottages = new List<Cottage>();
    }
    public User()
    {
        this.FirstName = string.Empty;
        this.LastName = string.Empty;
        this.Address = default!;
        this.Cottages = new List<Cottage>();
    }

    public User(Guid id)
    {
        Id = id;
        this.FirstName = string.Empty;
        this.LastName = string.Empty;
        this.Address = default!;
        this.Cottages = new List<Cottage>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid IdentityId { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public List<Cottage> Cottages { get; set; }
    public EUserType UserType { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

}
