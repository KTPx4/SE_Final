
using iTextSharp.text.pdf;
using iTextSharp.text;
using SEFinal.BUS;
using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        ///////////////// type report
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


       
        /////////////////  buton - click
     
        private void btnFind_Click(object sender, EventArgs e)
        {
            string month = cbbMonth.Text;
            string year = txtYear.Text;
            string top = cbbTop.Text;
            if (type == 0)// delivery
            {
                grbView.Text = "Report for Goods Delivery";
                
                BUS_GDelivery d = new BUS_GDelivery();
                if(top == "") // not have top
                {
                    dgvViews.DataSource = d.Report(month, year);
                }
                else
                {
                    dgvViews.DataSource = d.Report_Top(top, month, year);
                }

            }
            else if(type == 1)
            {
                grbView.Text = "Report for Goods Receipt";
                BUS_GReceipt r = new BUS_GReceipt();
                if (top == "") // not have top
                {
                    dgvViews.DataSource = r.Report(month, year);
                }
                else
                {
                    dgvViews.DataSource = r.Report_Top(top, month, year);
                }
            }
            else if (type == 2)
            {
                grbView.Text = "";

            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            
            if(type ==0)
            {
                grbView.Text = "Report for Goods Delivery";
                dgvViews.DataSource = (new BUS_GDelivery()).Report("", "");
            }
            else if(type == 1)
            {
                grbView.Text = "Report for Goods Receipt";
                dgvViews.DataSource = (new BUS_GReceipt()).Report("", "");

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            cbbFilter.Text = "";
            cbbMonth.Text = "";
            txtYear.Text = "";
            dgvViews.DataSource = null;
        }



        ///////////////// check input

        private void cbbTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTop.Text == "")
            {
                return;
            }
            bool check_number = int.TryParse(cbbTop.Text, out int n);
            if(!check_number )
            {
                MessageBox.Show("Input Top is real number");
                cbbTop.Text = "";
                return;
            }
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonth.Text == "")
            {
                return;
            }
            bool check_number = int.TryParse(cbbMonth.Text, out int n);
            if (!check_number)
            {
                MessageBox.Show("Input Month is real number");
                cbbMonth.Text = "";
                return;
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                return;
            }
            bool check_number = int.TryParse(txtYear.Text, out int n);
            if (!check_number)
            {
                MessageBox.Show("Input Year is real number");
                txtYear.Text = "";
                return;
            }
        }
        //

        // export pdf
        private void ExportPDF(DataTable tb, string Path)
        {
            Document document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path, FileMode.Create));
            document.Open();

            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 10);

            PdfPTable table = new PdfPTable(tb.Columns.Count + 1);

            // PdfPRow row = null;

            float[] widths = new float[tb.Columns.Count + 1];
            for (int i = 0; i <= tb.Columns.Count; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 98;

            table.AddCell(new Phrase("STT", font5));

            foreach (DataColumn c in tb.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }
            int turn = 1;
            foreach (DataRow r in tb.Rows)
            {
                if (tb.Rows.Count > 0)
                {
                    table.AddCell(new Phrase(turn.ToString(), font5));
                    for (int h = 0; h < tb.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                    turn++;
                }
            }
            document.Add(table);
            document.Close();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvViews.DataSource;

            ExportPDF(dt, grbView.Text + ".pdf");
            MessageBox.Show($"The report has created in '{grbView.Text}.pdf'");
        }
    }
}
