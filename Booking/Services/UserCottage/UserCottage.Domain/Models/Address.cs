using Booking.Services.Common.Domain;

namespace Booking.Services.UserCottage.Domain.Models;

public class Address : IAuditable, ISoftDeletable
{
    public Address(Guid id, string street, string city, string postalCode, string state, string country)
    {
        this.Id = id;
        this.Street = street;
        this.City = city;
        this.PostalCode = postalCode;
        this.State = state;
        this.Country = country;
    }
    public Address()
    {
        this.Street = string.Empty;
        this.City = string.Empty;
        this.Country = string.Empty;
        this.PostalCode = string.Empty;
        this.State = string.Empty;
    }


    public Guid Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public User? User { get; set; }
    public Cottage? Cottage { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}