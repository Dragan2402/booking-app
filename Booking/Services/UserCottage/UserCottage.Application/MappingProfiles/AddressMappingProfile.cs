using AutoMapper;
using Booking.Services.UserCottage.Application.UseCases._Common.Requests;
using Booking.Services.UserCottage.Application.UseCases._Common.Results;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Application.MappingProfiles;

public class AddressMappingProfile : Profile
{
    public AddressMappingProfile()
    {
        CreateMap<Address, AddressResult>()
            .ForMember(dest => dest.City, source => source.MapFrom(source => source.City.Name))
            .ForMember(dest => dest.Country, source => source.MapFrom(source => source.City.Country.Name));
        CreateMap<AddressContract, Address>()
            .ForMember(dest => dest.City, source => source.MapFrom(source => new City(source.City)));
    }
}