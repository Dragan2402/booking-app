using AutoMapper;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.ReadCottageById;

public class ReadCottageByIdUseCase
{
    private readonly ICottageRepository _cottageRepository;
    private readonly IMapper _mapper;

    public ReadCottageByIdUseCase(ICottageRepository cottageRepository, IMapper mapper)
    {
        _cottageRepository = cottageRepository;
        _mapper = mapper;
    }

    public async Task<CottageResult> Execute(Guid id)
    {
        var maybeCottage = await _cottageRepository.ReadById(id);

        if (maybeCottage.HasNoItem)
            throw new EntityNotFoundException("Cottage with provided id does not exist.");

        var cottage = maybeCottage.Item;
        return _mapper.Map<CottageResult>(cottage);
    } 
}