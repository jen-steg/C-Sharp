// Fig. 5.9: GradeBook.cs
// GradeBook class that solves class-average problem using
// sentinel-controlled repetition.
// Jennifer Stegina
/*
 *  Test Case: 
 *  Grades Entered: 93 + 95 + 96 + 97 + 90 + 100 + 100 + 98 + 94 + 94 = 957
 *  total Grade sum = 957 / 10 (grades entered) = 95.7
 */
 using System;

 public class GradeBook
 {
    // auto-implemented property CourseName
    private string CourseName { get; set; } 

    // constructor initializes CourseName property
    public GradeBook(string name)
    {
        CourseName = name; // sets CourseName to name
    } // end constructor

    // display a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        // property CourseName gets the name of the course
        Console.WriteLine( "Welcome to the grade book for\n{0}!\n",
             CourseName );
    } // end method DisplayMessage

    // determine class average based on 10 grades entered by user
    public void DetermineClassAverage()
    {
        double total; // sum of the grades entered by user
        int gradeCounter; // accumulator for grades entered count
        double grade; // grade value entered by the user
        double average; // decimal point for average of the grades

        // initialization phase 
        total = 0; // initialize the total 
        gradeCounter = 1; // initialize the loop counter 
     
        // processing phase 
         while ( gradeCounter <= 10 ) // loop 10 times 
        { 
            Console.Write( "Enter grade: " ); // prompt the user 
            grade = Convert.ToInt32( Console.ReadLine() ); // read grade 
            total += grade; // add the grade to total 
            gradeCounter += 1; // increment the counter by 1 
        } // end while 
     
        // termination phase 
        average = total / 10; // integer division yields integer result 
     
        // display total and average of grades 
        Console.WriteLine( "\nTotal of all 10 grades is {0}", total ); 
        Console.WriteLine( "Class average is {0}", average ); 
     } // end method DetermineClassAverage 
} // end class GradeBook