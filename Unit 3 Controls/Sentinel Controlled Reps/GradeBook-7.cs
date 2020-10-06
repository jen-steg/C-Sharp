// Fig. 5.9: GradeBook.cs
// GradeBook class that solves class-average problem using
// sentinel-controlled repetition.
// Jennifer Stegina
/*
 *  Test Case: 
 *  Grades Entered: 95 + 42 + 60 + 89 + -1 (exit)
 *  total Grade sum = 957 / 4 (grades entered) = 71.50
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
        gradeCounter = 0; // initialize the loop counter 

        // processing phase 
        // prompt for and read a grade entered by the user
        Console.Write("Enter a grade [or -1 to quit]: ");
        grade = Convert.ToInt32(Console.ReadLine());

        // loop until user enters the sentinel value
        while ( grade != -1 )
        { 
            total += grade; // add the grade to total 
            gradeCounter += 1; // increment the counter by 1 

            // prompt for and read a grade entered by the user
            Console.Write("Enter a grade [or -1 to quit]: ");
            grade = Convert.ToInt32(Console.ReadLine());
        } // end while 
     
        // termination phase 
        // if the user entered at least 1 grade
        if (gradeCounter != 0)
        {
            // calculate the average of all grades entered
            average = total / (double) gradeCounter; // case gradeCounter as a double
                                                     // display total and average of grades 
            Console.WriteLine("\nTotal of all {0} grades is {1}", gradeCounter, total);
            Console.WriteLine("Class average is {0:F}", average);
        } // end if
        else // no grades were entered
        {
            Console.WriteLine("No grades were entered.");
        } // end else
     } // end method DetermineClassAverage 
} // end class GradeBook