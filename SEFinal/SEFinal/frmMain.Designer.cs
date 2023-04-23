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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageGoodsToolStripMenuItem,
            this.manageAgentToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageGoodsToolStripMenuItem
            // 
            this.manageGoodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedToolStripMenuItem,
            this.goodsDeliveryToolStripMenuItem,
            this.mangeGoodsToolStripMenuItem});
            this.manageGoodsToolStripMenuItem.Name = "manageGoodsToolStripMenuItem";
            this.manageGoodsToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.manageGoodsToolStripMenuItem.Text = "Manage Goods";
            // 
            // goodsReceivedToolStripMenuItem
            // 
            this.goodsReceivedToolStripMenuItem.Name = "goodsReceivedToolStripMenuItem";
            this.goodsReceivedToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.goodsReceivedToolStripMenuItem.Text = "Goods Received";
            // 
            // goodsDeliveryToolStripMenuItem
            // 
            this.goodsDeliveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDeliveryToolStripMenuItem,
            this.updateStatusToolStripMenuItem});
            this.goodsDeliveryToolStripMenuItem.Name = "goodsDeliveryToolStripMenuItem";
            this.goodsDeliveryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.goodsDeliveryToolStripMenuItem.Text = "Goods Delivery";
            // 
            // createDeliveryToolStripMenuItem
            // 
            this.createDeliveryToolStripMenuItem.Name = "createDeliveryToolStripMenuItem";
            this.createDeliveryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createDeliveryToolStripMenuItem.Text = "Create Delivery";
            // 
            // updateStatusToolStripMenuItem
            // 
            this.updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            this.updateStatusToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateStatusToolStripMenuItem.Text = "Update Status";
            // 
            // manageAgentToolStripMenuItem
            // 
            this.manageAgentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAgentToolStripMenuItem,
            this.statusPaymentToolStripMenuItem});
            this.manageAgentToolStripMenuItem.Name = "manageAgentToolStripMenuItem";
            this.manageAgentToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.manageAgentToolStripMenuItem.Text = "Manage Agent";
            // 
            // createAgentToolStripMenuItem
            // 
            this.createAgentToolStripMenuItem.Name = "createAgentToolStripMenuItem";
            this.createAgentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createAgentToolStripMenuItem.Text = "Create Agent";
            // 
            // statusPaymentToolStripMenuItem
            // 
            this.statusPaymentToolStripMenuItem.Name = "statusPaymentToolStripMenuItem";
            this.statusPaymentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.statusPaymentToolStripMenuItem.Text = "Status Payment";
            // 
            // mangeGoodsToolStripMenuItem
            // 
            this.mangeGoodsToolStripMenuItem.Name = "mangeGoodsToolStripMenuItem";
            this.mangeGoodsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mangeGoodsToolStripMenuItem.Text = "Mange Goods";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 771);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant -  Nhớ siawr logo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReceivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

