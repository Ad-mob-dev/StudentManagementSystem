using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SMenu : Form
    {
        public SMenu()
        {
            InitializeComponent();
                
        }

        private void SMenu_Load(object sender, EventArgs e)
        {
            StudentIdStripStatusLbl.Text = Global.StudentId.ToString();
            StudentNameStripLbl.Text = Global.StudentName;
         
            studentMakeUpClass1.Hide();
            studentRegisteredCourses.Hide();
            studentResults1.Hide();
            sattendance1.Hide();
            smms1.Show();
            smms1.BringToFront();

        }



        private void classesScheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            studentRegisteredCourses.Hide();
            studentResults1.Hide();
            smms1.Hide();
            sattendance1.Hide();
            studentMakeUpClass1.Show();
            studentMakeUpClass1.BringToFront();
           
        }

        private void AddRecordsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            studentMakeUpClass1.Hide();
            studentResults1.Hide();
            smms1.Hide();
            sattendance1.Hide();
            studentRegisteredCourses.Show();
            studentRegisteredCourses.BringToFront();

        }

        private void StudentIdStripStatusLbl_Click(object sender, EventArgs e)
        {

      
        }

        private void marksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            studentMakeUpClass1.Hide();
            studentRegisteredCourses.Hide();
            smms1.Hide();
            sattendance1.Hide();
            studentResults1.Show();
            studentResults1.BringToFront();
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentResults1_Load(object sender, EventArgs e)
        {

        }

        private void attendanceInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentMakeUpClass1.Hide();
            studentRegisteredCourses.Hide();
            smms1.Hide();
            studentResults1.Hide();
            sattendance1.Show();
            sattendance1.BringToFront();
        }
    }
}
