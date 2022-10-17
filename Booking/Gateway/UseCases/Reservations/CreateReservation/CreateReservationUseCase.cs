using AutoMapper;
using Booking.Gateway.Controllers.Booking.Reservations.Requests;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.BookingContract.Interfaces;
using Booking.Grpc.BookingContract.Requests;
using Booking.Grpc.UserCottageContract.Interfaces;

namespace Booking.Gateway.UseCases.Reservations.CreateReservation;

public class CreateReservationUseCase
{
    private readonly IReservationService _reservationService;
    private readonly IMapper _mapper;
    private readonly IUserService _userService;
    private readonly ICottageService _cottageService;

    public CreateReservationUseCase(
        IMapper mapper, 
        IUserService userService,
        ICottageService cottageService,
        IReservationService reservationService
        )
    {
        this._reservationService = reservationService;
        this._mapper = mapper;
        this._userService = userService;
        this._cottageService = cottageService;
    }

    public async Task<CreateObjectResponse> Execute(CreateReservationGatewayRequest request)
    {
        var user = await _userService.ReadClientById(new GetObjectRequest() { Id = request.ClientId });
        var cottage = await _cottageService.ReadCottageById(new GetObjectRequest() { Id = request.CottageId });

        var response = await _reservationService.CreateReservation(new CreateReservationRequest()
        {
            ClientId = user.Id,
            CottageId = cottage.Id,
            DateFrom = request.DateFrom.ToString(),
            DateTo = request.DateTo.ToString()
        });

        return response;
    }
}