using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacare
{
    public class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-SOEEDMU2\\SQLEXPRESS;database=pharmacare;integrated security=True";
            return con;
        }
        public DataSet getData(String query)//fetch data from database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string msg)
        {
           
                SqlConnection con = getConnection();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;
                con.Open();
                //cmd.CommandText = query;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
       
        }
    }
}
//chnages