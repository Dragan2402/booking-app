using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.AuthenticationContract.Interfaces;

[Service]
public interface IIdentityService
{
    Task<CreateIdentityResponse> CreateIdentity(CreateIdentityRequest request, CallContext context = default);
    Task DeleteIdentity(DeleteObjectRequest request, CallContext context = default);
}