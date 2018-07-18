using System;
using System.Collections.Generic;
using Trees.Classes;
using Xunit;
using TreeIntersection;

namespace TreeIntersectionUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AllTreeValuesTheSameButInDifferentLocationsTest()
        {
            // Arrange
            Trees.Classes.Node n1 = new Trees.Classes.Node(10);
            Trees.Classes.Node n2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n3 = new Trees.Classes.Node(30);
            Trees.Classes.Node n4 = new Trees.Classes.Node(40);
            Trees.Classes.Node n5 = new Trees.Classes.Node(50);
            Trees.Classes.Node n6 = new Trees.Classes.Node(60);

            BinaryTree b1 = new BinaryTree(n1);
            b1.Add(n1, n2);
            b1.Add(n1, n3);
            b1.Add(n1, n4);
            b1.Add(n1, n5);
            b1.Add(n1, n6);

            Trees.Classes.Node n1v2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n2v2 = new Trees.Classes.Node(30);
            Trees.Classes.Node n3v2 = new Trees.Classes.Node(10);
            Trees.Classes.Node n4v2 = new Trees.Classes.Node(60);
            Trees.Classes.Node n5v2 = new Trees.Classes.Node(40);
            Trees.Classes.Node n6v2 = new Trees.Classes.Node(50);

            BinaryTree b2 = new BinaryTree(n1v2);
            b1.Add(n1v2, n2v2);
            b1.Add(n1v2, n3v2);
            b1.Add(n1v2, n4v2);
            b1.Add(n1v2, n5v2);
            b1.Add(n1v2, n6v2);

            // Act
            List<int> intersect = Program.TreeIntersection(n1, n1v2);
            List<int> expectedList = new List<int> { 20, 30, 10, 60, 40, 50 };

            // Assert
            Assert.Equal(expectedList, intersect);
        }
        [Fact]
        public void NoTreeValuesAreTheSameTest()
        {
            // Arrange
            Trees.Classes.Node n1 = new Trees.Classes.Node(10);
            Trees.Classes.Node n2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n3 = new Trees.Classes.Node(30);
            Trees.Classes.Node n4 = new Trees.Classes.Node(40);
            Trees.Classes.Node n5 = new Trees.Classes.Node(50);
            Trees.Classes.Node n6 = new Trees.Classes.Node(60);

            BinaryTree b1 = new BinaryTree(n1);
            b1.Add(n1, n2);
            b1.Add(n1, n3);
            b1.Add(n1, n4);
            b1.Add(n1, n5);
            b1.Add(n1, n6);

            Trees.Classes.Node n1v2 = new Trees.Classes.Node(1);
            Trees.Classes.Node n2v2 = new Trees.Classes.Node(2);
            Trees.Classes.Node n3v2 = new Trees.Classes.Node(3);
            Trees.Classes.Node n4v2 = new Trees.Classes.Node(4);
            Trees.Classes.Node n5v2 = new Trees.Classes.Node(5);
            Trees.Classes.Node n6v2 = new Trees.Classes.Node(6);

            BinaryTree b2 = new BinaryTree(n1v2);
            b1.Add(n1v2, n2v2);
            b1.Add(n1v2, n3v2);
            b1.Add(n1v2, n4v2);
            b1.Add(n1v2, n5v2);
            b1.Add(n1v2, n6v2);

            // Act
            List<int> intersect = Program.TreeIntersection(n1, n1v2);

            // Assert
            Assert.Empty(intersect);
        }
        [Fact]
        public void TreeSizesAreDifferentTest()
        {
            // Arrange
            Trees.Classes.Node n1 = new Trees.Classes.Node(10);
            Trees.Classes.Node n2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n3 = new Trees.Classes.Node(30);
            Trees.Classes.Node n4 = new Trees.Classes.Node(40);
            Trees.Classes.Node n5 = new Trees.Classes.Node(50);
            Trees.Classes.Node n6 = new Trees.Classes.Node(60);

            BinaryTree b1 = new BinaryTree(n1);
            b1.Add(n1, n2);
            b1.Add(n1, n3);
            b1.Add(n1, n4);
            b1.Add(n1, n5);
            b1.Add(n1, n6);

            Trees.Classes.Node n1v2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n2v2 = new Trees.Classes.Node(15);
            Trees.Classes.Node n3v2 = new Trees.Classes.Node(25);

            BinaryTree b2 = new BinaryTree(n1v2);
            b1.Add(n1v2, n2v2);
            b1.Add(n1v2, n3v2);

            // Act
            List<int> intersect = Program.TreeIntersection(n1, n1v2);

            // Assert
            Assert.Equal(20, intersect[0]);
        }
    }
}
