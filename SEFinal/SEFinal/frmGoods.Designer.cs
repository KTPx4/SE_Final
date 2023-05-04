namespace SEFinal
{
    partial class frmGoods
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
            this.grbView = new System.Windows.Forms.GroupBox();
            this.dgvViews = new System.Windows.Forms.DataGridView();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.grbInput1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).BeginInit();
            this.grbControl.SuspendLayout();
            this.grbInput1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.dgvViews);
            this.grbView.Location = new System.Drawing.Point(6, 245);
            this.grbView.Name = "grbView";
            this.grbView.Size = new System.Drawing.Size(833, 250);
            this.grbView.TabIndex = 1;
            this.grbView.TabStop = false;
            this.grbView.Paint += new System.Windows.Forms.PaintEventHandler(this.grbView_Paint);
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
            this.dgvViews.Location = new System.Drawing.Point(6, 9);
            this.dgvViews.Name = "dgvViews";
            this.dgvViews.RowHeadersVisible = false;
            this.dgvViews.Size = new System.Drawing.Size(821, 235);
            this.dgvViews.TabIndex = 0;
            this.dgvViews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViews_CellClick);
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnRefresh);
            this.grbControl.Controls.Add(this.btnRemove);
            this.grbControl.Controls.Add(this.btnSave);
            this.grbControl.Controls.Add(this.btnEdit);
            this.grbControl.Controls.Add(this.btnAdd);
            this.grbControl.Location = new System.Drawing.Point(6, 154);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(833, 85);
            this.grbControl.TabIndex = 1;
            this.grbControl.TabStop = false;
            this.grbControl.Paint += new System.Windows.Forms.PaintEventHandler(this.grbControl_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(664, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 42);
            this.btnRefresh.TabIndex = 0;
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
            this.btnRemove.Location = new System.Drawing.Point(544, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 42);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
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
            this.btnSave.Location = new System.Drawing.Point(416, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 42);
            this.btnSave.TabIndex = 0;
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
            this.btnEdit.Location = new System.Drawing.Point(287, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 42);
            this.btnEdit.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(170, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // grbInput1
            // 
            this.grbInput1.Controls.Add(this.label6);
            this.grbInput1.Controls.Add(this.label3);
            this.grbInput1.Controls.Add(this.label5);
            this.grbInput1.Controls.Add(this.label2);
            this.grbInput1.Controls.Add(this.label4);
            this.grbInput1.Controls.Add(this.label1);
            this.grbInput1.Controls.Add(this.txtQuan);
            this.grbInput1.Controls.Add(this.txtPrice);
            this.grbInput1.Controls.Add(this.txtCountry);
            this.grbInput1.Controls.Add(this.txtUnit);
            this.grbInput1.Controls.Add(this.txtName);
            this.grbInput1.Controls.Add(this.txtID);
            this.grbInput1.Location = new System.Drawing.Point(6, 2);
            this.grbInput1.Name = "grbInput1";
            this.grbInput1.Size = new System.Drawing.Size(833, 142);
            this.grbInput1.TabIndex = 6;
            this.grbInput1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(561, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity Warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(315, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(601, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Goods Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Goods ID";
            // 
            // txtQuan
            // 
            this.txtQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.Location = new System.Drawing.Point(673, 26);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(124, 28);
            this.txtQuan.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(673, 89);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 28);
            this.txtPrice.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(385, 89);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(124, 28);
            this.txtCountry.TabIndex = 4;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(100, 89);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(124, 28);
            this.txtUnit.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(385, 26);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 28);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(100, 26);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 28);
            this.txtID.TabIndex = 7;
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.grbInput1);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.grbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGoods";
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.grbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).EndInit();
            this.grbControl.ResumeLayout(false);
            this.grbInput1.ResumeLayout(false);
            this.grbInput1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTipText;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvViews;
        private System.Windows.Forms.GroupBox grbInput1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
    }
}