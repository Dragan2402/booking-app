using AutoMapper;
using Booking.Services.Common.Domain;
using Booking.Services.Common.Exception;
using Booking.Services.UserCottage.Application.Repositories;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;

public class CreateCottageUseCase
{
    private readonly ICottageRepository _cottageRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateCottageUseCase(ICottageRepository cottageRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._cottageRepository = cottageRepository;
        this._mapper = mapper;
    }

    public async Task<Guid> Execute(CreateCottageContract contract)
    {
        var cottage = _mapper.Map<Cottage>(contract);

        var maybeCottage = await _cottageRepository.ReadByName(cottage.Name);
        if (maybeCottage.HasItem)
        {
            throw new EntityExistsException($"Cottage with provided name {contract.Name} already exists");
        }

        await _cottageRepository.CreateAsync(cottage);

        await _unitOfWork.CommitAsync();

        return cottage.Id;
    }
}