// Fig. 4.5: GradeBookTest.cs
  // Create a GradeBook object and pass a string to
 // its DisplayMessage method.
 // Jennifer Stegina
using System;

public class GradeBookTest
{
    // Main method begins program execution
    public static void Main(string[] args)
    {
       // create a GradeBook object and assign it to myGradeBook
       GradeBook myGradeBook = new GradeBook();

        // prompt for and input course name
       Console.WriteLine( "Please enter the course name:" );
        string nameOfCourse = Console.ReadLine();  // read a line of text
       Console.WriteLine();  // output a blank line

       // call myGradeBook's DisplayMessage method
        // and pass nameOfCourse as an argument
        myGradeBook.DisplayMessage( nameOfCourse );
    }  // end Main
}  // end class GradeBookTest