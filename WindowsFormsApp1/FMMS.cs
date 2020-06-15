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
    public partial class FMMS : UserControl
    {
      
        public FMMS()
        {

            InitializeComponent();
            
        }

       

        private void FMMSLbl_Click(object sender, EventArgs e)
        {
            
            FMMSPNL.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
