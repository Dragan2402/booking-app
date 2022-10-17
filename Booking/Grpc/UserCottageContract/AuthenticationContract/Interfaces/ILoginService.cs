using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.AuthenticationContract.Interfaces;

[Service]
public interface ILoginService
{
    Task<LoginResponse> CredentialsLogin(CredentialsLoginRequest request, CallContext context = default);
    Task<LoginResponse> RefreshTokenLogin(RefreshTokenLoginRequest request, CallContext context = default);
}