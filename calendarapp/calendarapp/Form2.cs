using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendarapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calNameCheck = textBox1.Text;
            bool calName = string.IsNullOrWhiteSpace(calNameCheck);
            if (calName == true)
            {
                System.Windows.Forms.MessageBox.Show("Calendar name field is empty!");

            }
            else
            {
                string calNameStrip = textBox1.Text.Trim();
                listBox1.Items.Add(calNameStrip);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string listNameCheck = listBox1.Text;
            bool listName = string.IsNullOrWhiteSpace(listNameCheck);
            if (listName == true)
            {
                System.Windows.Forms.MessageBox.Show("Please make sure to select a calendar!");

            }
            else
            {
                Form3 obj2 = new Form3();
                obj2.Show();
                this.Hide();
            }
        }
    }
}
