namespace HMS_Solution.Forms.UserForm
{
    partial class ALLUsers
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
            this.pnlViewUser = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSearchUsername = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchUName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlViewUser.SuspendLayout();
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
            this.dataGridView1.TabIndex = 13;
            // 
            // pnlViewUser
            // 
            this.pnlViewUser.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlViewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewUser.Controls.Add(this.btnSearch);
            this.pnlViewUser.Controls.Add(this.btnCancel);
            this.pnlViewUser.Controls.Add(this.tbSearchUsername);
            this.pnlViewUser.Controls.Add(this.label15);
            this.pnlViewUser.Controls.Add(this.tbSearchUName);
            this.pnlViewUser.Controls.Add(this.label14);
            this.pnlViewUser.Location = new System.Drawing.Point(228, 121);
            this.pnlViewUser.Name = "pnlViewUser";
            this.pnlViewUser.Size = new System.Drawing.Size(300, 150);
            this.pnlViewUser.TabIndex = 0;
            this.pnlViewUser.Visible = false;
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
            // tbSearchUsername
            // 
            this.tbSearchUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchUsername.Location = new System.Drawing.Point(95, 56);
            this.tbSearchUsername.Name = "tbSearchUsername";
            this.tbSearchUsername.Size = new System.Drawing.Size(193, 25);
            this.tbSearchUsername.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Username";
            // 
            // tbSearchUName
            // 
            this.tbSearchUName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchUName.Location = new System.Drawing.Point(95, 25);
            this.tbSearchUName.Name = "tbSearchUName";
            this.tbSearchUName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchUName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "User\'s Name";
            // 
            // ALLUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewUser);
            this.Controls.Add(this.btnSearchMain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALLUsers";
            this.Text = "All Users";
            this.Load += new System.EventHandler(this.ALLUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlViewUser.ResumeLayout(false);
            this.pnlViewUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlViewUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSearchUsername;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchUName;
        private System.Windows.Forms.Label label14;
    }
}