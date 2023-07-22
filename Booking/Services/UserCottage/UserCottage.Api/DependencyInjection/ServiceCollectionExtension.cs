using Booking.Services.UserCottage.Api.Services;
using UserCottage.Infrastructure.Database;

namespace Booking.Services.UserCottage.Api.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static WebApplication MapGrpcServices(this WebApplication app)
    {
        app.MapGrpcService<CottageService>();
        app.MapGrpcService<UserService>();
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