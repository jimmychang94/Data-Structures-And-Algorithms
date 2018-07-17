using HashTables.Classes;
using RepeatedWord;
using System;
using Xunit;

namespace RepeatedWordUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("This is a theory test which allows for multiple tests done with the same code", "")]
        [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...", "it")]
        [InlineData("A word is a string in programming", "a")]
        [InlineData("While I am at Code Fellows, my job is being a student. This means studying, programming, and reading like any other student.", "student")]
        public void CanFindRepeatedWordTest(string phrase, string duplicateWord)
        {
            // Arrange
            HashTable hashTable = new HashTable();

            // Act
            string output = Program.RepeatedWord(phrase);

            // Assert
            Assert.Equal(duplicateWord, output);
        }

    }
}
