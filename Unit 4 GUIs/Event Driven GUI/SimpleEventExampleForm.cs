// Fig. 14.5: SimpleEventExampleForm.cs
// Simple event handling example
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

namespace SimpleEventExample
{
    // Form that shows a simple event handler
    public partial class SimpleEventExampleForm : Form
    {
        // default constructor
        public SimpleEventExampleForm()
        {
            InitializeComponent();
        } // end constructor

        // handles click even of Button btnClick
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I was clicked.", "CLICK!", MessageBoxButtons.OKCancel);
        } // end method btnClick_Click
    } // end class SimpleEventExample
} // end namespace SimpleEventExample
