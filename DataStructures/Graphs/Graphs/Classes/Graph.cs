using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        /// <summary>
        /// This list holds all the nodes that are in the graph.
        /// It is initialized with an empty list with the graph.
        /// </summary>
        public List<Node> Nodes { get; set; } = new List<Node>();

        /// <summary>
        /// This adds 2 nodes to the graph and also connects them together.
        /// </summary>
        /// <param name="root">The first node</param>
        /// <param name="addNode">The second node</param>
        public void AddEdge(Node root, Node addNode)
        {
            root.Children.Add(addNode);
            addNode.Children.Add(root);
            if (!Nodes.Contains(root))
            {
                Nodes.Add(root);
            }
            if (!Nodes.Contains(addNode))
            {
                Nodes.Add(addNode);
            }
        }

        /// <summary>
        /// This returns all the nodes in the graph
        /// </summary>
        /// <returns>All the nodes in the graph</returns>
        public List<Node> GetNodes()
        {
            return Nodes;
        }

        /// <summary>
        /// This returns the number of nodes in the graph
        /// </summary>
        /// <returns>The number of nodes in the graph</returns>
        public int Size()
        {
            return Nodes.Count;
        }

        /// <summary>
        /// This finds and returns the nodes attached to the current node.
        /// </summary>
        /// <param name="root">The current node</param>
        /// <returns>The list of nodes</returns>
        public List<Node> GetNeighbors(Node root)
        {
            return root.Children;
        }

        /// <summary>
        /// This traverses the graph using the breadth first method
        /// </summary>
        /// <param name="root">The starting point in the graph</param>
        /// <returns>The list of connected nodes in the graph</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            root.Visited = true; // This makes sure that the root isn't returned twice

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach(Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            return order;
        }
    }
}
