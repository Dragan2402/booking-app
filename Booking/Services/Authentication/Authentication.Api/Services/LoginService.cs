using AutoMapper;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;
using Booking.Services.Authentication.Application.UseCases.Logins.RefreshTokenLogin;
using ProtoBuf.Grpc;

namespace Booking.Services.Authentication.Api.Services;

public class LoginService : ILoginService
{
    private readonly IMapper _mapper;
    private readonly CredentialsLoginUseCase _credentialsLoginUseCase;
    private readonly RefreshTokenLoginUseCase _refreshTokenLoginUseCase;

    public LoginService(
        IMapper mapper,
        CredentialsLoginUseCase credentialsLoginUseCase,
        RefreshTokenLoginUseCase refreshTokenLoginUseCase
        )
    {
        this._mapper = mapper;
        this._credentialsLoginUseCase = credentialsLoginUseCase;
        this._refreshTokenLoginUseCase = refreshTokenLoginUseCase;
    }

    public async Task<LoginResponse> CredentialsLogin(CredentialsLoginRequest request, CallContext context = default)
    {
        var contract = _mapper.Map<CredentialsLoginContract>(request);
        var result = await _credentialsLoginUseCase.Execute(contract);
        return _mapper.Map<LoginResponse>(result);
    }

    public async Task<LoginResponse> RefreshTokenLogin(RefreshTokenLoginRequest request, CallContext context = default)
    {
        var contract = _mapper.Map<RefreshTokenLoginContract>(request);
        var result = await _refreshTokenLoginUseCase.Execute(contract);
        return _mapper.Map<LoginResponse>(result);
    }
}