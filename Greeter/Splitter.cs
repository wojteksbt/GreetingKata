namespace Greeter
{
    internal static class Splitter
    {
        private const char DefaultEscapingMark = '\"';
        
        public static string[] SplitWithEscaping(string value, char escapingMark = DefaultEscapingMark)
        {
            if (IsEscaped(value, escapingMark))
                return new[] {CutEscapingMark(value)};
            
            return value.Split(", ");
        }

        private static bool IsEscaped(string value, char escapingMark) 
            => value[0] == escapingMark && value[0] == escapingMark;

        private static string CutEscapingMark(string value) 
            => value.Substring(1, value.Length - 2);
    }
}