using System;
using Trees.Classes;

namespace FindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(10);
            Node n2 = new Node(7);
            Node n3 = new Node(27);
            Node n4 = new Node(13);
            Node n5 = new Node(31);
            Node n6 = new Node(1);
            Node n7 = new Node(17);
            Node n8 = new Node(23);

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            binaryTree.Add(n1, n5);
            binaryTree.Add(n1, n6);
            binaryTree.Add(n1, n7);
            binaryTree.Add(n1, n8);
            
            int maxValue = FindMax(n1);
            // should be 31
            Console.WriteLine(maxValue);
            Console.WriteLine("31");
        }

        /// <summary>
        /// This is the initial start to the recursive method to find the maximum value of a binary tree.  
        /// It takes in a root value and sets the initial maximum value to be the root.Value.  
        /// Once the traversal of the tree is finished, it returns the largest value in the binary tree.
        /// </summary>
        /// <param name="root">The starting node of the tree</param>
        /// <returns>The maximum value within the tree</returns>
        public static int FindMax(Node root)
        {
            int maxValue = root.Value;
            if (root.LeftChild != null)
            {
                maxValue = FindMax(root.LeftChild, maxValue);
            }
            if (root.RightChild != null)
            {
                maxValue = FindMax(root.RightChild, maxValue);
            }
            return maxValue;
        }

        /// <summary>
        /// This method takes is a recursive method to traverse an entire binary tree
        /// It takes a current maximum value and compares that with the current node's value.
        /// The value is changed if the current node has a larger value.
        /// </summary>
        /// <param name="root">The current node</param>
        /// <param name="maxValue">The current  maximum</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(Node root, int maxValue)
        {
            if (root.Value > maxValue)
            {
                maxValue = root.Value;
            }
            if (root.LeftChild != null)
            {
                maxValue = FindMax(root.LeftChild, maxValue);
            }
            if (root.RightChild != null)
            {
                maxValue = FindMax(root.RightChild, maxValue);
            }
            return maxValue;
        }
    }
}
