namespace amal_calendar
{
    // Main partial class that handles the login/register form
    public partial class Form1 : Form

    {
        // Starting the form instance
        public Form1()
        {
            InitializeComponent();

        }
        // register button click event 
        private void registerButton_Click(object sender, EventArgs e)
        {
            // checking if the user/password fields are empty
            string usrcheck = emailTextbox.Text;
            string pwcheck = passwordTextbox.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);
            // if they are, error message box pops up
            if (usr == true || pw == true)
            {
                MessageBox.Show("Username or password field is empty!", "Error!");
            }
            // if text is present, it checks for an @ symbol in the email
            else
            {
                if (usrcheck.Contains("@"))
                {
                    // if valid, the dashboard form opens
                    Form2 obj1 = new Form2();
                    obj1.Show();
                    this.Hide();
                }
                // otherwise, message box telling the user their error pops up
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }
            }
        }
        // login button click event
        private void loginButton_Click(object sender, EventArgs e)
        {
            // checking if the user/password fields are empty
            string usrcheck = emailTextbox.Text;
            string pwcheck = passwordTextbox.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);
            // if they are, error message box pops up
            if (usr == true || pw == true)
            {
                MessageBox.Show("Username or password field is empty!", "Error!");
            }
            else
            // if text is present, it checks for an @ symbol in the email
            {
                if (usrcheck.Contains("@"))
                {
                    // if valid, the dashboard form opens
                    Form2 obj1 = new Form2();
                    obj1.Show();
                    this.Hide();
                }
                else
                {
                    // otherwise, message box telling the user their error pops up
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

            }
        }

    }
}