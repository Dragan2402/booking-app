namespace Booking.Services.UserCottage.Application.UseCases._Common.Requests;

public class AddressContract
{
    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;
}