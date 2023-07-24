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

    public static WebApplication SeedData(this WebApplication app)
    {
        var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

        using (var scope = scopedFactory!.CreateScope())
        {
            var service = scope.ServiceProvider.GetService<DataSeeder>();
            service!.Seed();
        }

        return app;
    }
}