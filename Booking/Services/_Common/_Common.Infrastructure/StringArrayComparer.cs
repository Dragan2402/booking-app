using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Common.Infrastructure;

public class StringArrayComparer : ValueComparer<string[]>
{
    public StringArrayComparer() : base(
        (a, b) => ArraysEqual(a!, b!),
        array => array.GetHashCode(),
        array => (string[])array.Clone()
    )
    { }

    private static bool ArraysEqual(string[] a, string[] b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }
}