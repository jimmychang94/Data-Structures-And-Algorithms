using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // The following lines of code creates an input array and sets the output to a variable called reversedArray.
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i ++)
                array[i] = i;
            int[] reversedArray = ArrayReverse(array);
        }
        
        static int[] ArrayReverse(int[] array)
        {
            // Here we create a new array with the same length as our input array. This is where we will store the reversed array.
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i ++)
            {
                // This line of code allows us to have the old array assigned to the new array with the numbers flipped; the last element for the input array is the first element in the new array.
                newArray[i] = array[array.Length - i - 1];
            }
            return newArray;
        }
    }
}
