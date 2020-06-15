namespace WindowsFormsApp1
{
    partial class FAddCourseControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.TextBox();
            this.CTITLE = new System.Windows.Forms.MaskedTextBox();
            this.CHRS = new System.Windows.Forms.MaskedTextBox();
            this.TTABLE = new System.Windows.Forms.MaskedTextBox();
            this.CAMT = new System.Windows.Forms.MaskedTextBox();
            this.FcourseNewBtn = new System.Windows.Forms.Button();
            this.FCourseInsertBtn = new System.Windows.Forms.Button();
            this.FCourseUpdateBtn = new System.Windows.Forms.Button();
            this.FCourseDeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FSCRBatchlbl = new System.Windows.Forms.Label();
            this.FSCRBatchtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.FSCRSemesterlbl = new System.Windows.Forms.Label();
            this.FSCRSemestertxtbix = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Title";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Credit Hours";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(182, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time Table";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(376, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Add Student Courses";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount";
            // 
            // CID
            // 
            this.CID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CID.BackColor = System.Drawing.Color.Maroon;
            this.CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID.ForeColor = System.Drawing.Color.White;
            this.CID.Location = new System.Drawing.Point(304, 50);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(491, 26);
            this.CID.TabIndex = 1;
            // 
            // CTITLE
            // 
            this.CTITLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CTITLE.BackColor = System.Drawing.Color.Maroon;
            this.CTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTITLE.ForeColor = System.Drawing.Color.White;
            this.CTITLE.Location = new System.Drawing.Point(304, 80);
            this.CTITLE.Name = "CTITLE";
            this.CTITLE.Size = new System.Drawing.Size(491, 26);
            this.CTITLE.TabIndex = 2;
            // 
            // CHRS
            // 
            this.CHRS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CHRS.BackColor = System.Drawing.Color.Maroon;
            this.CHRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHRS.ForeColor = System.Drawing.Color.White;
            this.CHRS.Location = new System.Drawing.Point(304, 110);
            this.CHRS.Name = "CHRS";
            this.CHRS.Size = new System.Drawing.Size(491, 26);
            this.CHRS.TabIndex = 3;
            // 
            // TTABLE
            // 
            this.TTABLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TTABLE.BackColor = System.Drawing.Color.Maroon;
            this.TTABLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTABLE.ForeColor = System.Drawing.Color.White;
            this.TTABLE.Location = new System.Drawing.Point(304, 140);
            this.TTABLE.Name = "TTABLE";
            this.TTABLE.Size = new System.Drawing.Size(491, 26);
            this.TTABLE.TabIndex = 4;
            // 
            // CAMT
            // 
            this.CAMT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CAMT.BackColor = System.Drawing.Color.Maroon;
            this.CAMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAMT.ForeColor = System.Drawing.Color.White;
            this.CAMT.Location = new System.Drawing.Point(304, 230);
            this.CAMT.Name = "CAMT";
            this.CAMT.Size = new System.Drawing.Size(491, 26);
            this.CAMT.TabIndex = 5;
            // 
            // FcourseNewBtn
            // 
            this.FcourseNewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FcourseNewBtn.BackColor = System.Drawing.Color.Maroon;
            this.FcourseNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcourseNewBtn.ForeColor = System.Drawing.Color.White;
            this.FcourseNewBtn.Location = new System.Drawing.Point(260, 274);
            this.FcourseNewBtn.Name = "FcourseNewBtn";
            this.FcourseNewBtn.Size = new System.Drawing.Size(110, 34);
            this.FcourseNewBtn.TabIndex = 6;
            this.FcourseNewBtn.Text = "New/Clear";
            this.FcourseNewBtn.UseVisualStyleBackColor = false;
            this.FcourseNewBtn.Click += new System.EventHandler(this.FcourseNewBtn_Click);
            // 
            // FCourseInsertBtn
            // 
            this.FCourseInsertBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FCourseInsertBtn.BackColor = System.Drawing.Color.Maroon;
            this.FCourseInsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCourseInsertBtn.ForeColor = System.Drawing.Color.White;
            this.FCourseInsertBtn.Location = new System.Drawing.Point(390, 274);
            this.FCourseInsertBtn.Name = "FCourseInsertBtn";
            this.FCourseInsertBtn.Size = new System.Drawing.Size(110, 34);
            this.FCourseInsertBtn.TabIndex = 7;
            this.FCourseInsertBtn.Text = "Insert";
            this.FCourseInsertBtn.UseVisualStyleBackColor = false;
            this.FCourseInsertBtn.Click += new System.EventHandler(this.FCourseInsertBtn_Click);
            // 
            // FCourseUpdateBtn
            // 
            this.FCourseUpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FCourseUpdateBtn.BackColor = System.Drawing.Color.Maroon;
            this.FCourseUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCourseUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.FCourseUpdateBtn.Location = new System.Drawing.Point(515, 274);
            this.FCourseUpdateBtn.Name = "FCourseUpdateBtn";
            this.FCourseUpdateBtn.Size = new System.Drawing.Size(110, 34);
            this.FCourseUpdateBtn.TabIndex = 8;
            this.FCourseUpdateBtn.Text = "Update";
            this.FCourseUpdateBtn.UseVisualStyleBackColor = false;
            this.FCourseUpdateBtn.Click += new System.EventHandler(this.FCourseUpdateBtn_Click);
            // 
            // FCourseDeleteBtn
            // 
            this.FCourseDeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FCourseDeleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.FCourseDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCourseDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.FCourseDeleteBtn.Location = new System.Drawing.Point(641, 274);
            this.FCourseDeleteBtn.Name = "FCourseDeleteBtn";
            this.FCourseDeleteBtn.Size = new System.Drawing.Size(110, 34);
            this.FCourseDeleteBtn.TabIndex = 9;
            this.FCourseDeleteBtn.Text = "Delete";
            this.FCourseDeleteBtn.UseVisualStyleBackColor = false;
            this.FCourseDeleteBtn.Click += new System.EventHandler(this.FCourseDeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 215);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // FSCRBatchlbl
            // 
            this.FSCRBatchlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FSCRBatchlbl.AutoSize = true;
            this.FSCRBatchlbl.BackColor = System.Drawing.Color.Maroon;
            this.FSCRBatchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSCRBatchlbl.ForeColor = System.Drawing.Color.White;
            this.FSCRBatchlbl.Location = new System.Drawing.Point(182, 173);
            this.FSCRBatchlbl.Name = "FSCRBatchlbl";
            this.FSCRBatchlbl.Size = new System.Drawing.Size(56, 20);
            this.FSCRBatchlbl.TabIndex = 3;
            this.FSCRBatchlbl.Text = "Batch";
            // 
            // FSCRBatchtxtbox
            // 
            this.FSCRBatchtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FSCRBatchtxtbox.BackColor = System.Drawing.Color.Maroon;
            this.FSCRBatchtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSCRBatchtxtbox.ForeColor = System.Drawing.Color.White;
            this.FSCRBatchtxtbox.Location = new System.Drawing.Point(304, 170);
            this.FSCRBatchtxtbox.Name = "FSCRBatchtxtbox";
            this.FSCRBatchtxtbox.Size = new System.Drawing.Size(491, 26);
            this.FSCRBatchtxtbox.TabIndex = 5;
            // 
            // FSCRSemesterlbl
            // 
            this.FSCRSemesterlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FSCRSemesterlbl.AutoSize = true;
            this.FSCRSemesterlbl.BackColor = System.Drawing.Color.Maroon;
            this.FSCRSemesterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSCRSemesterlbl.ForeColor = System.Drawing.Color.White;
            this.FSCRSemesterlbl.Location = new System.Drawing.Point(182, 203);
            this.FSCRSemesterlbl.Name = "FSCRSemesterlbl";
            this.FSCRSemesterlbl.Size = new System.Drawing.Size(86, 20);
            this.FSCRSemesterlbl.TabIndex = 3;
            this.FSCRSemesterlbl.Text = "Semester";
            // 
            // FSCRSemestertxtbix
            // 
            this.FSCRSemestertxtbix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FSCRSemestertxtbix.BackColor = System.Drawing.Color.Maroon;
            this.FSCRSemestertxtbix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSCRSemestertxtbix.ForeColor = System.Drawing.Color.White;
            this.FSCRSemestertxtbix.Location = new System.Drawing.Point(304, 200);
            this.FSCRSemestertxtbix.Name = "FSCRSemestertxtbix";
            this.FSCRSemestertxtbix.Size = new System.Drawing.Size(491, 26);
            this.FSCRSemestertxtbix.TabIndex = 5;
            // 
            // FAddCourseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._11855660_1482352372079402_4647585737661156962_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FCourseDeleteBtn);
            this.Controls.Add(this.FCourseUpdateBtn);
            this.Controls.Add(this.FCourseInsertBtn);
            this.Controls.Add(this.FcourseNewBtn);
            this.Controls.Add(this.FSCRBatchtxtbox);
            this.Controls.Add(this.FSCRSemestertxtbix);
            this.Controls.Add(this.CAMT);
            this.Controls.Add(this.TTABLE);
            this.Controls.Add(this.CHRS);
            this.Controls.Add(this.CTITLE);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.FSCRSemesterlbl);
            this.Controls.Add(this.FSCRBatchlbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAddCourseControl";
            this.Size = new System.Drawing.Size(1006, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.MaskedTextBox CTITLE;
        private System.Windows.Forms.MaskedTextBox CHRS;
        private System.Windows.Forms.MaskedTextBox TTABLE;
        private System.Windows.Forms.MaskedTextBox CAMT;
        private System.Windows.Forms.Button FcourseNewBtn;
        private System.Windows.Forms.Button FCourseInsertBtn;
        private System.Windows.Forms.Button FCourseUpdateBtn;
        private System.Windows.Forms.Button FCourseDeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FSCRBatchlbl;
        private System.Windows.Forms.MaskedTextBox FSCRBatchtxtbox;
        private System.Windows.Forms.Label FSCRSemesterlbl;
        private System.Windows.Forms.MaskedTextBox FSCRSemestertxtbix;
    }
}
