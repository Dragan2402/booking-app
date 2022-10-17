using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.DeleteCottage;

public class DeleteCottageUseCase
{
    private readonly IAddressRepository _addressRepository;
    private readonly ICottageRepository _cottageRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCottageUseCase(
        IAddressRepository addressRepository,
        ICottageRepository cottageRepository,
        IUnitOfWork unitOfWork)
    {
        _addressRepository = addressRepository;
        _cottageRepository = cottageRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Execute(Guid cottageId)
    {
        var maybeCottage = await _cottageRepository.GetById(cottageId);

        if (maybeCottage.HasNoItem)
            throw new EntityNotFoundException("Cottage with provided Id does not exist");

        var cottage = maybeCottage.Item;

        await _cottageRepository.Delete(cottage);
        await _addressRepository.Delete(cottage.Address);
        await _unitOfWork.CommitAsync();
    }
}