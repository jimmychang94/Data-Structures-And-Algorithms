using LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable h1 = new HashTable();
            h1.Add("fond", "enamoured");
            h1.Add("wrath", "anger");
            h1.Add("diligent", "employed");
            h1.Add("outfit", "garb");
            h1.Add("guide", "usher");

            HashTable h2 = new HashTable();
            h2.Add("fond", "averse");
            h2.Add("wrath", "delight");
            h2.Add("diligent", "idle");
            h2.Add("guide", "follow");
            h2.Add("flow", "jam");

            List<string[]> leftJoin = LeftJoin(h1, h2);

            foreach(string[] array in leftJoin)
            {
                foreach(string str in array)
                {
                    Console.Write($"{str}, ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method takes two hash tables and left joins them.
        /// It then returns a list of string arrays holding:
        /// The Key, the value of the first table, the value of the second table.
        /// </summary>
        /// <param name="h1">The first hashtable</param>
        /// <param name="h2">The second hashtable</param>
        /// <returns>A list of string arrays</returns>
        public static List<string[]> LeftJoin(HashTable h1, HashTable h2)
        {
            List<string[]> answerList = new List<string[]>();
            for(int i = 0; i < h1.Table.Length; i ++)
            {
                if (h1.Table[i] != null)
                {
                    string[] answerArray = new string[] { h1.Table[i].Key, h1.Table[i].Value, "NULL" };
                    if (h2.Table[i] != null)
                    {
                        h2.Current = h2.Table[i];
                        while(h2.Current.Next != null)
                        {
                            if (h2.Current.Key == h1.Table[i].Key)
                            {
                                break;
                            }
                            h2.Current = h2.Current.Next;
                        }
                        if (h2.Current.Key == h1.Table[i].Key)
                        {
                            answerArray[2] = h2.Current.Value;
                        }
                    }
                    answerList.Add(answerArray);
                }
            }
            return answerList;
        }
    }
}
