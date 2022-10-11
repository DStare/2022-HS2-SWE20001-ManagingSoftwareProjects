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
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE (Username ='" + UsernameBox.Text + "') AND Password ='" + PasswordBox.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            /*
            try
            {
                string str_user, str_password;
                int j;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE (username LIKE='" + UsernameBox.Text + "') AND password LIKE='" + PasswordBox.Text + "'", con);
                SqlDataReader  dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                {
                    for (j = 0; j < 3; j++){
                        str_user = dr[j].ToString();
                        str_password = dr[j].ToString();
                        if (string.Compare(UsernameBox.Text, str_user, CasesensitiveComparer.Binary))
                        {
       
                        }
                    }
                }
                dr.Close();
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
            */

            
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
        }
    }
}
