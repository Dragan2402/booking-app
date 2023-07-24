using AutoMapper;
using Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;
using Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Application.MappingProfiles;


public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserResult>();

        CreateMap<CreateUserContract, User>();
    }
}