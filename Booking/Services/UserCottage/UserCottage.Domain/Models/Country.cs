using Booking.Services.Common.Domain;

namespace Booking.Services.UserCottage.Domain.Models;

public class Country : IAuditable, ISoftDeletable
{
    public Country(Guid id, string name)
    {
        Id = id;
        Name = name;
        Cities = new List<City>();
    }

    public Country(string name)
    {
        Name = name;
        Cities = new List<City>();
    }

    public Country()
    {
        Name = string.Empty;
        Cities = new List<City>();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<City> Cities { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
