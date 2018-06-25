using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree();
            BinarySearchTree();
        }

        public static void BinaryTree ()
        {
            Console.Clear();
            Console.WriteLine("This is a Binary Tree");
            Node n1 = new Node(15);
            Node n2 = new Node(20);
            Node n3 = new Node(10);
            Node n4 = new Node(70);
            Node n5 = new Node(30);
            Node n6 = new Node(40);
            Node n7 = new Node(50);
            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);

            Console.WriteLine("This is BreadthFirst");
            Console.WriteLine("The order should be:");
            Console.WriteLine("15 -> 20 -> 10 -> 70 -> 30 -> 40 -> 50");
            Console.WriteLine("The traversal starts now:");
            // 15 -> 20 -> 10 -> 70 -> 30 -> 40 -> 50 ->
            binaryTree.BreadthFirst(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is PreOrder");
            Console.WriteLine("The order should be:");
            Console.WriteLine("15 -> 20 -> 70 -> 30 -> 10 -> 40 -> 50");
            Console.WriteLine("The traversal starts now:");
            // 15 -> 20 -> 70 -> 30 -> 10 -> 40 -> 50
            binaryTree.PreOrder(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is InOrder");
            Console.WriteLine("The order should be:");
            Console.WriteLine("70 -> 20 -> 30 -> 15 -> 40 -> 10 -> 50");
            Console.WriteLine("The traversal starts now:");
            // 70 -> 20 -> 30 -> 15 -> 40 -> 10 -> 50
            binaryTree.InOrder(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is PostOrder");
            Console.WriteLine("The order should be:");
            Console.WriteLine("70 -> 30 -> 20 -> 40 -> 50 -> 10 -> 15");
            Console.WriteLine("The traversal starts now:");
            // 70 -> 30 -> 20 -> 40 -> 50 -> 10 -> 15
            binaryTree.PostOrder(n1);
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Here is a search for a value in the tree");
            try
            {
                Node node = binaryTree.Search(n1, 20);
                Console.WriteLine(node.Value);
                Console.ReadLine();
                Console.WriteLine("Here is a search for a value not in the tree");
                Node node2 = binaryTree.Search(n1, 25);
                Console.WriteLine(node2.Value);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("A null reference exception was thrown");
                Console.ReadLine();
            }
        }

        public static void BinarySearchTree()
        {
            Console.Clear();
            Console.WriteLine("This is a Binary Search Tree");
            Node n1 = new Node(15);
            Node n2 = new Node(20);
            Node n3 = new Node(10);
            Node n4 = new Node(70);
            Node n5 = new Node(30);
            Node n6 = new Node(40);
            Node n7 = new Node(50);
            Node n8 = new Node(5);
            BinarySearchTree binarySearchTree = new BinarySearchTree(n1);
            binarySearchTree.Add(n1, n2);
            binarySearchTree.Add(n1, n3);
            binarySearchTree.Add(n1, n4);
            binarySearchTree.Add(n1, n5);
            binarySearchTree.Add(n1, n6);
            binarySearchTree.Add(n1, n7);
            binarySearchTree.Add(n1, n8);

            Console.Clear();
            Console.WriteLine("This is BreadthFirst:");
            Console.WriteLine("The order should be:");
            Console.WriteLine("15 -> 10 -> 20 -> 5 -> 70 -> 30 -> 40 -> 50");
            Console.WriteLine("The traversal starts now:");
            // 15 -> 10 -> 20 -> 5 -> 70 -> 30 -> 40 -> 50 ->
            binarySearchTree.BreadthFirst(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is PreOrder:");
            Console.WriteLine("The order should be:");
            Console.WriteLine("15 -> 10 -> 5 -> 20 -> 70 -> 30 -> 40 -> 50");
            Console.WriteLine("The traversal starts now:");
            // 15 -> 10 -> 5 -> 20 -> 70 -> 30 -> 40 -> 50
            binarySearchTree.PreOrder(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is InOrder");
            Console.WriteLine("The order should be:");
            Console.WriteLine("5 -> 10 -> 15 -> 20 -> 30 -> 40 -> 50 -> 70");
            Console.WriteLine("The traversal starts now:");
            // 5 -> 10 -> 15 -> 20 -> 30 -> 40 -> 50 -> 70
            binarySearchTree.InOrder(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is PostOrder:");
            Console.WriteLine("The order should be:");
            Console.WriteLine("5 -> 10 -> 50 -> 40 -> 30 -> 70 -> 20 -> 15");
            Console.WriteLine("The traversal starts now:");
            // 5 -> 10 -> 50 -> 40 -> 30 -> 70 -> 20 -> 15
            binarySearchTree.PostOrder(n1);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Here is a search for a value in the tree");
            try
            {
                Node node = binarySearchTree.Search(n1, 20);
                Console.WriteLine(node.Value);
                Console.ReadLine();
                Console.WriteLine("Here is a search for a value not in the tree");
                Node node2 = binarySearchTree.Search(n1, 25);
                Console.WriteLine(node2.Value);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("A null reference exception was thrown");
                Console.ReadLine();
            }
        }

    }
}
