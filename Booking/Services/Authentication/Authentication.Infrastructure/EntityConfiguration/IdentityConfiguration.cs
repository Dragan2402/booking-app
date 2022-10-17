using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Authentication.Infrastructure.EntityConfiguration;

public class IdentityConfiguration : AEntityTypeConfiguration<Identity>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Identity> builder)
    {
        builder.ToTable("Identities");

        builder.HasKey(i => i.Id).IsClustered(false);

        builder.HasIndex(i => new { i.Email, i.Id })
            .IsUnique()
            .IsClustered();

        builder.Property(i => i.Id)
            .IsRequired()
            .ValueGeneratedNever();

        builder.Property(i => i.Email)
            .IsRequired()
            .HasColumnType("nvarchar(255)");

        builder.Property(vc => vc.LastLoginAt)
            .HasColumnType("datetimeoffset(2)");

        builder.HasData(CreateSeed());

    }

    private List<Identity> CreateSeed()
    {
        var identities = new List<Identity>();
        identities.Add(new Identity(new Guid("233275cd-158e-442c-90c1-3bc3495563c6"), "jova@mail.com"));
        identities.Add(new Identity(new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"), "pero@mail.com"));
        identities.Add(new Identity(new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"), "gazda@mail.com"));
        identities.Add(new Identity(new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"), "andrej@mail.com"));
        return identities;
    }
}