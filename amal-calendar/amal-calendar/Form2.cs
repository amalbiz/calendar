using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amal_calendar
{
    // main partial class that handles the dashboard form
    public partial class Form2 : Form
    {
        // initializing the Form2 instance
        public Form2()
        {
            InitializeComponent();


        }
        // create calendar button (left) click event
        private void createCalButton_Click(object sender, EventArgs e)
        {
            // checking if calendar name field is empty
            string calNameCheck = calNameTextbox.Text;
            bool calName = string.IsNullOrWhiteSpace(calNameCheck);
            // if not valid, error message will pop up for user
            if (calName == true)
            {
                MessageBox.Show("Calendar name field is empty!", "Error!");
                calNameTextbox.Text = "";

            }
            // if valid, looks to add the text field to listbox (right)
            else
            {
                // checking to see if name is unique
                string calNameStrip = calNameTextbox.Text.Trim();
                if (!availableCalListbox.Items.Contains(calNameStrip))
                {
                    // if unique, calendar name is added
                    availableCalListbox.Items.Add(calNameStrip);
                    calNameTextbox.Text = "";
                }
                else
                {
                    // if not unique, error message pops up for user
                    MessageBox.Show("Please enter a unique calendar name!", "Error!");
                    calNameTextbox.Text = "";

                }
            }
        }
        // open calendar button click event
        private void openCalButton_Click(object sender, EventArgs e)
        {
            // checking if any item in listbox collection is selected
            string listNameCheck = availableCalListbox.Text;
            bool listName = string.IsNullOrWhiteSpace(listNameCheck);
            if (listName == true)
            {
                // if nothing selected, error box pops up for user
                MessageBox.Show("Please make sure to select a calendar!", "Error!");

            }
            else
            {
                // if valid item selected, user can open the calendar form
                User obj2 = new User();
                obj2.Show();
                //this.Hide();
            }
        }
        // logout function
        private void logoutButton_Click(object sender, EventArgs e)
        {
            // prompts user to confirm logout of application which closes everything
            if (MessageBox.Show("This will log you out and close the whole application. Confirm?", "Logout?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("You have logged out successfully. Restart the application to start again!", "Application Closed..", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                this.Activate();
            }



        }
        // delete calendar button click event
        private void deleteCalendarButton_Click(object sender, EventArgs e)
        {
            // checking if valid item from listbox is selected
            string listNameCheck = availableCalListbox.Text;
            bool listName = string.IsNullOrWhiteSpace(listNameCheck);
            if (listName == true)
            {
                // if not, error message pops up for user
                MessageBox.Show("Please make sure to select a calendar!", "Error!");

            }
            else
            {
                // if item is selected, it is removed from listbox
                for (int i = availableCalListbox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    availableCalListbox.Items.RemoveAt(availableCalListbox.SelectedIndices[i]);
                }
            }
        }
    }
}

