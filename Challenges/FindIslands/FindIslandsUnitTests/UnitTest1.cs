using System;
using Xunit;
using FindIslands;

namespace FindIslandsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindIslandsGetsMultipleIslandsTest()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 1 },
                new int[] { 0, 0, 0, 1, 0 }
            };
            
            // Act
            int islandTest = Program.FindIslands(matrix);

            // Assert
            Assert.Equal(2, islandTest);
        }
        [Fact]
        public void FindIslandsGetsSingleIslandsTest()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 1, 0, 1, 1, 1 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 1, 1, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }
            };
            
            // Act
            int islandTest = Program.FindIslands(matrix);

            // Assert
            Assert.Equal(1, islandTest);
        }
        [Fact]
        public void FindIslandsGetsIslandsWithNoConnectionsTest()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };
            
            // Act
            int islandTest = Program.FindIslands(matrix);

            // Assert
            Assert.Equal(5, islandTest);
        }
    }
}
