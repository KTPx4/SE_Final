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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.ckShow = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.btnRefStatus = new System.Windows.Forms.Button();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.grbInput2 = new System.Windows.Forms.GroupBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtAgID = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).BeginInit();
            this.grbView.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.grbMana.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.grbInput2.SuspendLayout();
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
            this.dgvViews.Size = new System.Drawing.Size(821, 219);
            this.dgvViews.TabIndex = 0;
            this.dgvViews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViews_CellClick);
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.dgvViews);
            this.grbView.Location = new System.Drawing.Point(6, 259);
            this.grbView.Name = "grbView";
            this.grbView.Padding = new System.Windows.Forms.Padding(0);
            this.grbView.Size = new System.Drawing.Size(836, 238);
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
            this.grbMana.Controls.Add(this.btnRefresh);
            this.grbMana.Controls.Add(this.btnRemove);
            this.grbMana.Controls.Add(this.btnSave);
            this.grbMana.Controls.Add(this.btnEdit);
            this.grbMana.Controls.Add(this.btnAdd);
            this.grbMana.Controls.Add(this.grbInput);
            this.grbMana.Location = new System.Drawing.Point(6, 45);
            this.grbMana.Name = "grbMana";
            this.grbMana.Padding = new System.Windows.Forms.Padding(0);
            this.grbMana.Size = new System.Drawing.Size(836, 199);
            this.grbMana.TabIndex = 6;
            this.grbMana.TabStop = false;
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.ckShow);
            this.grbInput.Controls.Add(this.txtPass);
            this.grbInput.Controls.Add(this.label6);
            this.grbInput.Controls.Add(this.txtID);
            this.grbInput.Controls.Add(this.label3);
            this.grbInput.Controls.Add(this.txtName);
            this.grbInput.Controls.Add(this.label5);
            this.grbInput.Controls.Add(this.txtPhone);
            this.grbInput.Controls.Add(this.label2);
            this.grbInput.Controls.Add(this.txtUser);
            this.grbInput.Controls.Add(this.label4);
            this.grbInput.Controls.Add(this.txtAddr);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInput.Location = new System.Drawing.Point(19, 15);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(808, 122);
            this.grbInput.TabIndex = 1;
            this.grbInput.TabStop = false;
            // 
            // ckShow
            // 
            this.ckShow.AutoSize = true;
            this.ckShow.Location = new System.Drawing.Point(787, 86);
            this.ckShow.Name = "ckShow";
            this.ckShow.Size = new System.Drawing.Size(15, 14);
            this.ckShow.TabIndex = 18;
            this.ckShow.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(657, 78);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 28);
            this.txtPass.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(84, 15);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 28);
            this.txtID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(587, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(369, 15);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 28);
            this.txtName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(585, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(84, 78);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 28);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agent Name";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(657, 15);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 28);
            this.txtUser.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // txtAddr
            // 
            this.txtAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(369, 78);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(124, 28);
            this.txtAddr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agent ID";
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.btnRefStatus);
            this.grbStatus.Controls.Add(this.btnSaveStatus);
            this.grbStatus.Controls.Add(this.grbInput2);
            this.grbStatus.Location = new System.Drawing.Point(6, 45);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Padding = new System.Windows.Forms.Padding(0);
            this.grbStatus.Size = new System.Drawing.Size(836, 199);
            this.grbStatus.TabIndex = 19;
            this.grbStatus.TabStop = false;
            // 
            // btnRefStatus
            // 
            this.btnRefStatus.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRefStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefStatus.FlatAppearance.BorderSize = 0;
            this.btnRefStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefStatus.Location = new System.Drawing.Point(449, 137);
            this.btnRefStatus.Name = "btnRefStatus";
            this.btnRefStatus.Size = new System.Drawing.Size(43, 42);
            this.btnRefStatus.TabIndex = 1;
            this.btnRefStatus.UseVisualStyleBackColor = true;
            this.btnRefStatus.Click += new System.EventHandler(this.btnRefStatus_Click);
            this.btnRefStatus.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefStatus.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.BackgroundImage = global::SEFinal.Properties.Resources.save;
            this.btnSaveStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveStatus.FlatAppearance.BorderSize = 0;
            this.btnSaveStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Location = new System.Drawing.Point(327, 134);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(45, 42);
            this.btnSaveStatus.TabIndex = 3;
            this.btnSaveStatus.UseVisualStyleBackColor = true;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            this.btnSaveStatus.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSaveStatus.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // grbInput2
            // 
            this.grbInput2.Controls.Add(this.txtOrderID);
            this.grbInput2.Controls.Add(this.txtAgID);
            this.grbInput2.Controls.Add(this.txtAName);
            this.grbInput2.Controls.Add(this.label11);
            this.grbInput2.Controls.Add(this.label7);
            this.grbInput2.Controls.Add(this.label9);
            this.grbInput2.Controls.Add(this.cbbStatus);
            this.grbInput2.Controls.Add(this.label12);
            this.grbInput2.Controls.Add(this.label10);
            this.grbInput2.Controls.Add(this.label8);
            this.grbInput2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInput2.Location = new System.Drawing.Point(13, 9);
            this.grbInput2.Name = "grbInput2";
            this.grbInput2.Size = new System.Drawing.Size(808, 106);
            this.grbInput2.TabIndex = 21;
            this.grbInput2.TabStop = false;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(180, 22);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(113, 20);
            this.txtOrderID.TabIndex = 22;
            // 
            // txtAgID
            // 
            this.txtAgID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtAgID.Enabled = false;
            this.txtAgID.Location = new System.Drawing.Point(180, 71);
            this.txtAgID.Name = "txtAgID";
            this.txtAgID.Size = new System.Drawing.Size(113, 20);
            this.txtAgID.TabIndex = 22;
            // 
            // txtAName
            // 
            this.txtAName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtAName.Enabled = false;
            this.txtAName.Location = new System.Drawing.Point(439, 24);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(130, 20);
            this.txtAName.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(632, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "1 for success , -1 for failed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(648, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Status: 0 for waiting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(125, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Order ID";
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(439, 69);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(130, 21);
            this.cbbStatus.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(125, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Agent ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(361, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Agent Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(352, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status Payment";
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.grbMana);
            this.Controls.Add(this.grbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgent";
            this.Text = "frmAgent";
            this.Load += new System.EventHandler(this.frmAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).EndInit();
            this.grbView.ResumeLayout(false);
            this.panelTab.ResumeLayout(false);
            this.grbMana.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbInput2.ResumeLayout(false);
            this.grbInput2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox ckShow;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefStatus;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.ToolTip toolTipText;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbInput2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtAgID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}