using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            ArrayReverse(array);
        }

        static int[] ArrayReverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i ++)
            {
                newArray[i] = array[array.Length - i - 1];
            }
            return newArray;
        }
    }
}
