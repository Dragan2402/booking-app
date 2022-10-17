namespace Booking.Services.Authentication.Application.Interfaces;

public interface IPasswordService
{
    Task<string> DigestAsync(string password, string salt);
    Task<(string Digest, string Salt)> DigestNewAsync(string password);
}