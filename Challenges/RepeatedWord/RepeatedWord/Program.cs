using System;
using HashTables.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a test to see if the RepeatedWord method works. It takes in a string and returns the first repeated word";
            string output = RepeatedWord(input);
            Console.WriteLine(input);
            Console.WriteLine();
            Console.WriteLine(output);

            Console.WriteLine();
            Console.WriteLine();

            string input2 = "Another test uses another input and also returns another output.";
            string output2 = RepeatedWord(input2);
            Console.WriteLine(input2);
            Console.WriteLine();
            Console.WriteLine(output2);
            Console.WriteLine();
        }

        /// <summary>
        /// This takes in a string and returns the first repeated word.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>The first repeated word</returns>
        public static string RepeatedWord(string input)
        {
            if (input == null)
            {
                return "";
            }
            string[] array = input.Split(" ");
            HashTable uniqueWords = new HashTable();
            foreach(string word in array)
            {
                string replacePeriod = word.Replace(".", "");
                string replaceCommaAndPeriod = replacePeriod.Replace(",", "");
                try
                {
                    uniqueWords.Add(replaceCommaAndPeriod.ToLower(), 1);
                }
                catch (Exception)
                {
                    return replaceCommaAndPeriod;
                }
            }
            return "";
        }
    }
}
