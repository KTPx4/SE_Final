﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SEFinal.DTA;

namespace SEFinal
{
    public partial class frmMain : Form
    {
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Style();
        }

        public void Style() 
        {
        
            /*foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.White;

                }
                catch (Exception e)
                {
                }
            }*/

        }

        private void open_ChildForm(int index, int tab)
        {
            //foreach (Form c in this.MdiChildren) // close all form is open before open new form
            //{               
            //    c.Close();                       
            //}
            Form f;
            string title = "Manage System";

            if(index == 0)  // Child form is Goods
            {
                f = new frmGoods();
                title = "Goods";
            }
            else if(index == 1)// Child form is Supplier
            {
                f = new frmSupplier();
                title = "Supplier";
            }
            else if (index == 2) // Child form is Agent (Manage Agent and Update Status Payment)
            {
                f = new frmAgent();
                title = "Agent";

            }
            else if(index == 3) // Child form is Order( Manage Delivery, Receipt Goods)
            {
                title = "Order Goods";

                if (tab == 1) // if tab = 1 -> open tab for goods delivery
                {
                    f = new frmOrder(1);
                }
                else // open tab for goods Receipt
                {
                    f = new frmOrder();
                }

            }
            else   // last int is child form for Report
            {
                title = "Report";

                f = new frmReport();               
            }

            //f.MdiParent = this; // set parent of child form is frmMain (this)
            //f.Dock = DockStyle.Fill; // set full screen of childform when open in parent
            //f.Show(); // show form
           
            lbTitle.Text = title;

            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;

            pnContent.Controls.Clear();
            pnContent.Controls.Add(f);
        }  
      

         
        private void manageGoodsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_ChildForm(0, 0); 
        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(1, 0);

        }

        private void createAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(2, 0);

        }

        private void goodsReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(3, 0);

        }

        private void goodsDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(3, 1);

        }

      
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(4, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnControl_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging là biến cờ của bạn
            _startPoint = new Point(e.X, e.Y);
        }

        private void pnControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void pnControl_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Manage System";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(ptbContent);
        }
    }
}
