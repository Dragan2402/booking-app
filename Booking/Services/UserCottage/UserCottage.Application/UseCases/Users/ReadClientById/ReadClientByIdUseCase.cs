using AutoMapper;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;

namespace Booking.Services.UserCottage.Application.UseCases.Users.ReadClientById;

public class ReadClientByIdUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public ReadClientByIdUseCase(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserResult> Execute(Guid id)
    {
        var maybeClient = await _userRepository.ReadClientById(id);

        if(maybeClient.HasNoItem)
            throw new EntityNotFoundException("User with provided id does not exist.");

        var user = maybeClient.Item;

        if (user.UserType == Domain.Models.Enum.EUserType.Owner)
            throw new BusinessLogicException($"User is not client,");

        return _mapper.Map<UserResult>(user);
    }
}