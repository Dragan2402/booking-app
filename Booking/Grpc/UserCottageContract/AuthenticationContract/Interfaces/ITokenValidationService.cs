using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.AuthenticationContract.Interfaces;

[Service]
public interface ITokenValidationService
{
    Task<ValidateAccessTokenResponse> ValidateAccessToken(ValidateAccessTokenRequest request, CallContext context = default);

}