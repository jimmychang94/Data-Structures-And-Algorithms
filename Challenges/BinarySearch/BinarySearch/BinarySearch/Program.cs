using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = new int[10];
            // int[] array = new int[100];
            // int[] array = new int[1000];
            // int[] array = new int[10000];
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            int key = -10;
            int result = BinarySearch(array, key);
            Console.WriteLine(result);
        }

        static int BinarySearch(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                Console.WriteLine(mid);
                if (array[mid] < key)
                    start = mid + 1;
                else if (array[mid] > key)
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
