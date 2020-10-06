using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTest
{
    public partial class FileTestForm : Form
    {
        public FileTestForm()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string fileName = inputTextBox.Text;
                outputTextBox.AppendText(fileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
