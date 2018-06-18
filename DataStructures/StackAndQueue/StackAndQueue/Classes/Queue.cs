using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        /// <summary>
        /// A Node for the "front" of the queue. This is where a node would be dequeued.
        /// </summary>
        public Node Front { get; set; }

        /// <summary>
        /// A Node for the "rear" of the queue. This is where a node would be enqueued.
        /// </summary>
        public Node Rear { get; set; }

        /// <summary>
        /// This constructor makes sure that the queue starts with one node. It also initializes the Front and the Rear properties.
        /// </summary>
        /// <param name="node">The node required to initialize the queue</param>
        public Queue (Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// This method adds a node  the the rear of the queue.
        /// </summary>
        /// <param name="node">The node to be added</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// This method removes a node from the front of the queue.
        /// </summary>
        /// <returns>The node that is removed</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = temp.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// This method looks at what is currently at the front of the queue.
        /// </summary>
        /// <returns>The front node of the queue</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
