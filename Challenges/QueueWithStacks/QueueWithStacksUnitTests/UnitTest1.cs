using QueueWithStacks.Classes;
using Xunit;

namespace QueueWithStacksUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        [InlineData(50)]
        public void EnqueueAddsToTopOfStack1Test(int value)
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);

            Stack stack1 = new Stack(n1);
            Stack stack2 = new Stack(n2);

            Queue queue = new Queue(stack1, stack2);

            // Act
            queue.Enqueue(value);

            // Assert
            Assert.Equal(value, stack1.Top.Value);
        }

        [Fact]
        public void DequeueGrabsTheRightValueTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);

            Stack stack1 = new Stack(n1);
            Stack stack2 = new Stack(n2);
            stack2.Pop();

            Queue queue = new Queue(stack1, stack2);
            queue.Enqueue(10);
            queue.Enqueue(20);

            // Act
            Node test = queue.Dequeue();

            // Assert
            Assert.Equal(1, test.Value);
        }

        [Fact]
        public void DequeuingAllValuesFromQueueTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);

            Stack stack1 = new Stack(n1);
            Stack stack2 = new Stack(n2);
            stack2.Pop();

            Queue queue = new Queue(stack1, stack2);
            queue.Enqueue(10);
            queue.Enqueue(20);

            // Act
            Node test = queue.Dequeue();
            Node test2 = queue.Dequeue();
            Node test3 = queue.Dequeue();

            // Assert
            Assert.Equal(1, test.Value);
            Assert.Equal(10, test2.Value);
            Assert.Equal(20, test3.Value);
        }

        [Fact]
        public void DequeueWorksEvenWithEnqueuePartWayThroughTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);

            Stack stack1 = new Stack(n1);
            Stack stack2 = new Stack(n2);
            stack2.Pop();

            Queue queue = new Queue(stack1, stack2);
            queue.Enqueue(10);
            queue.Enqueue(20);

            // Act
            Node test = queue.Dequeue();
            Node test2 = queue.Dequeue();
            queue.Enqueue(25);
            Node test3 = queue.Dequeue();
            queue.Enqueue(12);
            Node test4 = queue.Dequeue();
            Node test5 = queue.Dequeue();

            // Assert
            Assert.Equal(1, test.Value);
            Assert.Equal(10, test2.Value);
            Assert.Equal(20, test3.Value);
            Assert.Equal(25, test4.Value);
            Assert.Equal(12, test5.Value);
    }
}
}
