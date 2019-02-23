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
        
        [Fact]
        public void WhenNameIsNullThenGreeterShouldGreetWithDefaultGreeting()
        {
            string name = null;

            var result = greeter.Greet(name);
            
            Assert.Equal($"Hello, my friend.", result);
        }
        
        [Fact]
        public void WhenNameIsUpperCasedThenGreeterShouldBeShouted()
        {
            var name = "JOE";

            var result = greeter.Greet(name);
            
            Assert.Equal($"HELLO, {name}.", result);
        }
    }
}