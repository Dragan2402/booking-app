using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc.AuthenticationContract.Interfaces;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using Booking.Services.Authentication.Application.UseCases.Identity.CreateIdentity;
using Booking.Services.Authentication.Application.UseCases.Identity.DeleteIdentity;
using ProtoBuf.Grpc;

namespace Booking.Services.Authentication.Api.Services;
public class IdentityService : IIdentityService
{
    private readonly IMapper _mapper;
    private readonly CreateIdentityUseCase _createIdentityUseCase;
    private readonly DeleteIdentityUseCase _deleteIdentityUseCase;

    public IdentityService(
        IMapper mapper,
        CreateIdentityUseCase createIdentityUseCase,
        DeleteIdentityUseCase deleteIdentityUseCase
        )
    {
        this._mapper = mapper;
        this._createIdentityUseCase = createIdentityUseCase;
        this._deleteIdentityUseCase = deleteIdentityUseCase;
    }

    public async Task<CreateIdentityResponse> CreateIdentity(CreateIdentityRequest createIdentityRequest, CallContext context = default)
    {
        var result = await _createIdentityUseCase.Execute(_mapper.Map<CreateIdentityContract>(createIdentityRequest));
        return new CreateIdentityResponse() { Id = result };
    }

    public async Task DeleteIdentity(DeleteObjectRequest request, CallContext context = default)
    {
        await _deleteIdentityUseCase.Execute(request.Id);
    }
}