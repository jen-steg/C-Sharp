// Using one console program, write statements that perform the following one-dimensional array operations:
// Assign five values to an integer array called bestScores, 
// and display them in column format, showing the index and the value.
// Jennifer DeVore
// CIS 317
// 27 February 2020
/*
 * Test Case
 * Index    Value
 * 0        80
 * 1        85
 * 2        90
 * 3        95
 * 4        60
 */
using System;

class InitializedArray
{
   static void Main()
   {
      // initialize bestScores array with assigned values
      int[] bestScores = { 80, 85, 90, 95, 60};

      Console.WriteLine($"{"Index"}{"Value",8}"); // headings for console output

      // output each array element's value 
      for (int index = 0; index < bestScores.Length; ++index)
      {
         Console.WriteLine($"{index,5}{bestScores[index],8}");
      } // end for loop for outputting array values
   } // end Main
} // end class InitializedArray
