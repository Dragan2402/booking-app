using AutoMapper;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.GetCottages;

public class GetCottagesUseCase
{
    private readonly ICottageRepository _cottageRepository;
    private readonly IMapper _mapper;

    public GetCottagesUseCase(ICottageRepository cottageRepository, IMapper mapper)
    {
        _cottageRepository = cottageRepository;
        _mapper = mapper;
    }

    public async Task<List<CottageResult>> Execute()
    {
        var getResult = await _cottageRepository.GetAllAsync();
        return _mapper.Map<List<CottageResult>>(getResult);
    }
}