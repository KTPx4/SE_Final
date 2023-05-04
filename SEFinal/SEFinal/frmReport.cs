using SEFinal.BUS;
using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEFinal
{
    public partial class frmReport : Form
    {
        private int type = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //Goods Delivery
            //Goods Receipt
            //Best - selling
            //Revenue report
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbFilter.Text == "")
            {
                return;
            }
            if(cbbFilter.Text == "Goods Delivery")
            {
                type = 0;
            }
            else if(cbbFilter.Text == "Goods Receipt")
            {
                type = 1;
            }
            else if (cbbFilter.Text == "Best - selling")
            {
                type = 2;
            }
            else if (cbbFilter.Text == "Revenue report")
            {
                type = 3;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BUS_GDelivery d = new BUS_GDelivery();
            if(type == 0)
            {
                if(cbbMonth.Text == "" && txtYear.Text =="" && cbbTop.Text =="")
                {
                    dgvViews.DataSource = d.getALL();
                }
                // month
                else if(cbbMonth.Text != "" && txtYear.Text == "" && cbbTop.Text =="")
                {
                    dgvViews.DataSource = d.getMonth(cbbMonth.Text);
                }
                // month + Top
                else if (cbbMonth.Text != "" && txtYear.Text == "" && cbbTop.Text != "")
                {
                    dgvViews.DataSource = d.getMonth(cbbMonth.Text, cbbTop.Text);
                }
                //Year
                else if(cbbMonth.Text == "" && txtYear.Text != "" && cbbTop.Text == "")
                {
                    dgvViews.DataSource = d.getYear(txtYear.Text);
                }
                //Year  + Top
                else if (cbbMonth.Text == "" && txtYear.Text != "" && cbbTop.Text != "")
                {
                    dgvViews.DataSource = d.getYear(txtYear.Text, cbbTop.Text);
                }
                //Top
                else if(cbbMonth.Text == "" && txtYear.Text == "" && cbbTop.Text != "")
                {
                    dgvViews.DataSource = d.getAll(cbbTop.Text);
                }
                // Month + Year
                else if(cbbMonth.Text != "" && txtYear.Text != "" && cbbTop.Text != "")
                {
                    dgvViews.DataSource = d.getMonth_Year(cbbMonth.Text, txtYear.Text);
                }
                //month year top
                else
                {
                    dgvViews.DataSource = d.getMonth_Year(cbbMonth.Text, txtYear.Text, cbbTop.Text);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if(type ==0)
            {
                dgvViews.DataSource = (new BUS_GDelivery()).getALL();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            cbbFilter.Text = "";
            cbbMonth.Text = "";
            txtYear.Text = "";
            dgvViews.DataSource = null;
        }
    }
}
