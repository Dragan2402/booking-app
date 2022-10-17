using AutoMapper;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Booking.Grpc.UserCottageContract.Responses.Cottages;
using Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;
using Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;
using Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;

namespace Booking.Services.UserCottage.Api.MappingProfiles;


public class CottagesMappingProfile : Profile
{
    public CottagesMappingProfile()
    {
        CreateMap<CottageResponse, CottageResult>().ReverseMap();

        CreateMap<CreateCottageRequest, CreateCottageContract>().ReverseMap();

        CreateMap<UpdateCottageCottageRequest, CottageContract>().ReverseMap();

    }
}