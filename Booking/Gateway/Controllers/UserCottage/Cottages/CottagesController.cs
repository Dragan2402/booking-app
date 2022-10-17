using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Cottages.Requests;
using Booking.Gateway.Controllers.UserCottage.Cottages.Responses;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.UserCottageContract.Interfaces;
using Booking.Grpc.UserCottageContract.Requests;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Controllers.UserCottage.Cottages;

[Route("api/cottages")]
[ApiController]
public class CottagesController : ControllerBase
{
    private readonly IMapper _mapper;
    public CottagesController(IMapper mapper)
    {
        this._mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CottageGatewayResponse>))]
    public async Task<IActionResult> GetAllCompanies([FromServices] ICottageService cottagesService)
    {
        var result = await cottagesService.GetAllCompanies();
        var response = _mapper.Map<List<CottageGatewayResponse>>(result);
        return Ok(response);
    }

    [HttpGet]
    [Route("{cottageId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CottageGatewayResponse))]
    public async Task<IActionResult> GetCottageById(
        [FromServices] ICottageService cottagesService,
        [FromRoute] Guid cottageId
        )
    {
        var result = await cottagesService.GetCottageById(new GetObjectRequest() { Id = cottageId });
        var response = _mapper.Map<CottageGatewayResponse>(result);
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateCottage(
        [FromServices] ICottageService cottagesService,
        [FromBody] CreateCottageGatewayRequest request
        )
    {
        var result = await cottagesService.CreateCottage(_mapper.Map<CreateCottageRequest>(request));
        return Created(Request.Path, result);
    }

    [HttpPut]
    [Route("{cottageId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateCottage(
        [FromServices] ICottageService cottagesService,
        [FromRoute] Guid cottageId,
        [FromBody] UpdateCottageGatewayRequest request
        )
    {
        await cottagesService.UpdateCottage(new UpdateCottageRequest()
        {
            Id = cottageId,
            CottageRequest = _mapper.Map<UpdateCottageCottageRequest>(request),
        });
        return NoContent();
    }

    [HttpDelete]
    [Route("{cottageId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(void))]
    public async Task<IActionResult> DeleteCottage(
        [FromServices] ICottageService cottagesService,
        [FromRoute] Guid cottageId)
    {
        await cottagesService.DeleteCottage(new DeleteObjectRequest() { Id = cottageId });
        return NoContent();
    }
}

