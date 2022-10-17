using AutoMapper;
using Booking.Services.UserCottage.Application.UseCases._Common.Requests;
using Booking.Services.UserCottage.Application.UseCases._Common.Results;
using Booking.Services.UserCottage.Domain.Models;

namespace Booking.Services.UserCottage.Application.MappingProfiles;

public class AddressMappingProfile : Profile
{
    public AddressMappingProfile()
    {
        CreateMap<Address, AddressResult>();
        CreateMap<AddressContract, Address>();
    }
}