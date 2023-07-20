using Booking.Services.Common.Domain;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Domain;

public class User : Entity, IAuditable, ISoftDeletable
{
    public User(
        Guid id,
        string firstName,
        string lastName,
        Guid identityId,
        Guid roleId
        ) : base(id)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = default!;
        this.IdentityId = identityId;
        this.RoleId = roleId;
        this.Role = default!;
        this.Cottages = new List<Cottage>();
    }
    public User()
    {
        this.FirstName = string.Empty;
        this.LastName = string.Empty;
        this.Address = default!;
        this.Role = default!;
        this.Cottages = new List<Cottage>();
    }

    public User(Guid id)
    {
        Id = id;
        this.FirstName = string.Empty;
        this.LastName = string.Empty;
        this.Address = default!;
        this.Role = default!;
        this.Cottages = new List<Cottage>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid IdentityId { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public List<Cottage> Cottages { get; set; }
    public Role Role { get; set; }
    public Guid RoleId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

}
