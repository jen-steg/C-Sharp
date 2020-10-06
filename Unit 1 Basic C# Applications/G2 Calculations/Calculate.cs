using System;

public class Calculation
{
    // Main method begins execution of C# app
    static void Main(string[] args)
    {
        int number1;
        int number2; 
        int sum; // answer for addition
        int product; // answer for multiplication
        int difference; // answer for subtraction
        int quotient; // answer for division 

        Console.Write("Enter first integer: "); //prompt user
        number1 = Convert.ToInt32(Console.ReadLine()); // read user entry

        Console.Write("Enter second integer: "); //prompt user
        number2 = Convert.ToInt32(Console.ReadLine()); // read user entry

        sum = number1 + number2; // addition
        product = number1 * number2; // multiplication
        if(number1 > number2)
        {
            difference = number1 - number2; // subtraction
            quotient = number1 / number2; // division
        } // end if
        else if (number2 > number1)
        {
            difference = number2 - number1; // subtraction
            quotient = number2 / number1; // division
        } // end elif
        else
        {
            difference = number1 - number2; //subtraction
            quotient = number1 / number2; // division
        } // end else

        Console.WriteLine("Sum is {0}", sum); // display addition results
        Console.WriteLine("Product is {0}", product); // display multiplication results
        Console.WriteLine("Difference is {0}", difference); // display subtraction results
        Console.WriteLine("Quotient is {0}", quotient); // display division results
    } // end Main
} // end class Calculation
