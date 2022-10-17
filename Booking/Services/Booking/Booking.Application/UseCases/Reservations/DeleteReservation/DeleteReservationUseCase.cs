using Booking.Services.Booking.Application.Repositories;
using Booking.Services.Booking.Application.UseCases.Reservations._Common.Result;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;

namespace Booking.Services.Booking.Application.UseCases.Reservations.DeleteReservation;

public class DeleteReservationUseCase
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteReservationUseCase(IReservationRepository reservationRepository, IUnitOfWork unitOfWork)
    {
        this._reservationRepository = reservationRepository;
        this._unitOfWork = unitOfWork;
    }

    public async Task Execute(Guid id)
    {
        var maybeReservation = await _reservationRepository.GetByIdAsync(id);

        if (maybeReservation.HasNoItem)
            throw new EntityNotFoundException($"Reservation with provided id does not exist");

        var reservation = maybeReservation.Item;

        await _reservationRepository.Delete(reservation);
        await _unitOfWork.CommitAsync();
    }
}