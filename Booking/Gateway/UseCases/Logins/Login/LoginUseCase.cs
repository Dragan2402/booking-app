using AutoMapper;
using Booking.Gateway.Controllers.Authentication.Logins.Requests;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;

namespace Booking.Gateway.UseCases.Logins.Login;

public class LoginUseCase
{
    private readonly ILoginService _loginService;
    private readonly IMapper _mapper;

    public LoginUseCase(ILoginService loginService, IMapper mapper)
    {
        _loginService = loginService;
        _mapper = mapper;
    }

    public async Task<LoginResponse> Execute(LoginContract contract)
    {
        switch (contract.GrantType)
        {
            case "credentials":
                var responseCredentials = await _loginService.CredentialsLogin(new CredentialsLoginRequest()
                {
                    Email = contract.Email ,
                    Password = contract.Password ,
                    Origin = contract.Origin,                    
                });
                return responseCredentials;
            case "refresh_token":
                var responseRefresh = await _loginService.RefreshTokenLogin(new RefreshTokenLoginRequest()
                {
                    RefreshToken = contract.RefreshToken ,
                    Origin = contract.Origin
                });
                return responseRefresh;
            default: throw new Exception();
        }
       
    }
}