using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SqlCon
    {

        String conString = @"Data Source = AD - PC\SQLEXPRESS10; Initial Catalog =tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;

        public void ConnectionOpen() {
            con = new SqlConnection(conString);
            con.Open();
        }

        public void ConnectionClose()
        {
            con.Close();
        }

        public void SqlQuery(String Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();

        }

        public object DisplayInGrid(String Query_,object data)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query_, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data = dt.TableName[0];
            return data;

        }

       
    }
}