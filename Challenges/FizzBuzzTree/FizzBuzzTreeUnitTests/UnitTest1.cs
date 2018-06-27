using FizzBuzzTree;
using FizzBuzzTree.Classes;
using System;
using Xunit;

namespace FizzBuzzTreeUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(10, "Buzz")]
        [InlineData(12, "Fizz")]
        [InlineData(17, "17")]
        public void CanReturnCorrectChangeInNodeWithCheckNodeMethodTest(int value, string expected)
        {
            // Arrange
            string stringValue = value.ToString();
            Node node = new Node(stringValue);

            // Act
            Node result = Program.CheckNode(node);

            // Assert
            Assert.Equal(expected, result.Value);
        }

        [Fact]
        public void ResultOfFizzBuzzTreeIsTheSameAsStartOfOriginalTree()
        {
            // Arrange
            Node n1 = new Node("13");
            Node n2 = new Node("21");
            Node n3 = new Node("32");
            Node n4 = new Node("45");
            Node n5 = new Node("19");
            Node n6 = new Node("15");

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);

            // Act
            Node result = Program.FizzBuzzTree(n1);

            // Assert
            Assert.Equal(n1, result);
        }

        [Fact]
        public void FizzBuzzTreeChangesOriginalTreeToHaveCorrectLocationsOfFizzBuzzTest()
        {
            // Arrange
            Node n1 = new Node("13");
            Node n2 = new Node("21");
            Node n3 = new Node("32");
            Node n4 = new Node("45");
            Node n5 = new Node("19");
            Node n6 = new Node("10");

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);

            // Act
            Node result = Program.FizzBuzzTree(n1);

            // Assert
            Assert.Equal(n1, result);
            Assert.Equal("13", n1.Value);
            Assert.Equal(n2, result.LeftChild);
            Assert.Equal("Fizz", n2.Value);
            Assert.Equal(n3, result.RightChild);
            Assert.Equal("32", n3.Value);
            Assert.Equal(n4, result.LeftChild.LeftChild);
            Assert.Equal("FizzBuzz", n4.Value);
            Assert.Equal(n5, result.LeftChild.RightChild);
            Assert.Equal("19", n5.Value);
            Assert.Equal(n6, result.RightChild.LeftChild);
            Assert.Equal("Buzz", n6.Value);
        }

        [Theory]
        [InlineData(90, "FizzBuzz")]
        [InlineData(10, "Buzz")]
        [InlineData(18, "Fizz")]
        [InlineData(1, "1")]
        public void CanAddAnyNodeAndGetCorrectResult(int value, string expected)
        {
            // Arrange
            string valueString = value.ToString();
            Node n1 = new Node("13");
            Node n2 = new Node("21");
            Node n3 = new Node("32");
            Node n4 = new Node("45");
            Node n5 = new Node("19");
            Node n6 = new Node("15");
            Node node = new Node(valueString);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, node);

            // Act
            Node result = Program.FizzBuzzTree(n1);

            // Assert
            Assert.Equal(expected, result.RightChild.RightChild.Value);
        }
    }
}
