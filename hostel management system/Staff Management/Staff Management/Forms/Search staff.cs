using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staff_systemDataSet1.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter1.Fill(this.staff_systemDataSet1.tbl_Staff);
            // TODO: This line of code loads data into the 'staff_systemDataSet.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter.Fill(this.staff_systemDataSet.tbl_Staff);

        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Search.Text == "Name")
            {
                txt_CNIC.Enabled = false;
                txt_Name.Enabled = true;
            }
            else if (cmb_Search.Text == "CNIC")
            {
                txt_CNIC.Enabled = true;
                txt_Name.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Search.Text == "Name")
            {
                SearchWithName();
            }
            else if (cmb_Search.Text == "CNIC")
            {
                SearchWithCNIC();
            }
        }
        private void SearchWithName()
        {
            string Query = "SELECT * FROM tbl_Staff Where Name LIKE'%" + txt_Name.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Staff.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GV.DataSource = ds.Tables[0];
        }
        private void SearchWithCNIC()
        {
            string Query = "SELECT * FROM tbl_Staff Where CNIC LIKE'%" + txt_CNIC.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Staff.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GV.DataSource = ds.Tables[0];
        }
    }
}
