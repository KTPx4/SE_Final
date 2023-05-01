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
    public partial class frmAccountant : Form
    {
        private bool is_edit = false;
        public frmAccountant()
        {
            InitializeComponent();
        }
        private void frmAccountant_Load(object sender, EventArgs e)
        {
            loadForm();
           
        }
        void loadForm()
        {
            //clear input
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

            // change name header and color of datagridviews
            dgvViews.DataSource = (new BUS_Acoountant()).getALL();
            dgvViews.Columns[0].HeaderText = "Accountant ID";
            dgvViews.Columns[1].HeaderText = "Accountant Name";
            dgvViews.Columns[2].HeaderText = "Accountant User";
            dgvViews.Columns[3].Visible = false;
            dgvViews.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.Crimson;
            dgvViews.EnableHeadersVisualStyles = false;


        }
        public void clearInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }

        public bool check_txtNull()
        {
            if(txtID.Text == "" || txtName.Text == "" || txtPass.Text == "" || txtUser.Text == "")
            {
                return true;
            }
            return false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearInput();
            txtID.Text = (new BUS_Acoountant()).get_Next_ID();

            grbInput.Enabled = true;
            grbInput.BackColor = Color.Transparent;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.Transparent;

            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;

            btnRemove.Enabled = false;
            btnRemove.BackColor = Color.Gray;

            //set var edit = false
            is_edit = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grbInput.Enabled = true;
            grbInput.BackColor = Color.Transparent;

            btnSave.Enabled = true;
            btnSave.BackColor = Color.Transparent;

            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.Gray;
            is_edit = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(check_txtNull())
            {
                MessageBox.Show("Please Input Full Values!");
                return;
            }
            string id = txtID.Text;
            string name = txtName.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            int is_deleted = 0;

            BUS_Acoountant acc = new BUS_Acoountant(id, name, user, pass, is_deleted);
            if (is_edit) // true is edit
            {
                if(!acc.edit())
                {
                    MessageBox.Show("The ID is not exists or the User is invalid");
                    return;
                }    
            }
            else // else is add new
            {
                int status = acc.checkAdd();
                if(status == -1)
                {
                    MessageBox.Show("Null values in data, Try again!");
                    return;
                }
                else if(status == 0)
                {
                    DialogResult result = MessageBox.Show("That Accountant Exists in data. Do you want to restore?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes) // call edit and edit status of is_deleted
                    {
                        // Call edit
                        string ids = acc.getID_from_User(); // find old id contain that old employee from user and pass
                        acc.restore(ids);
                    }
                    else if (result == DialogResult.No) // add rows with new id and user
                    {
                        if(acc.add() != 1)
                        {
                            MessageBox.Show("Error Add new Accountant, Or User Exists in data!");
                        }

                    }
                }
                else if(status == 2)
                {
                    MessageBox.Show("ID or User Exists in data, Try again!");
                    return;
                }
                else if( status == 1)
                {
                    acc.add();
                }
            }
            loadForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" )
            {                
                MessageBox.Show("Please Input ID want to delete!");
                return;
            }
            if (!(new BUS_Acoountant(txtID.Text)).delete())
            {
                MessageBox.Show("Can not find ID to remove");
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
            txtUser.Text = dgvViews.Rows[index].Cells[2].Value.ToString();
            txtPass.Text = dgvViews.Rows[index].Cells[3].Value.ToString();

        }


        // event tooltip mouse hover and leave
        public void Mouse_Hover(string text, Button b)
        {

            toolTipText.Show(text, b, b.Width - 10, b.Height - 20);
        }

        public void Mouse_Leave(Button b) // hide when mouse leave
        {
            toolTipText.Hide(b);
        }
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


    }
}
