using Booking.Services.UserCottage.Application.UseCases._Common.Requests;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;


public class CottageContract
{
    public string Name { get; set; } = string.Empty;

    public AddressContract? Address { get; set; }
}