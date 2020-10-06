// Jennifer Stegina
// GradeBook.cs

using System;

public class GradeBook
{
    /* auto-implemented property that implicitly creates an 
       instance variable for both CourseTitle and InstructorName */
    private string CourseTitle { get; set; }
    private string InstructorName { get; set; }

    // constructor with two arguments
    public GradeBook(string course, string instructor)
    {
        CourseTitle = course;
        InstructorName = instructor;
    } // end constructor for GradeBook

    public void DisplayMessage()
    {
        Console.WriteLine("Course name: " + CourseTitle);
        Console.WriteLine("This course is presented by: " + InstructorName);

    } // end display message method
} // end class GradeBook
