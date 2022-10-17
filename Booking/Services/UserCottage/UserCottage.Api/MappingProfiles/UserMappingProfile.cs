using AutoMapper;
using Booking.Grpc.UserCottageContract.Requests.Users;
using Booking.Grpc.UserCottageContract.Responses.Users;
using Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;
using Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;
using Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;

namespace Booking.Services.UserCottage.Api.MappingProfiles;


public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserResult, UserResponse>();

        CreateMap<CreateUserRequest, CreateUserContract>();

        CreateMap<UpdateUserUserRequest, UserContract>();
    }
}