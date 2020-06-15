using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class FClassScheduleUC : UserControl
    {
      String mycon= @"Data Source = AD-PC\SQLEXPRESS10; Initial Catalog = tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public FClassScheduleUC()
        {
            InitializeComponent();

            Showclass();
        }

        private void FCSclsbtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            Showclass();
        }


        private void FCSinstBtn_Click(object sender, EventArgs e)
        {



            if (DateTimePickerMCS.Text.Length != 0 || FCSDaytextBox.Text.Length !=0 || FCSTchTetBox.Text.Length != 0 || FCSRoomTextBox.Text.Length != 0 || FCSTimtextBox.Text.Length != 0 || FCSCoursTTextBox.Text.Length != 0) {

                try
                {
                    String Day = FCSDaytextBox.Text;
                    DateTime Date = Convert.ToDateTime(DateTimePickerMCS.Text);
                    String Time = FCSTimtextBox.Text;
                    int Room = Int32.Parse(FCSRoomTextBox.Text);
                    int CourseId = Int32.Parse(FCSCidtextBox.Text);
                    String CourseTitle = FCSCoursTTextBox.Text;
                    String Batch = FMCSbatchtxtbox.Text;
                    String Semester = FMCSSemesterTxtbox.Text;
                    String Teacher = FCSTchTetBox.Text;
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    string insertquery = "insert into makeupSchedule(Day,Date,Time,Room,CourseId, CourseTitle, Batch,Semester,Teacher) values('"+Day+ "','" +Date+"' ,'" + Time + "','" + Room + "','"+CourseId+"','" + CourseTitle + "','"+Batch+"','"+Semester+"','" + Teacher + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show( CourseTitle + "Make up Classes Inserted into Records");
                        Showclass();
                        ClearTextBox();
                       
                    }
                    else
                    {
                        MessageBox.Show(CourseTitle+":: Failed to Enter in Records" );
                    }
                    con.Close();




                }
                catch (System.Exception Exp)
                {
                    MessageBox.Show("Error Occured While Processing Request" + Exp);
                }


            }
       
        }
        // own Class Section

        public void ClearTextBox()
        {
            FCSDaytextBox.Text = "";
            DateTimePickerMCS.Text = "";
            FCSTimtextBox.Text = "";
            FCSRoomTextBox.Text = "";
            FCSTchTetBox.Text = "";
            FCSCidtextBox.Text = "";
            FMCSSemesterTxtbox.Text = "";
            FMCSbatchtxtbox.Text = "";
            FCSCoursTTextBox.Text = "";

        }
        public  void Showclass()

        {
           SqlConnection con = new SqlConnection(mycon);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from  makeupSchedule", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FCSdataGridView.DataSource = dt;
        }

        private void FCSupdbtn_Click(object sender, EventArgs e)
        {
            if (DateTimePickerMCS.Text.Length != 0 || FCSDaytextBox.Text.Length != 0 || FCSTchTetBox.Text.Length != 0 || FCSRoomTextBox.Text.Length != 0 || FCSTimtextBox.Text.Length != 0 || FCSCoursTTextBox.Text.Length != 0)
            {

                try
                {
                    string Day = FCSDaytextBox.Text;
                   DateTime Date = Convert.ToDateTime(DateTimePickerMCS.Text);
                    string Time = FCSTimtextBox.Text;
                    int Room = Int32.Parse(FCSRoomTextBox.Text);
                    int CourseId = Int32.Parse(FCSCidtextBox.Text);
                    string CourseTitle = FCSCoursTTextBox.Text;
                    String Batch = FMCSbatchtxtbox.Text;
                    String Semester = FMCSSemesterTxtbox.Text;
                    string Teacher = FCSTchTetBox.Text;
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    string query = "update makeupSchedule set Day = '"+Day+"', Date='"+Date+"',Time ='"+Time+"', Room ='"+Room+"',CourseId ='" +CourseId+ "',CourseTitle ='" + CourseTitle + "',Batch ='"+Batch+"',Semester='"+Semester+"',Teacher ='" + Teacher + "' Where CourseId ='" +CourseId+"' AND Semester ='"+Semester+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Records Updated");
                        Showclass();
                        ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Record Updation Failed");
                    }
                    con.Close();
                }
                catch (System.Exception exp)
                {

                    MessageBox.Show("Some Error Occured at MakeupSchedule Updation" + exp.ToString());
                }
            }

           }

        private void FCSdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FCSDaytextBox.Text = FCSdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            DateTimePickerMCS.Text = FCSdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            FCSTimtextBox.Text = FCSdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            FCSRoomTextBox.Text = FCSdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            FCSCidtextBox.Text = FCSdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            FCSCoursTTextBox.Text = FCSdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            FMCSbatchtxtbox.Text = FCSdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            FMCSSemesterTxtbox.Text = FCSdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            FCSTchTetBox.Text = FCSdataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void FCSdltbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon);
            if(FCSCidtextBox.Text.Length != 0)
            {
               
                try
                {
                    /* 
                      DateTime Date = Convert.ToDateTime(DateTimePickerMCS);
                      String Time = FCSTimtextBox.Text;
                       int Room = Int32.Parse(FCSRoomTextBox.Text);
                       String CourseTitle = FCSCoursTTextBox.Text;
                      String Teacher = FCSTchTetBox.Text;
                      */
                    int CourseId = Int32.Parse(FCSCidtextBox.Text);
                    String Day = FCSDaytextBox.Text;
                    con.Open();
                    String DeleteMakeUpClassQuery = "Delete makeupSchedule where CourseId='"+CourseId+ "'  AND Day ='" + Day + "'";
                    SqlCommand cmd = new SqlCommand(DeleteMakeUpClassQuery, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Record with CourseId '" + CourseId + "' has been Deleted");
                        ClearTextBox();
                        Showclass();
                    }
                    else
                    {

                        MessageBox.Show("Record with CourseId '" + CourseId + "'is not Deleted");

                    }
                    con.Close();
                }catch(System.Exception exp)
                {
                    MessageBox.Show("Some Error Occured While Deleting" +exp);

                }






            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
                
           