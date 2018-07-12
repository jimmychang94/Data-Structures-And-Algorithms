using System;
using System.Collections.Generic;

namespace FindIslands
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 1, 0, 1, 1, 1 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 1, 1, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }
            };
            int islands = FindIslands(matrix1);
            Console.WriteLine("There should be 1 island");
            Console.WriteLine($"There is {islands} island in this 2D matrix");
            Console.WriteLine();
            int[][] matrix2 = new int[][]
            {
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 1, 0 }
            };
            int island2 = FindIslands(matrix2);
            Console.WriteLine("There should be 2 islands");
            Console.WriteLine($"There are {island2} islands in this 2D matrix");
            Console.WriteLine();
            int[][] matrix3 = new int[][]
            {
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 1 },
                new int[] { 0, 0, 0, 1, 0 }
            };
            int island3 = FindIslands(matrix3);
            Console.WriteLine("There should be 2 islands");
            Console.WriteLine($"There are {island3} islands in this 2D matrix");
            Console.WriteLine();
            int[][] matrix4 = new int[][]
            {
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 1, 0 }
            };
            int island4 = FindIslands(matrix4);
            Console.WriteLine("There should be 3 islands");
            Console.WriteLine($"There are {island4} islands in this 2D matrix");
            Console.WriteLine();
            int[][] matrix5 = new int[][]
            {
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };
            int island5 = FindIslands(matrix5);
            Console.WriteLine("There should be 4 islands");
            Console.WriteLine($"There are {island5} islands in this 2D matrix");
            Console.WriteLine();
            int[][] matrix6 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };
            int island6 = FindIslands(matrix6);
            Console.WriteLine("There should be 5 islands");
            Console.WriteLine($"There are {island6} islands in this 2D matrix");
            Console.WriteLine();
        }

        /// <summary>
        /// This method takes in a 2D adjacency array of 0s and 1s and returns the number of islands
        /// </summary>
        /// <param name="matrix">The adjacency matrix</param>
        /// <returns>The number of islands</returns>
        public static int FindIslands(int[][] matrix)
        {
            int islandCounter = 0;
            bool connected;
            List<int> visited = new List<int> ();
            for(int i = 0; i < matrix.Length; i ++)
            {
                connected = false;    
                for (int j = i; j < matrix[i].Length; j ++)
                {
                    int connection = matrix[i][j];

                    if (connection == 1)
                    {
                        connected = true;
                        if (!visited.Contains(i))
                        {
                            islandCounter++;
                        }
                        visited.Add(j);
                        break;
                    }
                }
                if ((!connected) && (!visited.Contains(i)))
                {
                    islandCounter++;
                }

            }
            return islandCounter;
        }
    }
}
