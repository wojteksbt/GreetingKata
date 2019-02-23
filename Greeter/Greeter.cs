namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeting = "Hello, my friend.";
        
        public string Greet(string name)
        {
            if (name == null)
                return DefaultGreeting;
            if (IsUpperCased(name))
                return $"HELLO, {name}.";
            
            return $"Hello, {name}.";
        }

        private static bool IsUpperCased(string @string) => @string == @string.ToUpperInvariant();
    }
}