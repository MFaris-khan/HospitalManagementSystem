namespace HMS_Solution.Forms.BillForm
{
    partial class DELETEService
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
            this.pnlDeleteAppointment = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchServiceName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelMain = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbServiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchServiceID = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSearchResult = new System.Windows.Forms.Panel();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.pnlDeleteAppointment.SuspendLayout();
            this.pnlSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeleteAppointment
            // 
            this.pnlDeleteAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlDeleteAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteAppointment.Controls.Add(this.btnSearch);
            this.pnlDeleteAppointment.Controls.Add(this.btnCancel);
            this.pnlDeleteAppointment.Controls.Add(this.tbSearchServiceName);
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
            // tbSearchServiceName
            // 
            this.tbSearchServiceName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchServiceName.Location = new System.Drawing.Point(95, 51);
            this.tbSearchServiceName.Name = "tbSearchServiceName";
            this.tbSearchServiceName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchServiceName.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Service Name";
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMain.Location = new System.Drawing.Point(96, 73);
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
            this.btnDelete.Location = new System.Drawing.Point(162, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbServiceID
            // 
            this.tbServiceID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceID.Location = new System.Drawing.Point(96, 22);
            this.tbServiceID.Name = "tbServiceID";
            this.tbServiceID.Size = new System.Drawing.Size(116, 25);
            this.tbServiceID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Service ID";
            // 
            // btnSearchServiceID
            // 
            this.btnSearchServiceID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchServiceID.Location = new System.Drawing.Point(218, 22);
            this.btnSearchServiceID.Name = "btnSearchServiceID";
            this.btnSearchServiceID.Size = new System.Drawing.Size(33, 26);
            this.btnSearchServiceID.TabIndex = 3;
            this.btnSearchServiceID.Text = "...";
            this.btnSearchServiceID.UseVisualStyleBackColor = true;
            this.btnSearchServiceID.Click += new System.EventHandler(this.btnSearchServiceID_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(712, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSearchResult
            // 
            this.pnlSearchResult.Controls.Add(this.dgvSearchResult);
            this.pnlSearchResult.Location = new System.Drawing.Point(12, 197);
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.Size = new System.Drawing.Size(775, 146);
            this.pnlSearchResult.TabIndex = 44;
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
            // DELETEService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.pnlDeleteAppointment);
            this.Controls.Add(this.btnCancelMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbServiceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchServiceID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlSearchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DELETEService";
            this.Text = "DELETEService";
            this.pnlDeleteAppointment.ResumeLayout(false);
            this.pnlDeleteAppointment.PerformLayout();
            this.pnlSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchServiceName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbServiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchServiceID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSearchResult;
        private System.Windows.Forms.DataGridView dgvSearchResult;
    }
}