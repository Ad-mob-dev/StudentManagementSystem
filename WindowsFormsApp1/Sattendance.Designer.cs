namespace WindowsFormsApp1
{
    partial class Sattendance
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
            this.SattntopPanel = new System.Windows.Forms.Panel();
            this.Sattndncelbl = new MetroFramework.Controls.MetroLabel();
            this.ERRORlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SattntopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SattntopPanel
            // 
            this.SattntopPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SattntopPanel.Controls.Add(this.Sattndncelbl);
            this.SattntopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SattntopPanel.Location = new System.Drawing.Point(0, 0);
            this.SattntopPanel.Name = "SattntopPanel";
            this.SattntopPanel.Size = new System.Drawing.Size(989, 47);
            this.SattntopPanel.TabIndex = 1;
            // 
            // Sattndncelbl
            // 
            this.Sattndncelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sattndncelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sattndncelbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Sattndncelbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Sattndncelbl.Location = new System.Drawing.Point(390, 7);
            this.Sattndncelbl.Name = "Sattndncelbl";
            this.Sattndncelbl.Size = new System.Drawing.Size(208, 32);
            this.Sattndncelbl.Style = MetroFramework.MetroColorStyle.Lime;
            this.Sattndncelbl.TabIndex = 0;
            this.Sattndncelbl.Text = "YOUR ATTENDANCE";
            this.Sattndncelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ERRORlabel
            // 
            this.ERRORlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ERRORlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRORlabel.ForeColor = System.Drawing.Color.White;
            this.ERRORlabel.Location = new System.Drawing.Point(23, 29);
            this.ERRORlabel.Name = "ERRORlabel";
            this.ERRORlabel.Size = new System.Drawing.Size(520, 38);
            this.ERRORlabel.TabIndex = 0;
            this.ERRORlabel.Text = "THERE IS NO RECORD FOR YOUR ID ";
            this.ERRORlabel.Visible = false;
            this.ERRORlabel.Click += new System.EventHandler(this.ERRORlabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(0, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 390);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.ERRORlabel);
            this.panel1.Location = new System.Drawing.Point(211, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 97);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // Sattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SattntopPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sattendance";
            this.Size = new System.Drawing.Size(989, 540);
            this.Load += new System.EventHandler(this.Sattendance_Load);
            this.SattntopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SattntopPanel;
        private MetroFramework.Controls.MetroLabel Sattndncelbl;
        private System.Windows.Forms.Label ERRORlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}
