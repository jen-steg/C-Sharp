// Fig. 5.15: Increment.cs
// Prefix increment and postfix increment operators.
// Jennifer Stegina
// Test Case (assigned values in code)
/* 5
 * 5
 * 6
 * 
 * 5
 * 6
 * 6
 */ 
using System;

public class Increment
{
    public static void Main(string[] args)
    {
        int c;

        // demonstrate postfix increment operator
        c = 5; // assign 5 to c
        Console.WriteLine(c); // display 5
        Console.WriteLine(c++); // increment c and display 5
        Console.WriteLine(c); // display 6

        Console.WriteLine(); // skip a line

        // demonstrate prefix increment operator
        c = 5; // assign 5 to c
        Console.WriteLine(c); // display 5
        Console.WriteLine(++c); // increment c and display 6
        Console.WriteLine(c); // display 6 again

    } // end Main
} // end class Increment
