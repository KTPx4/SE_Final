using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEFinal
{
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            Style();
        }
        public void Style()
        {
            // form load -> firt load manage agent
            grbMana.Show();
            grbStatus.Hide();

            //add item for cbb status
            cbbStatus.DisplayMember = "Display";
            cbbStatus.ValueMember = "Value";
            cbbStatus.Items.Add(new { Value = 0, Display = "Choise Status Payment" });
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
       
        private void btnManage_Click(object sender, EventArgs e)
        {
            Color thisBtn = ColorTranslator.FromHtml("0, 153, 255");
            Color ortherBtn = ColorTranslator.FromHtml("77, 184, 255");
            changeColorBTN(btnManage, thisBtn);
            changeColorBTN(btnStatus, ortherBtn);

            grbMana.Show();
            grbStatus.Hide();

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Color thisBtn = ColorTranslator.FromHtml("0, 153, 255");
            Color ortherBtn = ColorTranslator.FromHtml("77, 184, 255");
            changeColorBTN(btnStatus, thisBtn);
            changeColorBTN(btnManage, ortherBtn);

            grbStatus.Show();
            grbMana.Hide();

            cbbStatus.SelectedIndex = 0;
        }

        public void Mouse_Hover(string text, System.Windows.Forms.Button b)
        {

            toolTipText.Show(text, b, b.Width - 20, b.Height - 30);
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

    }
}
