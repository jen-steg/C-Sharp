// Fig. 6.6: Interest.cs
// Compound-interest calculations with for.
// Jennifer Stegina
/* 
 * Test Case:
 * Year Amount on deposit
 * 1    $1,050.00
 * 2    $1,102.50
 * 3    $1,157.63
 * 4    $1,215.51
 * 5    $1,276.28
 * 6    $1,340.10
 * 7    $1,407.10
 * 8    $1,477.46
 * 9    $1,551.33
 * 10   $1,628.89
 */
using System;

public class Interest
{
    static void Main(string[] args)
    {
        decimal amount; // amount on deposit at end of each year
        decimal principal = 1000; // initial amount before interest
        double rate = 0.05; // interest rate

        // display headers
        Console.WriteLine("Year{0,20}", "Amount on deposit");

        // calculate amount on deposit for each of ten years
        for (int year = 1; year <= 10; ++year)
        {
            // calculate new amount for specified year
            amount = principal *
            ((decimal)Math.Pow(1.0 + rate, year));

            // display the year and the amount
            Console.WriteLine("{0,4}{1,20:C}", year, amount);
        } // end for
    } // end Main
} // end class Interest
