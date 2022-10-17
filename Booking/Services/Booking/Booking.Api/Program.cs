using Booking.Services.Booking.Api.DependencyInjection;
using Booking.Services.Booking.Api.Interceptors;
using Booking.Services.Booking.Application.DependencyInjection;
using Booking.Services.Booking.Infrastructure.Database;
using Booking.Services.Booking.Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services
    .AddUseCases()
    .AddDatabases(builder.Configuration)
    .AddDomainMappingProfiles()
    .AddRepositories()
    .AddGrpc(options =>
    {
        options.Interceptors.Add<BookingServiceInterceptor>();
    });

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCodeFirstGrpc();

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.ConfigureEndpointDefaults(listenOptions => listenOptions.Protocols = HttpProtocols.Http2));
var app = builder.Build();

app.MapGrpcServices();

await using var scope = app.Services.CreateAsyncScope();
await using var db = scope.ServiceProvider.GetRequiredService<BookingContext>();
await db.Database.MigrateAsync();


// Configure the HTTP request pipeline.
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
