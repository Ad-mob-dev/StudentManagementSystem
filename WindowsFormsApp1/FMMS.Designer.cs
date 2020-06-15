namespace WindowsFormsApp1
{
    partial class FMMS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FacultySection = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FMMSPNL = new System.Windows.Forms.Panel();
            this.FMMSPBOX = new System.Windows.Forms.PictureBox();
            this.FMMSLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.FMMSPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FMMSPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(700, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Check Current Time/Date");
            // 
            // FacultySection
            // 
            this.FacultySection.AutoSize = true;
            this.FacultySection.BackColor = System.Drawing.Color.Maroon;
            this.FacultySection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacultySection.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultySection.ForeColor = System.Drawing.Color.White;
            this.FacultySection.Location = new System.Drawing.Point(1, 0);
            this.FacultySection.Name = "FacultySection";
            this.FacultySection.Size = new System.Drawing.Size(207, 38);
            this.FacultySection.TabIndex = 4;
            this.FacultySection.Text = "Faculty Section";
            this.toolTip1.SetToolTip(this.FacultySection, "This is  Faculty Section Title");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._11855660_1482352372079402_4647585737661156962_n;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.FMMSPNL);
            this.panel1.Controls.Add(this.FacultySection);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 541);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FMMSPNL
            // 
            this.FMMSPNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FMMSPNL.Controls.Add(this.FMMSPBOX);
            this.FMMSPNL.Controls.Add(this.FMMSLbl);
            this.FMMSPNL.Location = new System.Drawing.Point(228, 143);
            this.FMMSPNL.Name = "FMMSPNL";
            this.FMMSPNL.Size = new System.Drawing.Size(545, 217);
            this.FMMSPNL.TabIndex = 5;
            // 
            // FMMSPBOX
            // 
            this.FMMSPBOX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FMMSPBOX.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.FMMSPBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FMMSPBOX.Location = new System.Drawing.Point(0, 0);
            this.FMMSPBOX.Name = "FMMSPBOX";
            this.FMMSPBOX.Size = new System.Drawing.Size(545, 102);
            this.FMMSPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FMMSPBOX.TabIndex = 2;
            this.FMMSPBOX.TabStop = false;
            // 
            // FMMSLbl
            // 
            this.FMMSLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FMMSLbl.AutoSize = true;
            this.FMMSLbl.BackColor = System.Drawing.Color.Black;
            this.FMMSLbl.Font = new System.Drawing.Font("Constantia", 15F);
            this.FMMSLbl.ForeColor = System.Drawing.Color.White;
            this.FMMSLbl.Location = new System.Drawing.Point(3, 136);
            this.FMMSLbl.Name = "FMMSLbl";
            this.FMMSLbl.Padding = new System.Windows.Forms.Padding(164, 0, 162, 0);
            this.FMMSLbl.Size = new System.Drawing.Size(582, 24);
            this.FMMSLbl.TabIndex = 0;
            this.FMMSLbl.Text = "Welcome To Faculty Section";
            this.FMMSLbl.Click += new System.EventHandler(this.FMMSLbl_Click);
            // 
            // FMMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.panel1);
            this.Name = "FMMS";
            this.Size = new System.Drawing.Size(983, 541);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FMMSPNL.ResumeLayout(false);
            this.FMMSPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FMMSPBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FacultySection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel FMMSPNL;
        private System.Windows.Forms.Label FMMSLbl;
        private System.Windows.Forms.PictureBox FMMSPBOX;
    }
}
