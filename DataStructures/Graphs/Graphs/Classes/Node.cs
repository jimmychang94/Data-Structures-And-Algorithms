using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node
    {
        /// <summary>
        /// The value of the node
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// The list of the nodes connected to this node
        /// </summary>
        public List<Node> Children { get; set; }
        /// <summary>
        /// This determines whehter or not this node has been visited in the breadth first traversal
        /// </summary>
        public bool Visited { get; set; }

        /// <summary>
        /// This initalizes the node with the given value and also some other set properties.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(int value)
        {
            Value = value;
            Visited = false;
            Children = new List<Node>();
        }
    }
}
