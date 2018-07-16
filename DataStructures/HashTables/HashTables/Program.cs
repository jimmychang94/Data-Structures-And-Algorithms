using HashTables.Classes;
using System;

namespace HashTables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable table = new HashTable();

            table.Add("tree", 10);
            int index = table.GetHash("tree");
            int value = table.Find("tree");

            Console.WriteLine($"The index of tree is: {index}");
            Console.WriteLine($"The value of tree is: {value}");
            Console.WriteLine();

            table.Add("sref", 15);
            int index2 = table.GetHash("sref");
            int value2 = table.Find("sref");

            Console.WriteLine($"The index of sref is: {index2}");
            Console.WriteLine($"The value of sref is: {value2}");
            Console.WriteLine();

            table.Add("cat", 25);
            int index3 = table.GetHash("cat");
            int value3 = table.Find("cat");

            Console.WriteLine($"The index of cat is: {index3}");
            Console.WriteLine($"The value of cat is: {value3}");
            Console.WriteLine();
            Console.WriteLine($"Checking to see if tree exists: {table.Contains("tree")}");
            Console.WriteLine($"Checking to see if sref exists: {table.Contains("sref")}");
            Console.WriteLine($"Checking to see if cat exists: {table.Contains("cat")}");
            Console.WriteLine($"Checking to see if dog exists: {table.Contains("dog")}");
        }
    }
}
