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
    public partial class User : Form

    {
        public User()
        {
            InitializeComponent();
        }
        public void logoutButton_Click(object sender, EventArgs e)
        {
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
        public List<string> ownerList = new List<string>();
        public List<string> adminList = new List<string>();
        public List<string> userList = new List<string>();
        public List<string> bannedList = new List<string>();
        public object userName;
        public string companyNameCheck;

        public void Form3_Load(object sender, EventArgs e)
        {


            string userMessage = "Please enter your preferred username:";
            string title = "Before you start..";
            string defaultValue = "Guest";
            //string companyName = "";
            userName = Interaction.InputBox(userMessage, title, defaultValue);
            if ((string)userName == "")
            {
                userName = defaultValue;
                usernameLabel.Text = "Hello, " + userName.ToString() + "!";
                ownerList.Add(userName.ToString());
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
                    MessageBox.Show("You have been banned from this calendar!");

                }


            }
            else
            {
                string usernameString = userName.ToString();
                usernameLabel.Text = "Hello, " + usernameString.Trim() + "!";
                ownerList.Add(usernameString.Trim());
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
                    MessageBox.Show("You have been banned from this calendar!");

                }


            }


        }

        public void companyNameButton_Click(object sender, EventArgs e)
        {
            companyNameCheck = companyNameInput.Text;
            bool companyCheck = string.IsNullOrWhiteSpace(companyNameCheck);
            if (companyCheck)
            {
                MessageBox.Show("Company Name field is empty!", "Error!");
            }
            else
            {
                finalCompanyNameLabel.Text = companyNameCheck.Trim();
                MessageBox.Show("Company Name has been added!", "Success!");
            }
        }

        public void adminButton_Click(object sender, EventArgs e)
        {
            string adminNameCheck = adminNameInput.Text;
            bool adminCheck = string.IsNullOrWhiteSpace(adminNameCheck);
            if (adminCheck)
            {
                MessageBox.Show("Admin email field is empty!", "Error!");
            }
            else
            {
                if (adminNameCheck.Contains("@"))
                {
                    adminList.Add(adminNameCheck.Trim());
                    MessageBox.Show("Admin has been invited to the calendar!", "Success!");
                    adminNameInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            string userNameCheck = userNameInput.Text;
            bool userCheck = string.IsNullOrWhiteSpace(userNameCheck);
            if (userCheck)
            {
                MessageBox.Show("User email field is empty!", "Error!");
            }
            else
            {
                if (userNameCheck.Contains("@"))
                {
                    userList.Add(userNameCheck.Trim());
                    MessageBox.Show("User has been invited to the calendar!", "Success!");
                    userNameInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

            }
        }


        private void bannedUserButton_Click(object sender, EventArgs e)
        {
            string bannedUserNameCheck = bannedUserNameInput.Text;
            bool userCheck = string.IsNullOrWhiteSpace(bannedUserNameCheck);
            if (userCheck)
            {
                MessageBox.Show("User email field is empty!", "Error!");
            }
            else
            {
                if (bannedUserNameCheck.Contains("@"))
                {
                    bannedList.Add(bannedUserNameCheck.Trim());
                    MessageBox.Show("User has been blacklisted!", "Success!");
                    bannedUserNameInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

            }
        }

    }

}
