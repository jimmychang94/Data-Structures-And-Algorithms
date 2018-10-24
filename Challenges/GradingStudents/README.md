# Grading Students

This is a problem from HackerRank.  
What will be written here is the pseudo-code for the problem; the solution will be tested and written on HackerRank itself.

## Challenge

HackerLand University has the following grading policy:
  *  Every student receives a grade in the inclusive range from 0 to 100
  *  Any grade less than 40 is a failing grade
Sam is a professor at the university and likes to round each student's grade according to these rules:
  *  If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5
  *  If the grade is less than 38, no rounding occurs as the result will still be a failing grade

Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.

## Pseudo-code

  1. Make separate integer array to hold the resulting values of the rounding.
  2. Check each grade with a set of conditions:
    1. If grade is less than 38 then add the grade to the new integer array (no change).
    2. Else, if grade % 5 is less then 3, round grade up to the next multiple of 5 and add the rounded grade to the new integer array.
       * This can be done through using the modulus and adding it to the actual grade.
  3. Return the rounded integer array.

## Big O
  * Time: O(n)
    * This is because it needs to loop through check the grade and possibly round it
  * Space: O(n)
    * This is because I create a separate array to hold the values; it could be O(1) if I mutate the original array but I'm not sure if the original should be changed.  