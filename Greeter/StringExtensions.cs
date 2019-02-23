namespace Greeter
{
    internal static class StringExtensions
    {
        public static bool IsUpperCased(this string value) 
            => value == value.ToUpperInvariant();
    }
}