namespace HMS_Solution.Forms.DoctorForm
{
    partial class DELETEDoctor
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
            this.btnCancelMain = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbDoctorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchDoctorID = new System.Windows.Forms.Button();
            this.pnlDeleteDoctor = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchDoctorSpecialization = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchDoctorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlSearchResult = new System.Windows.Forms.Panel();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDeleteDoctor.SuspendLayout();
            this.pnlSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMain.Location = new System.Drawing.Point(91, 73);
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(60, 23);
            this.btnCancelMain.TabIndex = 2;
            this.btnCancelMain.Text = "Cancel";
            this.btnCancelMain.UseVisualStyleBackColor = true;
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(157, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbDoctorID
            // 
            this.tbDoctorID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorID.Location = new System.Drawing.Point(91, 22);
            this.tbDoctorID.Name = "tbDoctorID";
            this.tbDoctorID.Size = new System.Drawing.Size(116, 25);
            this.tbDoctorID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Doctor ID";
            // 
            // btnSearchDoctorID
            // 
            this.btnSearchDoctorID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDoctorID.Location = new System.Drawing.Point(213, 22);
            this.btnSearchDoctorID.Name = "btnSearchDoctorID";
            this.btnSearchDoctorID.Size = new System.Drawing.Size(33, 26);
            this.btnSearchDoctorID.TabIndex = 3;
            this.btnSearchDoctorID.Text = "...";
            this.btnSearchDoctorID.UseVisualStyleBackColor = true;
            this.btnSearchDoctorID.Click += new System.EventHandler(this.btnSearchDoctorID_Click);
            // 
            // pnlDeleteDoctor
            // 
            this.pnlDeleteDoctor.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlDeleteDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteDoctor.Controls.Add(this.btnSearch);
            this.pnlDeleteDoctor.Controls.Add(this.btnCancel);
            this.pnlDeleteDoctor.Controls.Add(this.tbSearchDoctorSpecialization);
            this.pnlDeleteDoctor.Controls.Add(this.label15);
            this.pnlDeleteDoctor.Controls.Add(this.tbSearchDoctorName);
            this.pnlDeleteDoctor.Controls.Add(this.label14);
            this.pnlDeleteDoctor.Location = new System.Drawing.Point(25, 12);
            this.pnlDeleteDoctor.Name = "pnlDeleteDoctor";
            this.pnlDeleteDoctor.Size = new System.Drawing.Size(300, 150);
            this.pnlDeleteDoctor.TabIndex = 0;
            this.pnlDeleteDoctor.Visible = false;
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
            // pnlSearchResult
            // 
            this.pnlSearchResult.Controls.Add(this.dgvSearchResult);
            this.pnlSearchResult.Location = new System.Drawing.Point(12, 197);
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.Size = new System.Drawing.Size(775, 146);
            this.pnlSearchResult.TabIndex = 31;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResult.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.Size = new System.Drawing.Size(775, 146);
            this.dgvSearchResult.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DELETEDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.pnlDeleteDoctor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlSearchResult);
            this.Controls.Add(this.btnCancelMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbDoctorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDoctorID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DELETEDoctor";
            this.Text = "Delete Doctor";
            this.pnlDeleteDoctor.ResumeLayout(false);
            this.pnlDeleteDoctor.PerformLayout();
            this.pnlSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchDoctorID;
        private System.Windows.Forms.Panel pnlDeleteDoctor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchDoctorSpecialization;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchDoctorName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlSearchResult;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button button1;
    }
}