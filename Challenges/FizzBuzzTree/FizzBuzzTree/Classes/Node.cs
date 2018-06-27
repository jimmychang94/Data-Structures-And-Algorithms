using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        /// <summary>
        /// This holds the string value of the node
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// This holds the reference to the left child of the node
        /// </summary>
        public Node LeftChild { get; set; }

        /// <summary>
        /// This holds the reference to the right child of the node
        /// </summary>
        public Node RightChild { get; set; }

        /// <summary>
        /// This constructor ensures that every node has a value
        /// </summary>
        /// <param name="value"></param>
        public Node(string value)
        {
            Value = value;
        }
    }

}
