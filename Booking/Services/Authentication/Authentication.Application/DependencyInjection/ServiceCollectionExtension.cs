using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Authentication.Application.Services.Jwt;
using Booking.Services.Authentication.Application.Services.Password;
using Booking.Services.Authentication.Application.UseCases.Identity.CreateIdentity;
using Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;
using Booking.Services.Authentication.Application.UseCases.Logins.RefreshTokenLogin;
using Booking.Services.Authentication.Application.UseCases.TokenValidation;
using Microsoft.Extensions.Configuration;
using Booking.Services.Authentication.Application.UseCases.Identity.DeleteIdentity;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Booking.Services.Authentication.Application.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<CreateIdentityUseCase>();
        services.AddScoped<CredentialsLoginUseCase>();
        services.AddScoped<RefreshTokenLoginUseCase>();
        services.AddScoped<ValidateAccessTokenUseCase>();
        services.AddScoped<DeleteIdentityUseCase>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IJwtService, JwtService>();

        return services;
    }

    public static IServiceCollection AddDomainMappingProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection BindOptions(
    this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddOptions<JwtOptions>().Bind(configuration.GetSection(JwtOptions.ConfigurationSectionName));

        return services;
    }

}