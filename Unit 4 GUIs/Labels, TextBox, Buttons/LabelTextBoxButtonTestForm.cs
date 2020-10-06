// Fig. 14.20: LabelTextBoxButtonTestForm.cs
// Using a TextBox, Label and Button to display
// the hidden text in a password TextBox
// Jennifer Stegina

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextBoxButtonTest
{
    // Form that creates a password TextBox and
    // a label to display TextBox contents
    public partial class LabelTextBoxButtonTestForm : Form
    {
        // default constructor
        public LabelTextBoxButtonTestForm()
        {
            InitializeComponent();
        } // end constructor

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            // display the text the user typed
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        } // end method displayPasswordButton_Click
    } // end class LabelTextBoxButtonTestForm
} // end namespace LabelTextBoxButtonTest
