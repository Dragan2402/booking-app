using AutoMapper;
using Booking.Gateway.Controllers._Common.Requests;
using Booking.Gateway.Controllers._Common.Responses;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;

namespace Booking.Gateway.MappingProfiles.UserCottage;
public class AddressMappingProfile : Profile
{
    public AddressMappingProfile()
    {
        CreateMap<AddressGatewayRequest, AddressRequest>();

        CreateMap<AddressResponse, AddressGatewayResponse>();

        CreateMap<UpdateAddressGatewayRequest, AddressRequest>();
    }
}