using SEFinal.BUS;
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
    public partial class frmLogin : Form
    {
        private int timecheck;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public frmLogin()
        {
            timecheck = 0;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Style();
            // txtUser.Focus();
            btnCancel.Select();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        void Style()
        {
            ptbLogin.BackColor = System.Drawing.Color.Transparent;
            ptbUser.BackColor = System.Drawing.Color.Transparent;
            ptbPass.BackColor = System.Drawing.Color.Transparent;
            ckShow.BackColor = System.Drawing.Color.Transparent;

            // btnlogin 
            btnLogin.BackColor = ColorTranslator.FromHtml("#4fc56d");
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 4, 4));

            btnLoginAdmin.BackColor = ColorTranslator.FromHtml("#ff33bb");
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.FlatAppearance.BorderSize = 0;
            btnLoginAdmin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 4, 4));


            btnCancel.BackColor = ColorTranslator.FromHtml("#FBA442");
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 4, 4));
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                if (!ckShow.Checked)
                {
                    txtPass.PasswordChar = '*';
                }
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }



        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShow.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {

                txtPass.PasswordChar = '*';

            }

        }
        private void pnControl_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging là biến cờ của bạn
            _startPoint = new Point(e.X, e.Y);
        }

        private void pnControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void pnControl_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Login(string user, string pass)
        {
            BUS_Acoountant a = new BUS_Acoountant(user, pass);

            string Name = a.is_Accountant();
           
           /* string s = "select NameUser from USERLOGIN where UserID ='" + txtUser.Text + "' and PassID ='" + txtPass.Text + "'";

            DataTable tb = Connection.selectQuery(s);*/

            if (Name == "")
            {
                MessageBox.Show("Invalid Account!");

                timecheck++;
                if (timecheck >= 5)
                {
                    MessageBox.Show("You have input more than 5 times, Try again!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Welcom Accountant '" + Name + "'");
             
                frmMain main = new frmMain(a.getID_from_User());
           
                this.Hide(); //Hide current form.
                main.ShowDialog(); //Display the next form window
                this.Close(); //While closing the NextForm, control will come again and will close this form as well

            }
        }
        void LoginAdmin(string user, string pass)
        {

            string Name = (new BUS_AdminSystem(user, pass)).is_Accountant();

            /* string s = "select NameUser from USERLOGIN where UserID ='" + txtUser.Text + "' and PassID ='" + txtPass.Text + "'";

             DataTable tb = Connection.selectQuery(s);*/

            if (Name == "")
            {
                MessageBox.Show("Invalid Account!");

                timecheck++;
                if (timecheck >= 5)
                {
                    MessageBox.Show("You have input more than 5 times, Try again!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Welcom Admin '" + Name + "'");

                frmMain main = new frmMain();

                this.Hide(); //Hide current form.
                main.ShowDialog(); //Display the next form window
                this.Close(); //While closing the NextForm, control will come again and will close this form as well

            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Input User!");
                txtUser.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Input Password!");
                txtPass.Focus();
                return;
            }
            Login(txtUser.Text, txtPass.Text);


        }
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Input User!");
                txtUser.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Input Password!");
                txtPass.Focus();
                return;
            }
            LoginAdmin(txtUser.Text, txtPass.Text);

        }


        private void txtUser_KeyPress(object sender, DragEventArgs e)
        {
            txtPass.Focus();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
