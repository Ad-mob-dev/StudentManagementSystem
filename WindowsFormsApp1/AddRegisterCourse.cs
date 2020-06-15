using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FAddCourseControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS10;Initial Catalog = tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        public FAddCourseControl()
        {

            InitializeComponent();
            ShowCourses();
            ClearTextBoxes();
        }



        private void FcourseNewBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ShowCourses();

        }

        private void FCourseInsertBtn_Click(object sender, EventArgs e)
        {
             if (CID.Text.Length != 0 || CTITLE.Text.Length != 0 || CHRS.Text.Length != 0 || TTABLE.Text.Length != 0 || CAMT.Text.Length != 0)
            {

                try
                {
                    int CourseId = Int32.Parse(CID.Text);
                    string CourseTitle = CTITLE.Text;
                    int CreditHrs = Int32.Parse(CHRS.Text);
                    string TimeTable = TTABLE.Text;
                    int Amount = Int32.Parse(CAMT.Text);
                    string Batch = FSCRBatchtxtbox.Text;
                    string Semester = FSCRSemestertxtbix.Text;
                    con.Open();
                    string qry = "Insert into Cdetails(CourseId,CourseTitle,CreditHours,TimeTable,Batch,Semester,Amount) values('" + CourseId + "','" + CourseTitle + "','" + CreditHrs + "','" + TimeTable + "','"+Batch+"','"+Semester+"', '" + Amount + "' )";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show( CourseTitle + ":: Inserted into Course Records" );
                        ShowCourses();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show( CourseTitle + ":: Insertion Failed into Records" );


                    }
                    con.Close();
                }
                catch (System.Exception exp)

                {
                    MessageBox.Show("Some Error Occured at Course Insertion :" + exp.ToString());
                }


            }

        }
        public void ClearTextBoxes()
        {
            this.CID.Text = "";
            this.CTITLE.Text = "";
            this.CHRS.Text = "";
            this.TTABLE.Text = "";
            this.FSCRBatchtxtbox.Text = "";
            this.FSCRSemestertxtbix.Text = "";
            this.CAMT.Text = "";
          
        }
        public void ShowCourses()
        {
         
            SqlDataAdapter sda = new SqlDataAdapter("select * from Cdetails",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CTITLE.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CHRS.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            TTABLE.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            FSCRBatchtxtbox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            FSCRSemestertxtbix.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            CAMT.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void FCourseUpdateBtn_Click(object sender, EventArgs e)
        {
            if (CID.Text.Length != 0 )
            {

                try
                {
                    int CourseId = Int32.Parse(CID.Text);
                    string CourseTitle = CTITLE.Text;
                    int CreditHrs = Int32.Parse(CHRS.Text);
                    string TimeTable = TTABLE.Text;
                    string Batch = FSCRBatchtxtbox.Text;
                    string Semester = FSCRSemestertxtbix.Text;
                    int Amount = Int32.Parse(CAMT.Text);
                    con.ClientConnectionId.ToString();
                    con.Open();
                    string qry = "update Cdetails set CourseTitle ='" + CourseTitle + "', CreditHours ='" + CreditHrs + "',TimeTable ='" + TimeTable + "',Batch='" + Batch + "',Semester ='" + Semester + "', Amount='" + Amount + "'  where CourseId = '"+CourseId+"'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show(+CourseId+":: Updated ");
                        ClearTextBoxes();
                        ShowCourses();
                       
                    }
                    else
                    {
                        MessageBox.Show("Course Updation Failed into :" + CourseId);


                    }
                    con.Close();
                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Some Error Occured at Course Insertion :" + exp);
                }


            }
        }

        private void FCourseDeleteBtn_Click(object sender, EventArgs e)
        {
            if (CID.Text.Length != 0)
            {

                try
                {
                    int CourseId = Int32.Parse(CID.Text);
                    string CourseTitle = CTITLE.Text;
                    int CreditHrs = Int32.Parse(CHRS.Text);
                    string TimeTable = TTABLE.Text;
                    string Batch = FSCRBatchtxtbox.Text.ToString();
                    string Semester = FSCRSemestertxtbix.Text.ToString();
                    int Amount = Int32.Parse(CAMT.Text);
                    
                    con.Open();
                    string qry = "Delete Cdetails where CourseId = '" + CourseId + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("'"+CourseTitle+"'::  Deleted");
                        ShowCourses();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Course Deleted into :" + CourseId);


                    }
                    con.Close();
                }
                catch (System.Exception exp)

                {
                    MessageBox.Show("Some Error Occured at Course Insertion :" + exp.ToString());
                }


            }
        }

        
    }
}