using System;
using Xunit;
using Trees.Classes;

namespace TreesUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToBinarySearchTreeTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(5);
            BinarySearchTree binarySearchTree = new BinarySearchTree(n1);

            // Act
            binarySearchTree.Add(n1, n2);

            // Assert
            Assert.Equal(n2, n1.LeftChild);
        }

        [Fact]
        public void CanFindANodeInABinarySearchTreeTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(5);
            Node n3 = new Node(3);
            Node n4 = new Node(7);
            Node n5 = new Node(15);
            Node n6 = new Node(12);
            Node n7 = new Node(20);
            BinarySearchTree binarySearchTree = new BinarySearchTree(n1);
            binarySearchTree.Add(n1, n2);
            binarySearchTree.Add(n1, n3);
            binarySearchTree.Add(n1, n5);
            binarySearchTree.Add(n1, n6);
            binarySearchTree.Add(n1, n4);
            binarySearchTree.Add(n1, n7);

            // Act
            Node node = binarySearchTree.Search(n1, 12);

            // Assert
            Assert.Equal(12, node.Value);
            Assert.Equal(n6, node);
            Assert.Equal(n5.LeftChild, node);
        }

        [Fact]
        public void CanFindANodeInABinaryTreeTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(5);
            Node n3 = new Node(3);
            Node n4 = new Node(7);
            Node n5 = new Node(15);
            Node n6 = new Node(12);
            Node n7 = new Node(20);
            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);

            // Act
            Node node = binaryTree.Search(n1, 15);

            // Assert
            Assert.Equal(15, node.Value);
            Assert.Equal(n5, node);
            Assert.Equal(n2.RightChild, node);
        }
    }
}
