using Booking.Services.Common.Domain;
using Booking.Services.Common.Infrastructure;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Infrastructure.Database;
using Booking.Services.UserCottage.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Services.UserCottage.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICottageRepository, CottageRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork<UserCottageContext>>();
        return services;
    }

    public static IServiceCollection AddDatabases(this IServiceCollection services, IConfiguration configuration)
    {
        var userCotttageConnectionString = configuration.GetConnectionString("UserCottageDatabase");
        services.AddDbContext<UserCottageContext>(options => options.UseSqlServer(userCotttageConnectionString!));
        return services;
    }
}