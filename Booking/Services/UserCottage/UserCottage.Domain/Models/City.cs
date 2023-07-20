using Booking.Services.Common.Domain;

namespace Booking.Services.UserCottage.Domain.Models;

public class City : IAuditable, ISoftDeletable
{
    public City(Guid id, string name)
    {
        Id = id;
        Name = name;
        Addresses = new List<Address>();
        Country = default!;
    }

    public City(string name)
    {
        Name = name;
        Addresses = new List<Address>();
        Country = default!;
    }

    public City() 
    {
        Name = string.Empty;
        Addresses = new List<Address>();
        Country = default!;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Address> Addresses { get; set; }
    public Guid CountryId { get; set; }
    public Country Country { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
