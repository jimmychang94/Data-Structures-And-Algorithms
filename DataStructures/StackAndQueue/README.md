# Stack And Queue

## Data Structure
A stack and a queue are data structures that utilze nodes, like a linked list without "head" or "current".  
The difference for a stack is that it has a "top" reference and you can only add/remove nodes from the "top" of the stack, instead of anywhere in linked list.  
The difference for a queue is that it has a "front" and "rear" reference and you can only add the the queue from the "rear" while you remove from the "front".

## Visual
Here is how a queue looks like:  
![How a Stack Looks Like](../../assets/stack.PNG)  
Here is how a stack looks like:  
![How a Queue Looks Like](../../assets/queue.PNG)  

## Implementation
I utilized nodes in order to implement stacks and queues.  
I implemented stacks and queues through classes and setting up methods for each.  
Others can normally implement stacks and queues by using the System.Collections.Generic library and using their Stack<> and Queue<>.  
To implement this version of stacks and queues a few steps must be followed:  
1. Download Visual Studio
2. Clone the GitHub repository "Data-Structures-And-Algorithms"
3. Inside the folder "StackAndQueue" open the sln file "StackAndQueue" in Visual Studio
4. You may now utilize the stack and queue class by using StackAndQueue.Classes as a library and then using the Stack and Queue classes created in this solution.

## Types of uses
A stack is utilized when there are dependencies between each of the items.  
For example, a program's stack is when method 1 calls method 2.
Method 1 requires the output from Method 2 to continue so a stack is used; 
Method 2 was called last but it is removed first since method 1 depends on it.  
Another example would be a stack of boxes; to get to the box at the bottom you need to first remove the boxes on top of it.  
  
A queue is utilized when the items are independent of one another.  
For example, when people line up for a restaurant;
each group is not dependent on a later group to get seated,
as long as the restaurant has seats and is ready the group can be seated.  
Another example would be a 1 lane street; the cars that enter first exit first; it isn't dependent on a car that comes after it to leave.