// Fig. 15.11: DateTimePickerForm.cs
// Using a DateTimePicker to select a drop-off time.
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

namespace DateTimePickerTest
{
    public partial class DateTimePickerForm : Form
    {
        // default constructor
        public DateTimePickerForm()
        {
            InitializeComponent();
        } // end constructor

        private void dropOffDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dropOffDateTimePicker.Value;

            // add extra time when items are dropped off Sunday
            if (dropOffDate.DayOfWeek == DayOfWeek.Friday || 
                dropOffDate.DayOfWeek == DayOfWeek.Saturday || 
                dropOffDate.DayOfWeek == DayOfWeek.Sunday)
            {
                // estimate three days for delivery
                outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
            } // end if
            else
            {
                // otherwise estimate only two days for delivery
                outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
            } // end else
        } // end method dropOffDateTimePicker_ValueChanged

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            // user cannot select days before today
            dropOffDateTimePicker.MinDate = DateTime.Today;

            // user can only select days up to one year in the future
            dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        } // end method DateTimePickerForm_Load
    } // end class DateTimePickerForm
} // end namespace DateTimePickerTest
