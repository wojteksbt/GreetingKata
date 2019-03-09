using System.Linq;

namespace Greeter
{
    internal static class ListFormatter
    {
        public static string FormatList(string[] elements)
        {
            switch (elements.Length)
            {
                case 0: return string.Empty;
                case 1: return elements[0];
                case 2: return $"{elements[0]} and {elements[1]}";
                default: return FormatManyElements(elements);
            }
        }

        private static string FormatManyElements(string[] elements)
        {
            var formattedAllButLastElement = string.Join(", ", elements, 0, elements.Length - 1);

            return $"{formattedAllButLastElement}, and {elements.Last()}";
        }
    }
}