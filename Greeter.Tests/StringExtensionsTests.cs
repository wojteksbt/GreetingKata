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

        [Fact]
        public void WhenStringDoesNotContainSeparatorThenShouldReturnInitialValue()
        {
            var value = "Test string";

            var result = value.Split(", ");
            
            Assert.Single(result);
            Assert.Equal(value,result[0]);
        }
        
        [Fact]
        public void WhenStringContainsSeparatorThenShouldBeSplitted()
        {
            var value = "Test, string";

            var result = value.Split(", ");
            
            Assert.Equal("Test",result[0]);
            Assert.Equal("string", result[1]);
            Assert.Equal(2, result.Length);
        }
    }
}