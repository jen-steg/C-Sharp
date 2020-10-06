// Fig 14.26: CheckBoxTestForm.cs
// Using CheckBoxes to toggle italic and bold styles.
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

namespace CheckBoxTest
{
    // Form contains CheckBoxes to allow the user to modify sample text
    public partial class CheckBoxTestForm : Form
    {
        // default constructor
        public CheckBoxTestForm()
        {
            InitializeComponent();
        } // end constructor

        // toggle the font style between bold and not bold based on the current setting
        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font, 
                outputLabel.Font.Style ^ FontStyle.Bold);
        } // end method boldCheckBox_CheckedChanged

        // toggle the font style between italic and not italic based on the current setting
        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font,
               outputLabel.Font.Style ^ FontStyle.Italic);
        } // end method italicCheckBox_CheckedChanged
    } // end Class CheckBoxTestForm
} // end namespace CheckBoxTest
