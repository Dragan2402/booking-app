using AutoMapper;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Users.Common.Results;

namespace Booking.Services.UserCottage.Application.UseCases.Users.GetUsers;

public class GetUserByIdUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByIdUseCase(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserResult> Execute(Guid id)
    {
        var maybeUser = await _userRepository.GetById(id);

        if (maybeUser.HasNoItem)
            throw new EntityNotFoundException("User with provided id does not exist.");

        var user = maybeUser.Item;
        return _mapper.Map<UserResult>(user);
    }
}