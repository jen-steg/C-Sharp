// Fig. 8.3: InitArray.cs
// Initializing the elements of an array with an array initializer.
// Jennifer DeVore
// CIS 317
// 24 February 2020
/*
 * Test Case
 * Index    Value
 * 0        32
 * 1        27
 * 2        64
 * 3        18
 * 4        95
 * 5        14
 * 6        90
 * 7        70
 * 8        60
 * 9        37
 */
using System;

class InitArray
{
   static void Main()
   {
      // initializer list specifies the value of each element 
      int[] array = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

      Console.WriteLine($"{"Index"}{"Value",8}"); // headings

      // output each array element's value 
      for (int counter = 0; counter < array.Length; ++counter)
      {
         Console.WriteLine($"{counter,5}{array[counter],8}");
      }
   }
}


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
