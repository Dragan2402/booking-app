using AutoMapper;
using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Application.UseCases.Reservations._Common.Result;
using Booking.Services.Common.Exception;

namespace Booking.Services.Booking.Application.UseCases.Reservations.GetReservationById;

public class GetReservationByIdUseCase
{
    private readonly IMapper _mapper;
    private readonly IReservationRepository _reservationRepository;

    public GetReservationByIdUseCase(IMapper mapper, IReservationRepository reservationRepository)
    {
        this._mapper = mapper;
        this._reservationRepository = reservationRepository;
    }

    public async Task<ReservationResult> Execute(Guid id)
    {
        var result = await _reservationRepository.GetByIdAsync(id);

        if (result.HasNoItem)
            throw new EntityNotFoundException($"Reservation with provided id does not exist");

        return _mapper.Map<ReservationResult>(result.Item);
    }

}