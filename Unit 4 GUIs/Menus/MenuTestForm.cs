// Fig. 15.7: MenuTestForm.cs
// Using Menus to change font colors and styles.
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

namespace MenuTest
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
        }

        // display MessageBox when About ToolStripMenu is selected
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example\nof using menus.", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // end method aboutToolStripMenuItem_Click

        // exit program when Exit ToolStripMenuItem is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method exitToolStripMenuItem_Click

        // reset checkmarks for Color ToolStripMenuItem
        private void ClearColor()
        {
            // clear all checkmarks
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        } // end method ClearColor

        // update Menu state and color display text black
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for Color ToolStripMenuItems
            ClearColor();

            // set text color to black
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        } // end method blackToolStripMenuItem_Click

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for Color ToolStripMenuItems
            ClearColor();

            // set text color to blue
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        } // end method blueToolStripMenuItem_Click

        // update Menu state and color displat text red
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for Color ToolStripMenuItems
            ClearColor();

            // set text color to red
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        } // end method redToolStripMenuItem_Click

        // update Menu state and color display text green
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for Color ToolStripMenuItems
            ClearColor();

            // set text color to green
            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        } // end method greenToolStripMenuItem_Click

        // reset checkmarks for Font ToolStripMenuItems
        private void ClearFont()
        {
            // clear all checkmarks
            timesToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
        } // end method ClearFont

        // update Menu state and set Font to Times New Roman
        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for the Font ToolStripMenuItems
            ClearFont();

            // set Times New Roman font
            timesToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, 
                displayLabel.Font.Style);
        } // end method timesToolStripMenuItem_Click

        // update Menu state and set Font to Courier
        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for the Font ToolStripMenuItems
            ClearFont();

            // set Courier font
            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, 
                displayLabel.Font.Style);
        } // end menthod courierToolStripMenuItem_Click

        // update Menu state and set Font to Comic Sans MS
        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for the Font ToolStripMenuItems
            ClearFont();

            // set Comic Sans MS font
            comicToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14, 
                displayLabel.Font.Style);
        } // end method comicToolStripMenuItem_Click

        // toggle checkmark and toggle bold style
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkmark
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;

            // use Xor to toggle bold, keep all other styles
            displayLabel.Font = new Font(displayLabel.Font, 
                displayLabel.Font.Style ^ FontStyle.Bold);
        } // end method boldToolStripMenuItem_Click

        // toggle checkmark and toggle italic style
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkmark
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;

            // use Xor to toggle bold, keep all other styles
            displayLabel.Font = new Font(displayLabel.Font,
                displayLabel.Font.Style ^ FontStyle.Italic);
        } // end method italicToolStripMenuItem_Click
    } // end class MenuTestForm
} // end namespace MenuTest
