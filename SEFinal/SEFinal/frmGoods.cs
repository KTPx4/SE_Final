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
        public frmGoods()
        {
            InitializeComponent();
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {

        }
        public void Mouse_Hover(string text, Button b)
        {
           
            toolTipText.Show(text, b, b.Width - 20, b.Height - 30);
        }


        // Action Form
        public void Mouse_Leave(Button b)
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

    
    
    
    
    
    }
}
