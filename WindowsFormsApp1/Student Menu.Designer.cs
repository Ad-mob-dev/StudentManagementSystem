namespace WindowsFormsApp1
{
    partial class SMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StudentIdStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StudentNameStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Timers.Timer();
            this.sattendance1 = new WindowsFormsApp1.Sattendance();
            this.smms1 = new WindowsFormsApp1.SMMS();
            this.studentResults1 = new WindowsFormsApp1.StudentResults();
            this.studentRegisteredCourses = new WindowsFormsApp1.StudentRegisteredCourses();
            this.studentMakeUpClass1 = new WindowsFormsApp1.StudentMakeUpClass();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 29);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecordsToolStripMenuItem,
            this.classesScheduleToolStripMenuItem,
            this.marksheetToolStripMenuItem,
            this.attendanceInquiryToolStripMenuItem,
            this.assignmentDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.assignmentDetailsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddRecordsToolStripMenuItem
            // 
            this.AddRecordsToolStripMenuItem.AutoSize = false;
            this.AddRecordsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddRecordsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRecordsToolStripMenuItem.CheckOnClick = true;
            this.AddRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRecordsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Foursquare;
            this.AddRecordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddRecordsToolStripMenuItem.Name = "AddRecordsToolStripMenuItem";
            this.AddRecordsToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.AddRecordsToolStripMenuItem.Text = "Registered Courses";
            this.AddRecordsToolStripMenuItem.ToolTipText = "Registered Courses";
            this.AddRecordsToolStripMenuItem.Click += new System.EventHandler(this.AddRecordsToolStripMenuItem_Click_1);
            // 
            // classesScheduleToolStripMenuItem
            // 
            this.classesScheduleToolStripMenuItem.AutoSize = false;
            this.classesScheduleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.classesScheduleToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Myspace;
            this.classesScheduleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.classesScheduleToolStripMenuItem.Name = "classesScheduleToolStripMenuItem";
            this.classesScheduleToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.classesScheduleToolStripMenuItem.Text = "Classes Schedule";
            this.classesScheduleToolStripMenuItem.ToolTipText = "Class Schedules";
            this.classesScheduleToolStripMenuItem.Click += new System.EventHandler(this.classesScheduleToolStripMenuItem_Click_1);
            // 
            // marksheetToolStripMenuItem
            // 
            this.marksheetToolStripMenuItem.AutoSize = false;
            this.marksheetToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.marksheetToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Designbump;
            this.marksheetToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.marksheetToolStripMenuItem.Name = "marksheetToolStripMenuItem";
            this.marksheetToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.marksheetToolStripMenuItem.Text = "Marksheet";
            this.marksheetToolStripMenuItem.ToolTipText = "GPA/Total Course Marks";
            this.marksheetToolStripMenuItem.Click += new System.EventHandler(this.marksheetToolStripMenuItem_Click);
            // 
            // attendanceInquiryToolStripMenuItem
            // 
            this.attendanceInquiryToolStripMenuItem.AutoSize = false;
            this.attendanceInquiryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.attendanceInquiryToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Dzone2;
            this.attendanceInquiryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.attendanceInquiryToolStripMenuItem.Name = "attendanceInquiryToolStripMenuItem";
            this.attendanceInquiryToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.attendanceInquiryToolStripMenuItem.Text = "Attendance Inquiry";
            this.attendanceInquiryToolStripMenuItem.ToolTipText = "Attendance Inquiry";
            this.attendanceInquiryToolStripMenuItem.Click += new System.EventHandler(this.attendanceInquiryToolStripMenuItem_Click);
            // 
            // assignmentDetailsToolStripMenuItem
            // 
            this.assignmentDetailsToolStripMenuItem.AutoSize = false;
            this.assignmentDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.assignmentDetailsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Netvibes;
            this.assignmentDetailsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.assignmentDetailsToolStripMenuItem.Name = "assignmentDetailsToolStripMenuItem";
            this.assignmentDetailsToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.assignmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.assignmentDetailsToolStripMenuItem.Text = "Assignment Details";
            this.assignmentDetailsToolStripMenuItem.ToolTipText = "Assignment Details";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StudentIdStripStatusLbl,
            this.toolStripStatusLabel3,
            this.StudentNameStripLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::WindowsFormsApp1.Properties.Resources.keyring_icon;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "StudentId :";
            // 
            // StudentIdStripStatusLbl
            // 
            this.StudentIdStripStatusLbl.Margin = new System.Windows.Forms.Padding(-4, 3, 0, 2);
            this.StudentIdStripStatusLbl.Name = "StudentIdStripStatusLbl";
            this.StudentIdStripStatusLbl.Size = new System.Drawing.Size(28, 17);
            this.StudentIdStripStatusLbl.Text = "###";
            this.StudentIdStripStatusLbl.Click += new System.EventHandler(this.StudentIdStripStatusLbl_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = global::WindowsFormsApp1.Properties.Resources.App_login_manager_icon;
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel3.Text = "Student Name :";
            // 
            // StudentNameStripLbl
            // 
            this.StudentNameStripLbl.Margin = new System.Windows.Forms.Padding(-4, 3, 0, 2);
            this.StudentNameStripLbl.Name = "StudentNameStripLbl";
            this.StudentNameStripLbl.Size = new System.Drawing.Size(35, 17);
            this.StudentNameStripLbl.Text = "####";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10D;
            this.timer1.SynchronizingObject = this;
            // 
            // sattendance1
            // 
            this.sattendance1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sattendance1.Location = new System.Drawing.Point(0, 37);
            this.sattendance1.Name = "sattendance1";
            this.sattendance1.Size = new System.Drawing.Size(983, 503);
            this.sattendance1.TabIndex = 10;
            // 
            // smms1
            // 
            this.smms1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smms1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.smms1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smms1.BackgroundImage")));
            this.smms1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smms1.Location = new System.Drawing.Point(0, 37);
            this.smms1.Name = "smms1";
            this.smms1.Size = new System.Drawing.Size(989, 503);
            this.smms1.TabIndex = 9;
            // 
            // studentResults1
            // 
            this.studentResults1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentResults1.Location = new System.Drawing.Point(0, 37);
            this.studentResults1.Name = "studentResults1";
            this.studentResults1.Size = new System.Drawing.Size(983, 503);
            this.studentResults1.TabIndex = 8;
            this.studentResults1.Load += new System.EventHandler(this.studentResults1_Load);
            // 
            // studentRegisteredCourses
            // 
            this.studentRegisteredCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentRegisteredCourses.BackColor = System.Drawing.SystemColors.Highlight;
            this.studentRegisteredCourses.Location = new System.Drawing.Point(-4, 37);
            this.studentRegisteredCourses.Name = "studentRegisteredCourses";
            this.studentRegisteredCourses.Size = new System.Drawing.Size(996, 501);
            this.studentRegisteredCourses.TabIndex = 5;
            // 
            // studentMakeUpClass1
            // 
            this.studentMakeUpClass1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentMakeUpClass1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.studentMakeUpClass1.Location = new System.Drawing.Point(-8, 37);
            this.studentMakeUpClass1.Name = "studentMakeUpClass1";
            this.studentMakeUpClass1.Size = new System.Drawing.Size(1006, 502);
            this.studentMakeUpClass1.TabIndex = 6;
            // 
            // SMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(983, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentRegisteredCourses);
            this.Controls.Add(this.studentMakeUpClass1);
            this.Controls.Add(this.sattendance1);
            this.Controls.Add(this.smms1);
            this.Controls.Add(this.studentResults1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.SMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentDetailsToolStripMenuItem;
        private StudentRegisteredCourses studentRegisteredCourses;
        private StudentMakeUpClass studentMakeUpClass1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StudentIdStripStatusLbl;
        private StudentResults studentResults1;
        private SMMS smms1;
        private Sattendance sattendance1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StudentNameStripLbl;
        private System.Timers.Timer timer1;
    }
}