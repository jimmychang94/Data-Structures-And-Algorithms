using System;
using Xunit;
using LinkedLists;
using LinkedLists.Classes;

namespace LinkedListUnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// This tests for whether the Add() method works.
        /// </summary>
        /// <param name="value">Takes in a value for a new node to be created</param>
        [Theory]
        [InlineData(30)]
        [InlineData(40)]
        [InlineData(15)]
        public void CanAddNode (int value)
        {
            // Arrange
            LinkdList ll = new LinkdList(new Node(10));
            Node node = new Node(value);

            // Act
            ll.Add(node);

            // Assert
            Assert.Equal(value, ll.Head.Value);
        }
        /// <summary>
        /// This test makes sure that the find method returns a correct node when a node exists
        /// </summary>
        /// <param name="value">The value to search with</param>
        /// <param name="expected">The expected value of the node</param>
        [Theory]
        [InlineData(70, 70)]
        [InlineData(65, 65)]
        [InlineData(7, 7)]
        [InlineData(30, 30)]
        [InlineData(10, 10)]
        public void CanFindNodeThatExists (int value, int expected)
        {
            // Arrange
            LinkdList ll = new LinkdList(new Node(10));
            ll.Add(new Node(20));
            ll.Add(new Node(30));
            ll.Add(new Node(40));
            ll.Add(new Node(50));
            ll.Add(new Node(60));
            ll.Add(new Node(70));
            ll.Add(new Node(65));
            ll.Add(new Node(100));
            ll.Add(new Node(7));

            // Act
            Node result = ll.Find(value);

            // Assert
            Assert.Equal(expected, result.Value);

        }

        /// <summary>
        /// This method is to make sure that the find method returns null when there is no node with the search value
        /// </summary>
        /// <param name="value">The value that is searched for in the linked list</param>
        [Theory]
        [InlineData(51)]
        [InlineData(43)]
        [InlineData(27)]
        [InlineData(101)]
        public void ReturnsNullForNodeThatDoesNotExist (int value)
        {
            // Arrange
            LinkdList ll = new LinkdList(new Node(10));

            // Act
            ll.Add(new Node(20));
            ll.Add(new Node(30));
            ll.Add(new Node(40));
            ll.Add(new Node(50));
            ll.Add(new Node(60));
            ll.Add(new Node(70));
            ll.Add(new Node(65));
            ll.Add(new Node(100));
            ll.Add(new Node(7));
            Node found = ll.Find(value);

            // Assert
            Assert.Null(found);
        }
    }
}
