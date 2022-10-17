using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Authentication.Application.Services.Jwt;
using Booking.Services.Common.Exception;

namespace Booking.Services.Authentication.Application.UseCases.TokenValidation;

public class ValidateAccessTokenUseCase
{
    private readonly IIdentityRepository _repository;
    private readonly IJwtService _jwtService;

    public ValidateAccessTokenUseCase(IIdentityRepository repository,
                                      IJwtService jwtService)
    {
        this._repository = repository;  
        this._jwtService = jwtService;
    }

    public async Task<ValidateAccessTokenResult> Execute(ValidateAccessTokenContract contract)
    {
        var jwtValidationOutput = _jwtService.ValidateToken(contract.Token, contract.Origin);

        if (jwtValidationOutput.Type != TokenType.Refresh)
            throw new InvalidCredentialsException("Invalid access token");

        var claimedIdentity = new Guid(jwtValidationOutput.Identity);

        if (await _repository.ExistsByIdAsync(claimedIdentity))
            return new ValidateAccessTokenResult() { IdentityId = claimedIdentity };
        else
            throw new InvalidCredentialsException("Invalid access token");
    }
}