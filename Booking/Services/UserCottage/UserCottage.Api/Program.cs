using Booking.Services.UserCottage.Api.DependencyInjection;
using Booking.Services.UserCottage.Api.Interceptors;
using Booking.Services.UserCottage.Application.DependencyInjection;
using Booking.Services.UserCottage.Infrastructure.Database;
using Booking.Services.UserCottage.Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services
    .AddUseCases()
    .AddServices()
    .AddDatabases(builder.Configuration)
    .AddDomainMappingProfiles()
    .AddRepositories()
    .AddGrpc(options =>
    {
        options.Interceptors.Add<UserCottageServiceInterceptor>();
    });

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCodeFirstGrpc();

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.ConfigureEndpointDefaults(listenOptions => listenOptions.Protocols = HttpProtocols.Http2));
var app = builder.Build();

await using var scope = app.Services.CreateAsyncScope();
await using var db = scope.ServiceProvider.GetRequiredService<UserCottageContext>();
await db.Database.MigrateAsync();

app.MapGrpcServices();
// Configure the HTTP request pipeline.
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.SeedData();

app.Run();
