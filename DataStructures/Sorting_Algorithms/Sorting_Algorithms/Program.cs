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
            //InsertionsSort(unsortedArray);
            MergeSort(unsortedArray);
            foreach(int value in unsortedArray)
            {
                Console.Write($"{value} -> ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This method sorts the array from smallest to largest through a nested loop
        /// </summary>
        /// <param name="array">The unsorted array</param>
        public static void InsertionsSort(int[] array)     
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
        }
        /// <summary>
        /// This method takes in an array and sorts it recursively (using its overloaded method)
        /// </summary>
        /// <param name="array">array to be sorted</param>
        public static void MergeSort(int[] array)
        {
            int l = 0;
            int r = array.Length - 1;
            int m = (l + r) / 2;
            MergeSort(array, l, m);
            MergeSort(array, m + 1, r);
            Merge(array, l, m, r);

        }

        /// <summary>
        /// This method takes in an array to be sorted and then the left/right bounds that we are looking at.
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="l">The current left bound</param>
        /// <param name="r">The current right bound</param>
        public static void MergeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSort(array, l, m);
                MergeSort(array, m + 1, r);
                Merge(array, l, m, r);
            }
        }

        /// <summary>
        /// This is the logic behind how it sorts the array
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="l">The current left bound</param>
        /// <param name="m">The mid point</param>
        /// <param name="r">The current right bound</param>
        public static void Merge (int[] array, int l, int m, int r)
        {
            //Below we create lengths we want temporary arrays to be.
            int n1 = m - l + 1;
            int n2 = r - m;

            // We create temp arrays and fill them with values from the array.
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int a = 0; a < leftArr.Length; a++)
            {
                leftArr[a] = array[l + a];
            }

            for (int b = 0; b < rightArr.Length; b++)
            {
                rightArr[b] = array[m + 1 + b];
            }

            //This logic replaces the value of the array with whichever value is smaller when comparing the left and right temp arrays.
            int i = 0, j = 0;
            int k = l;
            while(i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    array[k] = leftArr[i];
                    i++;
                }
                else
                {
                    array[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            
            //These last 2 while loops are for catching any values that are left out from the first loop.
            while(i < leftArr.Length)
            {
                array[k] = leftArr[i];
                i++;
                k++;
            }
            while(j < rightArr.Length)
            {
                array[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
