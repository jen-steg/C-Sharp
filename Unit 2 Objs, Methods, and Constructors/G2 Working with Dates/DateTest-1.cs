// Application to test class Date.\
// Jennifer Stegina
/* answer should read 
 *                  The initial date is: 7/4/2004
 *                  Date with new values is: 11/1/2003
 */

using System;

public class DateTest
{

    public static void Main(string[] args)
    {

        Date date1 = new Date(7, 4, 2004);

        Console.Write("The initial date is: ");
        date1.DisplayDate();

        // change date values
        date1.Month = 11;
        date1.Day = 1;
        date1.Year = 2003;

        Console.Write("\nDate with new values is: ");
        date1.DisplayDate();

        Console.WriteLine(); // output a new line
    } // end Main
} // end class DateTest