using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.BookingContract.Requests;
using Booking.Grpc.BookingContract.Responses;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Booking.Grpc.BookingContract.Interfaces;

[Service]
public interface IReservationService
{
    Task DeleteReservation(DeleteObjectRequest request, CallContext context = default);
    Task<List<ReservationResponse>> GetAllReservations(CallContext context = default);
    Task<ReservationResponse> GetReservationById(GetObjectRequest request, CallContext context = default);
    Task UpdateReservation(UpdateReservationRequest request, CallContext context = default);
    Task<CreateObjectResponse> CreateReservation(CreateReservationRequest request, CallContext context = default);
}