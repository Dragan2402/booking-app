using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.UserCottage.Infrastructure.EntityConfigration;

public class UserConfiguration : AEntityTypeConfiguration<User>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.FirstName).HasColumnType("varchar(255)").IsRequired();

        builder.Property(u => u.LastName).HasColumnType("varchar(255)").IsRequired();

        builder.Property(u => u.UserType).HasColumnType("integer").IsRequired();

        builder.Property(u => u.IdentityId).IsRequired();

        builder.HasOne(u => u.Address).WithOne(a => a.User).HasForeignKey<User>(u => u.AddressId);

        builder.HasData(CreateSeed());

    }

    private List<User> CreateSeed()
    {
        var usersList = new List<User>
        {
            new User(new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"))
            {
                IdentityId = new Guid("233275cd-158e-442c-90c1-3bc3495563c6"),
                AddressId = new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                FirstName = "Jovan",
                LastName = "Jovic",
                UserType = EUserType.Client
            },
            new User(new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"))
            {
                IdentityId = new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"),
                AddressId = new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                FirstName = "Pero",
                LastName = "Peric",
                UserType = EUserType.Client,
            },
            new User(new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"))
            {
                IdentityId = new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"),
                AddressId = new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                FirstName = "Gazda",
                LastName = "Gazdic",
                UserType = EUserType.Owner
            },
            new User(new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"))
            {
                IdentityId = new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"),
                AddressId = new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                FirstName = "Andrej",
                LastName = "Culjak",
                UserType = EUserType.Owner
            }
        };

        return usersList;
    }
}