namespace WindowsFormsApp1
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AdminStriplbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.fGenerateResult1 = new WindowsFormsApp1.FGenerateResult();
            this.fmms1 = new WindowsFormsApp1.FMMS();
            this.AddStudentAttnd = new WindowsFormsApp1.AddStudentAttendance();
            this.FMenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttendanceInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAddCourseControl1 = new WindowsFormsApp1.FAddCourseControl();
            this.fClassScheduleUC1 = new WindowsFormsApp1.FClassScheduleUC();
            this.statusStrip1.SuspendLayout();
            this.FMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.AdminStriplbl});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLabel1.Text = "Faculty Id :";
            // 
            // AdminStriplbl
            // 
            this.AdminStriplbl.AutoToolTip = true;
            this.AdminStriplbl.BackColor = System.Drawing.SystemColors.Control;
            this.AdminStriplbl.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.AdminStriplbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStriplbl.Margin = new System.Windows.Forms.Padding(-4, 3, 0, 2);
            this.AdminStriplbl.Name = "AdminStriplbl";
            this.AdminStriplbl.Size = new System.Drawing.Size(49, 19);
            this.AdminStriplbl.Text = "Admin";
            this.AdminStriplbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminStriplbl.ToolTipText = "Faculty ID";
            // 
            // fGenerateResult1
            // 
            this.fGenerateResult1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGenerateResult1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fGenerateResult1.Location = new System.Drawing.Point(-6, 32);
            this.fGenerateResult1.Name = "fGenerateResult1";
            this.fGenerateResult1.Size = new System.Drawing.Size(1099, 610);
            this.fGenerateResult1.TabIndex = 8;
            // 
            // fmms1
            // 
            this.fmms1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fmms1.BackColor = System.Drawing.Color.Maroon;
            this.fmms1.Location = new System.Drawing.Point(0, 32);
            this.fmms1.Name = "fmms1";
            this.fmms1.Size = new System.Drawing.Size(1090, 610);
            this.fmms1.TabIndex = 6;
            this.fmms1.Load += new System.EventHandler(this.fmms1_Load_1);
            // 
            // AddStudentAttnd
            // 
            this.AddStudentAttnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStudentAttnd.Location = new System.Drawing.Point(0, 34);
            this.AddStudentAttnd.Name = "AddStudentAttnd";
            this.AddStudentAttnd.Size = new System.Drawing.Size(1097, 609);
            this.AddStudentAttnd.TabIndex = 9;
            // 
            // FMenuStrip2
            // 
            this.FMenuStrip2.AllowItemReorder = true;
            this.FMenuStrip2.AutoSize = false;
            this.FMenuStrip2.BackColor = System.Drawing.Color.Maroon;
            this.FMenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FMenuStrip2.GripMargin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.FMenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.FMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 40);
            this.FMenuStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecordsToolStripMenuItem,
            this.classesScheduleToolStripMenuItem,
            this.marksheetToolStripMenuItem,
            this.AttendanceInquiryToolStripMenuItem,
            this.assignmentDetailsToolStripMenuItem});
            this.FMenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.FMenuStrip2.MdiWindowListItem = this.AddRecordsToolStripMenuItem;
            this.FMenuStrip2.Name = "FMenuStrip2";
            this.FMenuStrip2.ShowItemToolTips = true;
            this.FMenuStrip2.Size = new System.Drawing.Size(1091, 31);
            this.FMenuStrip2.TabIndex = 2;
            this.FMenuStrip2.Text = "FMenuStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::WindowsFormsApp1.Properties.Resources.User_blue_icon;
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 16);
            // 
            // AddRecordsToolStripMenuItem
            // 
            this.AddRecordsToolStripMenuItem.AutoSize = false;
            this.AddRecordsToolStripMenuItem.AutoToolTip = true;
            this.AddRecordsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddRecordsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRecordsToolStripMenuItem.CheckOnClick = true;
            this.AddRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRecordsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Netvibes;
            this.AddRecordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AddRecordsToolStripMenuItem.Name = "AddRecordsToolStripMenuItem";
            this.AddRecordsToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.AddRecordsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddRecordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.AddRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.AddRecordsToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.AddRecordsToolStripMenuItem.Text = "Add New Courses";
            this.AddRecordsToolStripMenuItem.ToolTipText = "You can Add New Student Course From Here";
            this.AddRecordsToolStripMenuItem.Click += new System.EventHandler(this.AddRecordsToolStripMenuItem_Click);
            // 
            // classesScheduleToolStripMenuItem
            // 
            this.classesScheduleToolStripMenuItem.AutoSize = false;
            this.classesScheduleToolStripMenuItem.AutoToolTip = true;
            this.classesScheduleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.classesScheduleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classesScheduleToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Designbump;
            this.classesScheduleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.classesScheduleToolStripMenuItem.Name = "classesScheduleToolStripMenuItem";
            this.classesScheduleToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classesScheduleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.classesScheduleToolStripMenuItem.Size = new System.Drawing.Size(186, 27);
            this.classesScheduleToolStripMenuItem.Text = " Add Classes Schedule";
            this.classesScheduleToolStripMenuItem.ToolTipText = "You Can Add Classes Schedule From Here";
            this.classesScheduleToolStripMenuItem.Click += new System.EventHandler(this.classesScheduleToolStripMenuItem_Click);
            // 
            // marksheetToolStripMenuItem
            // 
            this.marksheetToolStripMenuItem.AutoSize = false;
            this.marksheetToolStripMenuItem.AutoToolTip = true;
            this.marksheetToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.marksheetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marksheetToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Foursquare;
            this.marksheetToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.marksheetToolStripMenuItem.Name = "marksheetToolStripMenuItem";
            this.marksheetToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.marksheetToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.marksheetToolStripMenuItem.Text = "Generate Result";
            this.marksheetToolStripMenuItem.ToolTipText = "You Can Generate Student Result From Here";
            this.marksheetToolStripMenuItem.Click += new System.EventHandler(this.marksheetToolStripMenuItem_Click);
            // 
            // AttendanceInquiryToolStripMenuItem
            // 
            this.AttendanceInquiryToolStripMenuItem.AutoSize = false;
            this.AttendanceInquiryToolStripMenuItem.AutoToolTip = true;
            this.AttendanceInquiryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AttendanceInquiryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AttendanceInquiryToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Myspace;
            this.AttendanceInquiryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.AttendanceInquiryToolStripMenuItem.Name = "AttendanceInquiryToolStripMenuItem";
            this.AttendanceInquiryToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AttendanceInquiryToolStripMenuItem.Size = new System.Drawing.Size(202, 27);
            this.AttendanceInquiryToolStripMenuItem.Text = "Add Student Attendance";
            this.AttendanceInquiryToolStripMenuItem.ToolTipText = "You Can Add Student Attendance From Here";
            this.AttendanceInquiryToolStripMenuItem.Click += new System.EventHandler(this.AttendanceInquiryToolStripMenuItem_Click);
            // 
            // assignmentDetailsToolStripMenuItem
            // 
            this.assignmentDetailsToolStripMenuItem.AutoSize = false;
            this.assignmentDetailsToolStripMenuItem.AutoToolTip = true;
            this.assignmentDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.assignmentDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignmentDetailsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Embossed_Social_Dzone2;
            this.assignmentDetailsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.assignmentDetailsToolStripMenuItem.Name = "assignmentDetailsToolStripMenuItem";
            this.assignmentDetailsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.assignmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.assignmentDetailsToolStripMenuItem.Text = "Add Assignment";
            this.assignmentDetailsToolStripMenuItem.ToolTipText = "You Can Add New Assignments From Here";
            // 
            // fAddCourseControl1
            // 
            this.fAddCourseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fAddCourseControl1.AutoScroll = true;
            this.fAddCourseControl1.BackColor = System.Drawing.Color.Maroon;
            this.fAddCourseControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fAddCourseControl1.BackgroundImage")));
            this.fAddCourseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fAddCourseControl1.Location = new System.Drawing.Point(0, 32);
            this.fAddCourseControl1.Name = "fAddCourseControl1";
            this.fAddCourseControl1.Size = new System.Drawing.Size(1090, 613);
            this.fAddCourseControl1.TabIndex = 3;
            // 
            // fClassScheduleUC1
            // 
            this.fClassScheduleUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fClassScheduleUC1.AutoScroll = true;
            this.fClassScheduleUC1.BackColor = System.Drawing.Color.Maroon;
            this.fClassScheduleUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fClassScheduleUC1.BackgroundImage")));
            this.fClassScheduleUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fClassScheduleUC1.Location = new System.Drawing.Point(0, 32);
            this.fClassScheduleUC1.Name = "fClassScheduleUC1";
            this.fClassScheduleUC1.Size = new System.Drawing.Size(1090, 614);
            this.fClassScheduleUC1.TabIndex = 5;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1091, 668);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FMenuStrip2);
            this.Controls.Add(this.fGenerateResult1);
            this.Controls.Add(this.fAddCourseControl1);
            this.Controls.Add(this.fClassScheduleUC1);
            this.Controls.Add(this.fmms1);
            this.Controls.Add(this.AddStudentAttnd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Menu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FMenuStrip2.ResumeLayout(false);
            this.FMenuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FAddCourseControl fAddCourseControl1;
        private FClassScheduleUC fClassScheduleUC1;
        private FMMS fmms1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AdminStriplbl;
        private FGenerateResult fGenerateResult1;
        private WindowsFormsApp1.AddStudentAttendance AddStudentAttnd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem AddRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AttendanceInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentDetailsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip FMenuStrip2;
    }
}