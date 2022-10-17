using AutoMapper;
using Booking.Gateway.Controllers.Booking.Reservations.Responses;
using Booking.Grpc.BookingContract.Responses;

namespace Booking.Gateway.MappingProfiles.Booking;

public class ReservationProfile : Profile
{
    public ReservationProfile()
    {
        CreateMap<ReservationResponse, ReservationGatewayResponse>();
    }
}