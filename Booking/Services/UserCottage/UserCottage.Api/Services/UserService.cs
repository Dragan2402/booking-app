using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract.Interfaces;
using Booking.Grpc.UserCottageContract.Requests.Users;
using Booking.Grpc.UserCottageContract.Responses.Users;
using Booking.Services.UserCottage.Application.UseCases.Users.CreateUser;
using Booking.Services.UserCottage.Application.UseCases.Users.DeleteUser;
using Booking.Services.UserCottage.Application.UseCases.Users.GetUsers;
using Booking.Services.UserCottage.Application.UseCases.Users.UpdateUser;
using Booking.Services.UserCottage.Application.UseCases.Users.ReadClientById;
using ProtoBuf.Grpc;

namespace Booking.Services.UserCottage.Api.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly GetUsersUseCase _getUsersUseCase;
    private readonly GetUserByIdUseCase _getUserByIdUseCase;
    private readonly CreateUserUseCase _createUserUseCase;
    private readonly UpdateUserUseCase _updateUserUseCase;
    private readonly DeleteUserUseCase _deleteUserUseCase;
    private readonly ReadClientByIdUseCase _readClientByIdUseCase;

    public UserService(
        GetUsersUseCase getUsersUseCase,
        GetUserByIdUseCase getUserByIdUseCase,
        CreateUserUseCase createUserUseCase,
        ReadClientByIdUseCase readClientByIdUseCase,
        UpdateUserUseCase updateUserUseCase,
        DeleteUserUseCase deleteUserUseCase,
        IMapper mapper)
    {
        this._getUsersUseCase = getUsersUseCase;
        this._getUserByIdUseCase = getUserByIdUseCase;
        this._createUserUseCase = createUserUseCase;
        this._readClientByIdUseCase = readClientByIdUseCase;
        this._updateUserUseCase = updateUserUseCase;
        this._deleteUserUseCase = deleteUserUseCase;
        this._mapper = mapper;
    }

    public async Task<CreateObjectResponse> CreateUser(CreateUserRequest request, CallContext context = default)
    {
        var result = await _createUserUseCase.Execute(_mapper.Map<CreateUserContract>(request));
        var response = new CreateObjectResponse() { Id = result };
        return response;
    }

    public async Task<DeleteUserResponse> DeleteUser(DeleteObjectRequest request, CallContext context = default)
    {
        var identityId = await _deleteUserUseCase.Execute(request.Id);
        return new DeleteUserResponse() { IdentityId = identityId };
    }

    public async Task<List<UserResponse>> GetAllUsers(CallContext context = default)
    {
        var result = await _getUsersUseCase.Execute();
        var response = _mapper.Map<List<UserResponse>>(result);
        return response;
    }

    public async Task<UserResponse> GetUserById(GetObjectRequest request, CallContext context = default)
    {
        var result = await _getUserByIdUseCase.Execute(request.Id);
        var response = _mapper.Map<UserResponse>(result);
        return response;
    }

    public async Task UpdateUser(UpdateUserRequest request, CallContext context = default)
    {
        await _updateUserUseCase.Execute(new UpdateUserContract()
        {
            Id = request.Id,
            User = _mapper.Map<UserContract>(request.UserRequest)
        });
    }

    public async Task<UserResponse> ReadClientById(GetObjectRequest request, CallContext context = default)
    {
        var result = await _readClientByIdUseCase.Execute(request.Id);
        return _mapper.Map<UserResponse>(result);
    }
}
