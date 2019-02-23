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
        
        [Fact]
        public void WhenNameIsProvidedThenGreeterShouldGreet()
        {
            var name = "Joe";

            var result = greeter.Greet(name);
            
            Assert.Equal($"Hello, {name}.", result);
        }
    }
}