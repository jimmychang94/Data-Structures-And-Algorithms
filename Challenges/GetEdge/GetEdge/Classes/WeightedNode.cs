using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdge.Classes
{
    public class WeightedNode
    {
        /// <summary>
        /// The string value for the name of the node (in this case city)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// This holds the list of the children along with their weights
        /// </summary>
        public List<Dictionary<WeightedNode, int>> WeightedChildren { get; set; }

        /// <summary>
        /// This holds a list of the unweighted children
        /// </summary>
        public List<WeightedNode> Children { get; set; } = new List<WeightedNode>();

        /// <summary>
        /// This is used for breadth first traversal
        /// </summary>
        public bool Visited { get; set; }

        /// <summary>
        /// This constructor function initializes the node with a value.  
        /// It also sets the initial values for some properties.
        /// </summary>
        /// <param name="value"></param>
        public WeightedNode(string value)
        {
            Value = value;
            Visited = false;
            WeightedChildren = new List<Dictionary<WeightedNode, int>>();
        }
    }
}
