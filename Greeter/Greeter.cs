namespace Greeter
{
    public class Greeter : IGreeter
    {
        public string Greet(string name) => $"Hello, {name}.";
    }
}