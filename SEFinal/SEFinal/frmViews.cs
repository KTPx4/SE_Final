using SEFinal.BUS;
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
    public partial class frmViews : Form
    {
        private int form ; // 0 for employee, 1 for Supplier
        private const string Payment_online = "P0001";
        private const string Payment_cash = "P0002";

        public frmViews()
        {
            this.form = 0;
            InitializeComponent();
        }
        public frmViews(int form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void frmViews_Load(object sender, EventArgs e)
        {
            if(form == 0)
            {
                this.Text = "Employee";
                dgvViews.DataSource = (new BUS_Acoountant()).getALL();

                dgvViews.Columns[0].HeaderText = "Accountant ID";
                dgvViews.Columns[1].HeaderText = "Accountant Name";
                dgvViews.Columns[2].HeaderText = "Accountant User";
                dgvViews.Columns[3].Visible = false;
            }
            else if(form == 1) 
            {
                this.Text = "Supplier";
                dgvViews.DataSource = (new BUS_Supplier()).getALL();
            }
            else
            {
                this.Text = "Order of Agent";
                dgvViews.DataSource = (new BUS_Order()).getOrder_from_Payment(Payment_cash, Payment_online);
            }
        }
    }
}
