using AutoMapper;
using Booking.Gateway.ProblemDetails;
using Booking.Gateway.UseCases.Logins.Login;
using Booking.Gateway.UseCases.Reservations.CreateReservation;
using Booking.Gateway.UseCases.Users.CreateUserUseCase;
using Booking.Gateway.UseCases.Users.DeleteUserUseCase;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.BookingContract.Interfaces;
using Booking.Grpc.UserCottageContract.Interfaces;
using Grpc.Core;
using Hellang.Middleware.ProblemDetails;
using ProtoBuf.Grpc.ClientFactory;
using System.Reflection;

namespace Booking.Gateway.DependencyInjection;


public static class ServiceCollectionExtensions
{
    public static void AddExceptionHandling(
        this IServiceCollection services,
        Action<ProblemDetailsOptions>? configure = null)
    {
        services.AddProblemDetails(options =>
        {
            configure?.Invoke(options);

            options.Map<RpcException>(ex => new RpcProblemDetails(ex));
            options.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);

        });
    }

    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<CreateUserUseCase, CreateUserUseCase>();
        services.AddScoped<DeleteUserUseCase, DeleteUserUseCase>();
        services.AddScoped<LoginUseCase, LoginUseCase>();

        services.AddScoped<CreateReservationUseCase>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IMapper, Mapper>();
        return services;
    }
    public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddClient<ICottageService>(configuration.GetUri(GrpcConfigurationNames.UserCottage));

        services.AddClient<IUserService>(configuration.GetUri(GrpcConfigurationNames.UserCottage));

        services.AddClient<IIdentityService>(configuration.GetUri(GrpcConfigurationNames.Authentication));
        services.AddClient<ILoginService>(configuration.GetUri(GrpcConfigurationNames.Authentication));
        services.AddClient<ITokenValidationService>(configuration.GetUri(GrpcConfigurationNames.Authentication));
       

        services.AddClient<IReservationService>(configuration.GetUri(GrpcConfigurationNames.Booking));

        return services;
    }
    public static void AddClient<TClient>(this IServiceCollection services, Uri address)
    where TClient : class
    {
        services.AddCodeFirstGrpcClient<TClient>(o =>
        {
            o.Address = address;
            o.ChannelOptionsActions.Add(options =>
            {
                options.HttpHandler = new SocketsHttpHandler
                {
                    PooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan,
                    KeepAlivePingDelay = TimeSpan.FromSeconds(60),
                    KeepAlivePingTimeout = TimeSpan.FromSeconds(30),
                    EnableMultipleHttp2Connections = true,
                };
            });
        });
    }

    public static Uri GetUri(this IConfiguration configuration, string configurationSectionName)
    {
        var section = configuration.GetSection(configurationSectionName);
        return new Uri($"http://{section["server"]}:{section["port"]}");
    }


    public static IServiceCollection AddCommonMappingProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}