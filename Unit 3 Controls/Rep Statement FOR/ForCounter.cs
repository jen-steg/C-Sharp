// Fig. 6.2: ForCounter.cs
// Counter-controlled repetition with the for repetition statement.
// Jennifer Stegina
/* Test Case
 * 1 2 3 4 5 6 7 8 9 10
 */
using System;

public class ForCounter
{
    static void Main(string[] args)
    {
        // for statement header includes initialization,
        // loop-continuation condition and increment
        for (int counter = 1; counter <= 10; ++counter)
        {
            Console.Write("{0} ", counter);
        } // end for
        Console.WriteLine(); // output a newline
    } // end Main
} // end clas ForCounter
