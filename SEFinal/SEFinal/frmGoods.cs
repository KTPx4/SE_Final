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
    public partial class frmGoods : Form
    {
        private bool is_edit = false;

        public frmGoods()
        {
            InitializeComponent();
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            loadForm();

            // check type of values of price and quantity
        }

        public void loadForm()
        {
            clearInput();
            //block input
            grbInput1.Enabled = false;
            grbInput1.BackColor = Color.Gray;
            //block btn
            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;

            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Gray;

            btnSave.Enabled = false;
            btnSave.BackColor = Color.Gray;
            //set name header of column
            dgvViews.DataSource = (new BUS_Goods()).getALL();
            
            dgvViews.Columns[0].HeaderText = "Goods ID";
            dgvViews.Columns[1].HeaderText = "Goods Name";
            dgvViews.Columns[2].HeaderText = "Unit";
            dgvViews.Columns[3].HeaderText = "Price";
            dgvViews.Columns[4].HeaderText = "Country";
            dgvViews.Columns[5].HeaderText = "Quantity Warehouse";

            //set color
            dgvViews.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.Crimson;
            dgvViews.EnableHeadersVisualStyles = false;

        }




        public void clearInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtCountry.Text = "";
            txtPrice.Text = "";
            txtQuan.Text = "";
            txtUnit.Text = "";
        }
        public bool check_txtNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtCountry.Text == "" || txtPrice.Text == "" || txtQuan.Text =="" || txtUnit.Text =="")
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            is_edit = false;
            clearInput();
            //auto ID
            txtID.Text = (new BUS_Goods()).get_Next_ID();

            grbInput1.Enabled = true;
            grbInput1.BackColor = Color.Transparent;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.Transparent;

            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;

            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Gray;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            is_edit = true;

            grbInput1.Enabled = true;
            grbInput1.BackColor = Color.Transparent;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.Transparent;

            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check_txtNull())
            {
                MessageBox.Show("Please Input Full Values!");
                return;
            }
            string id = txtID.Text;
            string name = txtName.Text;
            string unit = txtUnit.Text;
            double price = float.Parse(txtPrice.Text);
            string country = txtCountry.Text;
            int quan = int.Parse(txtQuan.Text);

            BUS_Goods goods = new BUS_Goods(id, name, unit, price, country, quan);

            if (is_edit) // edit 
            {
                if (!goods.edit())
                {
                    MessageBox.Show("Invalid Input, Please Check the Rules of Input");
                    return;
                }
            }
            else // add new
            {
                //if(!goods.add())
                //{
                //    MessageBox.Show("ID is Exists or Invalid, Try again!");
                //    return;
                //}
                int status = goods.checkAdd();
                if (status == 0)
                {
                    DialogResult result = MessageBox.Show("That Goods Exists in data. Do you want to restore?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes) // call edit and edit status of is_deleted
                    {
                        // Call restore
                      
                        if(!goods.restore())
                        {
                            MessageBox.Show("Error When retore, Please The rules of input!");
                            return;
                        }
                    }
                    else if (result == DialogResult.No) // add rows with new id and user
                    {
                        if (!goods.add())
                        {
                            MessageBox.Show("Error! Invalid Input, Please check The Rules of input!");
                        }

                    }
                }
                else if (status == 2)
                {
                    MessageBox.Show("ID  Exists in data, Try again!");
                    return;
                }
                else if (status == 1)
                {
                    if (!goods.add())
                    {
                        MessageBox.Show("Error! Invalid Input, Please Read The Rules of input!");
                    }
                }
            }
            loadForm();     
                
        
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
         
            if (check_txtNull())
            {
                MessageBox.Show("Please Input Full Values!");
                return;
            }
            string id = txtID.Text;
            string name = txtName.Text;
            string unit = txtUnit.Text;
            double price = float.Parse(txtPrice.Text);
            string country = txtCountry.Text;
            int quan = int.Parse(txtQuan.Text);

            BUS_Goods goods = new BUS_Goods(id);
            if(!goods.delete())
            {
                MessageBox.Show("Error!, Try Again");
                return;
            }
            loadForm() ;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void dgvViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnEdit.BackColor = Color.Transparent;

            btnRemove.Enabled = true;
            btnRemove.BackColor = Color.Transparent;

            btnSave.Enabled = false;
            btnSave.BackColor = Color.Gray;

            grbInput1.Enabled = false;
            grbInput1.BackColor = Color.Gray;

            int index = dgvViews.CurrentRow.Index;

            txtID.Text = dgvViews.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvViews.Rows[index].Cells[1].Value.ToString();
            txtUnit.Text = dgvViews.Rows[index].Cells[2].Value.ToString();
            txtPrice.Text = dgvViews.Rows[index].Cells[3].Value.ToString();
            txtCountry.Text = dgvViews.Rows[index].Cells[4].Value.ToString();
            txtQuan.Text = dgvViews.Rows[index].Cells[5].Value.ToString();

        }




        // Create tooltip -> show description when mouse hover
        public void Mouse_Hover(string text, Button b)
        {
           
            toolTipText.Show(text, b, b.Width , b.Height - 30);
        }

        public void Mouse_Leave(Button b) // hide when mouse leave
        {
            toolTipText.Hide(b);
        }
        //
        // create mouse hover and leave for button
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover("Add", btnAdd);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave(btnAdd);
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover("Edit", btnEdit);

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave(btnEdit);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover("Save", btnSave);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave(btnSave);
        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover("Remove", btnRemove);
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave(btnRemove);
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover("Refresh", btnRefresh);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave(btnRefresh);
        }

        // draw border for Groupbox
        private void grbInputGoods_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Color color = ColorTranslator.FromHtml("#626262");
            BorderGrb(box, e.Graphics, Color.Red, color);
        }

        private void grbView_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Color color = ColorTranslator.FromHtml("#626262");
            BorderGrb(box, e.Graphics, Color.Red, color);
        }

        private void grbControl_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Color color = ColorTranslator.FromHtml("#626262");
            BorderGrb(box, e.Graphics, Color.Red, color);
        }    
        
        private void BorderGrb(GroupBox grbBox, Graphics g, Color txtColor, Color bdColor)
        {
            if (grbBox != null)
            {
                Brush tBr = new SolidBrush(txtColor);
                Brush bBr = new SolidBrush(bdColor);
                Pen bP = new Pen(bBr);
                SizeF stringS = g.MeasureString(grbBox.Text, grbBox.Font);
                Rectangle Rectangles = new Rectangle(grbBox.ClientRectangle.X, grbBox.ClientRectangle.Y + (int)(stringS.Height / 2), grbBox.ClientRectangle.Width - 1, grbBox.ClientRectangle.Height - (int)(stringS.Height / 2) - 1);

                //  Xoa chu va vien
                g.Clear(this.BackColor);
             
                // Ve ben trai
                Point p = new Point(Rectangles.X, Rectangles.Y + Rectangles.Height);
                g.DrawLine(bP, Rectangles.Location, p);

                // Ve ben phai
                Point p2 = new Point(Rectangles.X + Rectangles.Width, Rectangles.Y);
                Point p3 = new Point(Rectangles.X + Rectangles.Width, Rectangles.Y + Rectangles.Height);
                g.DrawLine(bP, p2, p3);

                // Ve Ben duoi
                p2 = new Point(Rectangles.X, Rectangles.Y + Rectangles.Height);
                p3 = new Point(Rectangles.X + Rectangles.Width, Rectangles.Y + Rectangles.Height);
                g.DrawLine(bP, p2, p3);

                // ve top 1
                p2 = new Point(Rectangles.X, Rectangles.Y);
                p3 = new Point(Rectangles.X + grbBox.Padding.Left, Rectangles.Y);
                g.DrawLine(bP, p2, p3);

                // ve top 2
                p2 = new Point(Rectangles.X + grbBox.Padding.Left + (int)(stringS.Width), Rectangles.Y);
                p3 = new Point(Rectangles.X + Rectangles.Width, Rectangles.Y);
                g.DrawLine(bP, p2, p3);
            }
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            if(txtQuan.Text == "")
            {
                return;
            }
            bool is_number = int.TryParse(txtQuan.Text, out int n);
            if(!is_number)
            {
                MessageBox.Show("Invalid Quantity!");
                txtQuan.Text = "";
                return;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                return;
            }
            bool is_number = double.TryParse(txtPrice.Text, out double n);
            if (!is_number)
            {
                MessageBox.Show("Invalid Price!");
                txtPrice.Text = "";
                return;
            }
        }
    }
}
