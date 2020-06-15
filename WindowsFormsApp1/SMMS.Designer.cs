namespace WindowsFormsApp1
{
    partial class SMMS
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
            this.FMMSPBOX = new System.Windows.Forms.PictureBox();
            this.SMMSPNL = new System.Windows.Forms.Panel();
            this.SMMSLbl = new System.Windows.Forms.Label();
            this.StudentSection = new System.Windows.Forms.Label();
            this.SMMSdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.FMMSPBOX)).BeginInit();
            this.SMMSPNL.SuspendLayout();
            this.SuspendLayout();
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
            // SMMSPNL
            // 
            this.SMMSPNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SMMSPNL.BackColor = System.Drawing.SystemColors.Highlight;
            this.SMMSPNL.Controls.Add(this.FMMSPBOX);
            this.SMMSPNL.Controls.Add(this.SMMSLbl);
            this.SMMSPNL.Location = new System.Drawing.Point(227, 143);
            this.SMMSPNL.Name = "SMMSPNL";
            this.SMMSPNL.Size = new System.Drawing.Size(545, 217);
            this.SMMSPNL.TabIndex = 8;
            // 
            // SMMSLbl
            // 
            this.SMMSLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SMMSLbl.AutoSize = true;
            this.SMMSLbl.BackColor = System.Drawing.Color.Black;
            this.SMMSLbl.Font = new System.Drawing.Font("Constantia", 15F);
            this.SMMSLbl.ForeColor = System.Drawing.Color.White;
            this.SMMSLbl.Location = new System.Drawing.Point(3, 136);
            this.SMMSLbl.Name = "SMMSLbl";
            this.SMMSLbl.Padding = new System.Windows.Forms.Padding(164, 0, 162, 0);
            this.SMMSLbl.Size = new System.Drawing.Size(587, 24);
            this.SMMSLbl.TabIndex = 0;
            this.SMMSLbl.Text = "Welcome To Student Section";
            // 
            // StudentSection
            // 
            this.StudentSection.AutoSize = true;
            this.StudentSection.BackColor = System.Drawing.SystemColors.Highlight;
            this.StudentSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentSection.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSection.ForeColor = System.Drawing.Color.White;
            this.StudentSection.Location = new System.Drawing.Point(0, 0);
            this.StudentSection.Name = "StudentSection";
            this.StudentSection.Size = new System.Drawing.Size(215, 38);
            this.StudentSection.TabIndex = 7;
            this.StudentSection.Text = "Student Section";
            // 
            // SMMSdateTimePicker1
            // 
            this.SMMSdateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMMSdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMMSdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMMSdateTimePicker1.Location = new System.Drawing.Point(699, 0);
            this.SMMSdateTimePicker1.Name = "SMMSdateTimePicker1";
            this.SMMSdateTimePicker1.Size = new System.Drawing.Size(280, 26);
            this.SMMSdateTimePicker1.TabIndex = 6;
            // 
            // SMMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._11855660_1482352372079402_4647585737661156962_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.SMMSPNL);
            this.Controls.Add(this.StudentSection);
            this.Controls.Add(this.SMMSdateTimePicker1);
            this.Name = "SMMS";
            this.Size = new System.Drawing.Size(983, 541);
            ((System.ComponentModel.ISupportInitialize)(this.FMMSPBOX)).EndInit();
            this.SMMSPNL.ResumeLayout(false);
            this.SMMSPNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FMMSPBOX;
        private System.Windows.Forms.Panel SMMSPNL;
        private System.Windows.Forms.Label SMMSLbl;
        private System.Windows.Forms.Label StudentSection;
        private System.Windows.Forms.DateTimePicker SMMSdateTimePicker1;
    }
}
