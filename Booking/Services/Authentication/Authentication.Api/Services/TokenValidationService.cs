using AutoMapper;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using Booking.Services.Authentication.Application.UseCases.TokenValidation;
using ProtoBuf.Grpc;

namespace Booking.Services.Authentication.Api.Services;

public class TokenValidationService : ITokenValidationService
{
    private readonly ValidateAccessTokenUseCase _validateAccessTokenUseCase;
    private readonly IMapper _mapper;

    public TokenValidationService(
        ValidateAccessTokenUseCase validateAccessTokenUseCase,
        IMapper mapper
        )
    {
        this._validateAccessTokenUseCase = validateAccessTokenUseCase;
        this._mapper = mapper;
    }

    public async Task<ValidateAccessTokenResponse> ValidateAccessToken(ValidateAccessTokenRequest request, CallContext context = default)
    {
        var contract = _mapper.Map<ValidateAccessTokenContract>(request);
        var result = await _validateAccessTokenUseCase.Execute(contract);
        return _mapper.Map<ValidateAccessTokenResponse>(result);
    }
}
