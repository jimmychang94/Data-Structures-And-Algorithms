using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("10");
            Node n2 = new Node("15");
            Node n3 = new Node("3");
            Node n4 = new Node("17");

            BinaryTree binaryTree = new BinaryTree(n1);
            binaryTree.Add(n1, n2);
            binaryTree.Add(n1, n3);
            binaryTree.Add(n1, n4);
            Node random = FizzBuzzTree(n1);
            binaryTree.BreadthFirst(random);
        }

        /// <summary>
        /// This traverses a tree starting at the node given.
        /// It then calls another method to check the value of the node and possibly edit it.
        /// Once it is done with the traversal/change, it returns the starting node.
        /// </summary>
        /// <param name="root">Where the traversal starts</param>
        /// <returns>The starting node of the tree</returns>
        public static Node FizzBuzzTree(Node root)
        {
            root = CheckNode(root);
            if (root.LeftChild != null)
            {
                FizzBuzzTree(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                FizzBuzzTree(root.RightChild);
            }
            return root;
        }

        /// <summary>
        /// This method checks to see if the input has a value that is divisible by 3, 5, or both.
        /// It edits the value depending on the above if statement and returns the node.
        /// </summary>
        /// <param name="root">The node to be checked</param>
        /// <returns>The edited node</returns>
        public static Node CheckNode(Node root)
        {
            Int32.TryParse(root.Value, out int rootValue);
            if (rootValue % 15 == 0)
            {
                root.Value = "FizzBuzz";
            }
            else if (rootValue % 5 == 0)
            {
                root.Value = "Buzz";
            }
            else if (rootValue % 3 == 0)
            {
                root.Value = "Fizz";
            }
            return root;
        }
    }
}
