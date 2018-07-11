# Find Edges
This is a common problem of determining flight plans.  
We get a graph which contains cities where the edges between two vertices has a weight of the price for a flight between the cities.  

## Challenge
Write a function which takes in a graph and two city names.  
Without utilizing any of the built-in methods available to your language,  
return whether the trip is possible, 
and how much it would cost.

## Solution
Here is a whiteboard solution of the problem:  
![Find Edges](../../assets/get_edges.jpg)

## Explanation
I had to use multiple for loops within eachother because of when we find the needed value I had to implement it then 
rather than after the for loop.