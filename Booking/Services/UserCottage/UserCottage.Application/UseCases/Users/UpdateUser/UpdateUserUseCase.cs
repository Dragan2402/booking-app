using AutoMapper;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases._Common.Requests;
using Booking.Services.UserCottage.Domain;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;

public class UpdateUserUseCase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;

    public UpdateUserUseCase(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper,IAddressRepository addressRepository)
    {
        this._unitOfWork = unitOfWork;
        this._userRepository = userRepository;
        this._mapper = mapper;
        this._addressRepository = addressRepository;
    }

    public async Task Execute(UpdateUserContract contract)
    {
        var maybeUser = await _userRepository.GetById(contract.Id);

        if (maybeUser.HasNoItem)
            throw new EntityNotFoundException($"User with provided id does not exist.");

        var userToUpdate = maybeUser.Item;

        if (contract.User.FirstName != string.Empty)
            userToUpdate.FirstName = contract.User.FirstName;

        if (contract.User.LastName != string.Empty)
            userToUpdate.LastName = contract.User.LastName;

        if (contract.User.Address != null)
            UpdateAddress(userToUpdate, contract.User.Address);

        await _unitOfWork.CommitAsync();
    }

    private void UpdateAddress(User userToUpdate, AddressContract address)
    {
        userToUpdate.Address.Street = address.Street == string.Empty ? userToUpdate.Address.Street : address.Street;
        userToUpdate.Address.City.Name = address.City == string.Empty ? userToUpdate.Address.City.Name : address.City;
        userToUpdate.Address.PostalCode = address.PostalCode == string.Empty ? userToUpdate.Address.PostalCode : address.PostalCode;
        userToUpdate.Address.City.Country.Name = address.Country == string.Empty ? userToUpdate.Address.City.Country.Name : address.Country;
    }
}