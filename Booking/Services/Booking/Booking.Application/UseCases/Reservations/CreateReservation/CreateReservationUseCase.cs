using AutoMapper;
using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Domain;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;

public class CreateReservationUseCase
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReservationRepository _reservationRepository;

    public CreateReservationUseCase(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IReservationRepository reservationRepository)
    {
        this._mapper = mapper;
        this._unitOfWork = unitOfWork;
        this._reservationRepository = reservationRepository;
    }

    public async Task<Guid> Execute(CreateReservationContract contract) 
    {
        var reservation = _mapper.Map<Reservation>(contract);

        if (reservation.DateFrom.CompareTo(reservation.DateTo) > 0)
            throw new BusinessLogicException("Reservation end date must be after begin date.");

        await _reservationRepository.CreateAsync(reservation);

        await _unitOfWork.CommitAsync();

        return reservation.Id;
    }
}