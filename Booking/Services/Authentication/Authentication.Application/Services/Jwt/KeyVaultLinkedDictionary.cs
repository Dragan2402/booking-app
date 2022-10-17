using Booking.Services.Common.Data;
using System.Collections.Concurrent;
using System.Security;

namespace Booking.Services.Authentication.Application.Services.Jwt;

public sealed class KeyVaultLinkedDictionary : ConcurrentDictionary<string, SecureString>, IDisposable
{
    public KeyVaultLinkedDictionary()
        : base()
    {
    }

    public SecureString GetOrFetch(string key) => GetOrAdd(key, Fetch(key));

    public void Dispose()
    {
        foreach (var v in Values)
        {
            v.Dispose();
        }
    }
    private static SecureString Fetch(string key) => key.Secure();
}
