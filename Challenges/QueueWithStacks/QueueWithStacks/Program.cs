using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }

        /// <summary>
        /// This method tests the enqueueing and dequeueing with stacks
        /// </summary>
        static void QueueWithStacks()
        {
            Stack stack1 = new Stack(new Node(1));
            Stack stack2 = new Stack(new Node(1));

            Queue queue = new Queue(stack1, stack2);

            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Stack1.Top.Value);

            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Stack1.Top.Value);

        }
    }
}
