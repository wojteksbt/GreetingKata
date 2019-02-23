namespace Greeter
{
    public class Greeter : IGreeter
    {
        public string Greet(string name)
        {
            if (name == null)
            {
                return "Hello, my friend.";
            }
            return $"Hello, {name}.";
        }
    }
}