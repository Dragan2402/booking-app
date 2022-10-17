using AutoMapper;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Services.Authentication.Application.UseCases.Identity.CreateIdentity;

namespace Booking.Services.Authentication.Api.MappingProfiles;

public class IdentityProfile : Profile
{
    public IdentityProfile()
    {
        CreateMap<CreateIdentityRequest, CreateIdentityContract>();
    }
}