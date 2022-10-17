using Booking.Services.Authentication.Api.Services;

namespace Booking.Services.Authentication.Api.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static WebApplication MapGrpcServices(this WebApplication app)
    {
        app.MapGrpcService<IdentityService>();
        app.MapGrpcService<LoginService>();
        app.MapGrpcService<TokenValidationService>();
        return app;
    }
}