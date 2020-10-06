// Fig. 5.12: Analysis.cs
// Analysis of examination results, using nested control statements.
// Jennifer Stegina
/*
 * Test Case
 * Entered: 1, 1, 1, 1, 2, 1, 1, 1, 1, 1
 * Passed: 9
 * Failed: 1
 * Bonus to instructor!
 */
using System;

public class Analysis
{
    public static void Main(string[] args)
    {
        // initialize variables in declarations
        int passes = 0; // number of passes
        int failures = 0; // number of failures
        int studentCounter = 1; // student counter
        int result; // one exam result from user

        // process 10 students using counter-controlled repetition
        while (studentCounter <= 10)
        {
            // prompt user for input and obtain a value from the user
            Console.Write("Enter result (1 = pass, 2 = fail): ");
            result = Convert.ToInt32(Console.ReadLine());

            // if...else nested in while
            if (result == 1) // if result 1,
            {
                passes += 1; // increment passes
            } // end if
            else // else result is not 1, so
            {
                failures += 1; // increment failures
            } // end else

            //  increment studentCounter so loop eventually terminates
            studentCounter += 1;
        } // end while

        // termination phase; prepare and display results
        Console.WriteLine("Passed: {0}\nFailed: {1}", passes, failures);

        // determine whether more than 8 students passed
        if (passes > 8)
        {
            Console.WriteLine("Bonus to instructor!");
        } // end if
    } // end Main
} // end class Analysis
