namespace Staff_Management
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Search = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.Panel();
            this.GV = new System.Windows.Forms.DataGridView();
            this.tblStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblstafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_systemDataSet = new Staff_Management.staff_systemDataSet();
            this.tblStaffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StaffTableAdapter = new Staff_Management.staff_systemDataSetTableAdapters.tbl_StaffTableAdapter();
            this.staff_systemDataSet1 = new Staff_Management.staff_systemDataSet1();
            this.tblStaffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StaffTableAdapter1 = new Staff_Management.staff_systemDataSet1TableAdapters.tbl_StaffTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstafBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(403, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Staff";
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(1033, 142);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(162, 72);
            this.btn_Save.TabIndex = 126;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Location = new System.Drawing.Point(767, 165);
            this.txt_CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(230, 26);
            this.txt_CNIC.TabIndex = 125;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(430, 165);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(230, 26);
            this.txt_Name.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 123;
            this.label4.Text = "CNIC:";
            // 
            // cmb_Search
            // 
            this.cmb_Search.FormattingEnabled = true;
            this.cmb_Search.Items.AddRange(new object[] {
            "Name",
            "CNIC"});
            this.cmb_Search.Location = new System.Drawing.Point(172, 165);
            this.cmb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(136, 28);
            this.cmb_Search.TabIndex = 122;
            this.cmb_Search.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 121;
            this.label3.Text = "Search With:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 120;
            this.label2.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 616);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 65);
            this.panel2.TabIndex = 119;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txt_Search.Controls.Add(this.label1);
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Search.Location = new System.Drawing.Point(0, 0);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(1328, 131);
            this.txt_Search.TabIndex = 117;
            // 
            // GV
            // 
            this.GV.AutoGenerateColumns = false;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.cNICDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.saleryDataGridViewTextBoxColumn,
            this.satatusDataGridViewTextBoxColumn});
            this.GV.DataSource = this.tblStaffBindingSource2;
            this.GV.Location = new System.Drawing.Point(0, 224);
            this.GV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GV.Name = "GV";
            this.GV.RowHeadersWidth = 62;
            this.GV.Size = new System.Drawing.Size(1329, 442);
            this.GV.TabIndex = 118;
            // 
            // tblStaffBindingSource
            // 
            this.tblStaffBindingSource.DataMember = "tbl_Staff";
            // 
            // tblstafBindingSource
            // 
            this.tblstafBindingSource.DataMember = "tbl_staf";
            // 
            // staff_systemDataSet
            // 
            this.staff_systemDataSet.DataSetName = "staff_systemDataSet";
            this.staff_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStaffBindingSource1
            // 
            this.tblStaffBindingSource1.DataMember = "tbl_Staff";
            this.tblStaffBindingSource1.DataSource = this.staff_systemDataSet;
            // 
            // tbl_StaffTableAdapter
            // 
            this.tbl_StaffTableAdapter.ClearBeforeFill = true;
            // 
            // staff_systemDataSet1
            // 
            this.staff_systemDataSet1.DataSetName = "staff_systemDataSet1";
            this.staff_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStaffBindingSource2
            // 
            this.tblStaffBindingSource2.DataMember = "tbl_Staff";
            this.tblStaffBindingSource2.DataSource = this.staff_systemDataSet1;
            // 
            // tbl_StaffTableAdapter1
            // 
            this.tbl_StaffTableAdapter1.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cNICDataGridViewTextBoxColumn
            // 
            this.cNICDataGridViewTextBoxColumn.DataPropertyName = "CNIC";
            this.cNICDataGridViewTextBoxColumn.HeaderText = "CNIC";
            this.cNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNICDataGridViewTextBoxColumn.Name = "cNICDataGridViewTextBoxColumn";
            this.cNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 150;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // saleryDataGridViewTextBoxColumn
            // 
            this.saleryDataGridViewTextBoxColumn.DataPropertyName = "Salery";
            this.saleryDataGridViewTextBoxColumn.HeaderText = "Salery";
            this.saleryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleryDataGridViewTextBoxColumn.Name = "saleryDataGridViewTextBoxColumn";
            this.saleryDataGridViewTextBoxColumn.Width = 150;
            // 
            // satatusDataGridViewTextBoxColumn
            // 
            this.satatusDataGridViewTextBoxColumn.DataPropertyName = "Satatus";
            this.satatusDataGridViewTextBoxColumn.HeaderText = "Satatus";
            this.satatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.satatusDataGridViewTextBoxColumn.Name = "satatusDataGridViewTextBoxColumn";
            this.satatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 681);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_CNIC);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.GV);
            this.Name = "Form2";
            this.Text = "search";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.txt_Search.ResumeLayout(false);
            this.txt_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstafBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblStaffBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txt_Search;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.BindingSource tblstafBindingSource;
        private staff_systemDataSet staff_systemDataSet;
        private System.Windows.Forms.BindingSource tblStaffBindingSource1;
        private staff_systemDataSetTableAdapters.tbl_StaffTableAdapter tbl_StaffTableAdapter;
        private staff_systemDataSet1 staff_systemDataSet1;
        private System.Windows.Forms.BindingSource tblStaffBindingSource2;
        private staff_systemDataSet1TableAdapters.tbl_StaffTableAdapter tbl_StaffTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satatusDataGridViewTextBoxColumn;
    }
}