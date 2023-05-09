
namespace amal_calendar
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // IDictionary<string, string> accName = new Dictionary<string, string>();

            string usrcheck = emailTextbox.Text;
            string pwcheck = passwordTextbox.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);

            if (usr == true || pw == true)
            {
                MessageBox.Show("Username or password field is empty!", "Error!");
            }
            else
            {
                if (usrcheck.Contains("@"))
                {
                    Form2 obj1 = new Form2();
                    obj1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }
                /*var accounts = new Dictionary<string, string>()
                {

                };
                accounts.Add(usrcheck, pwcheck);
                foreach (var kvp in accounts)
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);*/


                /*string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                
                accName.Add(username, password);
                foreach (var kvp in accName)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }*/
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usrcheck = emailTextbox.Text;
            string pwcheck = passwordTextbox.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);
            if (usr == true || pw == true)
            {
                MessageBox.Show("Username or password field is empty!", "Error!");
            }
            else
            {
                if (usrcheck.Contains("@"))
                {
                    Form2 obj1 = new Form2();
                    obj1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a proper email!", "Error!");
                }

                /*string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                
                accName.Add(username, password);
                foreach (var kvp in accName)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }*/
            }
        }
        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
        }   */

    }
}