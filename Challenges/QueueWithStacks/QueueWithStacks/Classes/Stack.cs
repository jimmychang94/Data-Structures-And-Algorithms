using System;
using System.Collections.Generic;
using System.Text;
using QueueWithStacks.Classes;

namespace QueueWithStacks.Classes
{
    public class Stack
    {
        /// <summary>
        /// This node marks the top most node on the stack
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// This onstructor makes it so that creating a stack requires a node. It also sets top to be the first node.
        /// </summary>
        /// <param name="node">The node required to initialize the stack</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// This method takes a node and adds it to the top of the stack
        /// </summary>
        /// <param name="node">The node to be added</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// This method removes the top most node from the stack and returns it.
        /// </summary>
        /// <returns>The top most node from the stack</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = temp.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// This method looks at the top most node of the stack.
        /// </summary>
        /// <returns>The top most node of the stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
