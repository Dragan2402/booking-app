using AutoMapper;
using Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;
using Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;
using Booking.Services.UserCottage.Domain;

namespace Booking.Services.UserCottage.Application.MappingProfiles;


public class CottageMappingProfile : Profile
{
    public CottageMappingProfile()
    {
        CreateMap<Cottage, CottageResult>();

        CreateMap<CreateCottageContract, Cottage>();

        CreateMap<CottageContract, Cottage>();
    }
}