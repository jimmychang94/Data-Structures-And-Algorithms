# Find the Maximum Value in a Binary Tree
With a given binary tree, this method finds the value of the node with the largest number.  
This method traverses the tree recursively while keeping track of the current maximum value.  
Once has traversed the entire tree, it will output the maximum value that it has.  

## Challenge
Write a function called find-maximum-value which takes binary tree as its only imput.  
Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree.  
You can assume that the values stored in the Binary Tree will be numeric.  

## Solution
![Finding the Maximum Value in a Binary Tree](../../assets/find-maximum-value-binary-tree.jpg)  

## Explanation
I made the method have an overload because later when I need the maximum value I can recursively call my method.  
I could have made the overload a different method but since it was basically the same code wise, 
I kept the name the same and made it an overload.  