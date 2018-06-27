using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// This constructor makes sure that the Binary tree starts with a node.
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
        }

        /// <summary>
        /// This traverses the binary tree starting at the inputted Node.
        /// The order it goes in is: Root, Left, Right
        /// </summary>
        /// <param name="node">The node at which to start the traversal</param>
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        /// <summary>
        /// This traverses the binary tree starting at the inputted Node.
        /// The order it goes in is: Left, Root, Right
        /// </summary>
        /// <param name="node">The node at which to start the traversal</param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        /// <summary>
        /// This traverses the binary tree starting at the inputted Node.
        /// The order it goes in is: Left, Right, Root
        /// </summary>
        /// <param name="node">The node at which to start the traversal</param>
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// This traverses the binary tree starting at the inputted Node.
        /// It traverses the tree by going through each level of the tree, Node by Node.
        /// </summary>
        /// <param name="node">The node at which to start the traversal</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        /// <summary>
        /// This method searches the entire tree and then returns a Node if it finds it or null if it doesn't.
        /// It uses the PreOrder traversal method when searching each node.
        /// </summary>
        /// <param name="root">This is the node at which the search starts</param>
        /// <param name="value">This is the value of the node that is being searched for</param>
        /// <returns>This is the found Node or null if nothing is found</returns>
        public virtual Node Search(Node root, string value)
        {
            Node current = root;
            while (current.Value != value)
            {
                if (current.LeftChild != null)
                {
                    current = current.LeftChild;
                }

                if (current.Value == value)
                {
                    return current;
                }

                if (current.RightChild != null)
                {
                    current = current.RightChild;
                }

                if (current.Value == value)
                {
                    return current;
                }

                if (current.Value != value)
                {
                    return null;
                }
            }
            return current;
        }

        /// <summary>
        /// This method adds a node to the Binary Tree
        /// An empty spot is found through the breadthfirst traversal method.
        /// </summary>
        /// <param name="root">This is where it would start searching for a spot to put the node</param>
        /// <param name="newNode">This is the node to be added</param>
        public virtual void Add(Node root, Node newNode)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                else
                {
                    front.LeftChild = newNode;
                    return;
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
                else
                {
                    front.RightChild = newNode;
                    return;
                }
            }

        }
    }
}
