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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnContent = new System.Windows.Forms.Panel();
            this.ptbContent = new System.Windows.Forms.PictureBox();
            this.menutrip = new System.Windows.Forms.MenuStrip();
            this.tmiAccountant = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContent)).BeginInit();
            this.menutrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pnControl.Controls.Add(this.panel3);
            this.pnControl.Controls.Add(this.panel2);
            this.pnControl.Controls.Add(this.panel1);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1018, 59);
            this.pnControl.TabIndex = 2;
            this.pnControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseDown);
            this.pnControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseMove);
            this.pnControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ptbLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 59);
            this.panel3.TabIndex = 4;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Image = global::SEFinal.Properties.Resources.logov3;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ptbLogo.Size = new System.Drawing.Size(113, 59);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMini);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(917, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 59);
            this.panel2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SEFinal.Properties.Resources.cross;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(58, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Location = new System.Drawing.Point(13, 15);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 31);
            this.btnMini.TabIndex = 3;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(416, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 39);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseUp);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.lbTitle.Location = new System.Drawing.Point(13, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(180, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Manage System";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnControl_MouseUp);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnContent);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menutrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1018, 500);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 59);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1018, 500);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnContent.Controls.Add(this.ptbContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(170, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(848, 500);
            this.pnContent.TabIndex = 2;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // ptbContent
            // 
            this.ptbContent.Image = global::SEFinal.Properties.Resources.bunny;
            this.ptbContent.Location = new System.Drawing.Point(297, 92);
            this.ptbContent.Name = "ptbContent";
            this.ptbContent.Size = new System.Drawing.Size(274, 230);
            this.ptbContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbContent.TabIndex = 0;
            this.ptbContent.TabStop = false;
            // 
            // menutrip
            // 
            this.menutrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.menutrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menutrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menutrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiAccountant,
            this.goodsToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.manageAgentToolStripMenuItem,
            this.manageGoodsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menutrip.Location = new System.Drawing.Point(0, 0);
            this.menutrip.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menutrip.Name = "menutrip";
            this.menutrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menutrip.Size = new System.Drawing.Size(170, 500);
            this.menutrip.TabIndex = 1;
            this.menutrip.Text = "menuStrip1";
            // 
            // tmiAccountant
            // 
            this.tmiAccountant.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmiAccountant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.tmiAccountant.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tmiAccountant.Name = "tmiAccountant";
            this.tmiAccountant.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.tmiAccountant.Size = new System.Drawing.Size(161, 42);
            this.tmiAccountant.Text = "Manage Accountant";
            this.tmiAccountant.Click += new System.EventHandler(this.tmiAccountant_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.goodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.manageGoodsToolStripMenuItem1_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.supplierToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
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
            this.manageAgentToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
            this.manageAgentToolStripMenuItem.Text = "Agent";
            this.manageAgentToolStripMenuItem.Click += new System.EventHandler(this.createAgentToolStripMenuItem_Click);
            // 
            // manageGoodsToolStripMenuItem
            // 
            this.manageGoodsToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGoodsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.manageGoodsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.manageGoodsToolStripMenuItem.Name = "manageGoodsToolStripMenuItem";
            this.manageGoodsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.manageGoodsToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
            this.manageGoodsToolStripMenuItem.Text = "Order";
            this.manageGoodsToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(33)))), ((int)(((byte)(136)))));
            this.reportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1018, 559);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.pnControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant -  Nhớ siawr logo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbContent)).EndInit();
            this.menutrip.ResumeLayout(false);
            this.menutrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbContent;
        private System.Windows.Forms.ToolStripMenuItem tmiAccountant;
    }
}

