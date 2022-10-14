using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace go2grocery_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.dataSet1.Member);

        }

        private void memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                /*this.Validate();
                this.memberBindingSource.EndEdit();
                this.memberTableAdapter.Update(this.dataSet1.Member);
                */
                this.memberTableAdapter.Update(this.dataSet1.Member);
                this.dataSet1.Member.AcceptChanges();
                this.memberTableAdapter.Fill(this.dataSet1.Member);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void SalesFormButton_Click(object sender, EventArgs e)
        {
            SalesForm salesForm1 = new SalesForm();
            salesForm1.Show();
            this.Hide();

            try
            {
                /*this.Validate();
                this.memberBindingSource.EndEdit();
                this.memberTableAdapter.Update(this.dataSet1.Member);
                */
                this.memberTableAdapter.Update(this.dataSet1.Member);
                this.dataSet1.Member.AcceptChanges();
                this.memberTableAdapter.Fill(this.dataSet1.Member);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

        }


        private void export_btn_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml("Member.xml");
            MessageBox.Show("Export successful");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string s = sales_mem_id_txt.Text;
            bool containsLetter = Regex.IsMatch(s, "[a-zA-Z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]");

            if (containsLetter)
            {
                MessageBox.Show("Can only search for member by ID, please no letters or symbols");
            }
            else
            {
                DataRow foundRow = dataSet1.Tables["Member"].Rows.Find(s);
                if (foundRow != null)
                {
                    MessageBox.Show("First name: " + foundRow[1].ToString() + "\n" + "Last name: " + foundRow[2].ToString() + "\n" + "Address: " + foundRow[3].ToString());
                }
                else
                {
                    MessageBox.Show("A customer with the member ID of " + s + " Does not exist");
                }
            }
        }
    }
}
