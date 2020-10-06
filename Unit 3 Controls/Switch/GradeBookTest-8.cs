// Fig. 6.10: GradeBookTest.cs
// Create GradeBook object, input grades and display grade report.
// Jennifer Stegina

using System;

public class GradeBookTest
{
    public static void Main(string[] args)
    {
        // create GradeBook object myGradeBook and
        // pass course name to constructor
        GradeBook myGradeBook = new GradeBook(
            "CS101 Introduction to C# Programming");

        myGradeBook.DisplayMessage(); // display welcome message
        myGradeBook.InputGrades(); // read grades from user
        myGradeBook.DisplayGradeReport(); // display report based on grades
    } // end Main
} // end class GradeBookTest
