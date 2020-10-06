// ToolTipExample.cs
// Will show hidden text descriptions when items are hovered over
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

namespace ToolTipExample
{
    // Form contains tool tips that show the user hidden text 
    public partial class ToolTipExampleTestForm : Form
    {
        // default constructor
        public ToolTipExampleTestForm()
        {
            InitializeComponent();
        } // end constructor

        // method for the tool tip
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        } // end method toolTip1_Popup
    } // end class ToolTipExampleTestForm
} // end namespace ToolTipExample
