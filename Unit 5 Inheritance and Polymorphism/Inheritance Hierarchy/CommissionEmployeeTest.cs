// Fig. 11.5: CommissionEmployeeTest.cs
// Testing class CommissionEmployee.
// Jennifer Stegina
/* Case Test
 * Employee information obtained by properties and methods:
 * 
 * First name is Sue
 * Last name is Jones
 * Social number is 222-22-2222
 * Gross sales are $10,000.00
 * Commission rate is 0.06
 * Earnings are $600.00
 * 
 * Updated employee information obtained by ToString:
 * 
 * Commission employee: Sue Jones
 * Social security number: 222-22-2222
 * Gross sales: $5,000.00
 * Commission rate: 0.10
 * Earnings: $500.00
 */
using System;

public class CommissionEmployeeTest
{
   public static void Main( string[] args )
   {
      // instantiate CommissionEmployee object
      CommissionEmployee employee = new CommissionEmployee( "Sue",
         "Jones", "222-22-2222", 10000.00M, .06M );

      // display commission employee data
      Console.WriteLine(
         "Employee information obtained by properties and methods: \n" );
      Console.WriteLine( "First name is {0}", employee.FirstName );
      Console.WriteLine( "Last name is {0}", employee.LastName );
      Console.WriteLine( "Social security number is {0}",
         employee.SocialSecurityNumber );
      Console.WriteLine( "Gross sales are {0:C}", employee.GrossSales );
      Console.WriteLine( "Commission rate is {0:F2}",
         employee.CommissionRate );
      Console.WriteLine( "Earnings are {0:C}", employee.Earnings() );

      employee.GrossSales = 5000.00M; // set gross sales   
      employee.CommissionRate = .1M; // set commission rate

      Console.WriteLine( "\n{0}:\n\n{1}",
         "Updated employee information obtained by ToString", employee );
      Console.WriteLine( "Earnings: {0:C}", employee.Earnings() );
   } // end Main
} // end class CommissionEmployeeTest

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/