using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackAndQueue();
        }

        /// <summary>
        /// Thsi method tests out the push, pop, and peek methods for stacks and the enqueue, dequeue, and peek methods for queues.
        /// </summary>
        public static void StackAndQueue()
        {
            Node n1 = new Node(12);
            Node n2 = new Node(20);
            Node n3 = new Node(10);
            Node n4 = new Node(15);
            Node n5 = new Node(17);

            Stack stack = new Stack(n1);
            stack.Push(n2);
            stack.Push(n3);
            stack.Push(n4);
            stack.Push(n5);

            Node pop1 = stack.Pop();
            Node pop2 = stack.Pop();
            Node stackPeek = stack.Peek();

            Console.WriteLine($"This is the first node popped off of the stack; {pop1.Value} it was put in last.");
            Console.WriteLine($"This is the second node popped off of the stack; {pop2.Value}.");
            Console.WriteLine($"The top node is currently: {stackPeek.Value}.");

            Queue queue = new Queue(n1);
            queue.Enqueue(n2);
            queue.Enqueue(n3);
            queue.Enqueue(n4);
            queue.Enqueue(n5);

            Node dequeue1 = queue.Dequeue();
            Node dequeue2 = queue.Dequeue();
            Node queuePeek = queue.Peek();

            Console.WriteLine($"This is the first node dequeued from the queue: {dequeue1.Value}. It was the node the queue was initialized with");
            Console.WriteLine($"This is the second node dequeued from the queue: {dequeue2.Value}. It was the first node enqueued.");
            Console.WriteLine($"The next node to be dequeued (front node) would be: {queuePeek.Value}");
        }
    }
}
