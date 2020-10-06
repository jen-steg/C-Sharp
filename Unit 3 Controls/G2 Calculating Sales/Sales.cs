// Sales.cs
// Application calculates sales, based on an input of product
// number and quantity sold
// Jennifer Stegina
/* Test case
 * product number: 2
 * sold: 252
 * product number: 3
 * sold 501
 * product number: 1
 * sold: 55
 * product number: 2
 * sold: 305
 * product number: 3
 * sold: 708
 * product number: 2
 * sold: 12
 * [0 to exit]
 * 
 * product 1: $ 163.90
 * product 2: $ 2,560.50
 * product 3: $ 12,065.82
 */
using System;

public class Sales
{
    // calculates sales for 3 products
    static void Main(string[] args)
    {
        decimal product1 = 0M; // amount sold of first product
        decimal product2 = 0M; // amount sold of second product
        decimal product3 = 0M; // amount sold of third product

        int productId = 1; // current product id number

        // ask user for product number until exit value entered
        while (productId != 0)
        {
            // determine the product chosen or 0 to exit
            Console.Write("Enter product number (1-3) [or 0 to stop]: ");
            productId = Convert.ToInt32(Console.ReadLine());

            if (productId >= 1 && productId <= 3) // validate productId
            {
                // determine the number sold of the item
                Console.Write("Enter quantity sold: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                // increment the total for the item by the
                // price times the quantity sold using a switch multiple selection statement.
                switch (productId)
                {
                    case 1: // product 1
                        product1 += quantity * 2.98M; // quantity * price of 2.98 per each
                        break;                    case 2: // product 2
                        product2 += quantity * 4.50M; // quantity * price of 4.50 per each
                        break;
                    case 3: // product 3
                        product3 += quantity * 9.98M; // quantity * price of 9.98 per each
                        break;
                } // end switch
            } // end if
            // if user enters a value that does not match a product number or exit value
            else if (productId != 0)
            {
                Console.WriteLine("Product number must be between 1 and 3 or 0 to stop");
            } // end else if
        } // end while

        // print summary report
        Console.WriteLine("\nProduct 1: {0:C}", product1);
        Console.WriteLine("Product 2: {0:C}", product2);
        Console.WriteLine("Product 3: {0:C}", product3);
    }// end Main
} // end class Sales
