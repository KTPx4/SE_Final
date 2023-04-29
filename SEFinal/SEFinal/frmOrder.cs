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
    }
}
