using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEFinal
{
    public partial class frmOrder : Form
    {
        public int tab { get; set; }
        public frmOrder()
        {
            this.tab = 0;
            InitializeComponent();
        }
        public frmOrder(int tab)
        {
            this.tab = tab;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void changeColorBTN(System.Windows.Forms.Button btn, Color c)
        {
            btn.BackColor = c;
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            Color thisBtn = ColorTranslator.FromHtml("0, 230, 230");
            Color ortherBtn = ColorTranslator.FromHtml("153, 255, 255");
            changeColorBTN(btnGR, thisBtn);
            changeColorBTN(btnGD, ortherBtn);

            grbMana.Show();
            grbStatus.Hide();         
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Color thisBtn = ColorTranslator.FromHtml("0, 230, 230");
            Color ortherBtn = ColorTranslator.FromHtml("153, 255, 255");
            changeColorBTN(btnGD, thisBtn);
            changeColorBTN(btnGR, ortherBtn);

            grbStatus.Show();
            grbMana.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenEmployee_Click(object sender, EventArgs e)
        {
            frmViews views = new frmViews();
            views.Show();
        }

        private void btnOpenSup_Click(object sender, EventArgs e)
        {
            frmViews views = new frmViews();
            views.Show();
        }
    }
}
