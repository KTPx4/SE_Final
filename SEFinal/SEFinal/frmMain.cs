using System;
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
            if(index == 0)  // Child form is Goods
            {
                 f = new frmGoods();             
            }
            else if(index == 1)// Child form is Supplier
            {
                f = new frmSupplier();              
            }
            else if (index == 2) // Child form is Agent (Manage Agent and Update Status Payment)
            {
                f = new frmAgent();               
            }
            else if(index == 3) // Child form is Order( Manage Delivery, Receipt Goods)
            {

                if(tab == 1) // if tab = 1 -> open tab for goods delivery
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
                f = new frmReport();               
            }

            //f.MdiParent = this; // set parent of child form is frmMain (this)
            //f.Dock = DockStyle.Fill; // set full screen of childform when open in parent
            //f.Show(); // show form

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
    }
}
