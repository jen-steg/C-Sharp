// Jennifer Stegina

using System;

public class Larger
{
    // Main method begins execution of C# app
    static void Main(string[] args)
    {
        int number1; // declare first number to compare
        int number2; // delcare second number to compare

        // prompt user and read first number
        Console.Write("Enter first integer: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // prompt user and read second number
        Console.Write("Enter second integer: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2) // if both are the same
        {
            Console.WriteLine("They are equal.");
        } // end if
        else if( number1 > number2) // number1 is larger
        {
            Console.WriteLine("{0} is larger.", number1);
        } // end elif
        else // number 2 is larger
        {
            Console.WriteLine("{0} is larger.", number2);
        } // end else
    } // end Main
} // end class Comparison