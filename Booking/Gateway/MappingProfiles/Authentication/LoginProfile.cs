using AutoMapper;
using Booking.Gateway.Controllers.Authentication.Logins.Requests;
using Booking.Gateway.Controllers.Authentication.Logins.Responses;
using Booking.Gateway.UseCases.Logins.Login;
using Booking.Grpc.AuthenticationContract.Responses;

namespace Booking.Gateway.MappingProfiles.Authentication;

public class LoginProfile : Profile
{
    public LoginProfile()
    {
        CreateMap<LoginGatewayRequest, LoginContract>();

        CreateMap<LoginResponse, LoginGatewayResponse>().ConvertUsing(
            s => new LoginGatewayResponse() { AccessToken = s.Identity, TokenType = "bearer", ExpiresIn = s.ExpiresIn, RefreshToken = s.Refresh}
            );
    }
}