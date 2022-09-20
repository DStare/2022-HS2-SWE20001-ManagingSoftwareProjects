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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void editButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editForm editForm = new editForm();
            editForm.Show();
            //this.Form1_FormClosing(this);
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
                this.memberTableAdapter.fill()
    Me.yourTableAdapter.Fill(Me.yourDataSet.yourTable)
                MessageBox.Show("Update successful");

                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

    }
}
