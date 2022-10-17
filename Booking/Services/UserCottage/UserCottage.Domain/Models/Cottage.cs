using Booking.Services.Common.Domain;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Domain;

public class Cottage : IAuditable, ISoftDeletable
{
    public Cottage(Guid id, string name, Guid ownerId)
    {
        this.Id = id;
        this.Name = name;
        this.OwnerId = ownerId;
        this.Address = default!;
        this.Owner = default!;
    }
    public Cottage()
    {
        this.Name = string.Empty;
        this.Address = default!;
        this.Owner = default!;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid OwnerId { get; set; }
    public User Owner { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}