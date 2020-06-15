using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
   
    public partial class FGenerateResult : UserControl
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;

        public FGenerateResult()
        {
            
            InitializeComponent();
            ShowGR("Select * from Gpa",dataGridView1);
            ShowGR("Select * from TotalCourseMarks",dataGridView2);
        }


     public void ShowGR( string Selectquery , DataGridView Data )
        {
            
            con = new SqlConnection(Global.ConString);
           sda = new SqlDataAdapter(Selectquery, con);
             dt = new DataTable();
            sda.Fill(dt);
          Data.DataSource = dt;
        }

        public void ClearTextBox()
        {
            GRStudentIdtxt.Text = "";
            GRStudentNameTxt.Text = "";
            GRStudentBatch.Text = "";
            GRStudentSemester.Text = "";
            GRChrs1.Text = "";
            GRChrs2.Text = "";
            GRChrs3.Text = "";
            GRChrs4.Text = "";
            GRChrs5.Text = "";
            GRChrs6.Text = "";
            GRCid1.Text = "";
            GRCid2.Text = "";
            GRCid3.Text = "";
            GRCid4.Text = "";
            GRCid5.Text = "";
            GRCid6.Text = "";
            GRCT1.Text = "";
            GRCT2.Text = "";
            GRCT3.Text = "";
            GRCT4.Text = "";
            GRCT5.Text = "";
            GRCT6.Text = "";
            GRtm1.Text = "";
            GRtm2.Text = "";
            GRtm3.Text = "";
            GRtm4.Text = "";
            GRtm5.Text = "";
            GRtm6.Text = "";
            GRSubject1.Text = "";
            GRSubject2.Text = "";
            GRSubject3.Text = "";
            GRSubject4.Text = "";
            GRSubject5.Text = "";
            GRSubject6.Text = "";
            GRGP1.Text = "";
            GRGP2.Text = "";
            GRGP3.Text = "";
            GRGP4.Text = "";
            GRGP5.Text = "";
            GRGP6.Text = "";
            GRGPAtxt.Text = "";
            GRGPTOTL.Text = "";
            OBTMTOTAL.Text = "";
            TMTOTAL.Text = "";
            CHRSTOTAL.Text = "";
            GRG1.Text = "";
            GRG2.Text = "";
            GRG3.Text = "";
            GRG4.Text = "";
            GRG5.Text = "";
            GRG6.Text = "";
        }
      

        public void grade(int s11, TextBox t, TextBox p )
        {
            
            if (s11 >= 85 && s11 <= 100)
            {
               t.Text = "A";
                p.Text = "4.00";
            
                t.ForeColor = Color.Green;

           }
            else if (s11 >= 80 && s11 <= 84)
            {
                t.Text = "A-";
                p.Text = "3.70";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 75 && s11 <= 79)
            {
                t.Text = "B+";
                p.Text = "3.70";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 71 && s11 <= 74)
            {
                t.Text = "B";
                p.Text = "3.50";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 68 && s11 <= 70)
            {
                t.Text = "B-";
                p.Text = "3.20";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 64 && s11 <= 67)
            {
                p.Text = "3.00";
                t.Text = "C+";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 61 && s11 <= 63)
            {
                p.Text = "2.70";
                t.Text = "C";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 58 && s11 <= 60)
            {
                p.Text = "2.50";
                t.ForeColor = Color.Green;
                t.Text = "C-";
             
            }
            else if (s11 >= 54 && s11 <= 57)
            {
                p.Text = "2.20";
                t.Text = "D+";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 50 && s11 <= 53)
            {
                p.Text = "1.00";
                t.Text = "D";
                t.ForeColor = Color.Green;

            }
            else if (s11 >= 0 && s11 <= 49)
            {
                p.Text = "0.00";
                t.ForeColor = Color.Red;
                t.Text = "F";

            }

        }

        private void FGenerateResult_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) 
        {
            
            if (GRStudentIdtxt.Text.Length !=0 || GRStudentNameTxt.Text.Length != 0)
            {
                try
                {
                    int StudentId = Int32.Parse(GRStudentIdtxt.Text);
                    String StudentName = GRStudentNameTxt.Text;
                    String Batch = GRStudentBatch.Text;
                    String Semester = GRStudentSemester.Text;
                    int s1, s2, s3, s4, s5, s6;
                    int ch1, ch2, ch3, ch4, ch5, ch6;
                    int cid1, cid2, cid3, cid4, cid5, cid6;
                    String ct1, ct2, ct3, ct4, ct5, ct6;
                    int tm1, tm2, tm3, tm4, tm5, tm6;
                    s1 = Int32.Parse(GRSubject1.Text);
                    s2 = Int32.Parse(GRSubject2.Text);
                    s3 = Int32.Parse(GRSubject3.Text);
                    s4 = Int32.Parse(GRSubject4.Text);
                    s5 = Int32.Parse(GRSubject5.Text);
                    s6 = Int32.Parse(GRSubject6.Text);
                    ch1 = Int32.Parse(GRChrs1.Text);
                    ch2 = Int32.Parse(GRChrs2.Text);
                    ch3 = Int32.Parse(GRChrs3.Text);
                    ch4 = Int32.Parse(GRChrs4.Text);
                    ch5 = Int32.Parse(GRChrs5.Text);
                    ch6 = Int32.Parse(GRChrs6.Text);
                    tm1 = Int32.Parse(GRtm1.Text);
                    tm2 = Int32.Parse(GRtm2.Text);
                    tm3 = Int32.Parse(GRtm3.Text);
                    tm4 = Int32.Parse(GRtm4.Text);
                    tm5 = Int32.Parse(GRtm5.Text);
                    tm6 = Int32.Parse(GRtm6.Text);
                    cid1 = Int32.Parse(GRCid1.Text);
                    cid2 = Int32.Parse(GRCid2.Text);
                    cid3 = Int32.Parse(GRCid3.Text);
                    cid4 = Int32.Parse(GRCid4.Text);
                    cid5 = Int32.Parse(GRCid5.Text);
                    cid6 = Int32.Parse(GRCid6.Text);
                    ct1 = GRCT1.Text;
                    ct2 = GRCT2.Text;
                    ct3 = GRCT3.Text;
                    ct4 = GRCT4.Text;
                    ct5 = GRCT5.Text;
                    ct6 = GRCT6.Text;
                    grade(s1, GRG1, GRGP1);
                    grade(s2, GRG2, GRGP2);
                    grade(s3, GRG3, GRGP3);
                    grade(s4, GRG4, GRGP4);
                    grade(s5, GRG5, GRGP5);
                    grade(s6, GRG6, GRGP6);
                    float GP1 = float.Parse(GRGP1.Text);
                    float GP2 = float.Parse(GRGP2.Text);
                    float GP3 = float.Parse(GRGP3.Text);
                    float GP4 = float.Parse(GRGP4.Text);
                    float GP5 = float.Parse(GRGP5.Text);
                    float GP6 = float.Parse(GRGP6.Text);
                    string grd1 = GRG1.Text;
                    string grd2 = GRG2.Text;
                    string grd3 = GRG3.Text;
                    string grd4 = GRG4.Text;
                    string grd5 = GRG5.Text;
                    string grd6 = GRG6.Text;
                    int cidR = Convert.ToInt32(cid1 + cid2 + cid3 + cid4 + cid5 + cid6);
                    int tmr = Convert.ToInt32(tm1 + tm2 + tm3 + tm4 + tm5 + tm6);
                    int sr = Convert.ToInt32(s1 + s2 + s3 + s4 + s5 + s6);
                    int chr = Convert.ToInt32(ch1 + ch2 + ch3 + ch4 + ch5);
                    float gpoint = Convert.ToSingle(GP1 + GP2 + GP3 + GP4 + GP5 + GP6);
                    float gpa = gpoint / 6;
                    GRGPAtxt.Text = gpa.ToString();
                    CHRSTOTAL.Text = chr.ToString();
                    TMTOTAL.Text = tmr.ToString();
                    OBTMTOTAL.Text = sr.ToString();
                    GRGPTOTL.Text = gpoint.ToString();
                    string GPA = GRGPAtxt.Text = string.Format("{0:.00}", gpa);
                    string GPTOTAL = GRGPTOTL.Text = string.Format("{0:.00}", GP1 + GP2 + GP3 + GP4 + GP5 + GP6);
                    float GPttl = Convert.ToSingle(GRGPTOTL.Text);
                    int CTOTAL = Convert.ToInt32(CHRSTOTAL.Text);
                    int TM = Convert.ToInt32(TMTOTAL.Text);
                    int TOM = Convert.ToInt32(OBTMTOTAL.Text);
                    gpa = Convert.ToSingle(GRGPAtxt.Text);

                    SqlConnection con = new SqlConnection(Global.ConString);
                    con.Open();
                    string insertqueryDatagrid2 = "insert into TotalCourseMarks(StudentId,StudentName,Batch,Semester,CourseId1,CourseTitle1,CreditHours1,ObtainedMarks1,TotalMarks1," +
                       "CourseId2,CourseTitle2,CreditHours2,ObtainedMarks2,TotalMarks2,CourseId3,CourseTitle3,CreditHours3,ObtainedMarks3,TotalMarks3," +
                       "CourseId4,CourseTitle4,CreditHours4,ObtainedMarks4,TotalMarks4,CourseId5,CourseTitle5,CreditHours5,ObtainedMarks5,TotalMarks5," +
                       "CourseId6,CourseTitle6,CreditHours6,ObtainedMarks6,TotalMarks6)" +
                       " values" +
                       "('" + StudentId + "','" + StudentName + "','" + Batch + "','" + Semester + "','" + cid1 + "','" + ct1 + "','" + ch1 + "','" + s1 + "','" + tm1 + "'," +
                       "'" + cid2 + "','" + ct2 + "','" + ch2 + "','" + s2 + "','" + tm2 + "','" + cid3 + "','" + ct3 + "','" + ch3 + "','" + s3 + "','" + tm3 + "'," +
                       "'" + cid4 + "','" + ct4 + "','" + ch4 + "','" + s4 + "','" + tm4 + "','" + cid5 + "','" + ct5 + "','" + ch5 + "','" + s5 + "','" + tm5 + "','" + cid6 + "','" + ct6 + "','" + ch6 + "','" + s6 + "','" + tm6 + "')";


                    using (SqlCommand cmd1 = new SqlCommand(insertqueryDatagrid2, con))
                    {
                        int i = cmd1.ExecuteNonQuery();
                        if (i >= 1)
                        {

                            ShowGR("Select * from TotalCourseMarks", dataGridView2);

                        }
                        else
                        {
                            MessageBox.Show("Insertion with StudentId : '" + StudentId + "' Failed into Course Records Section:" );
                        }
                        con.Close();
                    }

                    string insertqueryDatagrid1 = "insert into Gpa(StudentId,StudentName,Batch,Semester,CreditHours,TotalMarks,ObtainedMarks,GradePoint,Gpa) values('" + StudentId + "','" + StudentName + "','" + Batch + "','" + Semester + "','" + CTOTAL + "','" + TM + "','" + TOM + "','" + GPttl + "','" + gpa + "')";
                    using (SqlCommand cmd = new SqlCommand(insertqueryDatagrid1, con))
                    {
                        con.Open();
                        int j = cmd.ExecuteNonQuery();
                        if (j >= 1)
                        {
                            MessageBox.Show("Results Generated for StudentId : '" + StudentId + "'");
                            ShowGR("Select * from Gpa", dataGridView1);
                          

                        }
                        else
                        {
                            MessageBox.Show("Insertion with StudentId : '" + StudentId + "' Failed into GPA Records Section");
                        }
                        con.Close();
                    }





                    

                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Some Error Occured : while Entering Please Check the Error Code Below:" + exp);
                }


            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
            ShowGR("Select * from Gpa", dataGridView1);
            ShowGR("Select * from TotalCourseMarks", dataGridView2);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                GRStudentIdtxt.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                GRStudentNameTxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                GRStudentBatch.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                GRStudentSemester.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();

                GRCid1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                GRCT1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                GRChrs1.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                GRSubject1.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                GRtm1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
           
                GRCid2.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
                GRCT2.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
                GRChrs2.Text = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
                GRSubject2.Text = dataGridView2.SelectedRows[0].Cells[12].Value.ToString();
                GRtm2.Text = dataGridView2.SelectedRows[0].Cells[13].Value.ToString();

                GRCid3.Text = dataGridView2.SelectedRows[0].Cells[14].Value.ToString();
                GRCT3.Text = dataGridView2.SelectedRows[0].Cells[15].Value.ToString();
                GRChrs3.Text = dataGridView2.SelectedRows[0].Cells[16].Value.ToString();
                GRSubject3.Text = dataGridView2.SelectedRows[0].Cells[17].Value.ToString();
                GRtm3.Text = dataGridView2.SelectedRows[0].Cells[18].Value.ToString();


                GRCid4.Text = dataGridView2.SelectedRows[0].Cells[19].Value.ToString();
                GRCT4.Text = dataGridView2.SelectedRows[0].Cells[20].Value.ToString();
                GRChrs4.Text = dataGridView2.SelectedRows[0].Cells[21].Value.ToString();
                GRSubject4.Text = dataGridView2.SelectedRows[0].Cells[22].Value.ToString();
                GRtm4.Text = dataGridView2.SelectedRows[0].Cells[23].Value.ToString();

                GRCid5.Text = dataGridView2.SelectedRows[0].Cells[24].Value.ToString();
                GRCT5.Text = dataGridView2.SelectedRows[0].Cells[25].Value.ToString();
                GRChrs5.Text = dataGridView2.SelectedRows[0].Cells[26].Value.ToString();
                GRSubject5.Text = dataGridView2.SelectedRows[0].Cells[27].Value.ToString();
                GRtm5.Text = dataGridView2.SelectedRows[0].Cells[28].Value.ToString();

                GRCid6.Text = dataGridView2.SelectedRows[0].Cells[29].Value.ToString();
                GRCT6.Text = dataGridView2.SelectedRows[0].Cells[30].Value.ToString();
                GRChrs6.Text = dataGridView2.SelectedRows[0].Cells[31].Value.ToString();
                GRSubject6.Text = dataGridView2.SelectedRows[0].Cells[32].Value.ToString();
                GRtm6.Text = dataGridView2.SelectedRows[0].Cells[33].Value.ToString();

                       
        }        
            /*foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int index = Int32.Parse(row.Index.ToString());
                MessageBox.Show("Erow" + e.RowIndex);
                MessageBox.Show("Index " + e.RowIndex);

                try
                {
                    GRStudentIdtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    GRStudentNameTxt.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    GRCid1.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    GRCT1.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs1.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm1.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject1.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    index++;
                    GRCid2.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    GRCT2.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs2.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm2.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject2.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    index++;
                    GRCid3.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    GRCT3.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs3.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm3.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject3.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    index++;
                    GRCid4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    GRCT4.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs4.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm4.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject4.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    index++;
                    GRCid5.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    GRCT5.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs5.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm5.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject5.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    index++;
                    GRCid6.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    GRCT6.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    GRChrs6.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    GRtm6.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    GRSubject6.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();
                }
                catch (System.NullReferenceException ex)
                {
                    string title = "Out of Range Error";
                    MessageBoxButtons btn = MessageBoxButtons.OK;


                    MessageBox.Show("You are Selecting " +
                        "Out of Range Rows" +
                        "Please Select Properly  \n Only 6 records can be Selected at Once ", title, btn, MessageBoxIcon.Warning);
                    ClearTextBox();

                }


             
            */
            
    

        private void GRStudentNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (GRStudentIdtxt.Text.Length != 0 || GRStudentNameTxt.Text.Length != 0)
            {
                try
                {
                    int StudentId = Int32.Parse(GRStudentIdtxt.Text);
                    String StudentName = GRStudentNameTxt.Text;
                    String Batch = GRStudentBatch.Text;
                    String Semester = GRStudentSemester.Text;
                    int s1, s2, s3, s4, s5, s6;
                    int ch1, ch2, ch3, ch4, ch5, ch6;
                    int cid1, cid2, cid3, cid4, cid5, cid6;
                    String ct1, ct2, ct3, ct4, ct5, ct6;
                    int tm1, tm2, tm3, tm4, tm5, tm6;
                    s1 = Int32.Parse(GRSubject1.Text);
                    s2 = Int32.Parse(GRSubject2.Text);
                    s3 = Int32.Parse(GRSubject3.Text);
                    s4 = Int32.Parse(GRSubject4.Text);
                    s5 = Int32.Parse(GRSubject5.Text);
                    s6 = Int32.Parse(GRSubject6.Text);
                    ch1 = Int32.Parse(GRChrs1.Text);
                    ch2 = Int32.Parse(GRChrs2.Text);
                    ch3 = Int32.Parse(GRChrs3.Text);
                    ch4 = Int32.Parse(GRChrs4.Text);
                    ch5 = Int32.Parse(GRChrs5.Text);
                    ch6 = Int32.Parse(GRChrs6.Text);
                    tm1 = Int32.Parse(GRtm1.Text);
                    tm2 = Int32.Parse(GRtm2.Text);
                    tm3 = Int32.Parse(GRtm3.Text);
                    tm4 = Int32.Parse(GRtm4.Text);
                    tm5 = Int32.Parse(GRtm5.Text);
                    tm6 = Int32.Parse(GRtm6.Text);
                    cid1 = Int32.Parse(GRCid1.Text);
                    cid2 = Int32.Parse(GRCid2.Text);
                    cid3 = Int32.Parse(GRCid3.Text);
                    cid4 = Int32.Parse(GRCid4.Text);
                    cid5 = Int32.Parse(GRCid5.Text);
                    cid6 = Int32.Parse(GRCid6.Text);
                    ct1 = GRCT1.Text;
                    ct2 = GRCT2.Text;
                    ct3 = GRCT3.Text;
                    ct4 = GRCT4.Text;
                    ct5 = GRCT5.Text;
                    ct6 = GRCT6.Text;
                    grade(s1, GRG1, GRGP1);
                    grade(s2, GRG2, GRGP2);
                    grade(s3, GRG3, GRGP3);
                    grade(s4, GRG4, GRGP4);
                    grade(s5, GRG5, GRGP5);
                    grade(s6, GRG6, GRGP6);
                    float GP1 = float.Parse(GRGP1.Text);
                    float GP2 = float.Parse(GRGP2.Text);
                    float GP3 = float.Parse(GRGP3.Text);
                    float GP4 = float.Parse(GRGP4.Text);
                    float GP5 = float.Parse(GRGP5.Text);
                    float GP6 = float.Parse(GRGP6.Text);
                    string grd1 = GRG1.Text;
                    string grd2 = GRG2.Text;
                    string grd3 = GRG3.Text;
                    string grd4 = GRG4.Text;
                    string grd5 = GRG5.Text;
                    string grd6 = GRG6.Text;
                    int cidR = Convert.ToInt32(cid1 + cid2 + cid3 + cid4 + cid5 + cid6);
                    int tmr = Convert.ToInt32(tm1 + tm2 + tm3 + tm4 + tm5 + tm6);
                    int sr = Convert.ToInt32(s1 + s2 + s3 + s4 + s5 + s6);
                    int chr = Convert.ToInt32(ch1 + ch2 + ch3 + ch4 + ch5);
                    float gpoint = Convert.ToSingle(GP1 + GP2 + GP3 + GP4 + GP5 + GP6);
                    float gpa = gpoint / 6;
                    GRGPAtxt.Text = gpa.ToString();
                    CHRSTOTAL.Text = chr.ToString();
                    TMTOTAL.Text = tmr.ToString();
                    OBTMTOTAL.Text = sr.ToString();
                    GRGPTOTL.Text = gpoint.ToString();
                    string GPA = GRGPAtxt.Text = string.Format("{0:.00}", gpa);
                    string GPTOTAL = GRGPTOTL.Text = string.Format("{0:.00}", GP1 + GP2 + GP3 + GP4 + GP5 + GP6);
                
                    //update dynamically
                    SqlCommandBuilder Scb = new SqlCommandBuilder(sda);
                    sda.Update(dt);

                    float GPttl = Convert.ToSingle(GRGPTOTL.Text);
                    int CTOTAL = Convert.ToInt32(CHRSTOTAL.Text);
                    int TM = Convert.ToInt32(TMTOTAL.Text);
                    int TOM = Convert.ToInt32(OBTMTOTAL.Text);
                    gpa = Convert.ToSingle(GRGPAtxt.Text);


                    SqlConnection con = new SqlConnection(Global.ConString);
                    con.Open();
                    
                    string UpdatequeryDatagrid1 = "update Gpa set StudentName ='" + StudentName +"',Batch ='"+Batch+"',Semester = '"+Semester+"', CreditHours ='" + CTOTAL + "',TotalMarks ='" + TM + "', ObtainedMarks='" + TOM + "',GradePoint ='" + GPttl + "',Gpa ='" + gpa + "' where StudentId = '" + StudentId + "'";
                  string UpdatequeryDatagrid2 = "update TotalCourseMarks set StudentName ='" + StudentName + "',Batch ='" + Batch + "',Semester = '" + Semester + "', CourseId1 ='" + cid1 + "', CourseTitle1 = '" + ct1 + "', CreditHours1 ='" + ch1 + "', ObtainedMarks1 ='" + s1 + "', TotalMarks1 ='" + tm1 + "', CourseId2='" + cid2 + "', CourseTitle2 = '" + ct2 + "', CreditHours2 ='" + ch2 + "',ObtainedMarks2='" + s2 + "', TotalMarks2 ='" + tm2 + "',CourseId3='" + cid3 + "', CourseTitle3 = '" + ct3 + "', CreditHours3 ='" + ch3 + "',ObtainedMarks3='" + s3 + "', TotalMarks3 ='" + tm3 + "', CourseId4 ='" + cid4 + "', CourseTitle4 = '" + ct4 + "', CreditHours4 ='" + ch4 + "', ObtainedMarks4 ='" + s4 + "', TotalMarks4 ='" + tm4 + "',CourseId5='" + cid5 + "', CourseTitle5 = '" + ct5 + "', CreditHours5 ='" + ch5 + "',ObtainedMarks5='" + s5 + "', TotalMarks5 ='" + tm5 + "' , CourseId6 ='" + cid6 + "', CourseTitle6 = '" + ct6 + "', CreditHours6 ='" + ch6 + "',ObtainedMarks6='" + s6 + "', TotalMarks6 ='" + tm6 + "' where StudentId = '"+StudentId+"'";
                    SqlCommand cmd = new SqlCommand(UpdatequeryDatagrid1, con);
                   SqlCommand cmd1 = new SqlCommand(UpdatequeryDatagrid2, con);

                    int i = cmd.ExecuteNonQuery();
                    int j = cmd1.ExecuteNonQuery();

                    if (i >= 1 || j >= 1 )
                    {
                        MessageBox.Show("Result Updated ID :" +StudentId);
                        ShowGR("Select * from Gpa", dataGridView1);
                        ShowGR("Select * from TotalCourseMarks", dataGridView2);

                    }
                    else
                    {
                        MessageBox.Show("Failed: ID :'"+StudentId+"' Name :'"+StudentName+"'");
                    }
                    con.Close();

                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Some Error Occured : while Entering Please Check the Error Code Below:" + exp);
                }


              
                
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           // dataGridView1.Rows[e.RowIndex].HeaderCell.Value = e.RowIndex + 1.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GRStudentIdtxt.Text.Length != 0)
            {

                try
                {

                    SqlConnection Sq = new SqlConnection(Global.ConString);
                    Sq.Open();
                    string GpaDltqry = "Delete Gpa where StudentId = '" +GRStudentIdtxt.Text+"'";
                    string MarksDltqry = "Delete TotalCourseMarks where StudentId = '" + GRStudentIdtxt.Text + "'";

                    SqlCommand GpaDltcmd = new SqlCommand(GpaDltqry, Sq);
                    SqlCommand MarksDltcmd = new SqlCommand(MarksDltqry, Sq);

                    int i = GpaDltcmd.ExecuteNonQuery();
                    int j = MarksDltcmd.ExecuteNonQuery();
                    if (i >= 1 || j >= 1)
                    {
                        MessageBox.Show("Records with Student Id ::'"+GRStudentIdtxt.Text+"'::  Deleted");
                        ShowGR("Select * from Gpa", dataGridView1);
                        ShowGR("Select * from TotalCourseMarks", dataGridView2);
                        ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Records With Student Id ::'"+GRStudentIdtxt.Text+"':: Deleted" );


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

