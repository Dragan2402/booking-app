using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Authentication.Infrastructure.Database;
using Booking.Services.Authentication.Infrastructure.Repositories;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Services.Authentication.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IIdentityRepository, IdentityRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork<AuthenticationContext>>();
        return services;
    }

    public static IServiceCollection AddDatabases(this IServiceCollection services, IConfiguration configuration)
    {
        var userCotttageConnectionString = configuration.GetConnectionString("AuthenticationDatabase");
        services.AddDbContext<AuthenticationContext>(options => options.UseSqlServer(userCotttageConnectionString));
        return services;
    }
}