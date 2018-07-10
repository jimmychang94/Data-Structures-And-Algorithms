using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);
            Node n9 = new Node(9);
            Node n10 = new Node(10);

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n4, n5);
            graph.AddEdge(n3, n6);
            graph.AddEdge(n1, n6);
            graph.AddEdge(n7, n8);
            graph.AddEdge(n7, n9);
            graph.AddEdge(n1, n10);
            graph.AddEdge(n4, n10);
            graph.AddEdge(n8, n10);
            graph.AddEdge(n3, n10);

            Console.WriteLine($"{n1.Value}'s neighbors: ");
            foreach(Node child in n1.Children)
            {
                Console.WriteLine($"{child.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{n1.Value}'s neighbor with GetNeighbor(): ");
            List<Node> neighbors = graph.GetNeighbors(n1);
            foreach (Node child in neighbors)
            {
                Console.WriteLine($"{child.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The size of the graph through the Size property");
            Console.WriteLine(graph.Size());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Here is all the nodes in the graph through the GetNodes property");
            foreach(Node node in graph.GetNodes())
            {
                Console.WriteLine($"{node.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("This is what the breadthfirst traversal should give: ");
            Console.WriteLine("1 --> 2 --> 3 --> 6 --> 10 --> 4 --> 8 --> 5 --> 7 --> 9");
            Console.WriteLine("Here is the breadthfirst traversal");
            List<Node> breadthfirst = graph.BreadthFirst(n1);
            foreach(Node node in breadthfirst)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
