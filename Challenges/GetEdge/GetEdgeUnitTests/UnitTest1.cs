using GetEdge.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace GetEdgeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetEdgesGivesCorrectResponseWithCorrectValuesTest()
        {
            // Arrange
            WeightedNode n1 = new WeightedNode("Seattle");
            WeightedNode n2 = new WeightedNode("New York");
            WeightedNode n3 = new WeightedNode("Chicago");
            WeightedNode n4 = new WeightedNode("Austin");

            Graph graph = new Graph();
            graph.AddEdge(n1, n2, 20);
            graph.AddEdge(n1, n3, 10);
            graph.AddEdge(n2, n3, 10);
            graph.AddEdge(n2, n4, 16);
            graph.AddEdge(n3, n4, 8);

            // Act
            Dictionary<bool, int> testTravel = graph.GetEdge(n1, "New York", "Austin");

            // Assert
            Assert.Equal(new Dictionary<bool, int> { { true, 16 } }, testTravel);
        }
        [Fact]
        public void GetEdgesGivesCorrectResponseWithIncorrectValuesTest()
        {
            // Arrange
            WeightedNode n1 = new WeightedNode("Seattle");
            WeightedNode n2 = new WeightedNode("New York");
            WeightedNode n3 = new WeightedNode("Chicago");
            WeightedNode n4 = new WeightedNode("Austin");

            Graph graph = new Graph();
            graph.AddEdge(n1, n2, 20);
            graph.AddEdge(n1, n3, 10);
            graph.AddEdge(n2, n3, 10);
            graph.AddEdge(n2, n4, 16);
            graph.AddEdge(n3, n4, 8);

            // Act
            Dictionary<bool, int> testTravel = graph.GetEdge(n1, "Seattle", "Austin");

            // Assert
            Assert.Equal(new Dictionary<bool, int> { { false, 0 } }, testTravel);
        }
        [Fact]
        public void GetEdgesGivesCorrectResponseToEmptyGraphTest()
        {
            // Arrange
            Graph graph = new Graph();

            // Act
            Dictionary<bool, int> testTravel = graph.GetEdge(new WeightedNode("Miami"), "Miami", "Las Vegas");

            // Assert
            Assert.Equal(new Dictionary<bool, int> { { false, 0 } }, testTravel);
        }
    }
}
