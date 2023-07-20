using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.UserCottage.Infrastructure.EntityConfigration;

public class CityConfiguration : AEntityTypeConfiguration<City>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).HasColumnType("varchar(255)").IsRequired();
        builder.Property(c => c.CountryId).IsRequired();

        builder.HasOne(c => c.Country).WithMany(c => c.Cities).HasForeignKey(c => c.CountryId).OnDelete(DeleteBehavior.NoAction);

        builder.HasData(CreateCountrySeed());
    }

    private List<City> CreateCountrySeed()
    {
        var cities = new List<City>
        {
            new City()
            {
                Name = "Novi Sad",
                Id = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                CountryId= new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },

            new City()
            {
                Name = "Brcko",
                Id = new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                CountryId = new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            }
        };

        return cities;
    }
}