namespace go2grocery_1
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new go2grocery_1.DataSet1();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new go2grocery_1.DataSet1TableAdapters.SalesTableAdapter();
            this.tableAdapterManager = new go2grocery_1.DataSet1TableAdapters.TableAdapterManager();
            this.salesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.salesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.SearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReturnToMembers = new System.Windows.Forms.ToolStripButton();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Export_Sales_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.find_sales_btn = new System.Windows.Forms.Button();
            this.sales_mem_ID_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).BeginInit();
            this.salesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.dataSet1;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = go2grocery_1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesBindingNavigator
            // 
            this.salesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesBindingNavigator.BindingSource = this.salesBindingSource;
            this.salesBindingNavigator.CountItem = null;
            this.salesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.salesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salesBindingNavigatorSaveItem,
            this.SearchBar,
            this.toolStripSeparator1,
            this.ReturnToMembers});
            this.salesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesBindingNavigator.MoveFirstItem = null;
            this.salesBindingNavigator.MoveLastItem = null;
            this.salesBindingNavigator.MoveNextItem = null;
            this.salesBindingNavigator.MovePreviousItem = null;
            this.salesBindingNavigator.Name = "salesBindingNavigator";
            this.salesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.salesBindingNavigator.PositionItem = null;
            this.salesBindingNavigator.Size = new System.Drawing.Size(1304, 31);
            this.salesBindingNavigator.TabIndex = 0;
            this.salesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // salesBindingNavigatorSaveItem
            // 
            this.salesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesBindingNavigatorSaveItem.Enabled = false;
            this.salesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesBindingNavigatorSaveItem.Image")));
            this.salesBindingNavigatorSaveItem.Name = "salesBindingNavigatorSaveItem";
            this.salesBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.salesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(100, 31);
            this.SearchBar.Text = "Search";
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // ReturnToMembers
            // 
            this.ReturnToMembers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReturnToMembers.Image = ((System.Drawing.Image)(resources.GetObject("ReturnToMembers.Image")));
            this.ReturnToMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReturnToMembers.Name = "ReturnToMembers";
            this.ReturnToMembers.Size = new System.Drawing.Size(144, 28);
            this.ReturnToMembers.Text = "Return to Members Form";
            this.ReturnToMembers.Click += new System.EventHandler(this.ReturnToMembers_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.salesDataGridView.DataSource = this.salesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.salesDataGridView.GridColor = System.Drawing.Color.RosyBrown;
            this.salesDataGridView.Location = new System.Drawing.Point(-9, 64);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = null;
            this.salesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.salesDataGridView.Size = new System.Drawing.Size(1264, 164);
            this.salesDataGridView.TabIndex = 1;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sales_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sales_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Unit_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit_Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total_Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total_Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date_Of_Sale";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date_Of_Sale";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Member_Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Member_Id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // Export_Sales_btn
            // 
            this.Export_Sales_btn.Location = new System.Drawing.Point(641, 350);
            this.Export_Sales_btn.Name = "Export_Sales_btn";
            this.Export_Sales_btn.Size = new System.Drawing.Size(114, 30);
            this.Export_Sales_btn.TabIndex = 2;
            this.Export_Sales_btn.Text = "Export";
            this.Export_Sales_btn.UseVisualStyleBackColor = true;
            this.Export_Sales_btn.Click += new System.EventHandler(this.Export_Sales_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Go2Grocery sales Page";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // find_sales_btn
            // 
            this.find_sales_btn.Location = new System.Drawing.Point(310, 350);
            this.find_sales_btn.Name = "find_sales_btn";
            this.find_sales_btn.Size = new System.Drawing.Size(114, 30);
            this.find_sales_btn.TabIndex = 5;
            this.find_sales_btn.Text = "Find Sales record";
            this.find_sales_btn.UseVisualStyleBackColor = true;
            this.find_sales_btn.Click += new System.EventHandler(this.find_sales_btn_Click);
            // 
            // sales_mem_ID_txt
            // 
            this.sales_mem_ID_txt.Location = new System.Drawing.Point(310, 310);
            this.sales_mem_ID_txt.Name = "sales_mem_ID_txt";
            this.sales_mem_ID_txt.Size = new System.Drawing.Size(100, 20);
            this.sales_mem_ID_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Find sales by member ID:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::go2grocery_1.Properties.Resources.go2grocery;
            this.ClientSize = new System.Drawing.Size(1304, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sales_mem_ID_txt);
            this.Controls.Add(this.find_sales_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Export_Sales_btn);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.salesBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).EndInit();
            this.salesBindingNavigator.ResumeLayout(false);
            this.salesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DataSet1TableAdapters.SalesTableAdapter salesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton salesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripTextBox SearchBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ReturnToMembers;
        private System.Windows.Forms.Button Export_Sales_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_sales_btn;
        private System.Windows.Forms.TextBox sales_mem_ID_txt;
        private System.Windows.Forms.Label label2;
    }
}