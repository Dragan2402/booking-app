using Booking.Services.UserCottage.Application.UseCases._Common.Requests;

namespace Booking.Services.UserCottage.Application.UseCases.Cottages.CreateCottage;

public class CreateCottageContract
{
    public Guid OwnerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public AddressContract Address { get; set; } = default!;
}