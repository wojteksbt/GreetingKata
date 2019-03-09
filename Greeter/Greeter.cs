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

            var greeted = ListFormatter.FormatList(names);
            
            return ShouldGreetingBeShouted(names) 
                ? SpeakGreeting(greeted) 
                : ShoutGreeting(greeted);
        }
        
        private string SpeakGreeting(string greeted) => $"Hello, {greeted}.";
        
        private string ShoutGreeting(string greeted) => $"HELLO {greeted}!";
   
        private static bool ShouldGreetingBeShouted(string[] names) => names.All(n => n.IsUpperCased());
    }

    internal static class ListFormatter
    {
        public static string FormatList(string[] elements)
        {
            switch (elements.Length)
            {
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