using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract.Interfaces;
using Booking.Grpc.UserCottageContract.Requests;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Booking.Grpc.UserCottageContract.Responses.Cottages;
using Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.DeleteCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.GetCottages;
using Booking.Services.UserCottage.Application.UseCases.Cottages.ReadCottageById;
using Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;
using ProtoBuf.Grpc;
using UserCottage.Application.UseCases.Cottages.GetCottageById;

namespace Booking.Services.UserCottage.Api.Services;

public class CottageService : ICottageService
{
    private readonly IMapper _mapper;
    private readonly GetCottagesUseCase _getCottagesUseCase;
    private readonly GetCottageByIdUseCase _getCottageByIdUseCase;
    private readonly CreateCottageUseCase _createCottageUseCase;
    private readonly UpdateCottageUseCase _updateCottageUseCase;
    private readonly DeleteCottageUseCase _deleteCottageUseCase;
    private readonly ReadCottageByIdUseCase _readCottageByIdUseCase;

    public CottageService(
        GetCottagesUseCase getCottagesUseCase,
        GetCottageByIdUseCase getCottageByIdUseCase,
        CreateCottageUseCase createCottageUseCase,
        UpdateCottageUseCase updateCottageUseCase,
        DeleteCottageUseCase deleteCottageUseCase,
        ReadCottageByIdUseCase readCottageByIdUseCase,
        IMapper mapper)
    {
        this._mapper = mapper;
        this._getCottagesUseCase = getCottagesUseCase;
        this._getCottageByIdUseCase = getCottageByIdUseCase;
        this._createCottageUseCase = createCottageUseCase;
        this._updateCottageUseCase = updateCottageUseCase;
        this._deleteCottageUseCase = deleteCottageUseCase;
        this._readCottageByIdUseCase = readCottageByIdUseCase;
    }

    public async Task<CreateObjectResponse> CreateCottage(CreateCottageRequest request, CallContext context)
    {
        var result = await _createCottageUseCase.Execute(_mapper.Map<CreateCottageContract>(request));
        return new CreateObjectResponse() { Id = result };

    }

    public async Task DeleteCottage(DeleteObjectRequest request, CallContext context)
    {
        await _deleteCottageUseCase.Execute(request.Id);
    }

    public async Task<List<CottageResponse>> GetAllCompanies(CallContext context)
    {
        var result = await _getCottagesUseCase.Execute();
        var response = _mapper.Map<List<CottageResponse>>(result);
        return response;
    }

    public async Task<CottageResponse> GetCottageById(GetObjectRequest request, CallContext context)
    {
        var result = await _getCottageByIdUseCase.Execute(request.Id);
        var response = _mapper.Map<CottageResponse>(result);
        return response;
    }

    public async Task<CottageResponse> ReadCottageById(GetObjectRequest request, CallContext context = default)
    {
        var result = await _readCottageByIdUseCase.Execute(request.Id);
        return _mapper.Map<CottageResponse>(result);
    }

    public async Task UpdateCottage(UpdateCottageRequest request, CallContext context)
    {
        await _updateCottageUseCase.Execute(new UpdateCottageContract()
        {
            Id = request.Id,
            Cottage = _mapper.Map<CottageContract>(request.CottageRequest),
        });
    }
}