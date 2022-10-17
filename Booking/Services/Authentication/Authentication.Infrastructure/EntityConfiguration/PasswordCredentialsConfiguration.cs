using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Data;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Authentication.Infrastructure.EntityConfiguration;

internal class PasswordCredentialsConfiguration : AEntityTypeConfiguration<PasswordCredentials>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<PasswordCredentials> builder)
    {
        builder.ToTable("PasswordCredentials");

        builder.HasKey(cc => cc.IdentityId).IsClustered();

        builder.Property(cc => cc.IdentityId)
            .IsRequired()
            .ValueGeneratedNever();

        builder.Property(cc => cc.Password)
            .IsRequired()
            .HasColumnType("binary(64)")
            .HasConversion(v => Encoding.Binary.GetBytes(v),
                           v => Encoding.Binary.GetString(v));

        builder.Property(cc => cc.Salt)
            .IsRequired()
            .HasColumnType("varbinary(20)")
            .HasConversion(v => Encoding.Binary.GetBytes(v),
                           v => Encoding.Binary.GetString(v));

        builder.HasOne<Identity>()
            .WithOne(i => i.Credentials)
            .HasForeignKey<PasswordCredentials>(cc => cc.IdentityId);


    }
}