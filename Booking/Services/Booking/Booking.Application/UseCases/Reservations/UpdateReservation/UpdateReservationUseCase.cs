using AutoMapper;
using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;

namespace Booking.Services.Booking.Application.UseCases.Reservations.UpdateReservation;

public class UpdateReservationUseCase
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReservationRepository _reservationRepository;

    public UpdateReservationUseCase(IMapper mapper, IReservationRepository reservationRepository, IUnitOfWork unitOfWork)
    {
        this._mapper = mapper;
        this._unitOfWork = unitOfWork;
        this._reservationRepository = reservationRepository;
    }

    public async Task Execute(UpdateReservationContract contract)
    {
        var maybeReservation = await _reservationRepository.GetByIdAsync(contract.Id);

        if (maybeReservation.HasNoItem)
            throw new EntityNotFoundException($"Reservation with provided id does not exist");

        var reservation = maybeReservation.Item;

        if (contract.DateFrom != null)
            reservation.DateFrom = (DateTimeOffset)contract.DateFrom;

        if (contract.DateTo != null)
            reservation.DateTo = (DateTimeOffset)contract.DateTo;

        if (reservation.DateFrom.CompareTo(reservation.DateTo) > 0)
            throw new BusinessLogicException("Reservation end date must be after begin date.");

        await _unitOfWork.CommitAsync();

    }
}