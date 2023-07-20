using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers._Common.Requests;

public class AddressGatewayRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string Street { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string City { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(16, ErrorMessage = "Max length of {0} is 16")]
    public string PostalCode { get; set; } = string.Empty;


    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
    [MaxLength(255, ErrorMessage = "Max length of {0} is 255")]
    public string Country { get; set; } = string.Empty;
}