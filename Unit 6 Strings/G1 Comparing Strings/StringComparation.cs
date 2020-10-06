/* Jennifer DeVore 
 27 January 2020
 CIS 317   Unit 1 Graded Exercise: Compare Strings

 Write a C# app that uses string method CompareTo to compare two strings 
 input by the user. Output whether the first string is less than, equal 
 to or greater than the second.

 TEST CASES:
 User Entry          Compare To     String Compare       Results
 exactlyTHEsame         0                   0               Equal
 exactlyTHEsame         0                   0               Equal

 String1ISlonger        1                   1               1 > 2
 2isShorter             1                   1               1 > 2
*/
using System;

class StringCompareTo
{
    static void Main()
    {
        // declare variables
        String userInput1 = null;
        String userInput2 = null;
        int userResults = 0;

        // Output instructions to console 
        Console.WriteLine("Enter the first string: ");
        // read in user input and overwrite null value
        userInput1 = Console.ReadLine();

        // Output instructions to console 
        Console.WriteLine("Enter the second string: ");
        // read in user input and overwrite null value
        userInput2 = Console.ReadLine();

        // Explanation for how compare to and the userResult results work
        Console.WriteLine($"\n1 means that string one is greater than string two.");
        Console.WriteLine("0 means that string one and two are equal.");
        Console.WriteLine("-1 means that string one is less than string two.");

        // test via Compare to and print result to screen
        Console.WriteLine($"{userInput1.CompareTo(userInput2)}");
         
        // test via string compare method and print to screen
        userResults = string.Compare(userInput1, userInput2);
        Console.WriteLine(userResults.ToString());

        // test for equality
        if (userResults == 1) 
        {
            Console.WriteLine($"\nString 1 is greater than String 2.");
        }
        else if (userResults == 0)
        {
            Console.WriteLine($"\nString 1 and String 2 are equal.");
        }
        else
        {
            Console.WriteLine($"\nString 1 is less than String 2.");
        }

    } // end Main
} // end class StringCompareTo
