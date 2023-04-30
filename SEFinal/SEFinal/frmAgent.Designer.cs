namespace SEFinal
{
    partial class frmAgent
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
            this.dgvViews = new System.Windows.Forms.DataGridView();
            this.grbView = new System.Windows.Forms.GroupBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.grbMana = new System.Windows.Forms.GroupBox();
            this.ckShow = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbANameview = new System.Windows.Forms.ComboBox();
            this.cbbAIDview = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefStatus = new System.Windows.Forms.Button();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.btnEditstatus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).BeginInit();
            this.grbView.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.grbMana.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvViews.Size = new System.Drawing.Size(821, 222);
            this.dgvViews.TabIndex = 0;
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.dgvViews);
            this.grbView.Location = new System.Drawing.Point(6, 247);
            this.grbView.Name = "grbView";
            this.grbView.Padding = new System.Windows.Forms.Padding(0);
            this.grbView.Size = new System.Drawing.Size(836, 241);
            this.grbView.TabIndex = 2;
            this.grbView.TabStop = false;
            this.grbView.Paint += new System.Windows.Forms.PaintEventHandler(this.grbView_Paint);
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.btnStatus);
            this.panelTab.Controls.Add(this.btnManage);
            this.panelTab.Location = new System.Drawing.Point(6, 4);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(836, 48);
            this.panelTab.TabIndex = 5;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(418, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(418, 48);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Status Payment";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(0, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(418, 48);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Manage Agent";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // grbMana
            // 
            this.grbMana.Controls.Add(this.ckShow);
            this.grbMana.Controls.Add(this.label6);
            this.grbMana.Controls.Add(this.label3);
            this.grbMana.Controls.Add(this.label5);
            this.grbMana.Controls.Add(this.label2);
            this.grbMana.Controls.Add(this.label4);
            this.grbMana.Controls.Add(this.label1);
            this.grbMana.Controls.Add(this.txtAddr);
            this.grbMana.Controls.Add(this.txtPass);
            this.grbMana.Controls.Add(this.txtUser);
            this.grbMana.Controls.Add(this.txtPhone);
            this.grbMana.Controls.Add(this.txtAName);
            this.grbMana.Controls.Add(this.txtAID);
            this.grbMana.Controls.Add(this.btnRefresh);
            this.grbMana.Controls.Add(this.btnRemove);
            this.grbMana.Controls.Add(this.btnSave);
            this.grbMana.Controls.Add(this.btnEdit);
            this.grbMana.Controls.Add(this.btnAdd);
            this.grbMana.Location = new System.Drawing.Point(6, 45);
            this.grbMana.Name = "grbMana";
            this.grbMana.Padding = new System.Windows.Forms.Padding(0);
            this.grbMana.Size = new System.Drawing.Size(836, 199);
            this.grbMana.TabIndex = 6;
            this.grbMana.TabStop = false;
            // 
            // ckShow
            // 
            this.ckShow.AutoSize = true;
            this.ckShow.Location = new System.Drawing.Point(800, 91);
            this.ckShow.Name = "ckShow";
            this.ckShow.Size = new System.Drawing.Size(15, 14);
            this.ckShow.TabIndex = 18;
            this.ckShow.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(315, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(598, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agent Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agent ID";
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(382, 83);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(124, 28);
            this.txtAddr.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(670, 83);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 28);
            this.txtPass.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(670, 20);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 28);
            this.txtUser.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(97, 83);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 28);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAName
            // 
            this.txtAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAName.Location = new System.Drawing.Point(382, 20);
            this.txtAName.Multiline = true;
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(124, 28);
            this.txtAName.TabIndex = 10;
            // 
            // txtAID
            // 
            this.txtAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAID.Location = new System.Drawing.Point(97, 20);
            this.txtAID.Multiline = true;
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(124, 28);
            this.txtAID.TabIndex = 11;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.cbbStatus);
            this.grbStatus.Controls.Add(this.cbbANameview);
            this.grbStatus.Controls.Add(this.cbbAIDview);
            this.grbStatus.Controls.Add(this.label8);
            this.grbStatus.Controls.Add(this.label10);
            this.grbStatus.Controls.Add(this.label12);
            this.grbStatus.Controls.Add(this.btnRefStatus);
            this.grbStatus.Controls.Add(this.btnSaveStatus);
            this.grbStatus.Controls.Add(this.btnEditstatus);
            this.grbStatus.Location = new System.Drawing.Point(6, 45);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Padding = new System.Windows.Forms.Padding(0);
            this.grbStatus.Size = new System.Drawing.Size(836, 199);
            this.grbStatus.TabIndex = 19;
            this.grbStatus.TabStop = false;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(666, 58);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(134, 21);
            this.cbbStatus.TabIndex = 20;
            // 
            // cbbANameview
            // 
            this.cbbANameview.FormattingEnabled = true;
            this.cbbANameview.Location = new System.Drawing.Point(386, 58);
            this.cbbANameview.Name = "cbbANameview";
            this.cbbANameview.Size = new System.Drawing.Size(134, 21);
            this.cbbANameview.TabIndex = 19;
            // 
            // cbbAIDview
            // 
            this.cbbAIDview.FormattingEnabled = true;
            this.cbbAIDview.Location = new System.Drawing.Point(97, 58);
            this.cbbAIDview.Name = "cbbAIDview";
            this.cbbAIDview.Size = new System.Drawing.Size(134, 21);
            this.cbbAIDview.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(579, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(291, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Agent Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(37, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Agent ID";
            // 
            // btnRefStatus
            // 
            this.btnRefStatus.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRefStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefStatus.FlatAppearance.BorderSize = 0;
            this.btnRefStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefStatus.Location = new System.Drawing.Point(526, 122);
            this.btnRefStatus.Name = "btnRefStatus";
            this.btnRefStatus.Size = new System.Drawing.Size(43, 42);
            this.btnRefStatus.TabIndex = 1;
            this.btnRefStatus.UseVisualStyleBackColor = true;
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.BackgroundImage = global::SEFinal.Properties.Resources.save;
            this.btnSaveStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveStatus.FlatAppearance.BorderSize = 0;
            this.btnSaveStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Location = new System.Drawing.Point(404, 123);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(45, 42);
            this.btnSaveStatus.TabIndex = 3;
            this.btnSaveStatus.UseVisualStyleBackColor = true;
            // 
            // btnEditstatus
            // 
            this.btnEditstatus.BackgroundImage = global::SEFinal.Properties.Resources.edit;
            this.btnEditstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditstatus.FlatAppearance.BorderSize = 0;
            this.btnEditstatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditstatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditstatus.Location = new System.Drawing.Point(269, 123);
            this.btnEditstatus.Name = "btnEditstatus";
            this.btnEditstatus.Size = new System.Drawing.Size(41, 42);
            this.btnEditstatus.TabIndex = 4;
            this.btnEditstatus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(646, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::SEFinal.Properties.Resources.delete;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(526, 145);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 42);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnRemove.MouseHover += new System.EventHandler(this.btnRemove_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SEFinal.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(398, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::SEFinal.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(269, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
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
            this.btnAdd.Location = new System.Drawing.Point(152, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 51);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.grbMana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgent";
            this.Text = "frmAgent";
            this.Load += new System.EventHandler(this.frmAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).EndInit();
            this.grbView.ResumeLayout(false);
            this.panelTab.ResumeLayout(false);
            this.grbMana.ResumeLayout(false);
            this.grbMana.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViews;
        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.GroupBox grbMana;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.CheckBox ckShow;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ComboBox cbbANameview;
        private System.Windows.Forms.ComboBox cbbAIDview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefStatus;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.Button btnEditstatus;
        private System.Windows.Forms.ToolTip toolTipText;
    }
}