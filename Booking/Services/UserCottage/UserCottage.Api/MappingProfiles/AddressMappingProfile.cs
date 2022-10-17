using AutoMapper;
using Booking.Grpc._Common.Grpc.Requests;
using Booking.Grpc._Common.Grpc.Responses;
using Booking.Services.UserCottage.Application.UseCases._Common.Requests;
using Booking.Services.UserCottage.Application.UseCases._Common.Results;

namespace Booking.Services.UserCottage.Api.MappingProfiles;
public class AddressMappingProfile : Profile
{
    public AddressMappingProfile()
    {
        CreateMap<AddressResult, AddressResponse>();
        CreateMap<AddressRequest, AddressContract>();
    }
}