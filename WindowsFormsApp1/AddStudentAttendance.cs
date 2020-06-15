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
    public partial class AddStudentAttendance : UserControl
    {
        SqlDataAdapter sd;
        SqlConnection sq;
        DataTable dt;
        SqlCommand cmd;

        public AddStudentAttendance()
        {
            InitializeComponent();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            ShowDatatoGrid("Select * From Attendance", dataGridView2);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ClearSelection();
                sq = new SqlConnection(Global.ConString);
                cmd = new SqlCommand("Select RecordId,Batch,StudentId,StudentName,Semester,CourseId,CourseTitle,Date,Attendance From Attendance where Batch ='" + MarkByComboBox.Text.ToString() + "'", sq);
                //   cmd = new SqlCommand(" Select Attendance.StudentId, Attendance.StudentName , Attendance.[Date],Attendance.Attendance,dbo.StudentRegistry.Semester from Attendance inner join dbo.StudentRegistry on dbo.StudentRegistry.StudentId = Attendance.StudentId where StudentRegistry.Semester ='"+comboBox1.Text.ToString()+"' ",sq);

                sq.Open();

                sd = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sd.Fill(dt);
                StudentId.ReadOnly = true;
                StudentName.ReadOnly = true;
                Semester.ReadOnly = false;
                Batch.ReadOnly = true;
                RecordId.ReadOnly = true;

                dataGridView1.Columns["RecordId"].Visible = false;
                dataGridView1.Columns["Batch"].DisplayIndex = 0;
                dataGridView1.Columns["StudentId"].DisplayIndex = 1;
                dataGridView1.Columns["StudentName"].DisplayIndex = 2;
                dataGridView1.Columns["Semester"].DisplayIndex = 3;
                dataGridView1.Columns["CourseId"].DisplayIndex = 4;
                dataGridView1.Columns["CourseTitle"].DisplayIndex = 5;
                dataGridView1.Columns["Date"].DisplayIndex = 6;
                dataGridView1.Columns["Attendance"].DisplayIndex = 7;

                RecordId.DataPropertyName = dt.Columns["RecordId"].ToString();
                Batch.DataPropertyName = dt.Columns["Batch"].ToString();
                StudentId.DataPropertyName = dt.Columns["StudentId"].ToString();
                StudentName.DataPropertyName = dt.Columns["StudentName"].ToString();
                Semester.DataPropertyName = dt.Columns["Semester"].ToString();
                CourseId.DataPropertyName = dt.Columns["CourseId"].ToString();
                CourseTitle.DataPropertyName = dt.Columns["CourseTitle"].ToString();
                Date.DataPropertyName = dt.Columns["Date"].ToString();
                Attendance.DataPropertyName = dt.Columns["Attendance"].ToString();


                dataGridView1.DataSource = dt;
                sq.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error Occured " + ex);
            }

        }

        private void dateTimePickerAttnd_ValueChanged(object sender, EventArgs e)
        {
            String t = dateTimePickerAttnd.Text.ToString();
            MessageBox.Show(t);
            if (dateTimePickerAttnd.Text.ToString().Equals(dateTimePickerAttnd.Text.ToString()))
            {

                try
                {
                    sq = new SqlConnection(Global.ConString);
                    //   cmd = new SqlCommand(" Select Attendance.StudentId, Attendance.StudentName , Attendance.[Date],Attendance.Attendance,dbo.StudentRegistry.Semester from Attendance inner join dbo.StudentRegistry on dbo.StudentRegistry.StudentId = Attendance.StudentId where StudentRegistry.Semester ='"+comboBox1.Text.ToString()+"' ",sq);

                    sq.Open();
                    cmd = new SqlCommand("Select RecordId,Date,StudentId,StudentName,Batch,Semester,CourseId,CourseTitle,Attendance From Attendance where Date ='" + dateTimePickerAttnd.Text.ToString() + "'", sq);

                    sd = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    sd.Fill(dt);
                    StudentId.ReadOnly = true;
                    StudentName.ReadOnly = true;
                    Semester.ReadOnly = true;
                    Batch.ReadOnly = true;
                    dataGridView1.Columns["Attendance"].DefaultCellStyle.BackColor = Color.Maroon;
                    dataGridView1.Columns["Attendance"].DefaultCellStyle.ForeColor = Color.White;

                    dataGridView1.Columns["RecordId"].Visible = false;
                    dataGridView1.Columns["Date"].DisplayIndex = 0;
                    dataGridView1.Columns["StudentId"].DisplayIndex = 1;
                    dataGridView1.Columns["StudentName"].DisplayIndex = 2;
                    dataGridView1.Columns["Batch"].DisplayIndex = 3;
                    dataGridView1.Columns["Semester"].DisplayIndex = 4;
                    dataGridView1.Columns["CourseId"].DisplayIndex = 5;
                    dataGridView1.Columns["CourseTitle"].DisplayIndex = 6;
                    dataGridView1.Columns["Attendance"].DisplayIndex = 7;


                    RecordId.DataPropertyName = dt.Columns["RecordId"].ToString();
                    Date.DataPropertyName = dt.Columns["Date"].ToString();
                    StudentId.DataPropertyName = dt.Columns["StudentId"].ToString();
                    StudentName.DataPropertyName = dt.Columns["StudentName"].ToString();
                    CourseId.DataPropertyName = dt.Columns["CourseId"].ToString();
                    CourseTitle.DataPropertyName = dt.Columns["CourseTItle"].ToString();
                    Attendance.DataPropertyName = dt.Columns["Attendance"].ToString();
                    Semester.DataPropertyName = dt.Columns["Semester"].ToString();
                    Batch.DataPropertyName = dt.Columns["Batch"].ToString();

                    dataGridView1.DataSource = dt;
                    sq.Close();

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Some Error Occured " + ex);
                }


            }


        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommandBuilder SCB = new SqlCommandBuilder(sd);
                sd.Update(dt);
                MessageBox.Show("Attendance Marked ");
                ShowDatatoGrid("Select * From Attendance", dataGridView2);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }

        }

        public void ShowDatatoGrid(String query, DataGridView DataG)
        {
            sq = new SqlConnection(Global.ConString);
            sd = new SqlDataAdapter(query, sq);
            dt = new DataTable();
            sd.Fill(dt);
            DataG.DataSource = dt;



        }

        private void textBoxMByName_TextChanged(object sender, EventArgs e)
        {


            try
            {

                sq = new SqlConnection(Global.ConString);
                //   cmd = new SqlCommand(" Select Attendance.StudentId, Attendance.StudentName , Attendance.[Date],Attendance.Attendance,dbo.StudentRegistry.Semester from Attendance inner join dbo.StudentRegistry on dbo.StudentRegistry.StudentId = Attendance.StudentId where StudentRegistry.Semester ='"+comboBox1.Text.ToString()+"' ",sq);

                sq.Open();
                cmd = new SqlCommand("Select RecordId,StudentName,StudentId,Batch,Semester,CourseId,CourseTitle,Date,Attendance From Attendance where StudentName ='" + textBoxMByName.Text.ToString() + "'", sq);

                sd = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sd.Fill(dt);
                StudentId.ReadOnly = true;
                StudentName.ReadOnly = true;
                Semester.ReadOnly = true;
                Batch.ReadOnly = true;
                dataGridView1.Columns["Attendance"].DefaultCellStyle.BackColor = Color.Maroon;
                dataGridView1.Columns["Attendance"].DefaultCellStyle.ForeColor = Color.White;

                dataGridView1.Columns["RecordId"].Visible = false;
                dataGridView1.Columns["StudentName"].DisplayIndex = 0;
                dataGridView1.Columns["StudentId"].DisplayIndex = 1;
                dataGridView1.Columns["Batch"].DisplayIndex = 2;
                dataGridView1.Columns["Semester"].DisplayIndex = 3;
                dataGridView1.Columns["CourseId"].DisplayIndex = 4;
                dataGridView1.Columns["CourseTitle"].DisplayIndex = 5;
                dataGridView1.Columns["Date"].DisplayIndex = 6;
                dataGridView1.Columns["Attendance"].DisplayIndex = 7;



                RecordId.DataPropertyName = dt.Columns["RecordId"].ToString();
                Date.DataPropertyName = dt.Columns["Date"].ToString();
                StudentId.DataPropertyName = dt.Columns["StudentId"].ToString();
                StudentName.DataPropertyName = dt.Columns["StudentName"].ToString();

                Attendance.DataPropertyName = dt.Columns["Attendance"].ToString();
                Semester.DataPropertyName = dt.Columns["Semester"].ToString();
                CourseId.DataPropertyName = dt.Columns["CourseId"].ToString();
                CourseTitle.DataPropertyName = dt.Columns["CourseTitle"].ToString();
                Batch.DataPropertyName = dt.Columns["Batch"].ToString();
                dataGridView1.DataSource = dt;
                sq.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show("Some Error Occured " + ex);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            changeGridLogic(dataGridView1, e);

        }




        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            changeGridLogic(dataGridView2, e);
        }

        public void changeGridLogic(DataGridView DG, DataGridViewCellFormattingEventArgs e)
        {
            if (DG.Columns[e.ColumnIndex].Name == "Attendance")
            {
                if (Convert.ToString(e.Value) == "P" || Convert.ToString(e.Value) == "p")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToString(e.Value) == "A" || Convert.ToString(e.Value) == "a")
                {
                    e.CellStyle.BackColor = Color.Maroon;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }

        }
    }
}

