using System;
using KthElement.Classes;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            KthElement();
        }
        public static void KthElement()
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);
            LinkdList ll = new LinkdList(n4);
            ll.Add(n3);
            ll.Add(n2);
            ll.Add(n1);
            int k = 3;
            try
            {
                Node result = ll.KthElement(k);
                Console.WriteLine(result.Value);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The input needs to be positive.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The input is too large.");
            }
        }
        
    }
}
