using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // The below acts as a test for the different size arrays; the key is also able to be changed.

            // int[] array = new int[10];
            // int[] array = new int[100];
            // int[] array = new int[1000];
            // int[] array = new int[10000];
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            int key = -10;
            // Here we call the search with the array and the key while setting the return value to the variable result.
            int result = BinarySearch(array, key);
            Console.WriteLine($"The key is: {key} and the result is: {result}");
        }

        static int BinarySearch(int[] array, int key)
        {
            // The start/end correspond to the range in which we are currently searching. We used a recursive method so depending on the number, both the start and end can change.
            int start = 0;
            int end = array.Length - 1;
            int mid;
            // Here is the start to the recursion for finding the right index.
            // We have the condition be start <= end because with only start < end we ran into a case where the key is the last value in the array and thus when start = end we need it to run once more but at that point it is already kicked out of the while loop.
            while (start <= end)
            {
                // Mid is the average of the start and end value and the array element at that index is compared to the key.
                mid = (start + end) / 2;
                if (array[mid] < key)
                    // When the key is larger than the element at mid; that means anything that is mid or below will not be the key therefore we set the lower-bound of the range to be 1 value higher than mid (since mid is already tested).
                    start = mid + 1;
                else if (array[mid] > key)
                    // When the key is smaller than the element at mid; that means anything that is mid or above will not be the key which is why we set the upper-bound of hte range to be 1 value less than the mid.
                    end = mid - 1;
                else
                    // The only other case is when the element at mid is equal to the key which would then end the method and return the index at which we found the match.
                    return mid;
            }
            // If the while loop runs its course that means we have checked through the array and the key is not within the array so we return -1.
            return -1;
        }
    }
}
