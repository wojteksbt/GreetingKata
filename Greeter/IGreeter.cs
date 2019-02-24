namespace Greeter
{
    public interface IGreeter
    {
        string Greet(string name);
        string Greet(params string[] names);
    }
}