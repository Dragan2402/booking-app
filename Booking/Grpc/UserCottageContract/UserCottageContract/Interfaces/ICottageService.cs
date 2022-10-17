using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract.Requests;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Booking.Grpc.UserCottageContract.Responses.Cottages;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.UserCottageContract.Interfaces;

[Service]
public interface ICottageService
{
    Task<CreateObjectResponse> CreateCottage(CreateCottageRequest request, CallContext context = default);
    Task DeleteCottage(DeleteObjectRequest request, CallContext context = default);
    Task<List<CottageResponse>> GetAllCompanies(CallContext context = default);
    Task<CottageResponse> GetCottageById(GetObjectRequest request, CallContext context = default);
    Task<CottageResponse> ReadCottageById(GetObjectRequest request, CallContext context = default);
    Task UpdateCottage(UpdateCottageRequest request, CallContext context = default);
}