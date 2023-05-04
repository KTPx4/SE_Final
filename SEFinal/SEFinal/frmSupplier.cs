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
using System.Xml.Linq;

namespace SEFinal
{
    public partial class frmSupplier : Form
    {
        private bool is_edit = false;

        public frmSupplier()
        {
            InitializeComponent();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void clearInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddr.Text = "";
          
        }

        public void loadForm()
        {
            clearInput();
            //block input
            grbInput.Enabled = false;
            grbInput.BackColor = Color.Gray;
            //block btn
            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;

            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Gray;

            btnSave.Enabled = false;
            btnSave.BackColor = Color.Gray;

            //set name header of column
            dgvViews.DataSource = (new BUS_Supplier()).getALL();

            dgvViews.Columns[0].HeaderText = "Supplier ID";
            dgvViews.Columns[1].HeaderText = "Name";
            dgvViews.Columns[2].HeaderText = "Address";
            dgvViews.Columns[3].HeaderText = "Phone";
           

            //set color
            dgvViews.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.Crimson;
            dgvViews.EnableHeadersVisualStyles = false;

        }

        public bool check_Invalid_Input()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtAddr.Text == "" )
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
            txtID.Text = (new BUS_Supplier()).get_Next_ID();

            grbInput.Enabled = true;
            grbInput.BackColor = Color.Transparent;

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

            grbInput.Enabled = true;
            grbInput.BackColor = Color.Transparent;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.Transparent;

            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check_Invalid_Input())
            {
                MessageBox.Show("Invalid Input!");
                return;
            }
            string id = txtID.Text ;
            string name = txtName.Text;
            string phone = txtPhone.Text ;
            string addr = txtAddr.Text;

            BUS_Supplier Supp = new BUS_Supplier(id, name, addr, phone);

            if (is_edit) // edit 
            {
                if(!Supp.edit())
                {
                    MessageBox.Show("Error!,The input is invalid or Exists in data!");
                    MessageBox.Show("Please Read The Rules of Input!");
                   
                }
            }
            else // add new
            {
                //if(!goods.add())
                //{
                //    MessageBox.Show("ID is Exists or Invalid, Try again!");
                //    return;
                //}
                int status = Supp.checkAdd();
                if (status == 0)
                {
                    DialogResult result = MessageBox.Show("That Goods Exists in data. Do you want to restore?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes) // call edit and edit status of is_deleted
                    {
                        // Call restore                       
                        Supp.restore();
                    }
                    else if (result == DialogResult.No) // add rows with new id and user
                    {
                        if (!Supp.add()) // add with new id
                        {
                            MessageBox.Show("Error!,The input is invalid or Exists in data!");
                            MessageBox.Show("Please Read The Rules of Input!");

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
                    if (!Supp.add()) // add with new id
                    {
                        MessageBox.Show("Error!. The input is invalid or Exists in data!");
                        MessageBox.Show("Please Read The Rules of Input!");

                    }
                }
            }
            loadForm();


        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (check_Invalid_Input())
            {
                MessageBox.Show("Please Input Full Values!");
                return;
            }
            string id = txtID.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string addr = txtAddr.Text;

            BUS_Supplier goods = new BUS_Supplier(id);

            if (!goods.delete())
            {
                MessageBox.Show("Error!, Try Again");
                return;
            }
            loadForm();
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

            grbInput.Enabled = false;
            grbInput.BackColor = Color.Gray;

            int index = dgvViews.CurrentRow.Index;

            txtID.Text = dgvViews.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvViews.Rows[index].Cells[1].Value.ToString();
            txtAddr.Text = dgvViews.Rows[index].Cells[2].Value.ToString();
            txtPhone.Text = dgvViews.Rows[index].Cells[3].Value.ToString();
           

        }


        // Create tooltip -> show description when mouse hover
        public void Mouse_Hover(string text, Button b)
        {

            toolTipText.Show(text, b, b.Width, b.Height - 30);
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

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if(txtPhone.Text == "")
            {
                return;
            }
            bool is_number = int.TryParse(txtPhone.Text, out int n);
            if(txtPhone.Text.Length > 10 || !is_number)
            {
                MessageBox.Show("The Phone is a number and less than 10 character");
                txtPhone.Text = "";
                return;

            }
        }
    }
}
