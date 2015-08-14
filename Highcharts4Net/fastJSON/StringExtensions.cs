using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Highcharts4Net.fastJSON
{
    internal static class StringExtensions
    {
        internal static string ToUpperFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        internal static string ToLowerFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToLower(a[0]);
            return new string(a);
        }
    }
}
