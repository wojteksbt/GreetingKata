using System;

namespace Greeter
{
    internal static class StringExtensions
    {
        public static bool IsUpperCased(this string value)
            => value == value.ToUpperInvariant();

        public static string[] Split(this string value, string separator)
            => value.Split(new[] {separator}, StringSplitOptions.None);
    }
}