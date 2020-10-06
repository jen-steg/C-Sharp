// Exercise 4.10 GradeBookTest.cs
// GradeBook constructor used to specify the course name 
// and instructor name at the time each GradeBook object is created.
// Jennifer Stegina
using System;

public class GradeBookTest
{
    // Main method begins program execution
    public static void Main(string[] args)
    {
        // create GradeBook object
        GradeBook gradeBook1 = new GradeBook(
           "CS101 Introduction to C# Programming", "Sam Smith");

        gradeBook1.DisplayMessage(); // display welcome message

        Console.WriteLine("\nChanging instructor name to Judy Jones\n");
        gradeBook1.InstructorName = "Judy Jones";

        gradeBook1.DisplayMessage(); // display welcome message
    } // end Main
} // end class GradeBookTest