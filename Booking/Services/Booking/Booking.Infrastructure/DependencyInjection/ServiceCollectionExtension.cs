using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Infrastructure.Database;
using Booking.Services.Booking.Infrastructure.Repositories;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Services.Booking.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IOfferRepository, OfferRepository>();
        services.AddScoped<IReservationRepository, ReservationRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork<BookingContext>>();
        return services;
    }

    public static IServiceCollection AddDatabases(this IServiceCollection services, IConfiguration configuration)
    {
        var userBookingConnectionString = configuration.GetConnectionString("BookingDatabase");
        services.AddDbContext<BookingContext>(options => options.UseSqlServer(userBookingConnectionString));
        return services;
    }
}