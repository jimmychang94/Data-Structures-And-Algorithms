using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Node
    {
        /// <summary>
        /// Every node needs a value in our linked list.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// This property allows for us to progress on our linked list.
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// This is a constructor for the Node and requires a value to create a node.
        /// </summary>
        /// <param name="value">A value which is required to create a node</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
