using System.Collections.Generic;
using System.Linq;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Greeter.Tests")]

namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string Welcome = "Hello";
        private const string DefaultGreeted = "my friend";

        public string Greet(params string[] names)
        {
            if (names[0] == null)
                return $"{Welcome}, {DefaultGreeted}.";

            var splittedNames = SplitNames(names);

            var spokenPart = BuildSpokenPart(splittedNames);
            var shoutedPart = BuildShoutedPart(splittedNames);
            var conjunction = BuildConjunction(spokenPart, shoutedPart);

            return $"{spokenPart}{conjunction}{shoutedPart}";
        }

        private static string[] SplitNames(IEnumerable<string> names) 
            => names.SelectMany(n => Splitter.SplitWithEscaping(n)).ToArray();

        private static string BuildSpokenPart(IEnumerable<string> names)
        {
            var spokenNames = names.Where(n => !n.IsUpperCased()).ToArray();
            var greeted = ListFormatter.FormatList(spokenNames);
            return spokenNames.Any() ? $"{Welcome}, {greeted}." : "";
        }

        private static string BuildShoutedPart(IEnumerable<string> names)
        {
            var shoutedNames = names.Where(n => n.IsUpperCased()).ToArray();
            var greeted = ListFormatter.FormatList(shoutedNames);
            return shoutedNames.Any() ? $"{Welcome} {greeted}!".ToUpperInvariant() : "";
        }
        
        private static string BuildConjunction(string spokenPart, string shoutedPart)
        {
            var areBothPartsPresent = spokenPart != "" && shoutedPart != "";
            return areBothPartsPresent ? " AND " : "";
        }
    }
}