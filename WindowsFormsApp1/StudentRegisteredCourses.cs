using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentRegisteredCourses : UserControl
    {
        public StudentRegisteredCourses()
        {
            InitializeComponent();
        }
        void ShowCourses(String Query,DataGridView DGV)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS10;Initial Catalog = tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGV.DataSource = dt;
            DGV.ReadOnly = true;
            DGV.AutoResizeColumn(0);
            DGV.AutoResizeColumn(1);
            DGV.AutoResizeColumn(2);
            DGV.AutoResizeColumn(3);
            DGV.AutoResizeColumn(4);
            DGV.AutoResizeColumn(5);
            DGV.AutoResizeColumn(6);

        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            ShowCourses("Select * from Cdetails Where Semester ='" +Global.Semester+"'", DataGridView2);

        }
        

     
    }
}
