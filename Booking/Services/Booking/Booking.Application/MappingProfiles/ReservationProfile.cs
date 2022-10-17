using AutoMapper;

using Booking.Services.Booking.Application.UseCases.Reservations._Common.Result;
using Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;
using Booking.Services.Booking.Domain;

namespace Booking.Services.Booking.Application.MappingProfiles;

public class ReservationProfile : Profile
{
    public ReservationProfile()
    {
        CreateMap<Reservation, ReservationResult>();

        CreateMap<CreateReservationContract, Reservation>();
    }
}