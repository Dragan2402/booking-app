using System.Runtime.InteropServices;
using System.Security;

namespace Booking.Services.Common.Data;

public static class SecureStringExtensions
{
    public static string Read(this SecureString secureString)
    {
        IntPtr resultStringPointer = IntPtr.Zero;
        try
        {
            resultStringPointer = Marshal.SecureStringToGlobalAllocUnicode(secureString);
            return Marshal.PtrToStringUni(resultStringPointer) ?? string.Empty;
        }
        finally
        {
            Marshal.ZeroFreeGlobalAllocUnicode(resultStringPointer);
        }
    }

    public static SecureString Secure(this string data)
    {
        var secureString = new SecureString();
        foreach (var character in data)
        {
            secureString.AppendChar(character);
        }

        secureString.MakeReadOnly();
        return secureString;
    }
}