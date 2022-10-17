using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Users.Requests;
using Booking.Grpc.AuthenticationContract.Requests;

namespace Booking.Gateway.MappingProfiles.Authentication;


public class AuthenticationProfile : Profile
{
    public AuthenticationProfile()
    {
        CreateMap<CreateUserIdentityGatewayRequest, CreateIdentityRequest>().ReverseMap();

    }

}