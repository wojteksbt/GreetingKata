namespace Greeter
{
    public interface IGreeter
    {
        string Greet(params string[] names);
    }
}