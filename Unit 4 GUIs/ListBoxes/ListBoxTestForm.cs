// Fig. 15.8: ListBoxTestForm.cs
// Program to add, remove, and clear ListBox items
// Jennifer Stegina
/* Test Case
 * Lucky (add)
 * Blackie (add)
 * exit
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

namespace ListBoxTest
{
    // Form uses a TextBox and Buttons to add,
    // remove, and clear ListBoxItems
    public partial class ListBoxTestForm : Form
    {
        // default constructor
        public ListBoxTestForm()
        {
            InitializeComponent();
        } // end constructor

        // add new item to ListBox (text from input TextBox)
        // and clear input TextBox
        private void addButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
        } // end method addButton_Click

        // remove item if one is selected
        private void removeButton_Click(object sender, EventArgs e)
        {
            // check whether item is selected; if so, remove
            if (displayListBox.SelectedIndex != -1)
            {
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            } // end if
        } // end method removeButton_Click

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        } // end method clearButton_Click

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method exitButton_Click
    } // end class ListBoxTestForm
} // end namespace ListBoxTest
