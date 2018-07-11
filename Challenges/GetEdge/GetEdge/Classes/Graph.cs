using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdge.Classes
{
    public class Graph
    {
        /// <summary>
        /// This holds all of the nodes in the graph
        /// </summary>
        public List<WeightedNode> Nodes { get; set; } = new List<WeightedNode>();

        /// <summary>
        /// This adds an edge to the graph while adding a weight with the inputted value
        /// </summary>
        /// <param name="root">The first node</param>
        /// <param name="addNode">The second node</param>
        /// <param name="value">The weight of the edge</param>
        public void AddEdge(WeightedNode root, WeightedNode addNode, int value)
        {
            root.Children.Add(addNode);
            root.WeightedChildren.Add(new Dictionary<WeightedNode, int> { { addNode, value } });
            addNode.Children.Add(root);
            addNode.WeightedChildren.Add(new Dictionary<WeightedNode, int> { { root, value } });
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
        /// This returns all of the nodes in the graph
        /// </summary>
        /// <returns>The nodes in the graph</returns>
        public List<WeightedNode> GetNodes()
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
        /// This returns the neighbors of the given node with weights attatched
        /// </summary>
        /// <param name="root">The node to check for neighbors</param>
        /// <returns>The list of neighbors and their weighted edges</returns>
        public List<Dictionary<WeightedNode, int>> GetNeighbors(WeightedNode root)
        {
            return root.WeightedChildren;
        }

        /// <summary>
        /// This traverses the graph and returns the list of all connected nodes.
        /// </summary>
        /// <param name="root">The node to start the traversal</param>
        /// <returns>A list of all the nodes connected to the given node</returns>
        public List<WeightedNode> BreadthFirst(WeightedNode root)
        {
            List<WeightedNode> order = new List<WeightedNode>();
            Queue<WeightedNode> breadth = new Queue<WeightedNode>();
            breadth.Enqueue(root);
            root.Visited = true; // This makes sure that the root isn't returned twice

            while (breadth.TryPeek(out root))
            {
                WeightedNode front = breadth.Dequeue();
                order.Add(front);

                foreach (WeightedNode child in front.Children)
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

        /// <summary>
        /// This takes in a starting node and then two strings which correspond with two values in the graph.
        /// It will return a true/weight if the nodes corresponding with the strings are connected.
        /// It will return a false/0 if the nodes are not connected.  
        /// </summary>
        /// <param name="root">The starting node to search for traversal</param>
        /// <param name="city1">The first city to look for</param>
        /// <param name="city2">The second city which we want to be attached to the first city</param>
        /// <returns>A bool/int dictionary of if the cities are connected</returns>
        public Dictionary<bool, int> GetEdge(WeightedNode root, string city1, string city2)
        {
            foreach(WeightedNode node in Nodes)
            {
                if (node.Value == city1)
                {
                    foreach(WeightedNode node2 in node.Children)
                    {
                        if (node2.Value == city2)
                        {
                            foreach(Dictionary<WeightedNode, int> child in node.WeightedChildren)
                            {
                                if (child.ContainsKey(node2))
                                {
                                    int value = child[node2];
                                    return new Dictionary<bool, int> { { true, value } };
                                }
                            }

                        }
                    }
                }
            }
            return new Dictionary<bool, int>{ { false, 0 } };
        }
    }
}
