using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace go2grocery_1
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        public LoginForm()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //this.loginTableAdapter.GetData();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con.Open();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text !="" & PasswordBox.Text != "")
            {
                string queryText = "SELECT Count(*) FROM Login " + " WHERE (Username = @Username COLLATE SQL_Latin1_general_CP1_CS_AS) AND Password = @Password COLLATE SQL_Latin1_general_CP1_CS_AS";
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(queryText, cn);
                {
                    cn.Open();
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        MessageBox.Show("Login Successfull");
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username and password are case sensitive, please double check and try again");
                    }
                }
            }
            else if (UsernameBox.Text == "" && PasswordBox.Text == "")
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
            con.Close();
        }
    }
}



/*
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE (Username ='" + UsernameBox.Text + "') AND Password ='" + PasswordBox.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
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
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfull");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            
            con.Close();
            */
