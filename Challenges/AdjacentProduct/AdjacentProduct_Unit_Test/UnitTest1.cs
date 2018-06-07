using System;
using AdjacentProduct;
using Xunit;

namespace AdjacentProduct_Unit_Test
{
    public class UnitTest1
    {
        /// <summary>
        /// This test is used to test for generic options with the program.
        /// There are many parameters because this allows for the easy creation of a multi-dimensional array without needing manually put in all the values.
        /// The downside to this is that the numbers are incremental which leads to the largest product being near the start or end.
        /// The only parameter that does not directly relate to the creation of the array is the "expected" which is what is used in the Assert.Equal() method.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="increment"></param>
        /// <param name="start"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(5, 5, 1, 0, 56)]
        [InlineData(4, 4, -1, 20, 380)]
        [InlineData(5, 5, -10, 0, 5600)]
        [InlineData(10, 1, 2, 20, 1368)]
        [InlineData(1, 10, 2, 20, 1368)]
        public void MultiDimensionalArrayTest(int length, int width, int increment, int start, int expected)
        {
            int[,] array2D = new int[length, width];
            for (int i = 0; i < length; i ++)
            {
                for (int j = 0; j < width; j ++)
                    array2D[i, j] = start + increment * j + increment * i;
            }
            //  Here is an example array with length = 3, width = 4, int increment = 1, and int start = 0
            // [
            //  [ 0 , 1 , 2 , 3 ]
            //  [ 1 , 2 , 3 , 4 ]
            //  [ 2 , 3 , 4 , 5 ]

            Assert.Equal(expected, Program.AdjacentProduct(array2D));
        }

        /// <summary>
        /// This test is for the case where the numbers in the multi-dimensional array are not incremental and don't follow a specific format.
        /// In particular, this test checks for when the largest number is not a part of the numbers which equate to the largest product.
        /// </summary>
        [Fact]
        public void LargestNumberNotLargestProductTest()
        {
            int[,] array2D = new int[,] { { 1, 9, 1, 6 }, { 1, 2, 3, 4 }, { 5, 1, 3, 2 }, { 6, 5, 1, 9 } };
            Assert.Equal(30, Program.AdjacentProduct(array2D));
        }
    }
}
