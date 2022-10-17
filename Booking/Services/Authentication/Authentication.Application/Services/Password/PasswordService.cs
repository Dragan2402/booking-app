using Booking.Services.Authentication.Application.Interfaces;
using Booking.Services.Common.Data;
using System.Security.Cryptography;

namespace Booking.Services.Authentication.Application.Services.Password;

public class PasswordService : IPasswordService
{
    public async Task<string> DigestAsync(string password, string salt)
    {
        using var sha512 = SHA512.Create();
        var toDigest = password + salt;
        var stream = new MemoryStream(System.Text.Encoding.Unicode.GetBytes(toDigest));
        return Encoding.Binary.GetString(await sha512.ComputeHashAsync(stream));
    }

    public async Task<(string Digest, string Salt)> DigestNewAsync(string password)
    {
        var salt = GenerateSalt(16, 20);
        return (await DigestAsync(password, salt), salt);
    }

    private static string GenerateSalt(int minLength, int maxLength)
    {
        var generator = new Random();
        var length = generator.Next(minLength, maxLength + 1);

        var bytes = new byte[length];
        generator.NextBytes(bytes);
        return Encoding.Binary.GetString(bytes);
    }
}