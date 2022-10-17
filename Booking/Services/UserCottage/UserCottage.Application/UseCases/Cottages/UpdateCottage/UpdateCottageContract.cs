namespace Booking.Services.UserCottage.Application.UseCases.Cottages.UpdateCottage;


public class UpdateCottageContract
{
    public Guid Id { get; set; }

    public CottageContract Cottage { get; set; } = default!;
}