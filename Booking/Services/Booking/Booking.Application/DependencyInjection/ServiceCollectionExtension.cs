using Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;
using Booking.Services.Booking.Application.UseCases.Reservations.DeleteReservation;
using Booking.Services.Booking.Application.UseCases.Reservations.GetReservationById;
using Booking.Services.Booking.Application.UseCases.Reservations.GetReservations;
using Booking.Services.Booking.Application.UseCases.Reservations.UpdateReservation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Booking.Services.Booking.Application.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<GetReservationsUseCase>();
        services.AddScoped<GetReservationByIdUseCase>();
        services.AddScoped<DeleteReservationUseCase>();
        services.AddScoped<UpdateReservationUseCase>();
        services.AddScoped<CreateReservationUseCase>();

        return services;
    }

    public static IServiceCollection AddDomainMappingProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}