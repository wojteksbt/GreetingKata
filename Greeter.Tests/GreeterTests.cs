using Xunit;

namespace Greeter.Tests
{
    public class GreeterTests
    {
        private readonly IGreeter greeter;
        
        public GreeterTests()
        {
            greeter = new Greeter();
        }
    }
}