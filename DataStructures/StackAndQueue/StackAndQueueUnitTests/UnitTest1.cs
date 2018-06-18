using System;
using Xunit;
using StackAndQueue.Classes;

namespace StackAndQueueUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushANodeToTheTopOfAStackTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(2);

            Stack stack = new Stack(n1);

            // Act
            stack.Push(n2);

            // Assert
            Assert.Equal(n2, stack.Top);
        }

        [Fact]
        public void CanPopANodeOffTheTopOfAStackTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(2);

            Stack stack = new Stack(n2);
            stack.Push(n1);

            // Act
            Node poppedNode = stack.Pop();

            // Assert
            Assert.Equal(n1, poppedNode);
        }

        [Fact]
        public void CanPeekAtTheTopOfAStackTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(3);
            Node n4 = new Node(25);

            Stack stack = new Stack(n1);
            stack.Push(n2);
            stack.Push(n3);
            stack.Push(n4);
            stack.Pop();
            stack.Pop();

            // Act
            Node peekedStack = stack.Peek();

            // Assert
            Assert.Equal(stack.Top, peekedStack);
            Assert.Equal(n2, peekedStack);
        }

        [Fact]
        public void CanEnqueueANodeToTheRearOfAQueueTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(2);

            Queue queue = new Queue(n1);

            // Act
            queue.Enqueue(n2);

            // Assert
            Assert.Equal(n2, queue.Rear);
        }

        [Fact]
        public void CanDequeueANodeFromTheFrontOfAQueueTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(2);

            Queue queue = new Queue(n1);
            queue.Enqueue(n2);

            // Act
            Node dequeuedNode = queue.Dequeue();

            // Assert
            Assert.Equal(n1, dequeuedNode);
        }

        [Fact]
        public void CanPeekAtTheFrontOfAQueueTest()
        {
            // Arrange
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(3);
            Node n4 = new Node(25);

            Queue queue = new Queue(n1);
            queue.Enqueue(n2);
            queue.Enqueue(n3);
            queue.Enqueue(n4);
            queue.Dequeue();
            queue.Dequeue();

            // Act
            Node peekedQueue = queue.Peek();

            // Assert
            Assert.Equal(queue.Front, peekedQueue);
            Assert.Equal(n3, peekedQueue);
        }
    }
}
