using Booking.Services.Common.Data;
using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserCottage.Infrastructure.EntityConfiguration;

public class PermissionConfiguration : AEntityTypeConfiguration<Permission>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("Permissions");

        builder.HasKey(c => c.Id);
    }
}
