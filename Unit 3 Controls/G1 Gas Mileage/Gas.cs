// Gas.cs
// Application calculates average mpg
// Jennifer Stegina
/*
 * Test case
 * Miles: 300
 * Gallons of gas: 14
 * MPG for this tank of gas: 21.43
 * total trip MPG: 21.43
 * 
 * Miles: 288
 * Gallons of gas: 12
 * MPG for this tank of gas: 24.00
 * total trip MPG: 22.62
 * 
 * Miles: 312
 * Gallons of gas: 10
 * MPG for this tank of gas: 31.20
 * total trip MPG: 25.00
 * [exited with -1]
 */
using System;

public class Gas
{
    // perform miles per gallon calculations
    public static void Main(string[] args)
    {
        int miles; // miles for one tankful
        int gallons; // gallons for one tankful
        int totalMiles = 0; // total miles for trip
        int totalGallons = 0; // total gallons for trip

        double milesPerGallon; // miles per gallon for tankful
        double totalMilesPerGallon; // miles per gallon for trip

        // prompt user and read in miles from user entry
        Console.Write("Enter miles [ or -1 to quit]: ");        miles = Convert.ToInt32(Console.ReadLine());

        // program exit if user enters -1
        while (miles != -1)
        {
            // prompt user and read in gallons of gas
            Console.Write("Enter gallons of gas: ");
            gallons = Convert.ToInt32(Console.ReadLine());

            // add current miles & gallons to total accumulators
            totalMiles += miles;
            totalGallons += gallons;

            // calculate mpg for current tank of gas
            if (gallons != 0)
            {
                // cast as a double to not lose value
                milesPerGallon = (double)miles / gallons;
                Console.WriteLine("MPG for this tank of gas: {0:F}", milesPerGallon);
            } // end if

            // calculate total mpg for the entire trip
            if (totalGallons != 0)
            {
                // cast as a double to not lose value
                totalMilesPerGallon = (double)totalMiles / totalGallons;
                Console.WriteLine("Total trip MPG: {0:F}\n", totalMilesPerGallon);
            } //end if
            
            // prompt user and read in miles from user entry
            Console.Write("Enter miles [ or -1 to quit]: ");
            miles = Convert.ToInt32(Console.ReadLine());
        } // end while
    } // end Main
} // end class Gas
