using Xunit;

namespace Greeter.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void WhenStringIsNotUpperCasedThenIsUpperCasedShouldBeFalse()
        {
            var value = "TestString";

            var result = value.IsUpperCased();
            
            Assert.False(result);
        }
        
        [Fact]
        public void WhenStringIsUpperCasedThenIsUpperCasedShouldBeTrue()
        {
            var value = "TESTSTRING";

            var result = value.IsUpperCased();
            
            Assert.True(result);
        }
    }
}