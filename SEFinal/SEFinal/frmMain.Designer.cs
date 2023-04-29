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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnControl = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnContent = new System.Windows.Forms.Panel();
            this.menutrip = new System.Windows.Forms.MenuStrip();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControl.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menutrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pnControl.Controls.Add(this.panel1);
            this.pnControl.Controls.Add(this.btnMini);
            this.pnControl.Controls.Add(this.btnClose);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(929, 49);
            this.pnControl.TabIndex = 2;
            this.pnControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseDown);
            this.pnControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseMove);
            this.pnControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseUp);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.lbTitle.Location = new System.Drawing.Point(20, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(180, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Manage System";
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
            this.pnContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnContent.Location = new System.Drawing.Point(83, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(846, 500);
            this.pnContent.TabIndex = 2;
            // 
            // menutrip
            // 
            this.menutrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
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
            this.menutrip.Size = new System.Drawing.Size(83, 500);
            this.menutrip.TabIndex = 1;
            this.menutrip.Text = "menuStrip1";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.supplierToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(74, 42);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.manageSupplierToolStripMenuItem_Click);
            // 
            // manageAgentToolStripMenuItem
            // 
            this.manageAgentToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAgentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.manageAgentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.manageAgentToolStripMenuItem.Name = "manageAgentToolStripMenuItem";
            this.manageAgentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.manageAgentToolStripMenuItem.Size = new System.Drawing.Size(74, 42);
            this.manageAgentToolStripMenuItem.Text = "Agent";
            this.manageAgentToolStripMenuItem.Click += new System.EventHandler(this.createAgentToolStripMenuItem_Click);
            // 
            // manageGoodsToolStripMenuItem
            // 
            this.manageGoodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedToolStripMenuItem,
            this.goodsDeliveryToolStripMenuItem});
            this.manageGoodsToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGoodsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.manageGoodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.manageGoodsToolStripMenuItem.Name = "manageGoodsToolStripMenuItem";
            this.manageGoodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.manageGoodsToolStripMenuItem.Size = new System.Drawing.Size(74, 42);
            this.manageGoodsToolStripMenuItem.Text = "Order";
            // 
            // goodsReceivedToolStripMenuItem
            // 
            this.goodsReceivedToolStripMenuItem.Name = "goodsReceivedToolStripMenuItem";
            this.goodsReceivedToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.goodsReceivedToolStripMenuItem.Text = "Goods Received";
            this.goodsReceivedToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedToolStripMenuItem_Click);
            // 
            // goodsDeliveryToolStripMenuItem
            // 
            this.goodsDeliveryToolStripMenuItem.Name = "goodsDeliveryToolStripMenuItem";
            this.goodsDeliveryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.goodsDeliveryToolStripMenuItem.Text = "Goods Delivery";
            this.goodsDeliveryToolStripMenuItem.Click += new System.EventHandler(this.goodsDeliveryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.reportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(74, 42);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.goodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(74, 42);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.manageGoodsToolStripMenuItem1_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Location = new System.Drawing.Point(844, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 31);
            this.btnMini.TabIndex = 3;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SEFinal.Properties.Resources.cross;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(889, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(425, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 39);
            this.panel1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.pnControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant -  Nhớ siawr logo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnControl.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menutrip.ResumeLayout(false);
            this.menutrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
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
        private System.Windows.Forms.Panel panel1;
    }
}

