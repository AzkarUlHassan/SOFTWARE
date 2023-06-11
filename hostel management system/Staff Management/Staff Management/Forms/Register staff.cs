using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Staff staf = new Staff();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Query = " INSERT INTO tbl_Staff VALUES('"+txt_Name.Text+"','"+txt_FtaherName.Text+"','"+txt_CNIC.Text+"','"+txt_DOB.Text+"','"+txt_BloodGroup.Text+"','"+txt_Mobile.Text+"','"+txt_Adress.Text+"','"+txt_JoiningDate.Text+"','"+txt_Salery.Text+"','"+txt_status.Text+"')";
            staf.OpenCon();
            staf.NonQueryExecuter(Query);
            staf.CloseCon();
            MessageBox.Show("Staff Added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            txt_status.Clear();
            txt_Salery.Clear();
            txt_Adress.Clear();
            txt_JoiningDate.Clear();
            txt_Salery.Clear();
            txt_FtaherName.Clear();
            txt_DOB.Clear();
            txt_BloodGroup.Clear();
            txt_Adress.Clear();
            txt_Mobile.Clear();
            txt_Name.Focus();
        }
    }
}
