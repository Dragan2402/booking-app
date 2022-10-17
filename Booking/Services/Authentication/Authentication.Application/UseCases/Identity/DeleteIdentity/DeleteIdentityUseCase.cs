using Booking.Services.Authentication.Application.Repositories;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;

namespace Booking.Services.Authentication.Application.UseCases.Identity.DeleteIdentity;

public class DeleteIdentityUseCase
{
    private readonly IIdentityRepository _identityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteIdentityUseCase(IIdentityRepository identityRepository,IUnitOfWork unitOfWork)
    {
        this._identityRepository = identityRepository;
        this._unitOfWork = unitOfWork;
    }

    public async Task Execute(Guid id)
    {
        var maybeIdentity = await _identityRepository.GetById(id);

        if (maybeIdentity.HasNoItem)
            throw new EntityNotFoundException($"Identity with provided id does not exist.");

        var identity = maybeIdentity.Item;

        await _identityRepository.Delete(identity);

        await _unitOfWork.CommitAsync();
    }
}