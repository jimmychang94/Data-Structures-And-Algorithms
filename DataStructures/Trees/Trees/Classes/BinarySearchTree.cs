using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// This forces a Binary Search Tree to also starts with a node.
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(Node root) : base(root)
        {
        }

        /// <summary>
        /// This method compares the value of the current node to the value it is looking for.
        /// If it finds a value, it returns that node.
        /// If it doesn't find a value, it returns null
        /// </summary>
        /// <param name="root">This is where the search starts from</param>
        /// <param name="value">This is the value that is being searched for</param>
        /// <returns>A node or null depending on if the search found something</returns>
        public override Node Search(Node root, int value)
        {
            Node current = root;

            while(current.Value != value)
            {
                if (current.Value > value)
                {
                    if (current.LeftChild != null)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        return null;
                    }
                }
                if (current.Value < value)
                {
                    if (current.RightChild != null)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return current;
        }

        /// <summary>
        /// This overrides the Binary Tree's Add method to be for the Binary Search Tree.
        /// It adds a node into an empty child location depending on a comparison with the current node.
        /// </summary>
        /// <param name="root">The node which we start searching for an empty spot</param>
        /// <param name="newNode">The node to be added</param>
        public override void Add(Node root, Node newNode)
        {
            Node current = root;

            while (current.Value != newNode.Value)
            {
                if (current.Value > newNode.Value)
                {
                    if (current.LeftChild != null)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        current.LeftChild = newNode;
                    }
                }
                if (current.Value < newNode.Value)
                {
                    if (current.RightChild != null)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        current.RightChild = newNode;
                    }
                }
            }
        }
    }
}
