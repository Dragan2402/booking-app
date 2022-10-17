using Booking.Gateway.Controllers._Common.Requests;
using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers.UserCottage.Cottages.Requests;

public class UpdateCottageGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string Name { get; set; } = string.Empty;
    public UpdateAddressGatewayRequest? Address { get; set; }
}