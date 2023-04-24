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
            //Style();
        }

        public void Style() 
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.White;

                }
                catch (Exception e)
                {
                }
            }
        }

        private void ChildForm(int index)
        {
            foreach (Form c in this.MdiChildren)
            {
               
                    c.Close();
                       
            }
       
            if(index == 0)
            {
                frmGoods f = new frmGoods();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                
                f.Show();
            }
            else if(index == 1)
            {
                frmSupplier f = new frmSupplier();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
              
                f.Show();
            }
            else if (index == 2)
            {
                frmAgent f = new frmAgent();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
               
                f.Show();
            }
            else if (index == 3)
            {
                frmReport f = new frmReport();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
              
                f.Show();
            }

        }

        private void mangeGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(0);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(1);
        }

        private void createAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(2);
        }

        private void statusPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(2);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(3);
        }
    }
}
