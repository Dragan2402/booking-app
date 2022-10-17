using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract.Requests.Users;
using Booking.Grpc.UserCottageContract.Responses.Users;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.UserCottageContract.Interfaces;

[Service]
public interface IUserService
{
    Task<CreateObjectResponse> CreateUser(CreateUserRequest request, CallContext context = default);
    Task<DeleteUserResponse> DeleteUser(DeleteObjectRequest request, CallContext context = default);
    Task<List<UserResponse>> GetAllUsers(CallContext context = default);
    Task<UserResponse> GetUserById(GetObjectRequest request, CallContext context = default);
    Task UpdateUser(UpdateUserRequest request, CallContext context = default);
    Task<UserResponse> ReadClientById(GetObjectRequest request, CallContext context = default);
}