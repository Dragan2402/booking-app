using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.BookingContract.Interfaces;
using Booking.Grpc.BookingContract.Requests;
using Booking.Grpc.BookingContract.Responses;
using Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;
using Booking.Services.Booking.Application.UseCases.Reservations.DeleteReservation;
using Booking.Services.Booking.Application.UseCases.Reservations.GetReservationById;
using Booking.Services.Booking.Application.UseCases.Reservations.GetReservations;
using Booking.Services.Booking.Application.UseCases.Reservations.UpdateReservation;
using ProtoBuf.Grpc;

namespace Booking.Services.Booking.Api.Services;

public class ReservationService : IReservationService
{
    private readonly IMapper _mapper;
    private readonly GetReservationsUseCase _getReservationsUseCase;
    private readonly GetReservationByIdUseCase _getReservationByIdUseCase;
    private readonly DeleteReservationUseCase _deleteReservationUseCase;
    private readonly UpdateReservationUseCase _updateReservationUseCase;
    private readonly CreateReservationUseCase _createReservationUseCase;

    public ReservationService(
        IMapper mapper, 
        GetReservationsUseCase getReservationsUseCase,
        GetReservationByIdUseCase getReservationByIdUseCase,
        DeleteReservationUseCase deleteReservationUseCase,
        UpdateReservationUseCase updateReservationUseCase,
        CreateReservationUseCase createReservationUseCase
        )
    {
        this._mapper = mapper;
        this._getReservationsUseCase = getReservationsUseCase;
        this._getReservationByIdUseCase = getReservationByIdUseCase;
        this._deleteReservationUseCase = deleteReservationUseCase;
        this._updateReservationUseCase = updateReservationUseCase;
        this._createReservationUseCase = createReservationUseCase;
    }

    public async Task<CreateObjectResponse> CreateReservation(CreateReservationRequest request, CallContext context = default)
    {
        var result = await _createReservationUseCase.Execute(_mapper.Map<CreateReservationContract>(request));
        return new CreateObjectResponse() { Id = result };
    }

    public async Task DeleteReservation(DeleteObjectRequest request, CallContext context = default)
    {
        await _deleteReservationUseCase.Execute(request.Id);
    }

    public async Task<List<ReservationResponse>> GetAllReservations(CallContext context = default)
    {
        var response = _mapper.Map<List<ReservationResponse>>(await _getReservationsUseCase.Execute());

        return response;
    }

    public async Task<ReservationResponse> GetReservationById(GetObjectRequest request, CallContext context = default)
    {
        var result = await _getReservationByIdUseCase.Execute(request.Id);

        return _mapper.Map<ReservationResponse>(result);
    }

    public async Task UpdateReservation(UpdateReservationRequest request, CallContext context = default)
    {
        await _updateReservationUseCase.Execute(_mapper.Map<UpdateReservationContract>(request));

    }
}