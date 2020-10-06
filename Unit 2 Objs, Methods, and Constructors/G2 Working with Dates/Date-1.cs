// Date.cs
// Jennifer Stegina
using System;

public class Date
{
    /* auto-implemented property that implicitly creates an 
       instance variable for Month, Day, and Year */
    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }

    // constructor with three arguments
    public Date(int month, int day, int year)
    {
        Month = month;
        Day = day;
        Year = year;
    } // end date constructor

    public void DisplayDate()
    {
        Console.Write(Month + "/" + Day + "/" + Year);
    } // end display date method
} // end class Date