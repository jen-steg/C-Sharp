/*
 * Jennifer DeVore
 * 9 February 2020
 * CIS 317
 * DisplayAuthorsTable.cs
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        // constructor
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        } // end method to Display Authors Table

        // Entity Framework DbContext
        private BooksExamples.BooksEntities dbcontext =
            new BooksExamples.BooksEntities();

        // Load data from database into DataGridView
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            // load Authors table ordered by last name then first name
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            // specify DataSource for authorBindingSource
            authorBindingSource.DataSource = dbcontext.Authors.Local;
        } // end method to load Authors table

        // click event handler for the Save Button in the
        // BindingNavigator saves the changes made to the data
        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate the input fields
            authorBindingSource.EndEdit(); // complete the current edit, if any

            // try to save changes
            try
            {
                dbcontext.SaveChanges(); // write changes to database file
            } // end try
            catch (DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values", "Entity Validation Exception");
            } // end catch
        } //end method for save button functionality
    } // end public partial class DisplayAuthorsTable : Form
} // end namespace DisplayTable
