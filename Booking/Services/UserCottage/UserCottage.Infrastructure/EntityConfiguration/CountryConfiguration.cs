using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.UserCottage.Infrastructure.EntityConfigration;

public class CountryConfiguration : AEntityTypeConfiguration<Country>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).HasColumnType("varchar(255)").IsRequired();

        builder.HasMany(c => c.Cities).WithOne(c => c.Country).OnDelete(DeleteBehavior.NoAction);

        builder.HasData(CreateCountrySeed());
    }

    private List<Country> CreateCountrySeed()
    {
        var countries = new List<Country>
        {
            new Country()
            {
                Name = "Serbia",
                Id = new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },

            new Country()
            {
                Name = "Bosnia and Herzegovina",
                Id = new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            }
        };

        return countries;
    }
}