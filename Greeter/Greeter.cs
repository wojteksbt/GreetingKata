using System.Linq;

namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeting = "Hello, my friend.";

        public string Greet(params string[] names)
        {
            if (names[0] == null)
                return DefaultGreeting;
                
            var greeting = $"Hello, {BuildGreeted(names)}.";

            if (names.All(n => n.IsUpperCased()))
                return Shout(greeting);
            
            return greeting;
        }

        private static string BuildGreeted(string[] names) 
            => string.Join(" and ", names);

        private static string Shout(string text) => text.ToUpperInvariant();
    }
}