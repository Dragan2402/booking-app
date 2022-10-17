using Booking.Services.UserCottage.Api.Services;

namespace Booking.Services.UserCottage.Api.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static WebApplication MapGrpcServices(this WebApplication app)
    {
        app.MapGrpcService<CottageService>();
        app.MapGrpcService<UserService>();
        return app;
    }
}