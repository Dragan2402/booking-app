using AutoMapper;
using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Application.UseCases.Reservations._Common.Result;

namespace Booking.Services.Booking.Application.UseCases.Reservations.GetReservations;

public class GetReservationsUseCase
{
    private readonly IMapper _mapper;
    private readonly IReservationRepository _reservationRepository;

    public GetReservationsUseCase(IMapper mapper, IReservationRepository reservationRepository)
    {
        this._mapper = mapper;
        this._reservationRepository = reservationRepository;
    }

    public async Task<List<ReservationResult>> Execute()
    {
        var result = _mapper.Map<List<ReservationResult>>(await _reservationRepository.GetAllAsync());

        return result;
    }
}