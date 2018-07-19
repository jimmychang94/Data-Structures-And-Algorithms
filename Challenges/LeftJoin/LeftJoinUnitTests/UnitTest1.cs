using LeftJoin;
using LeftJoin.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicLeftJoinWorksTest()
        {
            // Arrange
            HashTable h1 = new HashTable();
            h1.Add("fond", "enamoured");
            h1.Add("wrath", "anger");
            h1.Add("diligent", "employed");
            h1.Add("outfit", "garb");
            h1.Add("guide", "usher");

            HashTable h2 = new HashTable();
            h2.Add("fond", "averse");
            h2.Add("wrath", "delight");
            h2.Add("diligent", "idle");
            h2.Add("guide", "follow");
            h2.Add("flow", "jam");

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);
            List<string[]> expected = new List<string[]>()
            {
                new string[] { "fond", "enamoured", "averse" },
                new string[] { "guide", "usher", "follow" },
                new string[] { "wrath", "anger", "delight" },
                new string[] { "outfit", "garb", "NULL" },
                new string[] { "diligent", "employed", "idle" },
            };

            // Assert
            Assert.Equal(expected, leftJoin);
        }
        [Fact]
        public void NullTablesTestTest()
        {
            // Arrange
            HashTable h1 = new HashTable();

            HashTable h2 = new HashTable();

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);

            // Assert
            Assert.Empty(leftJoin);
        }
        [Fact]
        public void OnlyOneTableHasValuesTest()
        {
            // Arrange
            HashTable h1 = new HashTable();
            h1.Add("fond", "enamoured");
            h1.Add("wrath", "anger");
            h1.Add("diligent", "employed");
            h1.Add("outfit", "garb");
            h1.Add("guide", "usher");

            HashTable h2 = new HashTable();

            // Act
            List<string[]> leftJoin = Program.LeftJoin(h1, h2);
            List<string[]> expected = new List<string[]>()
            {
                new string[] { "fond", "enamoured", "NULL" },
                new string[] { "guide", "usher", "NULL" },
                new string[] { "wrath", "anger", "NULL" },
                new string[] { "outfit", "garb", "NULL" },
                new string[] { "diligent", "employed", "NULL" },
            };

            // Assert
            Assert.Equal(expected, leftJoin);
        }
    }
}
