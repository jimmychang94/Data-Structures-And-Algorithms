using System;
using Xunit;
using KthElement.Classes;

namespace KthElementUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 10)]
        [InlineData(2, 20)]
        [InlineData(0, 40)]
        public void KthFromTheEndCorrectAnswerTest(int k, int expectedValue)
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);
            LinkdList ll = new LinkdList(n4);
            ll.Add(n3);
            ll.Add(n2);
            ll.Add(n1);

            // Act
            Node result = ll.KthElement(k);

            // Assert
            Assert.Equal(result.Value, expectedValue);

        }

        // These tests were for exceptions but I couldn't get Assert.Throw to work.

        //[Fact]
        //public void kIsLessThanZeroTest()
        //{
        //    // Arrange
        //    Node n1 = new Node(10);
        //    Node n2 = new Node(20);
        //    Node n3 = new Node(30);
        //    Node n4 = new Node(40);
            
        //    // Act
        //    LinkdList ll = new LinkdList(n4);
        //    ll.Add(n3);
        //    ll.Add(n2);
        //    ll.Add(n1);


        //    // Assert
        //}

        //[Fact]
        //public void kIsGreaterThanLengthOfLinkedListTest()
        //{

        //}
    }
}
