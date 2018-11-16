# Rotate a 2D Array
This is a common interview question.  

## Challenge
Rotate a square 2D matrix by 90 degrees to the right.  

## Example

Input:  
```
{ 1, 2, 3 },  
{ 4, 5, 6 },  
{ 7, 8, 9 }
```

Output:
```
{ 7, 4, 1 },
{ 8, 5, 2 },
{ 9, 6, 3 }
```

## Explanation
This is a brute force method utilizing a queue and nested for loops.  
   
The Big O for this solution is:  
	- Time: O(n^2)  
	- Space: O(n)

There is most likely a solution which has a better time and space complexity but I haven't determined what that is at the moment.  