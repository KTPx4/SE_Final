using SEFinal.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEFinal
{
    public partial class frmAgent : Form
    {
        private bool is_edit;
        private bool is_Mana;
        public frmAgent()
        {
            is_Mana = true;
            InitializeComponent();
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            Style();
            if(is_Mana) // manage Agent
            {
                loadForm();
            }
            else // update Status Payment
            {

            }
        }
        public void Style()
        {
            // form load -> firt load manage agent
            grbMana.Show();
            grbStatus.Hide();

            //add item for cbb status
            cbbStatus.DisplayMember = "Display";
            cbbStatus.ValueMember = "Value";
            cbbStatus.Items.Add(new { Value = -2, Display = "Choise Status Payment" });
            cbbStatus.Items.Add(new { Value = 1, Display = "Success" });
            cbbStatus.Items.Add(new { Value = 0, Display = "Waiting Payment" });
            cbbStatus.Items.Add(new { Value = -1, Display = "Failed" });

            /*int index = comboBox1.FindStringExact("Success"); Tìm bằng display->index
            if (index >= 0)
            {
                comboBox1.SelectedIndex = index;
            }
            Trong đó, "Success" là giá trị hiển thị của mục bạn muốn chọn. Nếu không có mục nào có giá trị bằng 0, phương thức FindStringExact sẽ trả về -1 và không có mục nào được chọn.
          /////////////////////////
             comboBox1.SelectedValue = 0; // sẽ chọn đối tượng có giá trị value là 0 và hiển thị giá trị là "Success"
            ////get values: string selectedValue = cbb.SelectedValue.ToString();
             */



        }



        public void clearInput_Mana()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddr.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";

        }

        public void loadForm()
        {
            clearInput_Mana();
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
            dgvViews.DataSource = (new BUS_Agent()).getALL();

            dgvViews.Columns[0].HeaderText = "Agent ID";
            dgvViews.Columns[1].HeaderText = "Name";
            dgvViews.Columns[2].HeaderText = "Phone";
            dgvViews.Columns[3].HeaderText = "Address";
            dgvViews.Columns[4].HeaderText = "User";
            // Hide Pass
            dgvViews.Columns[5].HeaderText = "Pass";
            dgvViews.Columns[5].Visible = false;


            //set color
            dgvViews.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.Crimson;
            dgvViews.EnableHeadersVisualStyles = false;

        }
        public void loadStatus()
        {
            // clear text

            txtOrderID.Text = "";
            txtAgID.Text = "";
            txtAName.Text = "";
            cbbStatus.SelectedIndex = 0;


            // fill date to dgv and cbb
            DataTable data = (new BUS_Agent()).getStatus();
            dgvViews.DataSource = data;
            //set name of column
            dgvViews.Columns[0].HeaderText = "Order ID";
            dgvViews.Columns[1].HeaderText = "Agent ID";
            dgvViews.Columns[2].HeaderText = "Agent Name";
            dgvViews.Columns[3].HeaderText = "Order Date";
            dgvViews.Columns[4].HeaderText = "Status";
            //set color
            dgvViews.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.Crimson;
            dgvViews.EnableHeadersVisualStyles = false;

        }
        public bool check_Invalid_Input()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtAddr.Text == "" || txtUser.Text == "" || txtPass.Text == "")
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            is_edit = false;
            clearInput_Mana();
            //auto ID
            txtID.Text = (new BUS_Agent()).get_Next_ID();

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
            string id = txtID.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string addr = txtAddr.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            BUS_Agent ag = new BUS_Agent(id, name,phone, addr, user, pass);

            if (is_edit) // edit 
            {
                if (!ag.edit())
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
                int status = ag.checkAdd();
                if (status == 0)
                {
                    DialogResult result = MessageBox.Show("That Goods Exists in data. Do you want to restore?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes) // call edit and edit status of is_deleted
                    {
                        // Call restore                       
                        ag.restore();
                    }
                    else if (result == DialogResult.No) // add rows with new id and user
                    {
                        if (!ag.add()) // add with new id
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
                    if (!ag.add()) // add with new id
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

            BUS_Agent goods = new BUS_Agent(id);

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


        // cell click in datagridview
        private void dgvViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvViews.CurrentRow.Index;

            if (is_Mana) // in manage Agent
            {
                btnEdit.Enabled = true;
                btnEdit.BackColor = Color.Transparent;

                btnRemove.Enabled = true;
                btnRemove.BackColor = Color.Transparent;

                btnSave.Enabled = false;
                btnSave.BackColor = Color.Gray;

                grbInput.Enabled = false;
                grbInput.BackColor = Color.Gray;


                txtID.Text = dgvViews.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dgvViews.Rows[index].Cells[1].Value.ToString();
                txtPhone.Text = dgvViews.Rows[index].Cells[2].Value.ToString();
                txtAddr.Text = dgvViews.Rows[index].Cells[3].Value.ToString();
                txtUser.Text = dgvViews.Rows[index].Cells[4].Value.ToString();
                txtPass.Text = dgvViews.Rows[index].Cells[5].Value.ToString();

            }
            else // in update status
            {
                txtOrderID.Text = dgvViews.Rows[index].Cells[0].Value.ToString();
                txtAgID.Text = dgvViews.Rows[index].Cells[1].Value.ToString();
                txtAName.Text = dgvViews.Rows[index].Cells[2].Value.ToString();
                int status = int.Parse(dgvViews.Rows[index].Cells[4].Value.ToString());
                string displayMember = cbbStatus.Items.Cast<dynamic>().Where(x => x.Value == status).Select(x => x.Display).FirstOrDefault();
                cbbStatus.Text = displayMember;
            }

        }
        
        //draw border
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
        
        //draw groupbox
        private void grbControl_Paint(object sender, PaintEventArgs e)
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

        public void changeColorBTN(System.Windows.Forms.Button btn, Color c)
        {
            btn.BackColor = c;
        }
       
        // button manage
        private void btnManage_Click(object sender, EventArgs e)
        {
            is_Mana = true;
            Color thisBtn = ColorTranslator.FromHtml("0, 153, 255");
            Color ortherBtn = ColorTranslator.FromHtml("77, 184, 255");
            changeColorBTN(btnManage, thisBtn);
            changeColorBTN(btnStatus, ortherBtn);

            grbMana.Show();
          
            grbStatus.Hide();
          
            loadForm();

        }
        // button status
        private void btnStatus_Click(object sender, EventArgs e)
        {
            is_Mana = false;

            loadStatus();

            Color thisBtn = ColorTranslator.FromHtml("0, 153, 255");
            Color ortherBtn = ColorTranslator.FromHtml("77, 184, 255");
            changeColorBTN(btnStatus, thisBtn);
            changeColorBTN(btnManage, ortherBtn);

            grbStatus.Show();
          
            grbMana.Hide();
          

            cbbStatus.SelectedIndex = 0;
        }
        // show text when hover to button
        public void Mouse_Hover(string text, System.Windows.Forms.Button b)
        {

            toolTipText.Show(text, b, b.Width, b.Height - 30);
        }


        // Action Form
        public void Mouse_Leave(System.Windows.Forms.Button b)
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


        //check length of phone
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                return;
            }
            bool is_number = long.TryParse(txtPhone.Text, out long n);
            if (txtPhone.Text.Length > 10 || !is_number)
            {
                MessageBox.Show("The Phone is a number and less than 10 character");
                txtPhone.Text = "";
                return;

            }
        }

       
        //button in status


        private void btnRefStatus_Click(object sender, EventArgs e)
        {
            loadStatus();
        }

        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            if(txtOrderID.Text == "" || (cbbStatus.SelectedItem as dynamic).Value == -2)
            {
                MessageBox.Show("Invalid Input");
                return;
            }
            string id = txtOrderID.Text;          

            int status = (cbbStatus.SelectedItem as dynamic).Value;

            if(!(new BUS_PaymentDetail(id, status)).update_Status())
            {
                MessageBox.Show("Error!, Can not update status");
                return;
            }
            loadStatus();

           
        }

  
    }
}
