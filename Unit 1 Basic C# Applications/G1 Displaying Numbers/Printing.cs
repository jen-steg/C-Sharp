// Displays the numbers 1 through 4 in several ways using System.
// Jennifer Stegina

using System;

public class Printing
{
    // Main method begins execution of C# app
    static void Main(string[] args)
    {
        Console.Write("Part (a): ");

        // one Console.WriteLine statement
        Console.WriteLine("1 2 3 4");

        Console.Write("Part (b): ");

        Console.Write("1 ");
        Console.Write("2 ");
        Console.Write("3 ");
        Console.Write("4");

        Console.Write("\nPart (c): ");
        // one Console.WriteLine statement with four format items

        // declare and initialize variables
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        int number4 = 4;

        Console.WriteLine("{0} {1} {2} {3}", number1, number2, number3, number4);
    } // end Main
} // end class Printing
