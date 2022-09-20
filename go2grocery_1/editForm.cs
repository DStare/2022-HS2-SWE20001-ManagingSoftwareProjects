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
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }
        

        private void editForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.dataSet11.Member);
            // this.memberTableAdapter.Fill(this.dataSet1.Member);
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(enterMemberID.Text, out int memberID))
            {
                this.memberTableAdapter.FillByMemberId(this.dataSet11.Member, memberID);
            }
            else
            {
                MessageBox.Show("String to Int parse failed");
            }
            
        }
        private void confirmEditsButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(member_IdTextBox.Text, out int memberID))
            {
                this.memberTableAdapter.UpdateMemberData(first_nameTextBox.Text, 
                                    last_nameTextBox.Text, 
                                    addressTextBox.Text, 
                                    memberID,
                                    memberID);

            }
            else
            {
                MessageBox.Show("String to Int parse failed");
            }
            
        }

        private void editForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // try
           // {
           
                this.Validate();
                this.dataSet11.AcceptChanges();
                this.memberBindingSource.EndEdit();
                this.memberTableAdapter.Update(this.dataSet11.Member);
                MessageBox.Show("Update successful");

           /* }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
            */
            this.Hide();
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }


        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet11);

        }
    }
}
