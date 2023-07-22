using Booking.Services.Booking.Domain;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Booking.Infrastructure.EntityConfigration;

public class ReservationConfiguration : AEntityTypeConfiguration<Reservation>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservations");

        builder.HasKey(r => r.Id);


        builder.Property(c => c.SpecialRequest)
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(r => r.DateFrom)
            .IsRequired()
            .HasColumnType("datetimeoffset(2)");

        builder.Property(r => r.DateTo)
            .IsRequired()
            .HasColumnType("datetimeoffset(2)");


        builder.HasData(CreateSeed());

    }

    private List<Reservation> CreateSeed()
    {
        var reservations = new List<Reservation>
        {
            new Reservation()
            {
                Id = new Guid("2dabf974-45ba-4db7-99cb-2737a3fcaedf"),
                ClientId = new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                CottageId = new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                DateFrom = new DateTimeOffset(2022, 11, 11, 20, 00, 00, TimeSpan.Zero),
                DateTo = new DateTimeOffset(2022, 11, 20, 20, 00, 00, TimeSpan.Zero),
                TotalPrice = 400,
                Fee = 20,
                WithDiscount = false,
                SpecialRequest = "Bbq if possible"
            },
            new Reservation()
            {
                Id = new Guid("8d15c6a0-ec48-4e08-a391-865f27fd7dce"),
                ClientId = new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                CottageId = new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                DateFrom = new DateTimeOffset(2022, 9, 11, 20, 00, 00, TimeSpan.Zero),
                DateTo = new DateTimeOffset(2022, 9, 20, 20, 00, 00, TimeSpan.Zero),
                TotalPrice = 330,
                WithDiscount = true,
                Fee = 10
            }
        };
        return reservations;
    }
}