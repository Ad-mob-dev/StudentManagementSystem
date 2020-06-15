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
    public partial class StudentResults : UserControl
    {
        public StudentResults()
        {
            InitializeComponent();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentResults_Load(object sender, EventArgs e)
        {
            try
            {
                ShowResults("Select * from Gpa where StudentId = '"+Global.StudentId+"'",dataGridView1);
                ShowResults("Select * from TotalCourseMarks where StudentId = '" + Global.StudentId + "'", dataGridView2);
                RESIZEgRID(dataGridView2);
            }
            catch(System.Exception)
            {

            }
        }

        public void ShowResults(String Query, DataGridView DGV)

        {
            SqlConnection Sq = new SqlConnection(Global.ConString);
            SqlDataAdapter sda = new SqlDataAdapter(Query, Sq);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGV.DataSource = dt;
            DGV.ReadOnly = true;
           

        }
        public void RESIZEgRID(DataGridView D)
        {
            D.AutoResizeColumn(0);
            D.AutoResizeColumn(1);
            D.AutoResizeColumn(2);
            D.AutoResizeColumn(3);
            D.AutoResizeColumn(4);
            D.AutoResizeColumn(5);
            D.AutoResizeColumn(6);
            D.AutoResizeColumn(7);
            D.AutoResizeColumn(8);
            D.AutoResizeColumn(9);
            D.AutoResizeColumn(10);
            D.AutoResizeColumn(11);
            D.AutoResizeColumn(12);
            D.AutoResizeColumn(13);
            D.AutoResizeColumn(14);
            D.AutoResizeColumn(15);
            D.AutoResizeColumn(16);
            D.AutoResizeColumn(17);
            D.AutoResizeColumn(18);
            D.AutoResizeColumn(19);
            D.AutoResizeColumn(20);
            D.AutoResizeColumn(21);
            D.AutoResizeColumn(22);
            D.AutoResizeColumn(23);
            D.AutoResizeColumn(24);
            D.AutoResizeColumn(25);
            D.AutoResizeColumn(26);
            D.AutoResizeColumn(27);
            D.AutoResizeColumn(28);
            D.AutoResizeColumn(29);
            D.AutoResizeColumn(30);
            D.AutoResizeColumn(31);
            D.AutoResizeColumn(32);
            D.AutoResizeColumn(33);
        }

    }
}
