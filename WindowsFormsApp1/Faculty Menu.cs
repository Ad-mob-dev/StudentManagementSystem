using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            
      
            InitializeComponent();
            String a = Global.FacultyId.ToString();

            AdminStriplbl.Text = a;

        }

        private void FMenu_Load(object sender, EventArgs e)
        {   
            fClassScheduleUC1.Hide();
            fAddCourseControl1.Hide();
            fGenerateResult1.Hide();
         fmms1.Show();
          fmms1.BringToFront();
        }

        private void AddRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmms1.Hide();
            fClassScheduleUC1.Hide();
            fGenerateResult1.Hide();
            fAddCourseControl1.Show();
            fAddCourseControl1.BringToFront();
          

        }

        private void classesScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmms1.Hide();
            fClassScheduleUC1.Hide();
            fAddCourseControl1.Hide();
            fClassScheduleUC1.Show();
            fClassScheduleUC1.BringToFront();
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AdminStriplbl.ForeColor = Color.Black;
        }

        private void fmms1_Load_1(object sender, EventArgs e)
        {

        }

        private void marksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fmms1.Hide();
            fAddCourseControl1.Hide();
            fClassScheduleUC1.Hide();
            fGenerateResult1.Show();
            fGenerateResult1.BringToFront();

        }

      

        private void AttendanceInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmms1.Hide();
            fAddCourseControl1.Hide();
            fClassScheduleUC1.Hide();
            fGenerateResult1.Hide();
            AddStudentAttnd.Show();
            AddStudentAttnd.BringToFront();  
        }
        
    }
}
