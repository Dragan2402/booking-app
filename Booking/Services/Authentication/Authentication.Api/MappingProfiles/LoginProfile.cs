using AutoMapper;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using Booking.Services.Authentication.Application.UseCases.Logins._Common;
using Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;
using Booking.Services.Authentication.Application.UseCases.Logins.RefreshTokenLogin;

namespace Booking.Services.Authentication.Api.MappingProfiles;

public class LoginProfile : Profile
{
    public LoginProfile()
    {
        CreateMap<CredentialsLoginRequest, CredentialsLoginContract>();

        CreateMap<RefreshTokenLoginRequest, RefreshTokenLoginContract>();

        CreateMap<LoginResult, LoginResponse>().ConvertUsing(s => new LoginResponse
        {
            Identity = s.IdentityToken,
            Refresh = s.RefreshToken,
            ExpiresIn = (int)(s.ExpiresAt - DateTime.UtcNow).TotalSeconds
        }); 


    }
}