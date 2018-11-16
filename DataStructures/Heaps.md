# Heaps

To obtain the minimum (min-heap) or maximum (max-heap) valut in a collection in )(log(n)) time.

## Definition:
  A complete binary tree which satisfies a "heap ordering" property.
  Max-Heap property
    The value of each node is less than or equal to the value of its parent
    The maximum value is located at the root
  Min-Heap property
    The value of each node is greater than or equal to the value of its parent
    The minimum value is located at the root

  Complete Binary Tree
    - All levels are filled (but the last one)
    - The last level is filled from left to right
    - Any empty spaces are going to be on the right side

## Basic Operations
  Whatever you do; you always keep checking that you are fulfilling the heap ordering property
  
  Insert:
    Time Complexity:
      log(n) or H

  Remove:
    Take root since that is the largest value
    Take the node at the last level at the right-most position and put it at the root
    Compare this with the children and then replace the root with the largest value
    Repeat the above step until nothing changes anymore

    Time Complexxity:
      H or log(n)


## Complete Binary Trees as Arrays
  But Why??
    To save on Memory

  The below only works in a complete binary tree:
  Parent:
    (i - 1) / 2
  Children:
    Left = (2 * i) + 1
    Right = (2 * i) + 2

Implementation Details
  - TypeScript = JavaScript + C#
  - Compare Functions
    + f(a, b)
        It returns: 
          -1 if a < b
          0 if a == b
          1 if a > b
  - Heap Calculations Class
    + To be able to get the parents and children


MaxHeap<T>
  Heap itself
  - _compare : Function
  - _storage : Array<T>

  + ExtractMaximum(): T
      bubble down
  + Insert(value: T) : void
      bubble up

  - _swapValues(int indexA, int indexB)
  - _bubbleUp(int index)
      Get the parent element
      If parent element is not larger than the current value
      Swap parent and current
      Keep bubbling

  - _bubbleDown(int index)
      Get the left index and right index
      Update the max value based off of the left and right child
        Only update if  the there is a value at the left/right child.
      Check to see if the index is still the max
      If No
        Swap
        Bubble down
      If Yes
        Done

  - Insert
      Push
      Bubble Up

  - Extract Maximum
      Take first element
      Set Last element to be first element
      Bubble Down

## Next Steps

  - HeapSort (Insertion Sort + Heaps)
  - Priority Queues
  - Dijkstra's algorithm (BFS + Priority Queues)