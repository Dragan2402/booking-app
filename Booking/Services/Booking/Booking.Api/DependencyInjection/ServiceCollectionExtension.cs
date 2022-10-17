using Booking.Services.Booking.Api.Services;

namespace Booking.Services.Booking.Api.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static WebApplication MapGrpcServices(this WebApplication app)
    {
        app.MapGrpcService<ReservationService>();
        return app;
    }
}