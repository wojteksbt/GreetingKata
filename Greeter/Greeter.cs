using System.Linq;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Greeter.Tests")]

namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeted = "my friend";

        public string Greet(params string[] names)
        {
            if (names[0] == null)
                return SpeakGreeting(DefaultGreeted);

            var spokenNames = names.Where(n => !n.IsUpperCased()).ToArray();
            var shoutedNames = names.Where(n => n.IsUpperCased()).ToArray();

            var spokenPart = spokenNames.Any() ? SpeakGreeting(ListFormatter.FormatList(spokenNames)) : "";
            var shoutedPart = shoutedNames.Any() ? ShoutGreeting(ListFormatter.FormatList(shoutedNames)) : "";
            var conjunction = spokenNames.Any() && shoutedNames.Any() ? " AND " : "";

            return $"{spokenPart}{conjunction}{shoutedPart}";
        }
        
        private string SpeakGreeting(string greeted) => $"Hello, {greeted}.";
        
        private string ShoutGreeting(string greeted) => $"HELLO {greeted.ToUpperInvariant()}!";
    }

    internal static class ListFormatter
    {
        public static string FormatList(string[] elements)
        {
            switch (elements.Length)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return elements[0];
                case 2:
                    return $"{elements[0]} and {elements[1]}";
                default:
                    return FormatManyGreeted(elements);
            }
        }

        private static string FormatManyGreeted(string[] names)
        {
            var formattedAllButLastElement = string.Join(", ", names, 0, names.Length - 1);

            return $"{formattedAllButLastElement}, and {names.Last()}";
        }
    }
}