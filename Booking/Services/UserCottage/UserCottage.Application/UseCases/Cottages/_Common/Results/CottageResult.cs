using Booking.Services.UserCottage.Application.UseCases._Common.Results;
namespace Booking.Services.UserCottage.Application.UseCases.Cottages._Common.Results;

public class CottageResult
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public AddressResult Address { get; set; } = default!;
}