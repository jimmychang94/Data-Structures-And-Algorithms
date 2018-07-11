using GetEdge.Classes;
using System;
using System.Collections.Generic;

namespace GetEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();

            WeightedNode n1 = new WeightedNode("1");
            WeightedNode n2 = new WeightedNode("2");
            WeightedNode n3 = new WeightedNode("3");
            WeightedNode n4 = new WeightedNode("4");
            WeightedNode n5 = new WeightedNode("5");
            WeightedNode n6 = new WeightedNode("6");
            WeightedNode n7 = new WeightedNode("7");
            WeightedNode n8 = new WeightedNode("8");
            WeightedNode n9 = new WeightedNode("9");
            WeightedNode n10 = new WeightedNode("10");

            graph.AddEdge(n1, n2, 2);
            graph.AddEdge(n1, n3, 3);
            graph.AddEdge(n2, n4, 4);
            graph.AddEdge(n4, n5, 5);
            graph.AddEdge(n3, n6, 6);
            graph.AddEdge(n1, n6, 7);
            graph.AddEdge(n7, n8, 8);
            graph.AddEdge(n7, n9, 9);
            graph.AddEdge(n1, n10, 10);
            graph.AddEdge(n4, n10, 11);
            graph.AddEdge(n8, n10, 12);
            graph.AddEdge(n3, n10, 13);

            Dictionary<bool, int> valuePair = graph.GetEdge(n1, "1", "10");
            Console.WriteLine($"{valuePair[true]} is the value true for {n1.Value}-{n10.Value}");
            Dictionary<bool, int> valuePair2 = graph.GetEdge(n1, "1", "9");
            Console.WriteLine($"{valuePair2[false]} is the value false for {n1.Value}-{n9.Value}");

            Graph newGraph = new Graph();

            Dictionary<bool, int> notTrue = graph.GetEdge(n1, "hi", "what's up");
            Console.WriteLine($"{notTrue[false]} is the value for an empty graph");
        }
    }
}
