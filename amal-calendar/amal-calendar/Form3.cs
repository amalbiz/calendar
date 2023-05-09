using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace amal_calendar
{
    // User class created
    public partial class User : Form

    {
        // Form initialized
        public User()
        {
            InitializeComponent();
        }
        // logout button function
        public void logoutButton_Click(object sender, EventArgs e)
        {
            // confirms with user that they wish to logout (closes everything)
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
        // public lists and variables that is used by multiple methods within class
        public List<string> ownerList = new List<string>();
        public List<string> adminList = new List<string>();
        public List<string> userList = new List<string>();
        public List<string> bannedList = new List<string>();
        public object userName;
        public string companyNameCheck;
        // on form load events
        public void Form3_Load(object sender, EventArgs e)
        {

            // prompts user for preferred username (default = guest)
            string userMessage = "Please enter your preferred username:";
            string title = "Before you start..";
            string defaultValue = "Guest";
            userName = Interaction.InputBox(userMessage, title, defaultValue);
            if ((string)userName == "")
            {
                userName = defaultValue;
                usernameLabel.Text = "Hello, " + userName.ToString() + "!";
                ownerList.Add(userName.ToString());
                // permission rank of user is displayed in form according to username
                // and corresponding list
                if (ownerList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: Creator";
                }
                else if (adminList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: Admin";
                }
                else if (userList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: User";
                }
                else if (bannedList.Contains(userName.ToString()))
                {
                    // banned users are not allowed to view calendar
                    MessageBox.Show("You have been banned from this calendar!");

                }


            }
            else
            {
                string usernameString = userName.ToString();
                usernameLabel.Text = "Hello, " + usernameString.Trim() + "!";
                ownerList.Add(usernameString.Trim());
                // permission rank of user is displayed in form according to username
                // and corresponding list
                if (ownerList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: Creator";
                }
                if (adminList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: Admin";
                }
                if (userList.Contains(userName.ToString()))
                {
                    rankLabel.Text = "Rank: User";
                }
                if (bannedList.Contains(userName.ToString()))
                {
                    // banned users are not allowed to view calendar
                    MessageBox.Show("You have been banned from this calendar!");

                }


            }


        }
        // company name button click event
        public void companyNameButton_Click(object sender, EventArgs e)
        {
            // checking to see if text box field is valid
            companyNameCheck = companyNameInput.Text;
            bool companyCheck = string.IsNullOrWhiteSpace(companyNameCheck);
            if (companyCheck)
                // if not valid, user is notified via messagebox
            {
                MessageBox.Show("Company Name field is empty!", "Error!");
            }
            else
            {
                // if valid, user is notified via messagebox and company name displays on top
                finalCompanyNameLabel.Text = companyNameCheck.Trim();
                MessageBox.Show("Company Name has been added!", "Success!");
            }
        }
        // admin add button click event
        public void adminButton_Click(object sender, EventArgs e)
        {
            // checking if textbox value is empty
            string adminNameCheck = adminNameInput.Text;
            bool adminCheck = string.IsNullOrWhiteSpace(adminNameCheck);
            if (adminCheck)
            {
                MessageBox.Show("Admin email field is empty!", "Error!");
            }
            else
            {
                // if valid, checking if text contains an @ symbol
                if (adminNameCheck.Contains("@"))
                {
                    // user is notified that admin has been added and email is added to list
                    adminList.Add(adminNameCheck.Trim());
                    MessageBox.Show("Admin has been invited to the calendar!", "Success!");
                    adminNameInput.Text = "";
                }
                else
                {
                    // if @ symbol not found, user prompted to enter valid email address
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }
            }
        }
        // add user button click event
        private void userButton_Click(object sender, EventArgs e)
        {
            // checking if user email text field is valid
            string userNameCheck = userNameInput.Text;
            bool userCheck = string.IsNullOrWhiteSpace(userNameCheck);
            if (userCheck)
            {
                // if empty, user is prompted to fix
                MessageBox.Show("User email field is empty!", "Error!");
            }
            else
            {
                // if valid, code checks for @ symbol
                if (userNameCheck.Contains("@"))
                {
                    // if valid with @, user is added and list is updated as well
                    userList.Add(userNameCheck.Trim());
                    MessageBox.Show("User has been invited to the calendar!", "Success!");
                    userNameInput.Text = "";
                }
                else
                {
                    // if email check fails, user is notified with messagebox
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

            }
        }

        // ban user button click event
        private void bannedUserButton_Click(object sender, EventArgs e)
        {
            // checking if text field is valid
            string bannedUserNameCheck = bannedUserNameInput.Text;
            bool userCheck = string.IsNullOrWhiteSpace(bannedUserNameCheck);
            // if field empty, user is notified
            if (userCheck)
            {
                MessageBox.Show("User email field is empty!", "Error!");
            }
            else
            {
                // if text found, code checks for @ symbol
                if (bannedUserNameCheck.Contains("@"))
                {
                    // if valid and has @ symbol, user email is now blacklisted
                    bannedList.Add(bannedUserNameCheck.Trim());
                    MessageBox.Show("User has been blacklisted!", "Success!");
                    bannedUserNameInput.Text = "";
                }
                else
                {
                    // if not valid, user is notified via message box
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

            }
        }

    }

}
