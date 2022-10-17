using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;

namespace Booking.Services.UserCottage.Application.UseCases.Users.DeleteUser;

public class DeleteUserUseCase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAddressRepository _addressRepository;
    private readonly IUserRepository _userRepository;

    public DeleteUserUseCase(IUnitOfWork unitOfWork, IAddressRepository addressRepository, IUserRepository userRepository)
    {
        this._unitOfWork = unitOfWork;
        this._addressRepository = addressRepository;
        this._userRepository = userRepository;
    }

    public async Task<Guid> Execute(Guid id)
    {
        var maybeUser = await _userRepository.GetById(id);

        if (maybeUser.HasNoItem)
        {
            throw new EntityNotFoundException($"User with provided id does not exist");
        }

        var user = maybeUser.Item;

        // https://stackoverflow.com/questions/49242151/how-to-make-soft-delete-in-cascade-with-entity-framework-core-including-navigati
        await _userRepository.Delete(user);
        await _addressRepository.Delete(user.Address);

        await _unitOfWork.CommitAsync();

        return user.IdentityId;
    }
}