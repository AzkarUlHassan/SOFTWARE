using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management
{
    internal class Staff
    {

        public static string constring = ConfigurationManager.ConnectionStrings["Constring"].ToString();
        SqlConnection con = new SqlConnection(constring);
        public void OpenCon()
        {
            con.Open();
        }
        public void CloseCon()
        {
            con.Close();
        }
        public void NonQueryExecuter(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }

    }
}
