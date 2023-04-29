﻿using System;
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
        public frmLogin()
        {
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

            btnLogin.BackColor = ColorTranslator.FromHtml("#4fc56d");
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 4, 4));

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Login()
        {
           /* string s = "select NameUser from USERLOGIN where UserID ='" + txtUser.Text + "' and PassID ='" + txtPass.Text + "'";

            DataTable tb = Connection.selectQuery(s);

            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Account!");

                timeCheck++;
                if (timeCheck >= 5)
                {
                    MessageBox.Show("You have input more than 5 times, Try again!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Welcom '" + tb.Rows[0][0] + "'");
                //this.DialogResult = DialogResult.OK;
                frmMain main = new frmMain();
                //main.Show()
                this.Hide(); //Hide current form.
                main.ShowDialog(); //Display the next form window
                this.Close(); //While closing the NextForm, control will come again and will close this form as well

            }*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if(txtUser.Text =="")
            {
                MessageBox.Show("Input User!");
                txtUser.Focus();
                return;
            }
            if(txtPass.Text == "")
            {
                MessageBox.Show("Input Password!");
                txtPass.Focus();
                return;
            }*/
            Login();


        }



        private void txtUser_KeyPress(object sender, DragEventArgs e)
        {
            txtPass.Focus();
        }
    }
}
