using Sorting_Algorithms;
using System;
using Xunit;

namespace Sorting_AlgorithmUnitTests
{
    public class InsertionSortUnitTests
    {
        [Theory]
        [InlineData((new int[] { 1, 5, 4, 3, 7, 2, 10 }), (new int[] { 1, 2, 3, 4, 5, 7, 10 }) )]
        [InlineData((new int[] { 1, 5, 4, 3, 7, 2, 10, 1, 3, 5, 6, 8, 9 }), (new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 10 }) )]
        [InlineData((new int[] { -1, -5, -4, -3, -7, 2, 10 }), (new int[] { -7, -5, -4, -3, -1, 2, 10 }) )]
        public void InsertionSortCanSort(int[] unsortedArray, int[] sortedArray)
        {
            // Act
            Program.InsertionsSort(unsortedArray);

            // Assert
            Assert.Equal(sortedArray, unsortedArray);
        }
    }
}
