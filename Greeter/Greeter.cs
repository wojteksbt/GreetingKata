namespace Greeter
{
    public class Greeter : IGreeter
    {
        private const string DefaultGreeting = "Hello, my friend.";
        
        public string Greet(string name)
        {
            return name == null ? DefaultGreeting : $"Hello, {name}.";
        }
    }
}