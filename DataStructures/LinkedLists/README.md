# Linked Lists
Create your own technical documentation for your new implementation. 
1. Explain to your audience what the data structure is (in your own words) 
1. Visuals of what it looks like 
1. How you implemented it 
1. What type of uses you would use this for (provide 2 examples)

## The Data Structure

The data structure for a linked list is a heap since there are multiple nodes located randomly throughout memory.  
The nodes are connected in a linked list by having one be considered the "Head" and then every node points to another unique node.  

## Visuals

This visual shows that a linked list does not need to be orderly and all it needs is a starting point and the next node.
![A Visual of a Linked List] (../../assets/LinkedListVisual.png)  

## Implementation

I implemented this by creating a node and then adding another node which references it in its Next property.  
I kept adding to this chain and I get a linked list (It is already considered a linked list after 1 node).  

## Uses for Linked Lists

Internet History, though it uses a doubly linked list (which also has a Previous property) it is a great example of a linked list.  
Every time you change websites, it records the previous site that you visited in your history.

Trains, though the front and end are different, adding a new part to a train is like adding a new link.
Each part is connected to the next though the linked lists in programming is a lot more of a loose structure.
