using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.UserCottage.Infrastructure.EntityConfigration;

public class AddressConfiguration : AEntityTypeConfiguration<Address>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Street).HasColumnType("varchar(255)").IsRequired();
        builder.Property(a => a.PostalCode).HasColumnType("varchar(255)").IsRequired();
        builder.Property(a => a.CityId).IsRequired();

        builder.HasOne(a => a.City).WithMany(c => c.Addresses).HasForeignKey(a => a.CityId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(a => a.User).WithOne(u => u.Address).HasForeignKey<User>(u => u.AddressId);
        builder.HasOne(a => a.Cottage).WithOne(u => u.Address).HasForeignKey<Cottage>(c => c.AddressId);

        builder.HasData(CreateAddressSeed());
    }

    private List<Address> CreateAddressSeed()
    {
        var addresses = new List<Address>
        {
            new Address()
            {
                CityId = new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                PostalCode = "76100",
                Street = "Pavla Savica 42",
                Id = new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },

            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Svetojovanska 11",
                Id = new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Palicka 13",
                Id = new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Pavloviceva 11",
                Id = new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Futoski put bb",
                Id = new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Fruska Gora 2121",
                Id = new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Address()
            {
                CityId = new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                PostalCode = "21000",
                Street = "Jovana Popovica 51",
                Id = new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            }
        };

        return addresses;
    }
}