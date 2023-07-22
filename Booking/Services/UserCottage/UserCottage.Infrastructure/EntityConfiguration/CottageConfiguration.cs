using _Common.Infrastructure;
using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.UserCottage.Infrastructure.EntityConfigration;


public class CottageConfigration : AEntityTypeConfiguration<Cottage>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Cottage> builder)
    {
        builder.ToTable("Cottages");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).HasColumnType("varchar(255)").IsRequired();

        builder.Property(c => c.Pictures)
            .HasConversion(v => string.Join(':', v), v => v.Split(':', StringSplitOptions.RemoveEmptyEntries))
            .Metadata.SetValueComparer(new StringArrayComparer());

        builder.HasOne(c => c.Address).WithOne(a => a.Cottage).HasForeignKey<Cottage>(c => c.AddressId);
        builder.HasOne(c => c.Owner).WithMany(o => o.Cottages).HasForeignKey(c => c.OwnerId).OnDelete(DeleteBehavior.NoAction);

        builder.HasData(CreateSeed());
    }

    private List<Cottage> CreateSeed()
    {
        var cottages = new List<Cottage>
        {
            new Cottage()
            {
                Id = new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af896"),
                Name = "Sunshine Bebe",
                OwnerId = new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                AddressId = new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                AdditionalInfo = "Very cool and roomy cottage.",
                PromoDescription = "Cool cottage",
                PricePerDay = 50,
                Pictures = new string[]
                {
                    "picture.url1",
                    "picture.url2"
                }
            },
            new Cottage()
            {
                Id = new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                Name = "Funny Resort",
                OwnerId = new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                AddressId = new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                AdditionalInfo = "Funny cottage.",
                PromoDescription = "Fun fun fun",
                PricePerDay = 29,
                Pictures = new string[]
                {
                    "picture.url3",
                    "picture.url4"
                }
            },
            new Cottage()
            {
                Id = new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                Name = "QSX Mansion",
                OwnerId = new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                AddressId = new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                AdditionalInfo = "Terrible place with terrible people avoid at all costs.",
                PromoDescription = "Terrible",
                PricePerDay = 30,
                Pictures = new string[]
                {
                    "picture.url1",
                    "picture.url2"
                }
            }
        };
        return cottages;
    }
}