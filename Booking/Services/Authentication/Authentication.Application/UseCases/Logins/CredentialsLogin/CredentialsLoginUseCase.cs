using AutoMapper;
using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Authentication.Application.UseCases.Logins._Common;
using Booking.Services.Common.Domain;
using System.Security.Authentication;

namespace Booking.Services.Authentication.Application.UseCases.Logins.CredentialsLogin;

public class CredentialsLoginUseCase
{
    private readonly IPasswordService _passwordService;
    private readonly IIdentityRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtService _jwtService;

    public CredentialsLoginUseCase(
        IPasswordService passwordService,
        IIdentityRepository repository,
        IJwtService jwtService,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this._passwordService = passwordService;
        this._repository = repository;
        this._unitOfWork = unitOfWork;
        this._jwtService = jwtService;
    }

    public async Task<LoginResult> Execute(CredentialsLoginContract contract)
    {
        var identity = await ValidateCredentials(contract.Email, contract.Password);

        LoginUtilities.UpdateLastLoginAt(identity);

        await _unitOfWork.CommitAsync();

        return new LoginResult(_jwtService.MintLoginTokens(identity.Id.ToString(), contract.Origin));
    }

    private async Task<Domain.Models.Identity> ValidateCredentials(string email, string password)
    {
        var maybeMatchingIdentity = await _repository.GetByEmail(email);

        if (maybeMatchingIdentity.HasNoItem)
            throw new InvalidCredentialException("Invalid credentials.");

        var matchingIdentity = maybeMatchingIdentity.Item;
        var maybePasswordCredentials = matchingIdentity.TryGetPasswordCredentials();

        if(maybePasswordCredentials.HasNoItem)
            throw new InvalidCredentialException("Invalid credentials.");

        var (identityPassword, identitySalt) = maybePasswordCredentials.Item;

        if(await _passwordService.DigestAsync(password,identitySalt) != identityPassword)
            throw new InvalidCredentialException("Invalid credentials.");

        return matchingIdentity;
    }
}