namespace calendarapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> accName = new Dictionary<string, string>();

            string usrcheck = textBox1.Text;
            string pwcheck = textBox2.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);
            if (usr == true || pw == true){
                System.Windows.Forms.MessageBox.Show("Username or password field is empty!");
            }
            else
            {
                Form2 obj1 = new Form2();
                obj1.Show();
                this.Hide();

                /*string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                
                accName.Add(username, password);
                foreach (var kvp in accName)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }*/
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usrcheck = textBox1.Text;
            string pwcheck = textBox2.Text;
            bool usr = string.IsNullOrWhiteSpace(usrcheck);
            bool pw = string.IsNullOrWhiteSpace(pwcheck);
            if (usr == true || pw == true)
            {
                System.Windows.Forms.MessageBox.Show("Username or password field is empty!");
            }
            else
            {
                Form2 obj1 = new Form2();
                obj1.Show();
                this.Hide();

                /*string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                
                accName.Add(username, password);
                foreach (var kvp in accName)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }*/
            }
        }
    }
}