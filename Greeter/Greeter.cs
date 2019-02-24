using System.Linq;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Greeter.Tests")]

namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeting = "Hello, my friend.";

        public string Greet(params string[] names)
        {
            if (names[0] == null)
                return DefaultGreeting;

            var greeted = FormatGreeted(names);
                
            var greeting = $"Hello, {greeted}.";

            return ShouldGreetingBeShouted(names) ? Shout(greeting) : greeting;
        }

        private static string FormatGreeted(string[] names)
        {
            switch (names.Length)
            {
                case 1:
                    return names[0];
                case 2:
                    return $"{names[0]} and {names[1]}";
                default:
                    return FormatManyGreeted(names);
            }
        }

        private static string FormatManyGreeted(string[] names)
        {
            var formattedAllButLastElement = string.Join(", ", names, 0, names.Length - 1);

            return $"{formattedAllButLastElement}, and {names.Last()}";
        }
        
        private static bool ShouldGreetingBeShouted(string[] names) => names.All(n => n.IsUpperCased());

        private static string Shout(string text) => text.ToUpperInvariant();
    }
}