namespace WindowsFormsApp1
{
    partial class StudentRegisteredCourses
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SattntopPanel = new System.Windows.Forms.Panel();
            this.SCourselbl = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SattntopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.courses_bckg1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SattntopPanel
            // 
            this.SattntopPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SattntopPanel.Controls.Add(this.SCourselbl);
            this.SattntopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SattntopPanel.Location = new System.Drawing.Point(0, 0);
            this.SattntopPanel.Name = "SattntopPanel";
            this.SattntopPanel.Size = new System.Drawing.Size(992, 47);
            this.SattntopPanel.TabIndex = 6;
            // 
            // SCourselbl
            // 
            this.SCourselbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SCourselbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SCourselbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SCourselbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SCourselbl.Location = new System.Drawing.Point(370, 7);
            this.SCourselbl.Name = "SCourselbl";
            this.SCourselbl.Size = new System.Drawing.Size(253, 32);
            this.SCourselbl.Style = MetroFramework.MetroColorStyle.Lime;
            this.SCourselbl.TabIndex = 0;
            this.SCourselbl.Text = "YOUR REGISTERED COURSES";
            this.SCourselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 280);
            this.panel1.TabIndex = 7;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.Location = new System.Drawing.Point(0, 0);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.Size = new System.Drawing.Size(992, 280);
            this.DataGridView2.TabIndex = 5;
            // 
            // StudentRegisteredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SattntopPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentRegisteredCourses";
            this.Size = new System.Drawing.Size(992, 545);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SattntopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SattntopPanel;
        private MetroFramework.Controls.MetroLabel SCourselbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView2;
    }
}
