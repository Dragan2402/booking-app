using AutoMapper;
using Booking.Gateway.Controllers.UserCottage.Cottages.Requests;
using Booking.Gateway.Controllers.UserCottage.Cottages.Responses;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Grpc.UserCottageContract.Requests.Cottages;
using Booking.Grpc.UserCottageContract.Responses.Cottages;

namespace Booking.Gateway.MappingProfiles.UserCottage;

public class CottageMappingProfile : Profile
{
    public CottageMappingProfile()
    {
        CreateMap<CottageResponse, CottageGatewayResponse>();

        CreateMap<CreateCottageGatewayRequest, CreateCottageRequest>();

        CreateMap<UpdateCottageGatewayRequest, UpdateCottageCottageRequest>();
    }

}