using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Users.Requests;
using Booking.Gateway.Controllers.UserCottage.Users.Responses;
using Booking.Grpc.UserCottageContract.Requests.Users;
using Booking.Grpc.UserCottageContract.Responses.Users;

namespace Booking.Gateway.MappingProfiles.UserCottage;


public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserResponse, UserGatewayResponse>();

        CreateMap<UserGatewayRequest, CreateUserRequest>();

        CreateMap<UpdateUserGatewayRequest, UpdateUserUserRequest>();
    }

}