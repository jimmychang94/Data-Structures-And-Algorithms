using System;

namespace AdjacentProduct
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int result = AdjacentProduct(array2D);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Finds the largest product from an adjacent element in a given two-dimensional array.
        /// </summary>
        /// <param name="twoDimArray"></param>
        /// <returns>An integer of the largest product</returns>
        public static int AdjacentProduct(int[,] twoDimArray)
        {
            int largestProduct = 0;
            int outerLength = twoDimArray.GetLength(0);
            int innerLength = twoDimArray.GetLength(1);
            // This is testing for the edge case where the array only has 2 values in it in which case we return the product.
            if ((outerLength == 1) && (innerLength == 2))
                return twoDimArray[0, 0] * twoDimArray[0, 1];
            else if ((outerLength == 2) && (innerLength == 1))
                return twoDimArray[0, 0] * twoDimArray[1, 0]; 
            // This is for normmal two-dimensional arrays that have differing width and lengths.
            for (int i = 0; i < outerLength; i ++)
            {
                for (int j = 0; j < innerLength; j ++)
                {
                    int current = twoDimArray[i, j];
                    int east = 0, southEast = 0, south = 0, southWest = 0;
                    if (i == outerLength - 1)
                    {
                        if (j != innerLength - 1)
                        {
                            int eastNode = twoDimArray[i, j + 1];
                            east = current * eastNode;
                        }
                    }
                    else
                    {
                        int southNode = twoDimArray[i + 1, j];
                        south = current * southNode;
                        if ((j == 0) && (j == innerLength - 1))
                        {
                            // This is an edge case where the 2D array has only 1 column.
                            // The only value that can be calcualted is south which is already done.
                            // The only reason this is here is so that the following if statements are not implemented.
                        }
                        else if (j == 0)
                        {
                            int eastNode = twoDimArray[i, j + 1];
                            int southEastNode = twoDimArray[i + 1, j + 1];
                            east = current * eastNode;
                            southEast = current * southEastNode;
                        }
                        else if (j == innerLength - 1)
                        {
                            int southWestNode = twoDimArray[i + 1, j - 1];
                            southWest = current * southWestNode;
                        }
                        else
                        {
                            int eastNode = twoDimArray[i, j + 1];
                            int southEastNode = twoDimArray[i + 1, j + 1];
                            int southWestNode = twoDimArray[i + 1, j - 1];
                            east = current * eastNode;
                            southEast = current * southEastNode;
                            southWest = current * southWestNode;
                        }
                    }
                    largestProduct = ComparingProducts(largestProduct, east);
                    largestProduct = ComparingProducts(largestProduct, south);
                    largestProduct = ComparingProducts(largestProduct, southEast);
                    largestProduct = ComparingProducts(largestProduct, southWest);
                }
            }

            return largestProduct;
        }
        /// <summary>
        /// This method compares two numbers and returns the largest number.
        /// </summary>
        /// <param name="currentLargest">The initial largest number</param>
        /// <param name="contender">The number we are comparing to</param>
        /// <returns>Largest number</returns>
        static int ComparingProducts (int currentLargest, int contender)
        {
            return (currentLargest < contender) ? contender : currentLargest;
        }
    }
}
