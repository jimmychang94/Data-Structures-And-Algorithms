using MultiBracketValidation;
using System;
using Xunit;

namespace MultiBracketValidationUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("[]")]
        [InlineData("[]()")]
        [InlineData("[{()}]")]
        [InlineData("[No matter{what I (Put between) these brackets} it doesn't matter!]")]
        public void ThisIsAValidInputTest(string input)
        {
            // Arrange and Act
            bool value = Program.MultiBracketValidation(input);

            Assert.True(value);
        }

        [Theory]
        [InlineData("}{")]
        [InlineData("{{")]
        [InlineData("[(])")]
        [InlineData("[{()]")]
        [InlineData("[No matter how ]I try to[ hide) in( these {brackets} it doesn't matter!]")]
        public void ThisIsNotAValidInputTest(string input)
        {
            // Arrange and Act
            bool value = Program.MultiBracketValidation(input);

            Assert.False(value);
        }
    }
}
