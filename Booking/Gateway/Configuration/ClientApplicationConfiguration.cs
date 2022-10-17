namespace Booking.Gateway.Configuration;
public class ClientApplicationConfiguration
{
    public const string ConfigurationSectionName = "ClientApplicationConfiguration";
    public string Uri { get; set; } = string.Empty;
}