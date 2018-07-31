using Sorting_Algorithms;
using System;
using Xunit;

namespace Sorting_AlgorithmUnitTests
{
    public class MergeSortUnitTests
    {
        [Fact]
        public void MergeSortCanSort()
        {
            // Arrange
            int[] unsortedArray = new int[] { 1, 5, 4, 3, 7, 2, 10 };
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 7, 10 };

            // Act
            Program.MergeSort(unsortedArray);

            // Assert
            Assert.Equal(sortedArray, unsortedArray);
        }
        [Fact]
        public void MergeSortCanSortWithSameValues()
        {
            // Arrange
            int[] unsortedArray = new int[] { 1, 5, 4, 3, 7, 2, 10, 1, 3, 6, 8 };
            int[] sortedArray = new int[] { 1, 1, 2, 3, 3, 4, 5, 6, 7, 8, 10 };

            // Act
            Program.MergeSort(unsortedArray);

            // Assert
            Assert.Equal(sortedArray, unsortedArray);
        }
        [Fact]
        public void MergeSortCanSortWithNegativeNumbers()
        {
            // Arrange
            int[] unsortedArray = new int[] { -1, -5, -4, -3, -7, 2, 10 };
            int[] sortedArray = new int[] { -7, -5, -4, -3, -1, 2, 10 };

            // Act
            Program.MergeSort(unsortedArray);

            // Assert
            Assert.Equal(sortedArray, unsortedArray);
        }
    }
}
