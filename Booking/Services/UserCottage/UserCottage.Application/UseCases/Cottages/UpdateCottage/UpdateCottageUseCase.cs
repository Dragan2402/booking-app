using AutoMapper;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;

public class UpdateCottageUseCase
{
    private readonly ICottageRepository _cottageRepository;
    private readonly IAddressRepository _addressRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateCottageUseCase(
        ICottageRepository cottageRepository,
        IAddressRepository addressRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _cottageRepository = cottageRepository;
        _addressRepository = addressRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Execute(UpdateCottageContract contract)
    {
        var maybeCottage = await _cottageRepository.GetById(contract.Id);

        if (maybeCottage.HasNoItem)
            throw new EntityNotFoundException("Cottage with provided Id does not exist");

        var maybeNewCottage = await _cottageRepository.ReadByName(contract.Cottage.Name);


        if (maybeNewCottage.HasItem && maybeNewCottage.Item.Id != contract.Id)
        {
            throw new EntityExistsException($"Cottage with provided name {maybeNewCottage.Item.Name} already exists");
        }

        var cottageToUpdate = maybeCottage.Item;
        var newCottage = _mapper.Map<Cottage>(contract.Cottage);

        cottageToUpdate.Name = newCottage.Name;

        if (newCottage.Address != null)
        {
            UpdateAddress(cottageToUpdate, newCottage);
        }

        await _unitOfWork.CommitAsync();

    }

    private void UpdateAddress(Cottage cottageToUpdate, Cottage newCottage)
    {
        cottageToUpdate.Address.Street = newCottage.Address.Street == string.Empty ? cottageToUpdate.Address.Street : newCottage.Address.Street;
        cottageToUpdate.Address.PostalCode = newCottage.Address.PostalCode == string.Empty ? cottageToUpdate.Address.PostalCode : newCottage.Address.PostalCode;
        
        if (cottageToUpdate.Address.City.Name != newCottage.Address.City.Name && newCottage.Address.City.Name != string.Empty)
        {
            UpdateCity(cottageToUpdate, newCottage);
        }
    }

    private void UpdateCity(Cottage cottageToUpdate, Cottage newCottage)
    {
        cottageToUpdate.Address.City.Name = newCottage.Address.City.Name;
    }
}