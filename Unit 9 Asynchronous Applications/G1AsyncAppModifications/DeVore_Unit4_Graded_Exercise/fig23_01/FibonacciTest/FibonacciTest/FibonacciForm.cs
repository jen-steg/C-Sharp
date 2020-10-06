// Fig. 23.1: FibonacciForm.cs
// Performing a compute-intensive calculation from a GUI app
// Jennifer DeVore
// CIS 317
// 23 February 2020
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciTest
{
   public partial class FibonacciForm : Form
   {
      private long n1 = 0; // initialize with first Fibonacci number
      private long n2 = 1; // initialize with second Fibonacci number
      private int count = 1; // current Fibonacci number to display

      public FibonacciForm()
      {
         InitializeComponent();
      }

      // start an async Task to calculate specified Fibonacci number
      private async void calculateButton_Click(object sender, EventArgs e)
      {
            // validate entry for numerics only
            try 
            {
                // retrieve user's input as an integer
                int number = int.Parse(inputTextBox.Text);
                asyncResultLabel.Text = "Calculating...";
                long result1 = Fibonacci(number);

                // Task to perform Fibonacci calculation in separate thread
                Task<AsyncTimeData> fibonacciTask = Task.Run(() => StartFibonacci(number));

                // wait for Task in separate thread to complete
                await fibonacciTask;

                // display result after Task in separate thread completes
                asyncResultLabel.Text = ($"{result1} \r\n");

                // determine time that thread started
                DateTime startTime = fibonacciTask.Result.StartTime;

                // determine time that thread ended
                DateTime endTime = fibonacciTask.Result.EndTime;

                // display total time for calculations
                double totalMinutes = (endTime - startTime).TotalMinutes;
                timeAsyncTextBox.AppendText(
                   $"{totalMinutes:F6} minutes\r\n");

            } // end try
            catch(Exception)
            {
                MessageBox.Show("Enter a number only.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end catch
              

        } // end method calculateButton_Click

        // starts a call to fibonacci and captures start/end times
        AsyncTimeData StartFibonacci(int number)
        {
            // create a TimeData object to store start/end times
            var result = new AsyncTimeData();

            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(number);
            result.EndTime = DateTime.Now;

            return result;
        }
        // calculate next Fibonacci number iteratively
        private void nextNumberButton_Click(object sender, EventArgs e)
      {
         // calculate the next Fibonacci number
         long temp = n1 + n2; // calculate next Fibonacci number
         n1 = n2; // store prior Fibonacci number in n1
         n2 = temp; // store new Fibonacci
         ++count;

         // display the next Fibonacci number
         displayLabel.Text = $"Fibonacci of {count}:";
         syncResultLabel.Text = n2.ToString();
      }

      // recursive method Fibonacci; calculates nth Fibonacci number
      public long Fibonacci(long n)
      {
         if (n == 0 || n == 1)
         {
            return n;
         }
         else
         {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
         }
      }
        // append text to timeAsyncTextBox in UI thread
        public void AppendText(String text)
        {
            if (InvokeRequired) // not GUI thread, so add to GUI thread
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else // GUI thread so append text
            {
                timeAsyncTextBox.AppendText(text + "\r\n");
            }
        }
    }
}


/*************************************************************************
* (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
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
*************************************************************************/
