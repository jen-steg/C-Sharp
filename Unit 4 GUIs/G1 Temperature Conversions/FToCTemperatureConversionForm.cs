// FToCTemperatureConversionForm.cs
// Take a user inputted value of F temperature and convert to C
// Jennifer Stegina
/*  
 *  Test Case
 *  50
 *  ((50 - 32) * 5) / 9
 *  ((18) * 5) / 9
 *  (90) / 9
 *  Answer is 10
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FToCTemperatureConversionTest
{
    // this form will take user input of a farenheit temperature
    // and convert it to celsius
    public partial class FToCTemperatureConversionForm : Form
    {
        // default constructor
        public FToCTemperatureConversionForm()
        {
            InitializeComponent();
        } // end constructor

        // this button will take the user input temperature value and 
        // convert it to celsius to be displayed in the label
        private void convertButton_Click(object sender, EventArgs e)
        {
            double fahrenheitTemperature = double.Parse(temperatureInput.Text);
            
            // create and fill variable for celsius temperature
            double celsiusTemperature = ((fahrenheitTemperature - 32) * 5) / 9;

            // send termperature to the output label for temp in F in Bold text
            fahrenheitOutput.Text = fahrenheitTemperature + " degrees Fahrenheit is";
            fahrenheitOutput.Font = new Font(fahrenheitOutput.Font, 
                fahrenheitOutput.Font.Style ^ FontStyle.Bold);

            // send temperature to the output label for temp in C in Bold text
            celsiusOutput.Text = celsiusTemperature + " degrees Celsius";
            celsiusOutput.Font = new Font(celsiusOutput.Font, 
                celsiusOutput.Font.Style ^ FontStyle.Bold);
        } // end method convertButton_Click
    }
}
