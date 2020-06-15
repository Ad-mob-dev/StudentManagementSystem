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
    public partial class Sattendance : UserControl
    {
        public Sattendance()
        {
            InitializeComponent();
        }

        private void Sattendance_Load(object sender, EventArgs e)
        {

            try
            {
                ShowAttn("Select * from Attendance Where StudentId = '" + Global.StudentId + "'", dataGridView1);
                  if(dataGridView1.Rows[0].Cells[0].Value == null)
                {
                  
                    dataGridView1.Hide();
                    pictureBox1.Hide();
                 
                    panel1.Show();
                    ERRORlabel.Show();

                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error Occured", ex.ToString());
            }
            
        }



        public void ShowAttn(String Query, DataGridView DGV)

        {
            SqlConnection Sq = new SqlConnection(Global.ConString);
            SqlDataAdapter sda = new SqlDataAdapter(Query, Sq);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGV.DataSource = dt;
            DGV.ReadOnly = true;


        }

        private void ERRORlabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Attendance")
            {
                if (Convert.ToString(e.Value) == "P" || Convert.ToString(e.Value) == "p")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if( Convert.ToString(e.Value) == "A" || Convert.ToString(e.Value) == "a")
                {
                    e.CellStyle.BackColor = Color.Maroon;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
    }


}