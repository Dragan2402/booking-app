using AutoMapper;
using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;

namespace Booking.Services.Authentication.Application.UseCases.Identity.CreateIdentity;

public class CreateIdentityUseCase
{
    private readonly IIdentityRepository _identityRepository;
    private readonly IPasswordService _passwordService;
    private readonly IUnitOfWork _unitOfWork;

    public CreateIdentityUseCase(
        IIdentityRepository identityRepository,
        IUnitOfWork unitOfWork,
        IPasswordService passwordService)
    {
        this._identityRepository = identityRepository;
        this._unitOfWork = unitOfWork;
        this._passwordService = passwordService;
    }

    public async Task<Guid> Execute(CreateIdentityContract contract)
    {
        if (contract.Password != contract.ConfirmPassword)
            throw new PasswordsNotMatchingException($"Provided passwords {contract.Password} - {contract.ConfirmPassword} do not match.");

        var maybeIdentity = await _identityRepository.ReadByEmail(contract.Email);
        if (maybeIdentity.HasItem)
        {
            throw new EmailNotUniqueException($"User with provided mail {contract.Email} already exists");
        }

        var digestSalt = await _passwordService.DigestNewAsync(contract.Password);
        Domain.Models.Identity identity = new Domain.Models.Identity(Guid.NewGuid(), contract.Email);
        identity.SetCredentials(digestSalt.Digest, digestSalt.Salt);

        await _identityRepository.CreateAsync(identity);
        await _unitOfWork.CommitAsync();

        return identity.Id;
    }


}