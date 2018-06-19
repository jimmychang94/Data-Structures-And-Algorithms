using System;
using System.Collections.Generic;
using System.Text;
using QueueWithStacks.Classes;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        /// <summary>
        /// This is the main stack; it is the one which needs to be seen as enqueueing and dequeueing
        /// </summary>
        public Stack Stack1 { get; set; }

        /// <summary>
        /// This is the secondary stack which is used in order for enqueueing and dequeueing to work with stacks
        /// </summary>
        public Stack Stack2 { get; set; }

        /// <summary>
        /// This constructor function forces the queue to take two stacks as parameters
        /// </summary>
        /// <param name="stack1">The main stack</param>
        /// <param name="stack2">The secondary stack</param>
        public Queue(Stack stack1, Stack stack2)
        {
            Stack1 = stack1;
            Stack2 = stack2;
        }

        /// <summary>
        /// This method takes in a value and then adds it to the "rear" of the queue; which is the top of stack1.
        /// </summary>
        /// <param name="value">This is the value that is added to the "rear" of the queue</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Stack1.Push(node);
        }

        /// <summary>
        /// This method removes the node at the "front" of the queue; which is at the bottom of stack1.
        /// </summary>
        /// <returns>This is the node at the bottom of stack 1</returns>
        public Node Dequeue()
        {
            while (Stack1.Peek().Next != null)
            {
                Stack2.Push(Stack1.Pop());
            }
            Node current = Stack1.Pop();
            while (Stack2.Peek().Next != null)
            {
                Stack1.Push(Stack2.Pop());
            }
            return current;
        }
    }
}
