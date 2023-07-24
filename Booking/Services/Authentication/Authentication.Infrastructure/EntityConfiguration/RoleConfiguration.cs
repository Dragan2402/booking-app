using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Data;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Services.Authentication.Infrastructure.EntityConfiguration;

public class RoleConfiguration : AEntityTypeConfiguration<Role>
{
    protected override void BuildModelConfiguration(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).HasColumnType("varchar(255)").IsRequired();

        builder.HasMany(r => r.Permissions).WithMany(p => p.Roles);

        builder.HasData(CreateRoleSeed());
    }

    private List<Role> CreateRoleSeed()
    {
        var roles = new List<Role>
        {
            new Role()
            {
                Name = GeneralRoles.AdminRole,
                Id = new Guid("162613b2-aa55-498c-9819-c01caaa4ecca"),

            },

            new Role()
            {
                Name = GeneralRoles.ClientRole,
                Id = new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"),
            },

            new Role()
            {
                Name = GeneralRoles.OwnerRole,
                Id = new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"),
            }
        };

        return roles;
    }
}