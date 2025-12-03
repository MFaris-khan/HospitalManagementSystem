namespace HMS_Solution.Forms.PatientForm
{
    partial class ALLPatients
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
            this.dgvAllPatients = new System.Windows.Forms.DataGridView();
            this.btnSearchMain = new System.Windows.Forms.Button();
            this.pnlAllPatients = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchPatientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPatients)).BeginInit();
            this.pnlAllPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllPatients
            // 
            this.dgvAllPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAllPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPatients.Location = new System.Drawing.Point(13, 13);
            this.dgvAllPatients.Name = "dgvAllPatients";
            this.dgvAllPatients.Size = new System.Drawing.Size(775, 394);
            this.dgvAllPatients.TabIndex = 0;
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
            // pnlAllPatients
            // 
            this.pnlAllPatients.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlAllPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllPatients.Controls.Add(this.btnSearch);
            this.pnlAllPatients.Controls.Add(this.btnCancel);
            this.pnlAllPatients.Controls.Add(this.tbSearchPatientPhone);
            this.pnlAllPatients.Controls.Add(this.label15);
            this.pnlAllPatients.Controls.Add(this.tbSearchPatientName);
            this.pnlAllPatients.Controls.Add(this.label14);
            this.pnlAllPatients.Location = new System.Drawing.Point(228, 121);
            this.pnlAllPatients.Name = "pnlAllPatients";
            this.pnlAllPatients.Size = new System.Drawing.Size(300, 150);
            this.pnlAllPatients.TabIndex = 0;
            this.pnlAllPatients.Visible = false;
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
            // tbSearchPatientPhone
            // 
            this.tbSearchPatientPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPatientPhone.Location = new System.Drawing.Point(95, 56);
            this.tbSearchPatientPhone.Name = "tbSearchPatientPhone";
            this.tbSearchPatientPhone.Size = new System.Drawing.Size(193, 25);
            this.tbSearchPatientPhone.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Patient Phone";
            // 
            // tbSearchPatientName
            // 
            this.tbSearchPatientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPatientName.Location = new System.Drawing.Point(95, 25);
            this.tbSearchPatientName.Name = "tbSearchPatientName";
            this.tbSearchPatientName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchPatientName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Patient Name";
            // 
            // ALLPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAllPatients);
            this.Controls.Add(this.btnSearchMain);
            this.Controls.Add(this.dgvAllPatients);
            this.Name = "ALLPatients";
            this.Text = "All Patients";
            this.Load += new System.EventHandler(this.ALLPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPatients)).EndInit();
            this.pnlAllPatients.ResumeLayout(false);
            this.pnlAllPatients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPatients;
        private System.Windows.Forms.Button btnSearchMain;
        private System.Windows.Forms.Panel pnlAllPatients;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchPatientPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchPatientName;
        private System.Windows.Forms.Label label14;
    }
}