using HashTables.Classes;
using System;
using System.Collections.Generic;
using Trees.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Trees.Classes.Node n1 = new Trees.Classes.Node(10);
            Trees.Classes.Node n2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n3 = new Trees.Classes.Node(30);
            Trees.Classes.Node n4 = new Trees.Classes.Node(40);
            Trees.Classes.Node n5 = new Trees.Classes.Node(50);
            Trees.Classes.Node n6 = new Trees.Classes.Node(60);

            BinaryTree b1 = new BinaryTree(n1);
            b1.Add(n1, n2);
            b1.Add(n1, n3);
            b1.Add(n1, n4);
            b1.Add(n1, n5);
            b1.Add(n1, n6);

            Trees.Classes.Node n1v2 = new Trees.Classes.Node(15);
            Trees.Classes.Node n2v2 = new Trees.Classes.Node(20);
            Trees.Classes.Node n3v2 = new Trees.Classes.Node(25);
            Trees.Classes.Node n4v2 = new Trees.Classes.Node(30);
            Trees.Classes.Node n5v2 = new Trees.Classes.Node(35);
            Trees.Classes.Node n6v2 = new Trees.Classes.Node(40);

            BinaryTree b2 = new BinaryTree(n1v2);
            b1.Add(n1v2, n2v2);
            b1.Add(n1v2, n3v2);
            b1.Add(n1v2, n4v2);
            b1.Add(n1v2, n5v2);
            b1.Add(n1v2, n6v2);

            List<int> intersect = TreeIntersection(n1, n1v2);
            foreach(int value in intersect)
            {
                Console.WriteLine($"An intersection is: {value}");
            }
        }

        /// <summary>
        /// This method takes in two tree nodes and returns a list of the values that are the same.
        /// </summary>
        /// <param name="n1">The node for the first tree</param>
        /// <param name="n2">The node for the second tree</param>
        /// <returns>A list of same values</returns>
        public static List<int> TreeIntersection (Trees.Classes.Node n1, Trees.Classes.Node n2)
        {
            List<int> answers = new List<int>();
            HashTable hashTable = new HashTable();
            Queue<Trees.Classes.Node> queue = new Queue<Trees.Classes.Node>();
            queue.Enqueue(n1);
            while (queue.TryPeek(out n1))
            {
                Trees.Classes.Node current = queue.Dequeue();
                try
                {
                    hashTable.Add(current.Value.ToString(), 1);
                }
                catch (Exception)
                {
                    answers.Add(current.Value);
                }
                finally
                {
                    if (current.LeftChild != null)
                    {
                        queue.Enqueue(current.LeftChild);
                    }
                    if (current.RightChild != null)
                    {
                        queue.Enqueue(current.RightChild);
                    }
                }
            }
            queue.Enqueue(n2);
            while(queue.TryPeek(out n2))
            {
                Trees.Classes.Node current = queue.Dequeue();
                try
                {
                    hashTable.Add(current.Value.ToString(), 1);
                }
                catch (Exception)
                {
                    answers.Add(current.Value);
                }
                finally
                {
                    if (current.LeftChild != null)
                    {
                        queue.Enqueue(current.LeftChild);
                    }
                    if (current.RightChild != null)
                    {
                        queue.Enqueue(current.RightChild);
                    }
                }
            }
            return answers;
        }
    }
}
