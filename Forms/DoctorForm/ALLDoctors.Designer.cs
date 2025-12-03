namespace HMS_Solution.Forms.DoctorForm
{
    partial class ALLDoctors
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
            this.btnSearchMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAllDoctors = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchDoctorSpecialization = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchDoctorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAllDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchMain
            // 
            this.btnSearchMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMain.Location = new System.Drawing.Point(713, 413);
            this.btnSearchMain.Name = "btnSearchMain";
            this.btnSearchMain.Size = new System.Drawing.Size(75, 26);
            this.btnSearchMain.TabIndex = 0;
            this.btnSearchMain.Text = "Search";
            this.btnSearchMain.UseVisualStyleBackColor = true;
            this.btnSearchMain.Click += new System.EventHandler(this.btnSearchMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 394);
            this.dataGridView1.TabIndex = 3;
            // 
            // pnlAllDoctors
            // 
            this.pnlAllDoctors.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlAllDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllDoctors.Controls.Add(this.btnSearch);
            this.pnlAllDoctors.Controls.Add(this.btnCancel);
            this.pnlAllDoctors.Controls.Add(this.tbSearchDoctorSpecialization);
            this.pnlAllDoctors.Controls.Add(this.label15);
            this.pnlAllDoctors.Controls.Add(this.tbSearchDoctorName);
            this.pnlAllDoctors.Controls.Add(this.label14);
            this.pnlAllDoctors.Location = new System.Drawing.Point(228, 121);
            this.pnlAllDoctors.Name = "pnlAllDoctors";
            this.pnlAllDoctors.Size = new System.Drawing.Size(300, 150);
            this.pnlAllDoctors.TabIndex = 0;
            this.pnlAllDoctors.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(200, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(110, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbSearchDoctorSpecialization
            // 
            this.tbSearchDoctorSpecialization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchDoctorSpecialization.Location = new System.Drawing.Point(95, 56);
            this.tbSearchDoctorSpecialization.Name = "tbSearchDoctorSpecialization";
            this.tbSearchDoctorSpecialization.Size = new System.Drawing.Size(193, 25);
            this.tbSearchDoctorSpecialization.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Specialization";
            // 
            // tbSearchDoctorName
            // 
            this.tbSearchDoctorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchDoctorName.Location = new System.Drawing.Point(95, 25);
            this.tbSearchDoctorName.Name = "tbSearchDoctorName";
            this.tbSearchDoctorName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchDoctorName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Doctor Name";
            // 
            // ALLDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAllDoctors);
            this.Controls.Add(this.btnSearchMain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALLDoctors";
            this.Text = "All Doctors";
            this.Load += new System.EventHandler(this.ALLDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAllDoctors.ResumeLayout(false);
            this.pnlAllDoctors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlAllDoctors;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchDoctorSpecialization;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchDoctorName;
        private System.Windows.Forms.Label label14;
    }
}