using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentMakeUpClass : UserControl
    {
       public StudentMakeUpClass()
        {
            InitializeComponent();

            try
            {
                SqlConnection tcon = new SqlConnection(@"Data Source =AD-PC\SQLEXPRESS10;Initial Catalog = tlogin; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
               SqlDataAdapter sda = new SqlDataAdapter("select Name,Semester from StudentRegistry where StudentId = '" +Global.StudentId+ "'", tcon);
                 DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    
                    Global.StudentName = dt.Rows[0]["Name"].ToString();
                    switch (dt.Rows[0]["Semester"] as String)
                    {
                        case "8th":
                            {

                                Global.Semester = "8th";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "7th":
                            {
                                Global.Semester = "7th";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "6th":
                            {
                                Global.Semester = "6th";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "5th":
                            {
                                Global.Semester = "5th";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "4th":
                            {
                                Global.Semester = "4th";
                               
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "3rd":
                            {
                                Global.Semester = "3rd";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "2nd":
                            {
                                Global.Semester = "2nd";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        case "1st":
                            {
                                Global.Semester = "1st";
                                ShowMakeUpClass("select * from makeupSchedule Where Semester = '" + Global.Semester + "' ", SMClsSchdataGridView);
                                break;
                            }
                        default:
                            {
                                Makeupnotassignedlbl.Visible = true;


                                break;

                            }
                    }
                }
             
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error Occured",ex.ToString());
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

      public void ShowMakeUpClass(String Query,DataGridView DGV)
            
        {
            SqlConnection Sq = new SqlConnection(Global.ConString);
            SqlDataAdapter sda = new SqlDataAdapter(Query,Sq);
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

      
    }
}
