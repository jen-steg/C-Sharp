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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
      
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

        // constructor
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

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

        // use LINQ to create a data source that contains only people
        // with last names that start with the specified text
        private void findButton_Click(object sender, EventArgs e)
        {
            // use LINQ to filter contacts with last names that
            // start with findTextBox contents
            var lastNameQuery =
                from author in dbcontext.Authors
                where author.LastName.StartsWith(findTextBox.Text)
                orderby author.LastName, author.FirstName
                select author;

            // display matching contacts
            authorBindingSource.DataSource = lastNameQuery.ToList();
            authorBindingSource.MoveFirst(); // go to first result

            // don't allow add/delete when contacts are filtered
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        } // end method for the "find" button

        // reload authorBindingSource with all rows
        private void browseAllButton_Click(object sender, EventArgs e)
        {
            // allow add/delete when contacts are not filtered
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
        } // end method for the browse all button
    } // end public partial class DisplayAuthorsTable : Form
} // end namespace DisplayTable
