using System;
using Trees.Classes;
using Xunit;
using FindMax;

namespace FindMaxUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMaxValueTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(7);
            Node n3 = new Node(27);
            Node n4 = new Node(13);
            Node n5 = new Node(31);
            Node n6 = new Node(1);
            Node n7 = new Node(17);
            Node n8 = new Node(23);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);

            // Act
            int maxValue = Program.FindMax(n1);

            // Assert
            Assert.Equal(31, maxValue);
        }

        [Fact]
        public void CanFindMaxValueAtStartTest()
        {
            // Arrange
            Node n1 = new Node(31);
            Node n2 = new Node(7);
            Node n3 = new Node(27);
            Node n4 = new Node(13);
            Node n5 = new Node(10);
            Node n6 = new Node(1);
            Node n7 = new Node(17);
            Node n8 = new Node(23);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);

            // Act
            int startMax = n1.Value;
            int maxValue = Program.FindMax(n1);

            // Assert
            Assert.Equal(31, maxValue);
        }

        [Fact]
        public void CanFindMaxValueAtEndTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(7);
            Node n3 = new Node(27);
            Node n4 = new Node(13);
            Node n5 = new Node(21);
            Node n6 = new Node(1);
            Node n7 = new Node(17);
            Node n8 = new Node(31);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);

            // Act
            int startMax = n1.Value;
            int maxValue = Program.FindMax(n1);

            // Assert
            Assert.Equal(31, maxValue);
        }

        [Fact]
        public void CanFindMaxValueWithMultipleMaxValueTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(7);
            Node n3 = new Node(27);
            Node n4 = new Node(13);
            Node n5 = new Node(31);
            Node n6 = new Node(1);
            Node n7 = new Node(31);
            Node n8 = new Node(23);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);

            // Act
            int startMax = n1.Value;
            int maxValue = Program.FindMax(n1);

            // Assert
            Assert.Equal(31, maxValue);
        }

        [Fact]
        public void CanFindMaxValueWithAllNegativesTest()
        {
            // Arrange
            Node n1 = new Node(-10);
            Node n2 = new Node(-7);
            Node n3 = new Node(-27);
            Node n4 = new Node(-13);
            Node n5 = new Node(-31);
            Node n6 = new Node(-1);
            Node n7 = new Node(-17);
            Node n8 = new Node(-23);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);

            // Act
            int startMax = n1.Value;
            int maxValue = Program.FindMax(n1);

            // Assert
            Assert.Equal(-1, maxValue);
        }
    }
}
