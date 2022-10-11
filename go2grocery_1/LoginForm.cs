using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace go2grocery_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.LoginTableAdapter.GetData();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "" && PasswordBox.Text == "") 
            {
                MessageBox.Show("Please enter a username and password");
            }
            else if (UsernameBox.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }
            else if (PasswordBox.Text == "")
            {
                MessageBox.Show("Please enter a password");
            }
            //Form1 form1 = new Form1();
            //form1.Show();
            //this.Hide();
        }
    }
}
