using Booking.Gateway.Controllers._Common.Requests;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Cottages.Requests;

public class CreateCottageGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public Guid OwnerId { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string Name { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    public AddressGatewayRequest Address { get; set; } = default!;


}