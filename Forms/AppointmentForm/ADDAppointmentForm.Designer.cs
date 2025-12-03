namespace HMS_Solution.Forms.AppointmentForm
{
    partial class ADDAppointmentForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchDoctorID = new System.Windows.Forms.Button();
            this.btnSearchPatientID = new System.Windows.Forms.Button();
            this.dtpAppTime = new System.Windows.Forms.DateTimePicker();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDoctorID = new System.Windows.Forms.TextBox();
            this.tbPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchPatients = new System.Windows.Forms.Panel();
            this.btnSearchPpnl = new System.Windows.Forms.Button();
            this.btnCancelPpnl = new System.Windows.Forms.Button();
            this.tbSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchPatientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlSearchDoctors = new System.Windows.Forms.Panel();
            this.btnSearchDpnl = new System.Windows.Forms.Button();
            this.btnCancelDpnl = new System.Windows.Forms.Button();
            this.tbSearchSpecialization = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchDoctorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.pnlSearchPatients.SuspendLayout();
            this.pnlSearchDoctors.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchDoctorID);
            this.groupBox2.Controls.Add(this.btnSearchPatientID);
            this.groupBox2.Controls.Add(this.dtpAppTime);
            this.groupBox2.Controls.Add(this.dtpAppDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbReason);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDoctorID);
            this.groupBox2.Controls.Add(this.tbPatientID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Information";
            // 
            // btnSearchDoctorID
            // 
            this.btnSearchDoctorID.Location = new System.Drawing.Point(311, 58);
            this.btnSearchDoctorID.Name = "btnSearchDoctorID";
            this.btnSearchDoctorID.Size = new System.Drawing.Size(25, 25);
            this.btnSearchDoctorID.TabIndex = 6;
            this.btnSearchDoctorID.Text = "...";
            this.btnSearchDoctorID.UseVisualStyleBackColor = true;
            this.btnSearchDoctorID.Click += new System.EventHandler(this.btnSearchDoctorID_Click);
            // 
            // btnSearchPatientID
            // 
            this.btnSearchPatientID.Location = new System.Drawing.Point(311, 26);
            this.btnSearchPatientID.Name = "btnSearchPatientID";
            this.btnSearchPatientID.Size = new System.Drawing.Size(25, 25);
            this.btnSearchPatientID.TabIndex = 5;
            this.btnSearchPatientID.Text = "...";
            this.btnSearchPatientID.UseVisualStyleBackColor = true;
            this.btnSearchPatientID.Click += new System.EventHandler(this.btnSearchPatientID_Click);
            // 
            // dtpAppTime
            // 
            this.dtpAppTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppTime.Location = new System.Drawing.Point(123, 121);
            this.dtpAppTime.Name = "dtpAppTime";
            this.dtpAppTime.Size = new System.Drawing.Size(215, 25);
            this.dtpAppTime.TabIndex = 3;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppDate.Location = new System.Drawing.Point(123, 90);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(215, 25);
            this.dtpAppDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appointment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doctor ID";
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.Location = new System.Drawing.Point(123, 152);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(215, 25);
            this.tbReason.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Appointment Time";
            // 
            // tbDoctorID
            // 
            this.tbDoctorID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorID.Location = new System.Drawing.Point(122, 58);
            this.tbDoctorID.Name = "tbDoctorID";
            this.tbDoctorID.Size = new System.Drawing.Size(183, 25);
            this.tbDoctorID.TabIndex = 1;
            // 
            // tbPatientID
            // 
            this.tbPatientID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientID.Location = new System.Drawing.Point(122, 26);
            this.tbPatientID.Name = "tbPatientID";
            this.tbPatientID.Size = new System.Drawing.Size(183, 25);
            this.tbPatientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient ID";
            // 
            // pnlSearchPatients
            // 
            this.pnlSearchPatients.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlSearchPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchPatients.Controls.Add(this.btnSearchPpnl);
            this.pnlSearchPatients.Controls.Add(this.btnCancelPpnl);
            this.pnlSearchPatients.Controls.Add(this.tbSearchPatientPhone);
            this.pnlSearchPatients.Controls.Add(this.label15);
            this.pnlSearchPatients.Controls.Add(this.tbSearchPatientName);
            this.pnlSearchPatients.Controls.Add(this.label14);
            this.pnlSearchPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSearchPatients.Location = new System.Drawing.Point(228, 121);
            this.pnlSearchPatients.Name = "pnlSearchPatients";
            this.pnlSearchPatients.Size = new System.Drawing.Size(300, 150);
            this.pnlSearchPatients.TabIndex = 0;
            this.pnlSearchPatients.Visible = false;
            // 
            // btnSearchPpnl
            // 
            this.btnSearchPpnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPpnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPpnl.Location = new System.Drawing.Point(200, 104);
            this.btnSearchPpnl.Name = "btnSearchPpnl";
            this.btnSearchPpnl.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPpnl.TabIndex = 2;
            this.btnSearchPpnl.Text = "Search";
            this.btnSearchPpnl.UseVisualStyleBackColor = true;
            this.btnSearchPpnl.Click += new System.EventHandler(this.btnSearchPpnl_Click);
            // 
            // btnCancelPpnl
            // 
            this.btnCancelPpnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelPpnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPpnl.Location = new System.Drawing.Point(110, 104);
            this.btnCancelPpnl.Name = "btnCancelPpnl";
            this.btnCancelPpnl.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPpnl.TabIndex = 3;
            this.btnCancelPpnl.Text = "Cancel";
            this.btnCancelPpnl.UseVisualStyleBackColor = true;
            this.btnCancelPpnl.Click += new System.EventHandler(this.btnCancelPpnl_Click);
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
            // pnlSearchDoctors
            // 
            this.pnlSearchDoctors.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlSearchDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchDoctors.Controls.Add(this.btnSearchDpnl);
            this.pnlSearchDoctors.Controls.Add(this.btnCancelDpnl);
            this.pnlSearchDoctors.Controls.Add(this.tbSearchSpecialization);
            this.pnlSearchDoctors.Controls.Add(this.label6);
            this.pnlSearchDoctors.Controls.Add(this.tbSearchDoctorName);
            this.pnlSearchDoctors.Controls.Add(this.label7);
            this.pnlSearchDoctors.Location = new System.Drawing.Point(250, 150);
            this.pnlSearchDoctors.Name = "pnlSearchDoctors";
            this.pnlSearchDoctors.Size = new System.Drawing.Size(300, 150);
            this.pnlSearchDoctors.TabIndex = 0;
            this.pnlSearchDoctors.Visible = false;
            // 
            // btnSearchDpnl
            // 
            this.btnSearchDpnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDpnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDpnl.Location = new System.Drawing.Point(200, 104);
            this.btnSearchDpnl.Name = "btnSearchDpnl";
            this.btnSearchDpnl.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDpnl.TabIndex = 2;
            this.btnSearchDpnl.Text = "Search";
            this.btnSearchDpnl.UseVisualStyleBackColor = true;
            this.btnSearchDpnl.Click += new System.EventHandler(this.btnSearchDpnl_Click);
            // 
            // btnCancelDpnl
            // 
            this.btnCancelDpnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelDpnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDpnl.Location = new System.Drawing.Point(110, 104);
            this.btnCancelDpnl.Name = "btnCancelDpnl";
            this.btnCancelDpnl.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDpnl.TabIndex = 3;
            this.btnCancelDpnl.Text = "Cancel";
            this.btnCancelDpnl.UseVisualStyleBackColor = true;
            this.btnCancelDpnl.Click += new System.EventHandler(this.btnCancelDpnl_Click);
            // 
            // tbSearchSpecialization
            // 
            this.tbSearchSpecialization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchSpecialization.Location = new System.Drawing.Point(95, 56);
            this.tbSearchSpecialization.Name = "tbSearchSpecialization";
            this.tbSearchSpecialization.Size = new System.Drawing.Size(193, 25);
            this.tbSearchSpecialization.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Specialization";
            // 
            // tbSearchDoctorName
            // 
            this.tbSearchDoctorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchDoctorName.Location = new System.Drawing.Point(95, 25);
            this.tbSearchDoctorName.Name = "tbSearchDoctorName";
            this.tbSearchDoctorName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchDoctorName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doctor Name";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(632, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(713, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchList);
            this.panel1.Location = new System.Drawing.Point(13, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 146);
            this.panel1.TabIndex = 26;
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchList.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.Size = new System.Drawing.Size(775, 146);
            this.dgvSearchList.TabIndex = 0;
            // 
            // ADDAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearchPatients);
            this.Controls.Add(this.pnlSearchDoctors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ADDAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.ADDAppointmentForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSearchPatients.ResumeLayout(false);
            this.pnlSearchPatients.PerformLayout();
            this.pnlSearchDoctors.ResumeLayout(false);
            this.pnlSearchDoctors.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAppTime;
        private System.Windows.Forms.Button btnSearchPatientID;
        private System.Windows.Forms.Button btnSearchDoctorID;
        private System.Windows.Forms.TextBox tbDoctorID;
        private System.Windows.Forms.Panel pnlSearchPatients;
        private System.Windows.Forms.Button btnSearchPpnl;
        private System.Windows.Forms.Button btnCancelPpnl;
        private System.Windows.Forms.TextBox tbSearchPatientPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchPatientName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlSearchDoctors;
        private System.Windows.Forms.Button btnSearchDpnl;
        private System.Windows.Forms.Button btnCancelDpnl;
        private System.Windows.Forms.TextBox tbSearchSpecialization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchDoctorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSearchList;
    }
}