using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.UserCottage.Infrastructure.Database;

public class UserCottageContext : ADbContext<UserCottageContext>
{
    public UserCottageContext(DbContextOptions<UserCottageContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries => this.Set<Country>();
    public DbSet<City> Cities => this.Set<City>();
    public DbSet<Address> Addresses => this.Set<Address>();
    public DbSet<User> Users => this.Set<User>();
    public DbSet<Cottage> Cottages => this.Set<Cottage>();


}