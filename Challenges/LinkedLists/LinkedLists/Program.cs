using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestLL();
        }

        /// <summary>
        /// This method is used to test the Linked Lists in the console.
        /// </summary>
        static void TestLL()
        {
            LinkdList ll = new LinkdList(new Node(10));

            ll.Add(new Node(15));
            ll.Add(new Node(20));

            ll.Print();
            // 20 -> 15 -> 10 -> NULL;
            Console.WriteLine();

            Console.WriteLine("Let's find Node 10");

            Node found = ll.Find(10);

            Console.WriteLine(found.Value);

            Node n3 = new Node(27);
            Node n6 = new Node(12);
            Node n7 = new Node(24);
            ll.AddBefore(n3, ll.Find(15));
            ll.AddAfter(n6, ll.Find(27));
            ll.AddLast(n7);

            ll.Print();
            Console.WriteLine();
            // 20 -> 27 -> 12 -> 15 -> 10 -> 24 -> NULL;
        }
    }
}
