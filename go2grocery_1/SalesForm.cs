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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Table' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dataSet1.Sales);

        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                MessageBox.Show("entered");
            }
        }

        private void ReturnToMembers_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            try
            {
                /*this.Validate();
                this.memberBindingSource.EndEdit();
                this.memberTableAdapter.Update(this.dataSet1.Member);
                */

                this.salesTableAdapter.Update(this.dataSet1.Sales);
                this.dataSet1.Sales.AcceptChanges();
                this.salesTableAdapter.Fill(this.dataSet1.Sales);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                /*this.Validate();
                this.memberBindingSource.EndEdit();
                this.memberTableAdapter.Update(this.dataSet1.Member);
                */
                this.salesTableAdapter.Update(this.dataSet1.Sales);
                this.dataSet1.Sales.AcceptChanges();
                this.salesTableAdapter.Fill(this.dataSet1.Sales);

            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void Export_Sales_btn_Click(object sender, EventArgs e)
        {
            {
                dataSet1.WriteXml("Sales.xml");
                MessageBox.Show("Export successful");
            }
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void find_sales_btn_Click(object sender, EventArgs e)
        {
            string b = sales_mem_ID_txt.Text;
            bool containsLetter = Regex.IsMatch(b, "[a-zA-Z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]");

            if (containsLetter)
            {
                MessageBox.Show("Can only search for member by ID, please no letters or symbols");
            }
            else
            {
                DataRow foundRow = dataSet1.Tables["Sales"].Rows.Find(b);
                if (foundRow != null)
                {
                    MessageBox.Show("Sales ID: " + foundRow[0].ToString() + "\n" + "Product ID: " + foundRow[1].ToString() + "\n" + "Product name: " + foundRow[2].ToString() + "\n" + "Quantity: " + foundRow[3].ToString() + "\n" + "Price: $" + foundRow[4].ToString()
                       + "\n" + "Total price: $" + foundRow[5].ToString() + "\n" + "Date of sale: " + foundRow[6].ToString() + "\n" + "Member ID: " + foundRow[7].ToString());
                }
                else
                {
                    MessageBox.Show("A sale record with the sales ID of " + b + " Does not exist");
                }
            }

        }
    }
}
