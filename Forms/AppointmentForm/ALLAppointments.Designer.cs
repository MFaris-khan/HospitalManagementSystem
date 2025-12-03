namespace HMS_Solution.Forms.AppointmentForm
{
    partial class ALLAppointments
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
            this.dgvAllAppointments = new System.Windows.Forms.DataGridView();
            this.pnlAllAppointments = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchPatientName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).BeginInit();
            this.pnlAllAppointments.SuspendLayout();
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
            // dgvAllAppointments
            // 
            this.dgvAllAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAllAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAppointments.Location = new System.Drawing.Point(13, 13);
            this.dgvAllAppointments.Name = "dgvAllAppointments";
            this.dgvAllAppointments.Size = new System.Drawing.Size(775, 394);
            this.dgvAllAppointments.TabIndex = 8;
            // 
            // pnlAllAppointments
            // 
            this.pnlAllAppointments.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlAllAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllAppointments.Controls.Add(this.btnSearch);
            this.pnlAllAppointments.Controls.Add(this.btnCancel);
            this.pnlAllAppointments.Controls.Add(this.tbSearchPatientPhone);
            this.pnlAllAppointments.Controls.Add(this.label15);
            this.pnlAllAppointments.Controls.Add(this.tbSearchPatientName);
            this.pnlAllAppointments.Controls.Add(this.label14);
            this.pnlAllAppointments.Location = new System.Drawing.Point(228, 121);
            this.pnlAllAppointments.Name = "pnlAllAppointments";
            this.pnlAllAppointments.Size = new System.Drawing.Size(300, 150);
            this.pnlAllAppointments.TabIndex = 0;
            this.pnlAllAppointments.Visible = false;
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
            // ALLAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAllAppointments);
            this.Controls.Add(this.btnSearchMain);
            this.Controls.Add(this.dgvAllAppointments);
            this.Name = "ALLAppointments";
            this.Text = "All Appointments";
            this.Load += new System.EventHandler(this.ALLAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).EndInit();
            this.pnlAllAppointments.ResumeLayout(false);
            this.pnlAllAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchMain;
        private System.Windows.Forms.DataGridView dgvAllAppointments;
        private System.Windows.Forms.Panel pnlAllAppointments;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchPatientPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchPatientName;
        private System.Windows.Forms.Label label14;
    }
}