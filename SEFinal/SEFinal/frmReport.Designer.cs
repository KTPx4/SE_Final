namespace SEFinal
{
    partial class frmReport
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
            this.grbView = new System.Windows.Forms.GroupBox();
            this.dgvViews = new System.Windows.Forms.DataGridView();
            this.grbTool = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.grbReport = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cbbTop = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).BeginInit();
            this.grbTool.SuspendLayout();
            this.grbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.dgvViews);
            this.grbView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbView.Location = new System.Drawing.Point(349, 3);
            this.grbView.Name = "grbView";
            this.grbView.Padding = new System.Windows.Forms.Padding(0);
            this.grbView.Size = new System.Drawing.Size(491, 488);
            this.grbView.TabIndex = 3;
            this.grbView.TabStop = false;
            // 
            // dgvViews
            // 
            this.dgvViews.AllowUserToAddRows = false;
            this.dgvViews.AllowUserToDeleteRows = false;
            this.dgvViews.AllowUserToOrderColumns = true;
            this.dgvViews.AllowUserToResizeColumns = false;
            this.dgvViews.AllowUserToResizeRows = false;
            this.dgvViews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViews.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViews.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvViews.Location = new System.Drawing.Point(6, 19);
            this.dgvViews.Name = "dgvViews";
            this.dgvViews.RowHeadersVisible = false;
            this.dgvViews.Size = new System.Drawing.Size(481, 457);
            this.dgvViews.TabIndex = 0;
            // 
            // grbTool
            // 
            this.grbTool.Controls.Add(this.btnFind);
            this.grbTool.Controls.Add(this.btnExportReport);
            this.grbTool.Controls.Add(this.btnRef);
            this.grbTool.ForeColor = System.Drawing.SystemColors.Control;
            this.grbTool.Location = new System.Drawing.Point(12, 327);
            this.grbTool.Name = "grbTool";
            this.grbTool.Size = new System.Drawing.Size(331, 164);
            this.grbTool.TabIndex = 5;
            this.grbTool.TabStop = false;
            this.grbTool.Text = "Tool";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::SEFinal.Properties.Resources.magnifying_glass;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(58, 61);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 46);
            this.btnFind.TabIndex = 21;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackgroundImage = global::SEFinal.Properties.Resources.export;
            this.btnExportReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExportReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Location = new System.Drawing.Point(221, 61);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(50, 46);
            this.btnExportReport.TabIndex = 21;
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // btnRef
            // 
            this.btnRef.BackgroundImage = global::SEFinal.Properties.Resources.refresh;
            this.btnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Location = new System.Drawing.Point(142, 61);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(50, 46);
            this.btnRef.TabIndex = 21;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // grbReport
            // 
            this.grbReport.Controls.Add(this.btnAll);
            this.grbReport.Controls.Add(this.txtYear);
            this.grbReport.Controls.Add(this.cbbTop);
            this.grbReport.Controls.Add(this.cbbMonth);
            this.grbReport.Controls.Add(this.label8);
            this.grbReport.Controls.Add(this.label9);
            this.grbReport.Controls.Add(this.cbbFilter);
            this.grbReport.Controls.Add(this.label7);
            this.grbReport.Controls.Add(this.label6);
            this.grbReport.Controls.Add(this.label5);
            this.grbReport.ForeColor = System.Drawing.SystemColors.Control;
            this.grbReport.Location = new System.Drawing.Point(12, 3);
            this.grbReport.Name = "grbReport";
            this.grbReport.Size = new System.Drawing.Size(331, 318);
            this.grbReport.TabIndex = 4;
            this.grbReport.TabStop = false;
            this.grbReport.Text = "Report";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAll.Location = new System.Drawing.Point(235, 208);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtYear.Location = new System.Drawing.Point(235, 171);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(57, 20);
            this.txtYear.TabIndex = 5;
            // 
            // cbbTop
            // 
            this.cbbTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbTop.FormattingEnabled = true;
            this.cbbTop.Items.AddRange(new object[] {
            "",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbbTop.Location = new System.Drawing.Point(118, 207);
            this.cbbTop.Name = "cbbTop";
            this.cbbTop.Size = new System.Drawing.Size(55, 21);
            this.cbbTop.TabIndex = 4;
            // 
            // cbbMonth
            // 
            this.cbbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(118, 170);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(55, 21);
            this.cbbMonth.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Top";
            // 
            // cbbFilter
            // 
            this.cbbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "Goods Delivery",
            "Goods Receipt",
            "Best-selling",
            "Revenue report"});
            this.cbbFilter.Location = new System.Drawing.Point(118, 128);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(174, 21);
            this.cbbFilter.TabIndex = 4;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Type Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(128, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Filter";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.grbTool);
            this.Controls.Add(this.grbReport);
            this.Controls.Add(this.grbView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.grbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViews)).EndInit();
            this.grbTool.ResumeLayout(false);
            this.grbReport.ResumeLayout(false);
            this.grbReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.DataGridView dgvViews;
        private System.Windows.Forms.GroupBox grbTool;
        private System.Windows.Forms.GroupBox grbReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cbbTop;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnFind;
    }
}