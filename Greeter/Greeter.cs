using System.Collections.Generic;
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
                return $"Hello, {DefaultGreeted}.";

            var splittedNames = SplitNames(names);

            var spokenNames = splittedNames.Where(n => !n.IsUpperCased()).ToArray();
            var shoutedNames = splittedNames.Where(n => n.IsUpperCased()).ToArray();

            var spokenPart = BuildSpokenPart(spokenNames);
            var shoutedPart = BuildShoutedPart(shoutedNames);
            var conjunction = spokenNames.Any() && shoutedNames.Any() ? " AND " : "";

            return $"{spokenPart}{conjunction}{shoutedPart}";
        }

        private static string[] SplitNames(IEnumerable<string> names)
        {
            return names.SelectMany(SplitWithEscapingByQuotes).ToArray();
        }

        private static string[] SplitWithEscapingByQuotes(string value)
        {
            if (value[0] == '\"' && value[0] == '\"')
                return new []{ value.Substring(1, value.Length - 2) };
            return value.Split(", ");
        }

        private static string BuildSpokenPart(string[] spokenNames)
        {
            var greeted = ListFormatter.FormatList(spokenNames);
            return spokenNames.Any() ? $"Hello, {greeted}." : "";
        }

        private static string BuildShoutedPart(string[] shoutedNames)
        {
            var greeted = ListFormatter.FormatList(shoutedNames);
            return shoutedNames.Any() ? $"HELLO {greeted.ToUpperInvariant()}!" : "";
        }
    }
}