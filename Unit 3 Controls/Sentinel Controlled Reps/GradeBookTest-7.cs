// Fig. 5.10: GradeBookTest.cs
// Create GradeBook object and invoke its DetermineClassAverage method.
// Jennifer Stegina

using System;

public class GradeBookTest
{
    public static void Main(string[] args)
    {
        // create GradeBook object myGradeBook and
        // pass course name to constructor
        GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming");

        myGradeBook.DisplayMessage(); // display welcome message
        myGradeBook.DetermineClassAverage(); // find average of 10 grades

    } // end Main
} // end class GradeBookTest