using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        int counter = 0;
        public LoginScreen()
        {
            
            InitializeComponent();
            if (counter == 0)
            {
                SMS.Text = "Student Management System";
                SMS.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\AD\source\repos\Student Management System\WindowsFormsApp1\Resources\Blue.ico"));
                SMS.Visible = true;
                SMS.BalloonTipIcon = ToolTipIcon.Info;
                SMS.BalloonTipText = " Welcome to Student Management System ";
                SMS.BalloonTipTitle = "Click to See More Details";
                SMS.ShowBalloonTip(30);
                counter ++;
            }
        }



        private void STXTBOXID_Enter(object sender, EventArgs e)
        {
            if (STXTBOXID.Text.Equals("Student Id"))
            {
                STXTBOXID.Text = "";

            }
        }

        private void STXTBOXID_Leave(object sender, EventArgs e)
        {
            if (STXTBOXID.Text.Equals(""))
            {
                STXTBOXID.Text = "Student Id";
            }
        }

        private void STXTBOXPASS_Enter(object sender, EventArgs e)
        {
            if (STXTBOXPASS.Text.Equals("Password"))
            {
                STXTBOXPASS.Text = "";
            }
        }

        private void STXTBOXPASS_Leave(object sender, EventArgs e)
        {
            if (STXTBOXPASS.Text.Equals(""))
            {
                STXTBOXPASS.Text = "Password";
            }
        }

        private void SLGNBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS10;Initial Catalog=tlogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from StudentRegistry where StudentId = '" + STXTBOXID.Text + "' and Password='" + STXTBOXPASS.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    Global.StudentId = Int32.Parse(STXTBOXID.Text);
                    MessageBox.Show(" ID: '" + Global.StudentId + "' Successfully Logged in");
                    this.Hide();

                    SMenu f2 = new SMenu();
                    if (f2.Enabled || counter  == 1)
                    {
                        SMS.Text = "Student ID : " + Global.StudentId + " || Student Name : " + Global.StudentName + " ";
                        SMS.Visible = true;
                        SMS.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C: \Users\AD\source\repos\Student Management System\WindowsFormsApp1\Resources\Black.ico"));
                        SMS.BalloonTipText = "With : Student ID : " + Global.StudentId + "  ||  Student Name : " + Global.StudentName + "";
                        SMS.BalloonTipTitle = "You're  Successfully Logged in !! ";
                        SMS.ShowBalloonTip(100); 
                    }
                    else
                    {

                    }

                    f2.Show();


                }
                else
                {

                    MessageBox.Show("Check Your StudentId or Password ");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Please Enter Integer Value in StudentId", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTXTBOXID_Enter(object sender, EventArgs e)
        {
            if (FTXTBOXID.Text.Equals("Faculty Id"))
            {


                FTXTBOXID.Text = "";


            }
        }

        private void FTXTBOXID_Leave(object sender, EventArgs e)
        {
            if (FTXTBOXID.Text.Equals(""))
            {

                FTXTBOXID.Text = "Faculty Id";

            }
        }

        private void FTXTBOXPASS_Enter(object sender, EventArgs e)
        {
            if (FTXTBOXPASS.Text.Equals("Password"))
            {
                FTXTBOXPASS.Text = "";

            }
        }

        private void FTXTBOXPASS_Leave(object sender, EventArgs e)
        {
            if (FTXTBOXPASS.Text.Equals(""))
            {

                FTXTBOXPASS.Text = "Password";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLGNBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection tcon = new SqlConnection(@"Data Source =AD-PC\SQLEXPRESS10;Initial Catalog = tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from flogin where FacultyId = '" + FTXTBOXID.Text + "' and Pass='" + FTXTBOXPASS.Text + "'", tcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    Global.FacultyId = Int32.Parse(FTXTBOXID.Text);
                    MessageBox.Show(" ID No:'" + Global.FacultyId + "' Successfully Logged in");
                    this.Hide();
            
                    FMenu menu = new FMenu();
                    counter = 3;
                    if (menu.Enabled || counter ==3 )
                    {
                        SMS.Text = "Faculty ID : " + Global.FacultyId;
                        SMS.Visible = true;
                        SMS.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C: \Users\AD\source\repos\Student Management System\WindowsFormsApp1\Resources\Black.ico"));
                        SMS.BalloonTipText = "Faculty ID : '" + Global.FacultyId + "'  You're  Successfully Logged in  ";
                        SMS.BalloonTipTitle = "Have a Great Day Ahead :) :)";
                        SMS.ShowBalloonTip(100);
                        SMS.ContextMenuStrip.AllowTransparency = true;
                    }
                    menu.Show();
                    

                }
                else
                {

                    MessageBox.Show("Check your Id or Password");

                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Please Enter Integer Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void STXTBOXID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;


            this.Activate();

        }

      

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
