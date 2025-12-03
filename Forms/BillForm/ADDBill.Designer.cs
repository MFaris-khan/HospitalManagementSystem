namespace HMS_Solution
{
    partial class ADDBill
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
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnSearchPatientID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReceivedAmount = new System.Windows.Forms.TextBox();
            this.tbServiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPatientID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlSearchServiceName = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSearchServiceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSelectedServices = new System.Windows.Forms.ListBox();
            this.lbID = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbBillingInfo = new System.Windows.Forms.GroupBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSearchPatientName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearchPatientPhone = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearchPatientID = new System.Windows.Forms.Panel();
            this.lbCost = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlSearchServiceName.SuspendLayout();
            this.gbBillingInfo.SuspendLayout();
            this.pnlSearchPatientID.SuspendLayout();
            this.SuspendLayout();
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
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid",
            "Installments"});
            this.cbStatus.Location = new System.Drawing.Point(122, 89);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(215, 25);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.Text = "Select";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "JazzCash",
            "Easypaisa",
            "Bank Transfer"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(122, 58);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(215, 25);
            this.cbPaymentMethod.TabIndex = 1;
            this.cbPaymentMethod.Text = "Select";
            // 
            // btnSearchPatientID
            // 
            this.btnSearchPatientID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPatientID.Location = new System.Drawing.Point(313, 27);
            this.btnSearchPatientID.Name = "btnSearchPatientID";
            this.btnSearchPatientID.Size = new System.Drawing.Size(24, 23);
            this.btnSearchPatientID.TabIndex = 9;
            this.btnSearchPatientID.Text = "...";
            this.btnSearchPatientID.UseVisualStyleBackColor = true;
            this.btnSearchPatientID.Click += new System.EventHandler(this.btnSearchPatientID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Service ID";
            // 
            // tbReceivedAmount
            // 
            this.tbReceivedAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceivedAmount.Location = new System.Drawing.Point(584, 373);
            this.tbReceivedAmount.Name = "tbReceivedAmount";
            this.tbReceivedAmount.Size = new System.Drawing.Size(202, 25);
            this.tbReceivedAmount.TabIndex = 6;
            // 
            // tbServiceID
            // 
            this.tbServiceID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceID.Location = new System.Drawing.Point(122, 32);
            this.tbServiceID.Name = "tbServiceID";
            this.tbServiceID.Size = new System.Drawing.Size(185, 25);
            this.tbServiceID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // tbPatientID
            // 
            this.tbPatientID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientID.Location = new System.Drawing.Point(122, 26);
            this.tbPatientID.Name = "tbPatientID";
            this.tbPatientID.Size = new System.Drawing.Size(185, 25);
            this.tbPatientID.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(713, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(632, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(713, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchList);
            this.panel1.Location = new System.Drawing.Point(13, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 146);
            this.panel1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.cbPaymentMethod);
            this.groupBox2.Controls.Add(this.btnSearchPatientID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPatientID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 131);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing Information";
            // 
            // btnAddService
            // 
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Location = new System.Drawing.Point(191, 99);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(46, 23);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "ADD";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlSearchServiceName
            // 
            this.pnlSearchServiceName.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlSearchServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchServiceName.Controls.Add(this.button1);
            this.pnlSearchServiceName.Controls.Add(this.button2);
            this.pnlSearchServiceName.Controls.Add(this.tbSearchServiceName);
            this.pnlSearchServiceName.Controls.Add(this.label7);
            this.pnlSearchServiceName.Location = new System.Drawing.Point(239, 110);
            this.pnlSearchServiceName.Name = "pnlSearchServiceName";
            this.pnlSearchServiceName.Size = new System.Drawing.Size(300, 150);
            this.pnlSearchServiceName.TabIndex = 0;
            this.pnlSearchServiceName.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(110, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSearchServiceName
            // 
            this.tbSearchServiceName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchServiceName.Location = new System.Drawing.Point(95, 41);
            this.tbSearchServiceName.Name = "tbSearchServiceName";
            this.tbSearchServiceName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchServiceName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Service Name";
            // 
            // lbSelectedServices
            // 
            this.lbSelectedServices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSelectedServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedServices.FormattingEnabled = true;
            this.lbSelectedServices.ItemHeight = 15;
            this.lbSelectedServices.Location = new System.Drawing.Point(584, 32);
            this.lbSelectedServices.Name = "lbSelectedServices";
            this.lbSelectedServices.Size = new System.Drawing.Size(103, 304);
            this.lbSelectedServices.TabIndex = 33;
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.FormattingEnabled = true;
            this.lbID.ItemHeight = 15;
            this.lbID.Location = new System.Drawing.Point(550, 32);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 304);
            this.lbID.TabIndex = 33;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(539, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 17);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(584, 342);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(202, 25);
            this.tbTotal.TabIndex = 35;
            this.tbTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Services";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(692, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Qty";
            // 
            // lbQty
            // 
            this.lbQty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQty.FormattingEnabled = true;
            this.lbQty.ItemHeight = 15;
            this.lbQty.Location = new System.Drawing.Point(692, 32);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(30, 304);
            this.lbQty.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Received:";
            // 
            // gbBillingInfo
            // 
            this.gbBillingInfo.Controls.Add(this.tbQty);
            this.gbBillingInfo.Controls.Add(this.label5);
            this.gbBillingInfo.Controls.Add(this.tbServiceID);
            this.gbBillingInfo.Controls.Add(this.label2);
            this.gbBillingInfo.Controls.Add(this.button3);
            this.gbBillingInfo.Controls.Add(this.btnAddService);
            this.gbBillingInfo.Location = new System.Drawing.Point(12, 152);
            this.gbBillingInfo.Name = "gbBillingInfo";
            this.gbBillingInfo.Size = new System.Drawing.Size(343, 138);
            this.gbBillingInfo.TabIndex = 41;
            this.gbBillingInfo.TabStop = false;
            this.gbBillingInfo.Text = "Add Services";
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(122, 64);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(215, 25);
            this.tbQty.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
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
            // tbSearchPatientName
            // 
            this.tbSearchPatientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPatientName.Location = new System.Drawing.Point(95, 25);
            this.tbSearchPatientName.Name = "tbSearchPatientName";
            this.tbSearchPatientName.Size = new System.Drawing.Size(193, 25);
            this.tbSearchPatientName.TabIndex = 0;
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
            // tbSearchPatientPhone
            // 
            this.tbSearchPatientPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPatientPhone.Location = new System.Drawing.Point(95, 56);
            this.tbSearchPatientPhone.Name = "tbSearchPatientPhone";
            this.tbSearchPatientPhone.Size = new System.Drawing.Size(193, 25);
            this.tbSearchPatientPhone.TabIndex = 1;
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
            // pnlSearchPatientID
            // 
            this.pnlSearchPatientID.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlSearchPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchPatientID.Controls.Add(this.btnSearch);
            this.pnlSearchPatientID.Controls.Add(this.btnCancel);
            this.pnlSearchPatientID.Controls.Add(this.tbSearchPatientPhone);
            this.pnlSearchPatientID.Controls.Add(this.label15);
            this.pnlSearchPatientID.Controls.Add(this.tbSearchPatientName);
            this.pnlSearchPatientID.Controls.Add(this.label14);
            this.pnlSearchPatientID.Location = new System.Drawing.Point(239, 123);
            this.pnlSearchPatientID.Name = "pnlSearchPatientID";
            this.pnlSearchPatientID.Size = new System.Drawing.Size(300, 150);
            this.pnlSearchPatientID.TabIndex = 0;
            this.pnlSearchPatientID.Visible = false;
            // 
            // lbCost
            // 
            this.lbCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.FormattingEnabled = true;
            this.lbCost.ItemHeight = 15;
            this.lbCost.Location = new System.Drawing.Point(728, 32);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(58, 304);
            this.lbCost.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(738, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cost";
            // 
            // ADDBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearchServiceName);
            this.Controls.Add(this.pnlSearchPatientID);
            this.Controls.Add(this.gbBillingInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbSelectedServices);
            this.Controls.Add(this.tbReceivedAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ADDBill";
            this.Text = "Add Bill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSearchServiceName.ResumeLayout(false);
            this.pnlSearchServiceName.PerformLayout();
            this.gbBillingInfo.ResumeLayout(false);
            this.gbBillingInfo.PerformLayout();
            this.pnlSearchPatientID.ResumeLayout(false);
            this.pnlSearchPatientID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Button btnSearchPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReceivedAmount;
        private System.Windows.Forms.TextBox tbServiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatientID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlSearchServiceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSearchServiceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSelectedServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbBillingInfo;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSearchPatientName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchPatientPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearchPatientID;
        private System.Windows.Forms.ListBox lbCost;
        private System.Windows.Forms.Label label11;
    }
}