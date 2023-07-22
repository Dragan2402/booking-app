using Booking.Services.Booking.Domain;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Booking.Infrastructure.EntityConfigration;

public class OfferConfiguration : AEntityTypeConfiguration<Offer>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Offer> builder)
    {
        builder.ToTable("Offers");

        builder.HasKey(r => r.Id);


        builder.Property(r => r.DateFrom)
            .IsRequired()
            .HasColumnType("datetimeoffset(2)");

        builder.Property(r => r.DateTo)
            .IsRequired()
            .HasColumnType("datetimeoffset(2)");


        builder.HasData(CreateSeed());

    }

    private List<Offer> CreateSeed()
    {
        var offers = new List<Offer>
        {
            new Offer()
            {
                Id = new Guid("089a9b2a-b844-498c-8797-1a1812c9b504"),
                CottageId = new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                DateFrom = new DateTimeOffset(2022, 12, 11, 20, 00, 00, TimeSpan.Zero),
                DateTo = new DateTimeOffset(2022, 12, 20, 20, 00, 00, TimeSpan.Zero),
                TotalPrice = 200
            },
            new Offer()
            {
                Id = new Guid("6b44e9d5-ca61-4c91-95d7-4bd0eb730981"),
                CottageId = new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                DateFrom = new DateTimeOffset(2022, 10, 1, 20, 00, 00, TimeSpan.Zero),
                DateTo = new DateTimeOffset(2022, 10, 22, 20, 00, 00, TimeSpan.Zero),
                TotalPrice = 500
            }
        };
        return offers;
    }
}