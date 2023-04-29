namespace SEFinal
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnContent = new System.Windows.Forms.Panel();
            this.menutrip = new System.Windows.Forms.MenuStrip();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menutrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMini.Location = new System.Drawing.Point(842, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 31);
            this.btnMini.TabIndex = 3;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(887, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SEFinal.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnContent);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menutrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(929, 500);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 49);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(929, 500);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnContent.Location = new System.Drawing.Point(81, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(848, 500);
            this.pnContent.TabIndex = 2;
            // 
            // menutrip
            // 
            this.menutrip.BackColor = System.Drawing.Color.Azure;
            this.menutrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menutrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menutrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.manageAgentToolStripMenuItem,
            this.manageGoodsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menutrip.Location = new System.Drawing.Point(0, 0);
            this.menutrip.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menutrip.Name = "menutrip";
            this.menutrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menutrip.Size = new System.Drawing.Size(81, 500);
            this.menutrip.TabIndex = 1;
            this.menutrip.Text = "menuStrip1";
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Image = global::SEFinal.Properties.Resources.padlock;
            this.goodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(72, 48);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.manageGoodsToolStripMenuItem1_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(72, 39);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.manageSupplierToolStripMenuItem_Click);
            // 
            // manageAgentToolStripMenuItem
            // 
            this.manageAgentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.manageAgentToolStripMenuItem.Name = "manageAgentToolStripMenuItem";
            this.manageAgentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.manageAgentToolStripMenuItem.Size = new System.Drawing.Size(72, 39);
            this.manageAgentToolStripMenuItem.Text = "Agent";
            this.manageAgentToolStripMenuItem.Click += new System.EventHandler(this.createAgentToolStripMenuItem_Click);
            // 
            // manageGoodsToolStripMenuItem
            // 
            this.manageGoodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedToolStripMenuItem,
            this.goodsDeliveryToolStripMenuItem});
            this.manageGoodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.manageGoodsToolStripMenuItem.Name = "manageGoodsToolStripMenuItem";
            this.manageGoodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.manageGoodsToolStripMenuItem.Size = new System.Drawing.Size(72, 39);
            this.manageGoodsToolStripMenuItem.Text = "Order";
            // 
            // goodsReceivedToolStripMenuItem
            // 
            this.goodsReceivedToolStripMenuItem.Name = "goodsReceivedToolStripMenuItem";
            this.goodsReceivedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goodsReceivedToolStripMenuItem.Text = "Goods Received";
            this.goodsReceivedToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedToolStripMenuItem_Click);
            // 
            // goodsDeliveryToolStripMenuItem
            // 
            this.goodsDeliveryToolStripMenuItem.Name = "goodsDeliveryToolStripMenuItem";
            this.goodsDeliveryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goodsDeliveryToolStripMenuItem.Text = "Goods Delivery";
            this.goodsDeliveryToolStripMenuItem.Click += new System.EventHandler(this.goodsDeliveryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(72, 39);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Accountant -  Nhớ siawr logo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menutrip.ResumeLayout(false);
            this.menutrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.MenuStrip menutrip;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReceivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel pnContent;
    }
}

