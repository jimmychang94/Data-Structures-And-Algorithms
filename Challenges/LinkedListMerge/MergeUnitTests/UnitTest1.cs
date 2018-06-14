using System;
using Xunit;
using LinkedListMerge.Classes;

namespace MergeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void MergeDoesNotReturnNullValueTest()
        {
            // Arrange
            Node n6 = new Node(5);
            Node n5 = new Node(4);
            Node n4 = new Node(3);
            Node n3 = new Node(2);
            Node n2 = new Node(1);
            Node n1 = new Node(0);

            LinkdList LL1 = new LinkdList(n6);
            LL1.Add(n5);
            LL1.Add(n4);
            LL1.Add(n3);
            LL1.Add(n2);
            LL1.Add(n1);

            Node n3v2 = new Node(12);
            Node n2v2 = new Node(11);
            Node n1v2 = new Node(10);

            LinkdList LL2 = new LinkdList(n3v2);
            LL2.Add(n2v2);
            LL2.Add(n1v2);

            // Act
            Node head = LL1.Merge(LL1, LL2);

            // Assert
            Assert.NotNull(head);
        }

        [Fact]
        public void MergeReturnsHeadOfLinkedList1Test()
        {
            // Arrange
            Node n6 = new Node(5);
            Node n5 = new Node(4);
            Node n4 = new Node(3);
            Node n3 = new Node(2);
            Node n2 = new Node(1);
            Node n1 = new Node(0);

            LinkdList LL1 = new LinkdList(n6);
            LL1.Add(n5);
            LL1.Add(n4);
            LL1.Add(n3);
            LL1.Add(n2);
            LL1.Add(n1);

            Node n3v2 = new Node(12);
            Node n2v2 = new Node(11);
            Node n1v2 = new Node(10);

            LinkdList LL2 = new LinkdList(n3v2);
            LL2.Add(n2v2);
            LL2.Add(n1v2);

            // Act
            Node head = LL1.Merge(LL1, LL2);

            // Assert
            Assert.Equal(head.Value, LL1.Head.Value);
        }

        [Fact]
        public void MergeHeadNextIsTheSameAsLinkedList2Test()
        {
            // Arrange
            Node n6 = new Node(5);
            Node n5 = new Node(4);
            Node n4 = new Node(3);
            Node n3 = new Node(2);
            Node n2 = new Node(1);
            Node n1 = new Node(0);

            LinkdList LL1 = new LinkdList(n6);
            LL1.Add(n5);
            LL1.Add(n4);
            LL1.Add(n3);
            LL1.Add(n2);
            LL1.Add(n1);

            Node n3v2 = new Node(12);
            Node n2v2 = new Node(11);
            Node n1v2 = new Node(10);

            LinkdList LL2 = new LinkdList(n3v2);
            LL2.Add(n2v2);
            LL2.Add(n1v2);

            // Act
            Node head = LL1.Merge(LL1, LL2);

            // Assert
            Assert.Equal(head.Next.Value, LL2.Head.Value);
        }
    }
}
