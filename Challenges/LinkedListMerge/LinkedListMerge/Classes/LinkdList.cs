using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListMerge.Classes
{
    public class LinkdList
    {
        /// <summary>
        /// This serves as a reference to which Node is the start of the list
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// This serves as a reference to where we are along the linked list
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// This is a constructor for a linked list which requires at least 1 node to start
        /// </summary>
        /// <param name="node">A starting node for a linked list</param>
        public LinkdList(Node node)
        {
            Head = node;
            Current = node;
        }

        //Adding a Node O(1)
        /// <summary>
        /// This method adds a node to the start of the linked list
        /// </summary>
        /// <param name="node">This is the node that we are adding to the list</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        //Print out Nodes O(N)
        /// <summary>
        /// This method goes through the entire list and prints out the value for each node.
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value}--> NULL");
        }
        //Find a Node O(N)
        /// <summary>
        /// This method takes in a value and returns the first node that has the same value
        /// </summary>
        /// <param name="value">How we are searching for the node</param>
        /// <returns>A node which has the same value or null</returns>
        public Node Find(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }

            return Current.Value == value ? Current : null;
        }

        // Add Before
        /// <summary>
        /// This method takes in 2 nodes and adds the first node before the 2nd node which should exist
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        /// <param name="existingNode">The existing node</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            // Reset our Current to the beginning of the Linked List
            Current = Head;
            if (Head == existingNode)
            {
                Add(newNode);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next == existingNode)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        // Add After
        /// <summary>
        /// This method takes in 2 nodes and adds the first node to after the second node which should exist.
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        /// <param name="existingNode">The existing node</param>
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current == existingNode)
                {
                    newNode.Next = existingNode.Next;
                    Current.Next = newNode;
                }
                Current = Current.Next;
            }
            if (Current == existingNode)
            {
                Current.Next = newNode;
            }
        }

        // Add Last
        /// <summary>
        /// This method takes in one node and adds it to the end of the linked list
        /// </summary>
        /// <param name="node">The node to be added</param>
        public void AddLast(Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

        //Add Kth value from the end
        /// <summary>
        /// This method finds the node which is k nodes from the end.
        /// </summary>
        /// <param name="k"></param>
        public Node KthElement(int k)
        {
            if (k < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Current = Head;
            Node Runner = Head;
            int counter = 0;
            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    Current = Current.Next;
                }
            }
            if (k > counter)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Current;
        }

        // Merge 2 Linked Lists
        /// <summary>
        /// This method takes 2 linked lists and merges them together. 
        /// The head of the merged linked list should be the first linked list put in as an argument.
        /// </summary>
        /// <param name="LL1">The first linked list</param>
        /// <param name="LL2">The second linked list</param>
        /// <returns>The head of the first linked list</returns>
        public Node Merge(LinkdList LL1, LinkdList LL2)
        {
            Node refNode1 = LL1.Head;
            Node refNode2 = LL2.Head;
            LL1.Current = LL1.Head;
            LL2.Current = LL2.Head;
            while ((LL1.Current.Next != null) && (LL2.Current.Next != null))
            {
                refNode1 = LL1.Current.Next;
                refNode2 = LL2.Current.Next;
                LL1.Current.Next = LL2.Current;
                LL2.Current.Next = refNode1;
                LL2.Current = refNode2;
                LL1.Current = refNode1;
            }
            if ((LL2.Current.Next == null) && (LL1.Current.Next != null))
            {
                LL2.Current.Next = LL1.Current.Next;
                LL1.Current.Next = LL2.Current;
            }
            else
            {
                LL1.Current.Next = LL2.Current;
            }

            return LL1.Head;
        }
    }
}
