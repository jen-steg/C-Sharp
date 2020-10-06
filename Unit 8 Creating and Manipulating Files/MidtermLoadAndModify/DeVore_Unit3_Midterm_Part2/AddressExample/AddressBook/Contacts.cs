﻿/*
 * Jennifer DeVore
 * 13 February 2020
 * CIS 317
 * 
 * Midterm Unit 3
 * 
 * Modify the Guided Practice 2 Solution in Unit 2 to allow the user to locate users within area codes. 
 * Add a TextBox for the area code(0.000 by default). Use a Label to identify the Area Code TextBox. 
 * Add a Button for executing a query that selects rows from the Address table in which the area code 
 * matches the one entered.
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

namespace AddressBook
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }
        // Entity Framework DbContext
        private AddressExample.AddressBookEntities dbcontext = null;

        // fill our addressBindingSource with all rows, ordered by name
        private void RefreshContacts()
        {
            // Dispose old DbContext, if any
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }

            // create new DbContext so we can reorder records based on edits
            dbcontext = new AddressExample.AddressBookEntities();

            // use LINQ to order the Addresses table contents
            // by last name, then first name
            dbcontext.Addresses
                .OrderBy(entry => entry.LastName)
                .ThenBy(entry => entry.FirstName)
                .Load();

            // specify DataSource for addressBindingSource
            addressBindingSource.DataSource = dbcontext.Addresses.Local;
            addressBindingSource.MoveFirst(); // go to the first result
            findTextBox.Clear();
        } // end method for resfreshing the contacts

        // when the form loads, fill it with data from the database
        private void Contacts_Load(object sender, EventArgs e)
        {
            RefreshContacts(); // fill binding with data from database
        } // end method for loading contacts

        // Click event handler for the Save Button in the
        // BindingNavigator saves the changes made to the data
        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate input fields
            addressBindingSource.EndEdit(); // complete current edit, if any

            // try to save changes
            try
            {
                dbcontext.SaveChanges(); // write changes to database file
            } // end try
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Columns cannot be empty", "Entity Validation Exception");
            } // end  catch

            RefreshContacts(); // change back to updated unfiltered data
        } // end method for save button

        // use LINQ to create a data source that contains only people
        // with last names that start with the specified text
        private void findButton_Click(object sender, EventArgs e)
        {
            // use LINQ to filter contacts with last names that
            // start with findTextBox contents
            var lastNameQuery =
                from address in dbcontext.Addresses
                where address.LastName.StartsWith(findTextBox.Text)
                orderby address.LastName, address.FirstName
                select address;

            // display matching contacts
            addressBindingSource.DataSource = lastNameQuery.ToList();
            addressBindingSource.MoveFirst(); // go to first result

            // don't allow add/delete when contacts are filtered
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        } // end method for the "find" button for last names

        // reload addressBindingSource with all rows
        private void browseAllButton_Click(object sender, EventArgs e)
        {
            // allow add/delete when contacts are not filtered
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            RefreshContacts(); // change back to initial unfiltered data
        } // end method for the browse all button

        private void areaCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } // end method to check keypress for area code TextBox

        private void findAreaCodeButton_Click(object sender, EventArgs e)
        {
            // use LINQ to filter contacts with last names that
            // start with findTextBox contents
            var areaCodeQuery =
                from address in dbcontext.Addresses
                where address.PhoneNumber.StartsWith(findTextBox.Text)
                orderby address.LastName, address.FirstName
                select address;

            // display matching contacts
            addressBindingSource.DataSource = areaCodeQuery.ToList();
            addressBindingSource.MoveFirst(); // go to first result

            // don't allow add/delete when contacts are filtered
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        } // end method for the "find" button for area code

    } // end public partial class Contacts: Form
} // end namespace AddressBook