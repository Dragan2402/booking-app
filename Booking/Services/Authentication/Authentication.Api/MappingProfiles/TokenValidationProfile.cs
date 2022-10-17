using AutoMapper;
using Booking.Grpc.AuthenticationContract.Requests;
using Booking.Grpc.AuthenticationContract.Responses;
using Booking.Services.Authentication.Application.UseCases.TokenValidation;

namespace Booking.Services.Authentication.Api.MappingProfiles;

public class TokenValidationProfile : Profile
{
    public TokenValidationProfile()
    {
        CreateMap<ValidateAccessTokenRequest, ValidateAccessTokenContract>();

        CreateMap<ValidateAccessTokenResult, ValidateAccessTokenResponse>();
    }
}