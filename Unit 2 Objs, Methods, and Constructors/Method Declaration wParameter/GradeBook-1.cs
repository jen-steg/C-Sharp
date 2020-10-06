// Fig. 4.4: GradeBook.cs
// Class declaration with a method that has a parameter.
// Jennifer Stegina
using System;

public class GradeBook
{
     // display a welcome message to the GradeBook user
    public void DisplayMessage(string courseName)
    {        
        Console.WriteLine( "Welcome to the grade book for\n{0}!",
          courseName );
    }  // end method DisplayMessage
}  // end class GradeBook