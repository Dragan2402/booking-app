using Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.DeleteCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.GetCottages;
using Booking.Services.UserCottage.Application.UseCases.Cottages.ReadCottageById;
using Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;
using Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;
using Booking.Services.UserCottage.Application.UseCases.Users.DeleteUser;
using Booking.Services.UserCottage.Application.UseCases.Users.GetUsers;
using Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;
using Booking.Services.UserCottage.Application.UseCases.Users.ReadClientById;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using UserCottage.Application.UseCases.Cottages.GetCottageById;

namespace Booking.Services.UserCottage.Application.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<GetCottagesUseCase>();
        services.AddScoped<GetCottageByIdUseCase>();
        services.AddScoped<CreateCottageUseCase>();
        services.AddScoped<UpdateCottageUseCase>();
        services.AddScoped<DeleteCottageUseCase>();
        services.AddScoped<ReadCottageByIdUseCase>();
        services.AddScoped<GetUsersUseCase>();
        services.AddScoped<GetUserByIdUseCase>();
        services.AddScoped<CreateUserUseCase>();
        services.AddScoped<ReadClientByIdUseCase>();
        services.AddScoped<UpdateUserUseCase>();
        services.AddScoped<DeleteUserUseCase>();

        return services;
    }

    public static IServiceCollection AddDomainMappingProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection AddDefaultUserCottageInfo(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<UserCottageInfoConfiguration>(
            configuration.GetSection(UserCottageInfoConfiguration.ConfigurationSectionName));

        services.AddScoped<UserCottageInfoConfiguration>();
        return services;
    }
}