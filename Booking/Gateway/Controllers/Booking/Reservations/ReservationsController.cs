using AutoMapper;
using Booking.Gateway.Controllers.Booking.Reservations.Requests;
using Booking.Gateway.Controllers.Booking.Reservations.Responses;
using Booking.Gateway.UseCases.Reservations.CreateReservation;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.BookingContract.Interfaces;
using Booking.Grpc.BookingContract.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Controllers.Booking.Reservations;

[Route("api/reservations")]
[ApiController]
public class ReservationsController : Controller
{
    private readonly IMapper _mapper;

    public ReservationsController(IMapper mapper)
    {
        this._mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(List<ReservationGatewayResponse>))]
    public async Task<IActionResult> GetAllReservations(
        [FromServices] IReservationService reservationService
        )
    {
        var response = _mapper.Map<List<ReservationGatewayResponse>>(await reservationService.GetAllReservations());
        
        return Ok(response);
    }

    [HttpGet]
    [Route("{reservationId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReservationGatewayResponse))]
    public async Task<IActionResult> GetUserById(
        [FromServices] IReservationService reservationService,
        [FromRoute] Guid reservationId)
    {
        var response = _mapper.Map<ReservationGatewayResponse>(
            await reservationService.GetReservationById(new GetObjectRequest() { Id = reservationId }));

        return Ok(response);
    }

    [HttpDelete]
    [Route("{reservationId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> DeleteReservation(
        [FromServices] IReservationService reservationService,
        [FromRoute] Guid reservationId)
    {
        await reservationService.DeleteReservation(new DeleteObjectRequest() { Id = reservationId });

        return NoContent();
    }

    [HttpPut]
    [Route("{reservationId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateReservation(
        [FromServices] IReservationService reservationService,
        [FromRoute] Guid reservationId,
        [FromBody] UpdateReservationGatewayRequest request
        )
    {
        await reservationService.UpdateReservation(new UpdateReservationRequest()
        {
            Id = reservationId,
            DateFrom = request.DateFrom.ToString(),
            DateTo = request.DateTo.ToString()
        });

        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateReservation(
        [FromBody] CreateReservationGatewayRequest request,
        [FromServices] CreateReservationUseCase createReservationUseCase
        )
    {
        var response = await createReservationUseCase.Execute(request);

        return Created(Request.Path, response.Id);
    }

}