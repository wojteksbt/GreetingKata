namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeting = "Hello, my friend.";
        
        public string Greet(string name)
        {
            if (name == null)
                return DefaultGreeting;
            if (name.IsUpperCased())
                return $"HELLO, {name}.";
            
            return $"Hello, {name}.";
        }

        public string Greet(params string[] names)
        {
            return $"Hello, {names[0]} and {names[1]}.";
        }
    }
}