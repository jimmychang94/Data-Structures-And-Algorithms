using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Graph graph = new Graph();

            // Act
            graph.AddEdge(n1, n2);

            // Assert
            Assert.Equal(n2, n1.Children[0]);
        }
        [Fact]
        public void SizeTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            Graph graph = new Graph();

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n5);

            // Act
            int size = graph.Size();

            // Assert
            Assert.Equal(5, size);
        }
        [Fact]
        public void GetNeighborsTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            Graph graph = new Graph();

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n5);

            // Act
            List<Node> neighbors = graph.GetNeighbors(n2);

            // Assert
            Assert.Equal(1, neighbors[0].Value);
            Assert.Equal(4, neighbors[1].Value);
        }
    }
}
