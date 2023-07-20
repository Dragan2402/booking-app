using Booking.Services.Common.Domain;

namespace Booking.Services.UserCottage.Domain.Models;

public class Address : IAuditable, ISoftDeletable
{
    public Address(Guid id, string street, string postalCode, string country)
    {
        this.Id = id;
        this.Street = street;
        this.City = default!;
        this.PostalCode = postalCode;
    }
    public Address()
    {
        this.Street = string.Empty;
        this.City = default!;
        this.PostalCode = string.Empty;
    }


    public Guid Id { get; set; }
    public string Street { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
    public string PostalCode { get; set; }
    public User? User { get; set; }
    public Cottage? Cottage { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}