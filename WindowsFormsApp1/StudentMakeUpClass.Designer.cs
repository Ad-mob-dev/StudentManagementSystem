namespace WindowsFormsApp1
{
    partial class StudentMakeUpClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SClsSChtabctrl = new System.Windows.Forms.TabControl();
            this.SMCSTabpg = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SMClsSchdataGridView = new System.Windows.Forms.DataGridView();
            this.MCLsSchhdrpanel = new System.Windows.Forms.Panel();
            this.SPMCSLbl = new System.Windows.Forms.Label();
            this.SClsSchtabpg = new System.Windows.Forms.TabPage();
            this.Makeupnotassignedlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SClsSChtabctrl.SuspendLayout();
            this.SMCSTabpg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMClsSchdataGridView)).BeginInit();
            this.MCLsSchhdrpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SClsSChtabctrl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SClsSChtabctrl
            // 
            this.SClsSChtabctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SClsSChtabctrl.Controls.Add(this.SMCSTabpg);
            this.SClsSChtabctrl.Controls.Add(this.SClsSchtabpg);
            this.SClsSChtabctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SClsSChtabctrl.Location = new System.Drawing.Point(3, 3);
            this.SClsSChtabctrl.Name = "SClsSChtabctrl";
            this.SClsSChtabctrl.SelectedIndex = 0;
            this.SClsSChtabctrl.Size = new System.Drawing.Size(974, 533);
            this.SClsSChtabctrl.TabIndex = 0;
            // 
            // SMCSTabpg
            // 
            this.SMCSTabpg.Controls.Add(this.pictureBox1);
            this.SMCSTabpg.Controls.Add(this.SMClsSchdataGridView);
            this.SMCSTabpg.Controls.Add(this.MCLsSchhdrpanel);
            this.SMCSTabpg.Location = new System.Drawing.Point(4, 27);
            this.SMCSTabpg.Name = "SMCSTabpg";
            this.SMCSTabpg.Padding = new System.Windows.Forms.Padding(3);
            this.SMCSTabpg.Size = new System.Drawing.Size(966, 502);
            this.SMCSTabpg.TabIndex = 0;
            this.SMCSTabpg.Text = "Make Up Classes";
            this.SMCSTabpg.ToolTipText = "Your Current Makeup Class Schedule";
            this.SMCSTabpg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.abstract_blue_colorful_mosaic_background_vector_design_6817840;
            this.pictureBox1.Location = new System.Drawing.Point(3, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SMClsSchdataGridView
            // 
            this.SMClsSchdataGridView.AllowUserToAddRows = false;
            this.SMClsSchdataGridView.AllowUserToDeleteRows = false;
            this.SMClsSchdataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SMClsSchdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SMClsSchdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SMClsSchdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.SMClsSchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SMClsSchdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SMClsSchdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SMClsSchdataGridView.Location = new System.Drawing.Point(3, 52);
            this.SMClsSchdataGridView.Name = "SMClsSchdataGridView";
            this.SMClsSchdataGridView.ReadOnly = true;
            this.SMClsSchdataGridView.Size = new System.Drawing.Size(960, 447);
            this.SMClsSchdataGridView.TabIndex = 1;
            // 
            // MCLsSchhdrpanel
            // 
            this.MCLsSchhdrpanel.Controls.Add(this.Makeupnotassignedlbl);
            this.MCLsSchhdrpanel.Controls.Add(this.SPMCSLbl);
            this.MCLsSchhdrpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MCLsSchhdrpanel.Location = new System.Drawing.Point(3, 3);
            this.MCLsSchhdrpanel.Name = "MCLsSchhdrpanel";
            this.MCLsSchhdrpanel.Size = new System.Drawing.Size(960, 49);
            this.MCLsSchhdrpanel.TabIndex = 0;
            // 
            // SPMCSLbl
            // 
            this.SPMCSLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.SPMCSLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPMCSLbl.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPMCSLbl.ForeColor = System.Drawing.Color.White;
            this.SPMCSLbl.Location = new System.Drawing.Point(0, 0);
            this.SPMCSLbl.Name = "SPMCSLbl";
            this.SPMCSLbl.Size = new System.Drawing.Size(960, 47);
            this.SPMCSLbl.TabIndex = 0;
            this.SPMCSLbl.Text = "YOUR MAKE-UP CLASS SCHEDULE";
            this.SPMCSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SClsSchtabpg
            // 
            this.SClsSchtabpg.Location = new System.Drawing.Point(4, 27);
            this.SClsSchtabpg.Name = "SClsSchtabpg";
            this.SClsSchtabpg.Padding = new System.Windows.Forms.Padding(3);
            this.SClsSchtabpg.Size = new System.Drawing.Size(966, 502);
            this.SClsSchtabpg.TabIndex = 1;
            this.SClsSchtabpg.Text = "Classes Schedule";
            this.SClsSchtabpg.ToolTipText = "Your Regular Classes Schedule";
            this.SClsSchtabpg.UseVisualStyleBackColor = true;
            // 
            // Makeupnotassignedlbl
            // 
            this.Makeupnotassignedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Makeupnotassignedlbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.Makeupnotassignedlbl.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Makeupnotassignedlbl.ForeColor = System.Drawing.Color.White;
            this.Makeupnotassignedlbl.Location = new System.Drawing.Point(0, 0);
            this.Makeupnotassignedlbl.Name = "Makeupnotassignedlbl";
            this.Makeupnotassignedlbl.Size = new System.Drawing.Size(960, 47);
            this.Makeupnotassignedlbl.TabIndex = 3;
            this.Makeupnotassignedlbl.Text = "NOTICE : Currently there is no MakeUp Classes Available For your Semester";
            this.Makeupnotassignedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Makeupnotassignedlbl.Visible = false;
            // 
            // StudentMakeUpClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentMakeUpClass";
            this.Size = new System.Drawing.Size(983, 540);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SClsSChtabctrl.ResumeLayout(false);
            this.SMCSTabpg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMClsSchdataGridView)).EndInit();
            this.MCLsSchhdrpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl SClsSChtabctrl;
        private System.Windows.Forms.TabPage SMCSTabpg;
        private System.Windows.Forms.TabPage SClsSchtabpg;
        private System.Windows.Forms.Panel MCLsSchhdrpanel;
        private System.Windows.Forms.DataGridView SMClsSchdataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SPMCSLbl;
        private System.Windows.Forms.Label Makeupnotassignedlbl;
    }
}
