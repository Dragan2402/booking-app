using Booking.Services.Authentication.Domain.Models;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Authentication.Infrastructure.Database;

public class AuthenticationContext : ADbContext<AuthenticationContext>
{
    public AuthenticationContext(DbContextOptions<AuthenticationContext> options)
        : base(options)
    {
    }
    public DbSet<Permission> Permissions => Set<Permission>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Identity> Identities => Set<Identity>();

}
