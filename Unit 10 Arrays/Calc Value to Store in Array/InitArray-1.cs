// Fig. 8.4: InitArray.cs
// Calculating values to be placed into the elements of an array.
// Jennifer DeVore
// CIS 317
// 24 February 2020
/*
 * Test Case
 * Index    Value
 * 0        2
 * 1        4
 * 2        6
 * 3        8
 * 4        10
 * 5        12
 * 6        14
 * 7        16
 * 8        18
 * 9        20
 */
using System;

class InitArray
{
   static void Main()
   {
      const int ArrayLength = 10; // create a named constant
      int[] array = new int[ArrayLength]; // create array 

      // calculate value for each array element
      for (int counter = 0; counter < array.Length; ++counter)
      {
         array[counter] = 2 + 2 * counter;
      } //end for

      Console.WriteLine($"{"Index"}{"Value",8}"); // headings

      // output each array element's value 
      for (int counter = 0; counter < array.Length; ++counter)
      {
         Console.WriteLine($"{counter,5}{array[counter],8}");
      } // end for
   } // end MAin
} // end class InitArray 



/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
