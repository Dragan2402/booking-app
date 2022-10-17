using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Authentication.Application.Services.Jwt;
using Booking.Services.Authentication.Application.UseCases.Logins._Common;
using Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using System.Security.Authentication;

namespace Booking.Services.Authentication.Application.UseCases.Logins.RefreshTokenLogin;

public class RefreshTokenLoginUseCase
{
    private readonly IIdentityRepository _repository;
    private readonly IJwtService _jwtService;
    private readonly IUnitOfWork _unitOfWork;

    public RefreshTokenLoginUseCase(IIdentityRepository repository,IUnitOfWork unitOfWork, IJwtService jwtService)
    {
        this._unitOfWork = unitOfWork;
        this._repository = repository;
        this._jwtService = jwtService;
    }

    public async Task<LoginResult> Execute(RefreshTokenLoginContract contract)
    {
        var identity = await ValidateToken(contract.RefreshToken, contract.Origin);

        LoginUtilities.UpdateLastLoginAt(identity);

        await _unitOfWork.CommitAsync();

        return new LoginResult(_jwtService.MintLoginTokens(identity.Id.ToString(), contract.Origin));
    }

    private async Task<Domain.Models.Identity> ValidateToken(string refreshToken, string origin)
    {
        var jwtValidationOutput = _jwtService.ValidateToken(refreshToken, origin);

        if (jwtValidationOutput.Type != TokenType.Refresh)
            throw new InvalidCredentialsException("Invalid refresh token");

        var maybeMatchingIdentity = await _repository.GetByIdAsync(new Guid(jwtValidationOutput.Identity));

        if (maybeMatchingIdentity.HasNoItem)
            throw new InvalidCredentialsException("Invalid refresh token");

        return maybeMatchingIdentity.Item;

    }
}