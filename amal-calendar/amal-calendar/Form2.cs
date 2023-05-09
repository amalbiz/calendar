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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }

        private void createCalButton_Click(object sender, EventArgs e)
        {

            string calNameCheck = calNameTextbox.Text;
            bool calName = string.IsNullOrWhiteSpace(calNameCheck);
            if (calName == true)
            {
                MessageBox.Show("Calendar name field is empty!", "Error!");
                calNameTextbox.Text = "";

            }
            else
            {
                string calNameStrip = calNameTextbox.Text.Trim();
                if (!availableCalListbox.Items.Contains(calNameStrip))
                {
                    availableCalListbox.Items.Add(calNameStrip);
                    calNameTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a unique calendar name!", "Error!");
                    calNameTextbox.Text = "";

                }
            }
        }

        private void openCalButton_Click(object sender, EventArgs e)
        {
            string listNameCheck = availableCalListbox.Text;
            bool listName = string.IsNullOrWhiteSpace(listNameCheck);
            if (listName == true)
            {
                MessageBox.Show("Please make sure to select a calendar!", "Error!");

            }
            else
            {
                User obj2 = new User();
                obj2.Show();
                //this.Hide();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will log you out and close the whole application. Confirm?", "Logout?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("You have logged out successfully. Restart the application to start again!", "Application Closed..", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }



        }

        private void deleteCalendarButton_Click(object sender, EventArgs e)
        {
            string listNameCheck = availableCalListbox.Text;
            bool listName = string.IsNullOrWhiteSpace(listNameCheck);
            if (listName == true)
            {
                MessageBox.Show("Please make sure to select a calendar!", "Error!");

            }
            else
            {
                for (int i = availableCalListbox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    availableCalListbox.Items.RemoveAt(availableCalListbox.SelectedIndices[i]);
                }
            }
        }
    }
}

