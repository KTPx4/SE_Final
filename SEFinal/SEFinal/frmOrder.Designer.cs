namespace SEFinal
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            this.grbDelivery = new System.Windows.Forms.GroupBox();
            this.grbInfoD = new System.Windows.Forms.GroupBox();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.cbbDstatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDorder = new System.Windows.Forms.Button();
            this.btnDEm = new System.Windows.Forms.Button();
            this.cbbDorderID = new System.Windows.Forms.ComboBox();
            this.cbbDEmp = new System.Windows.Forms.ComboBox();
            this.txtDid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.txtRID = new System.Windows.Forms.TextBox();
            this.grbReceipt = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRupdateListG = new System.Windows.Forms.Button();
            this.btnRaddG = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.txtGQuan = new System.Windows.Forms.TextBox();
            this.cbbRGoodsID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.dateR = new System.Windows.Forms.DateTimePicker();
            this.btnOpenSup = new System.Windows.Forms.Button();
            this.btnOpenEmployee = new System.Windows.Forms.Button();
            this.cbbRSupID = new System.Windows.Forms.ComboBox();
            this.cbbREmployee = new System.Windows.Forms.ComboBox();
            this.btnGD = new System.Windows.Forms.Button();
            this.btnGR = new System.Windows.Forms.Button();
            this.panelTab = new System.Windows.Forms.Panel();
            this.grbItems = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.grbViews = new System.Windows.Forms.GroupBox();
            this.dgvViews = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbDelivery.SuspendLayout();
            this.grbInfoD.SuspendLayout();
            this.grbReceipt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.grbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.grbViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDelivery
            // 
            this.grbDelivery.Controls.Add(this.grbInfoD);
            this.grbDelivery.Location = new System.Drawing.Point(6, 57);
            this.grbDelivery.Name = "grbDelivery";
            this.grbDelivery.Padding = new System.Windows.Forms.Padding(0);
            this.grbDelivery.Size = new System.Drawing.Size(836, 121);
            this.grbDelivery.TabIndex = 23;
            this.grbDelivery.TabStop = false;
            // 
            // grbInfoD
            // 
            this.grbInfoD.Controls.Add(this.dateD);
            this.grbInfoD.Controls.Add(this.cbbDstatus);
            this.grbInfoD.Controls.Add(this.label9);
            this.grbInfoD.Controls.Add(this.btnDorder);
            this.grbInfoD.Controls.Add(this.btnDEm);
            this.grbInfoD.Controls.Add(this.cbbDorderID);
            this.grbInfoD.Controls.Add(this.cbbDEmp);
            this.grbInfoD.Controls.Add(this.txtDid);
            this.grbInfoD.Controls.Add(this.label13);
            this.grbInfoD.Controls.Add(this.label14);
            this.grbInfoD.Controls.Add(this.label15);
            this.grbInfoD.Controls.Add(this.label16);
            this.grbInfoD.ForeColor = System.Drawing.SystemColors.Control;
            this.grbInfoD.Location = new System.Drawing.Point(6, 12);
            this.grbInfoD.Name = "grbInfoD";
            this.grbInfoD.Size = new System.Drawing.Size(824, 106);
            this.grbInfoD.TabIndex = 26;
            this.grbInfoD.TabStop = false;
            this.grbInfoD.Text = "Info";
            this.grbInfoD.Enter += new System.EventHandler(this.grbInfoD_Enter);
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(455, 19);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(151, 20);
            this.dateD.TabIndex = 23;
            this.dateD.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            // 
            // cbbDstatus
            // 
            this.cbbDstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbDstatus.FormattingEnabled = true;
            this.cbbDstatus.Location = new System.Drawing.Point(673, 51);
            this.cbbDstatus.Name = "cbbDstatus";
            this.cbbDstatus.Size = new System.Drawing.Size(134, 21);
            this.cbbDstatus.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(696, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status Delivery";
            // 
            // btnDorder
            // 
            this.btnDorder.BackgroundImage = global::SEFinal.Properties.Resources.expand_arrows;
            this.btnDorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDorder.FlatAppearance.BorderSize = 0;
            this.btnDorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDorder.Location = new System.Drawing.Point(585, 63);
            this.btnDorder.Name = "btnDorder";
            this.btnDorder.Size = new System.Drawing.Size(21, 21);
            this.btnDorder.TabIndex = 19;
            this.btnDorder.UseVisualStyleBackColor = true;
            this.btnDorder.Click += new System.EventHandler(this.btnDorder_Click);
            // 
            // btnDEm
            // 
            this.btnDEm.BackgroundImage = global::SEFinal.Properties.Resources.expand_arrows;
            this.btnDEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEm.FlatAppearance.BorderSize = 0;
            this.btnDEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEm.Location = new System.Drawing.Point(288, 63);
            this.btnDEm.Name = "btnDEm";
            this.btnDEm.Size = new System.Drawing.Size(21, 21);
            this.btnDEm.TabIndex = 19;
            this.btnDEm.UseVisualStyleBackColor = true;
            this.btnDEm.Click += new System.EventHandler(this.btnOpenEmployee_Click);
            // 
            // cbbDorderID
            // 
            this.cbbDorderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbDorderID.FormattingEnabled = true;
            this.cbbDorderID.Location = new System.Drawing.Point(454, 63);
            this.cbbDorderID.Name = "cbbDorderID";
            this.cbbDorderID.Size = new System.Drawing.Size(125, 21);
            this.cbbDorderID.TabIndex = 18;
            this.cbbDorderID.SelectedIndexChanged += new System.EventHandler(this.cbbDorderID_SelectedIndexChanged);
            // 
            // cbbDEmp
            // 
            this.cbbDEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbDEmp.FormattingEnabled = true;
            this.cbbDEmp.Location = new System.Drawing.Point(185, 64);
            this.cbbDEmp.Name = "cbbDEmp";
            this.cbbDEmp.Size = new System.Drawing.Size(97, 21);
            this.cbbDEmp.TabIndex = 18;
            // 
            // txtDid
            // 
            this.txtDid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtDid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDid.Location = new System.Drawing.Point(185, 19);
            this.txtDid.Name = "txtDid";
            this.txtDid.Size = new System.Drawing.Size(124, 22);
            this.txtDid.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(384, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Order ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(113, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Delivery ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(375, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Delivery Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(109, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Suplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Receipt Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Receipt ID";
            // 
            // txtRID
            // 
            this.txtRID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRID.Location = new System.Drawing.Point(82, 24);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(124, 22);
            this.txtRID.TabIndex = 11;
            // 
            // grbReceipt
            // 
            this.grbReceipt.Controls.Add(this.groupBox1);
            this.grbReceipt.Controls.Add(this.grbInfo);
            this.grbReceipt.Location = new System.Drawing.Point(6, 53);
            this.grbReceipt.Name = "grbReceipt";
            this.grbReceipt.Padding = new System.Windows.Forms.Padding(0);
            this.grbReceipt.Size = new System.Drawing.Size(836, 125);
            this.grbReceipt.TabIndex = 22;
            this.grbReceipt.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRupdateListG);
            this.groupBox1.Controls.Add(this.btnRaddG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGName);
            this.groupBox1.Controls.Add(this.txtGQuan);
            this.groupBox1.Controls.Add(this.cbbRGoodsID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(527, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods";
            // 
            // btnRupdateListG
            // 
            this.btnRupdateListG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.btnRupdateListG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRupdateListG.FlatAppearance.BorderSize = 0;
            this.btnRupdateListG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRupdateListG.ForeColor = System.Drawing.Color.Black;
            this.btnRupdateListG.Location = new System.Drawing.Point(230, 62);
            this.btnRupdateListG.Name = "btnRupdateListG";
            this.btnRupdateListG.Size = new System.Drawing.Size(68, 41);
            this.btnRupdateListG.TabIndex = 19;
            this.btnRupdateListG.Text = "Update";
            this.btnRupdateListG.UseVisualStyleBackColor = false;
            this.btnRupdateListG.Click += new System.EventHandler(this.btnRupdateListG_Click);
            // 
            // btnRaddG
            // 
            this.btnRaddG.BackgroundImage = global::SEFinal.Properties.Resources.add_to_cart;
            this.btnRaddG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRaddG.FlatAppearance.BorderSize = 0;
            this.btnRaddG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaddG.Location = new System.Drawing.Point(245, 9);
            this.btnRaddG.Name = "btnRaddG";
            this.btnRaddG.Size = new System.Drawing.Size(41, 41);
            this.btnRaddG.TabIndex = 19;
            this.btnRaddG.UseVisualStyleBackColor = true;
            this.btnRaddG.Click += new System.EventHandler(this.btnRaddG_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // txtGName
            // 
            this.txtGName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtGName.Enabled = false;
            this.txtGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGName.Location = new System.Drawing.Point(86, 46);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(111, 22);
            this.txtGName.TabIndex = 11;
            // 
            // txtGQuan
            // 
            this.txtGQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtGQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGQuan.Location = new System.Drawing.Point(86, 74);
            this.txtGQuan.Name = "txtGQuan";
            this.txtGQuan.Size = new System.Drawing.Size(111, 22);
            this.txtGQuan.TabIndex = 11;
            this.txtGQuan.TextChanged += new System.EventHandler(this.txtGQuan_TextChanged);
            // 
            // cbbRGoodsID
            // 
            this.cbbRGoodsID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbRGoodsID.FormattingEnabled = true;
            this.cbbRGoodsID.Location = new System.Drawing.Point(86, 20);
            this.cbbRGoodsID.Name = "cbbRGoodsID";
            this.cbbRGoodsID.Size = new System.Drawing.Size(111, 21);
            this.cbbRGoodsID.TabIndex = 18;
            this.cbbRGoodsID.SelectedIndexChanged += new System.EventHandler(this.cbbRGoodsID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Goods Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Goods ID";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.dateR);
            this.grbInfo.Controls.Add(this.btnOpenSup);
            this.grbInfo.Controls.Add(this.btnOpenEmployee);
            this.grbInfo.Controls.Add(this.cbbRSupID);
            this.grbInfo.Controls.Add(this.cbbREmployee);
            this.grbInfo.Controls.Add(this.txtRID);
            this.grbInfo.Controls.Add(this.label3);
            this.grbInfo.Controls.Add(this.label1);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Controls.Add(this.label4);
            this.grbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.grbInfo.Location = new System.Drawing.Point(6, 11);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(515, 110);
            this.grbInfo.TabIndex = 19;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Info";
            // 
            // dateR
            // 
            this.dateR.Location = new System.Drawing.Point(351, 26);
            this.dateR.Name = "dateR";
            this.dateR.Size = new System.Drawing.Size(151, 20);
            this.dateR.TabIndex = 20;
            this.dateR.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            // 
            // btnOpenSup
            // 
            this.btnOpenSup.BackgroundImage = global::SEFinal.Properties.Resources.expand_arrows;
            this.btnOpenSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenSup.FlatAppearance.BorderSize = 0;
            this.btnOpenSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSup.Location = new System.Drawing.Point(454, 67);
            this.btnOpenSup.Name = "btnOpenSup";
            this.btnOpenSup.Size = new System.Drawing.Size(21, 21);
            this.btnOpenSup.TabIndex = 19;
            this.btnOpenSup.UseVisualStyleBackColor = true;
            this.btnOpenSup.Click += new System.EventHandler(this.btnOpenSup_Click);
            // 
            // btnOpenEmployee
            // 
            this.btnOpenEmployee.BackgroundImage = global::SEFinal.Properties.Resources.expand_arrows;
            this.btnOpenEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenEmployee.FlatAppearance.BorderSize = 0;
            this.btnOpenEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEmployee.Location = new System.Drawing.Point(185, 68);
            this.btnOpenEmployee.Name = "btnOpenEmployee";
            this.btnOpenEmployee.Size = new System.Drawing.Size(21, 21);
            this.btnOpenEmployee.TabIndex = 19;
            this.btnOpenEmployee.UseVisualStyleBackColor = true;
            this.btnOpenEmployee.Click += new System.EventHandler(this.btnOpenEmployee_Click);
            // 
            // cbbRSupID
            // 
            this.cbbRSupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbRSupID.FormattingEnabled = true;
            this.cbbRSupID.Location = new System.Drawing.Point(351, 68);
            this.cbbRSupID.Name = "cbbRSupID";
            this.cbbRSupID.Size = new System.Drawing.Size(97, 21);
            this.cbbRSupID.TabIndex = 18;
            // 
            // cbbREmployee
            // 
            this.cbbREmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbREmployee.FormattingEnabled = true;
            this.cbbREmployee.Location = new System.Drawing.Point(82, 69);
            this.cbbREmployee.Name = "cbbREmployee";
            this.cbbREmployee.Size = new System.Drawing.Size(97, 21);
            this.cbbREmployee.TabIndex = 18;
            // 
            // btnGD
            // 
            this.btnGD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGD.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGD.FlatAppearance.BorderSize = 0;
            this.btnGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD.Location = new System.Drawing.Point(418, 0);
            this.btnGD.Name = "btnGD";
            this.btnGD.Size = new System.Drawing.Size(418, 48);
            this.btnGD.TabIndex = 1;
            this.btnGD.Text = "Goods Delivery";
            this.btnGD.UseVisualStyleBackColor = false;
            this.btnGD.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnGR
            // 
            this.btnGR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnGR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGR.FlatAppearance.BorderSize = 0;
            this.btnGR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGR.Location = new System.Drawing.Point(0, 0);
            this.btnGR.Name = "btnGR";
            this.btnGR.Size = new System.Drawing.Size(418, 48);
            this.btnGR.TabIndex = 0;
            this.btnGR.Text = "Goods Receipt";
            this.btnGR.UseVisualStyleBackColor = false;
            this.btnGR.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.btnGD);
            this.panelTab.Controls.Add(this.btnGR);
            this.panelTab.Location = new System.Drawing.Point(6, 8);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(836, 48);
            this.panelTab.TabIndex = 21;
            // 
            // grbItems
            // 
            this.grbItems.Controls.Add(this.dgvItem);
            this.grbItems.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grbItems.Location = new System.Drawing.Point(6, 251);
            this.grbItems.Name = "grbItems";
            this.grbItems.Padding = new System.Windows.Forms.Padding(0);
            this.grbItems.Size = new System.Drawing.Size(310, 241);
            this.grbItems.TabIndex = 20;
            this.grbItems.TabStop = false;
            this.grbItems.Text = "List Item";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToOrderColumns = true;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(6, 15);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.Size = new System.Drawing.Size(294, 222);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // grbViews
            // 
            this.grbViews.Controls.Add(this.dgvViews);
            this.grbViews.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grbViews.Location = new System.Drawing.Point(312, 251);
            this.grbViews.Name = "grbViews";
            this.grbViews.Padding = new System.Windows.Forms.Padding(0);
            this.grbViews.Size = new System.Drawing.Size(530, 241);
            this.grbViews.TabIndex = 21;
            this.grbViews.TabStop = false;
            this.grbViews.Text = "Order";
            // 
            // dgvViews
            // 
            this.dgvViews.AllowUserToAddRows = false;
            this.dgvViews.AllowUserToDeleteRows = false;
            this.dgvViews.AllowUserToOrderColumns = true;
            this.dgvViews.AllowUserToResizeColumns = false;
            this.dgvViews.AllowUserToResizeRows = false;
            this.dgvViews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViews.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViews.Location = new System.Drawing.Point(6, 15);
            this.dgvViews.Name = "dgvViews";
            this.dgvViews.RowHeadersVisible = false;
            this.dgvViews.Size = new System.Drawing.Size(518, 222);
            this.dgvViews.TabIndex = 0;
            this.dgvViews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViews_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(559, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SEFinal.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(427, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAdd.BackgroundImage = global::SEFinal.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(274, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 51);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbViews);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbItems);
            this.Controls.Add(this.grbReceipt);
            this.Controls.Add(this.grbDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grbDelivery.ResumeLayout(false);
            this.grbInfoD.ResumeLayout(false);
            this.grbInfoD.PerformLayout();
            this.grbReceipt.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.grbItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.grbViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipText;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.GroupBox grbReceipt;
        private System.Windows.Forms.Button btnGD;
        private System.Windows.Forms.Button btnGR;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.GroupBox grbItems;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.GroupBox grbViews;
        private System.Windows.Forms.DataGridView dgvViews;
        private System.Windows.Forms.ComboBox cbbREmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGQuan;
        private System.Windows.Forms.ComboBox cbbRGoodsID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Button btnRaddG;
        private System.Windows.Forms.Button btnRupdateListG;
        private System.Windows.Forms.Button btnOpenEmployee;
        private System.Windows.Forms.Button btnOpenSup;
        private System.Windows.Forms.ComboBox cbbRSupID;
        private System.Windows.Forms.GroupBox grbInfoD;
        private System.Windows.Forms.Button btnDorder;
        private System.Windows.Forms.Button btnDEm;
        private System.Windows.Forms.ComboBox cbbDorderID;
        private System.Windows.Forms.ComboBox cbbDEmp;
        private System.Windows.Forms.TextBox txtDid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbDstatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.DateTimePicker dateR;
        private System.Windows.Forms.DateTimePicker dateD;
    }
}