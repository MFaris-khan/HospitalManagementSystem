namespace HMS_Solution.Forms.AppointmentForm
{
    partial class DELETEAppointment
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
            this.tbAppointmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchAppointmentID = new System.Windows.Forms.Button();
            this.pnlDeleteAppointment = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchPatientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSearchResult = new System.Windows.Forms.Panel();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.pnlDeleteAppointment.SuspendLayout();
            this.pnlSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelMain
            // 
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
            // tbAppointmentID
            // 
            this.tbAppointmentID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppointmentID.Location = new System.Drawing.Point(91, 22);
            this.tbAppointmentID.Name = "tbAppointmentID";
            this.tbAppointmentID.Size = new System.Drawing.Size(116, 25);
            this.tbAppointmentID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "App. ID";
            // 
            // btnSearchAppointmentID
            // 
            this.btnSearchAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAppointmentID.Location = new System.Drawing.Point(213, 22);
            this.btnSearchAppointmentID.Name = "btnSearchAppointmentID";
            this.btnSearchAppointmentID.Size = new System.Drawing.Size(33, 26);
            this.btnSearchAppointmentID.TabIndex = 3;
            this.btnSearchAppointmentID.Text = "...";
            this.btnSearchAppointmentID.UseVisualStyleBackColor = true;
            this.btnSearchAppointmentID.Click += new System.EventHandler(this.btnSearchAppointmentID_Click);
            // 
            // pnlDeleteAppointment
            // 
            this.pnlDeleteAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlDeleteAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteAppointment.Controls.Add(this.btnSearch);
            this.pnlDeleteAppointment.Controls.Add(this.btnCancel);
            this.pnlDeleteAppointment.Controls.Add(this.tbSearchPatientPhone);
            this.pnlDeleteAppointment.Controls.Add(this.label15);
            this.pnlDeleteAppointment.Controls.Add(this.tbSearchPatientName);
            this.pnlDeleteAppointment.Controls.Add(this.label14);
            this.pnlDeleteAppointment.Location = new System.Drawing.Point(25, 12);
            this.pnlDeleteAppointment.Name = "pnlDeleteAppointment";
            this.pnlDeleteAppointment.Size = new System.Drawing.Size(300, 150);
            this.pnlDeleteAppointment.TabIndex = 0;
            this.pnlDeleteAppointment.Visible = false;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlSearchResult
            // 
            this.pnlSearchResult.Controls.Add(this.dgvSearchResult);
            this.pnlSearchResult.Location = new System.Drawing.Point(12, 197);
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.Size = new System.Drawing.Size(775, 146);
            this.pnlSearchResult.TabIndex = 36;
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
            // DELETEAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.pnlDeleteAppointment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlSearchResult);
            this.Controls.Add(this.btnCancelMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbAppointmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchAppointmentID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DELETEAppointment";
            this.Text = "Delete Appointment";
            this.pnlDeleteAppointment.ResumeLayout(false);
            this.pnlDeleteAppointment.PerformLayout();
            this.pnlSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbAppointmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAppointmentID;
        private System.Windows.Forms.Panel pnlDeleteAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchPatientPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchPatientName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSearchResult;
        private System.Windows.Forms.DataGridView dgvSearchResult;
    }
}