namespace HMS_Solution.Forms
{
    partial class UpdateLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLicenseKey = new System.Windows.Forms.TextBox();
            this.btnUpdateLIcense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter license key";
            // 
            // tbLicenseKey
            // 
            this.tbLicenseKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicenseKey.Location = new System.Drawing.Point(154, 27);
            this.tbLicenseKey.Name = "tbLicenseKey";
            this.tbLicenseKey.Size = new System.Drawing.Size(276, 27);
            this.tbLicenseKey.TabIndex = 0;
            this.tbLicenseKey.UseSystemPasswordChar = true;
            // 
            // btnUpdateLIcense
            // 
            this.btnUpdateLIcense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLIcense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLIcense.Location = new System.Drawing.Point(196, 76);
            this.btnUpdateLIcense.Name = "btnUpdateLIcense";
            this.btnUpdateLIcense.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateLIcense.TabIndex = 1;
            this.btnUpdateLIcense.Text = "Update";
            this.btnUpdateLIcense.UseVisualStyleBackColor = true;
            this.btnUpdateLIcense.Click += new System.EventHandler(this.btnUpdateLIcense_Click);
            // 
            // UpdateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 138);
            this.Controls.Add(this.btnUpdateLIcense);
            this.Controls.Add(this.tbLicenseKey);
            this.Controls.Add(this.label1);
            this.Name = "UpdateLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLicenseKey;
        private System.Windows.Forms.Button btnUpdateLIcense;
    }
}