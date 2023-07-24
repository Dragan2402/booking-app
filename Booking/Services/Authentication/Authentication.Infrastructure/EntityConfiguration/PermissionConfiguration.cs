using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Authentication.Infrastructure.EntityConfiguration;

public class PermissionConfiguration : AEntityTypeConfiguration<Permission>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("Permissions");

        builder.HasKey(c => c.Id);
    }
}
