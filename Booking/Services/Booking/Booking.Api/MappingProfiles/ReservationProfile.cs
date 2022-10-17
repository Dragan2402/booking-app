using AutoMapper;
using Booking.Grpc.BookingContract.Requests;
using Booking.Grpc.BookingContract.Responses;
using Booking.Services.Booking.Application.UseCases.Reservations._Common.Result;
using Booking.Services.Booking.Application.UseCases.Reservations.CreateReservation;
using Booking.Services.Booking.Application.UseCases.Reservations.UpdateReservation;

namespace Booking.Services.Booking.Api.MappingProfiles;

public class ReservationProfile : Profile
{
    public ReservationProfile()
    {
        CreateMap<ReservationResult, ReservationResponse>();

        CreateMap<UpdateReservationRequest, UpdateReservationContract>();

        CreateMap<CreateReservationRequest, CreateReservationContract>();
    }
}