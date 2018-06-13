using System;
using KthElement.Classes;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);
            LinkdList ll = new LinkdList(n4);
            ll.Add(n3);
            ll.Add(n2);
            ll.Add(n1);

            // Act
            Node result = ll.KthElement(0);
            Console.WriteLine(result.Value);
        }
        
    }
}
