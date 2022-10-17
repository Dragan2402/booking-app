using AutoMapper;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;

namespace UserCottage.Application.UseCases.Cottages.GetCottageById;

public class GetCottageByIdUseCase
{
    private readonly ICottageRepository _cottageRepository;
    private readonly IMapper _mapper;

    public GetCottageByIdUseCase(ICottageRepository cottageRepository, IMapper mapper)
    {
        _cottageRepository = cottageRepository;
        _mapper = mapper;
    }

    public async Task<CottageResult> Execute(Guid id)
    {
        var maybeCottage = await _cottageRepository.GetById(id);

        if (maybeCottage.HasNoItem)
            throw new EntityNotFoundException("Cottage with provided id does not exist.");

        var cottage = maybeCottage.Item;
        return _mapper.Map<CottageResult>(cottage);
    }
}