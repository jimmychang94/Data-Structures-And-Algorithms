using System;

namespace Sorting_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 1, 5, 4, 3, 7, 2, 10 };
            foreach(int value in unsortedArray)
            {
                Console.Write($"{value} -> ");
            }
            Console.WriteLine();
            int[] sortedArray = InsertionsSort(unsortedArray);
            foreach(int value in sortedArray)
            {
                Console.Write($"{value} -> ");
            }
            Console.WriteLine();
        }

        public static int[] InsertionsSort(int[] array)     
        {
            for (int i = 1; i < array.Length; i ++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j = j - 1;
                }
            }

            return array;
        }
    }
}
