using System;
using LinkedListMerge.Classes;

namespace LinkedListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Merge();
        }

        public static void Merge()
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);
            LinkdList LL1 = new LinkdList(n4);
            LL1.Add(n3);
            LL1.Add(n2);
            LL1.Add(n1);
            LL1.Add(new Node(0));
            LL1.Add(new Node(100));

            Node n1_2 = new Node(5);
            Node n2_2 = new Node(15);
            Node n3_2 = new Node(25);
            Node n4_2 = new Node(35);
            LinkdList LL2 = new LinkdList(n4_2);
            LL2.Add(n3_2);
            LL2.Add(n2_2);
            LL2.Add(n1_2);

            LL1.Print();
            // 100 --> 0 --> 10 --> 20 --> 30 --> 40 --> NULL
            Console.WriteLine();
            LL2.Print();
            // 5 --> 15 --> 25 --> 35 --> NULL
            Console.WriteLine();
            Node head = LL1.Merge(LL1, LL2);
            LL1.Print();
            // 100 --> 5 --> 0 --> 15 --> 10 --> 25 --> 20 --> 35 --> 30 --> 40 --> NULL
            Console.WriteLine();
        }
    }
}
