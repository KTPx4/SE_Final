using SEFinal.BUS;
using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEFinal
{
    public partial class frmOrder : Form
    {
        private static bool is_edit_Item = false;

        private static bool is_edit = false;
        
        private static  bool is_Receipt = true;
       
        private static int indexList; // index of list item when click in dataGridView
        
        private  string Accountant;
        private const string Payment_online = "P0001";
        private const string Payment_cash = "P0002";
        
        private static DataTable order;
        private static DataTable ListGoods;

        public frmOrder(string AccountantID)
        {
            this.Accountant = AccountantID;
            InitializeComponent();
        }
        public frmOrder()
        {
            this.Accountant = "";
            InitializeComponent();
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            loadFormReceipt();
            loadReceipt();
        }
       
        ////////////////////////////// Receipt
        void loadReceipt()
        {
            txtRID.Text = "";           
            cbbREmployee.Text = "";
            cbbRSupID.Text = "";

            createList_Goods();
            LoadListGoods();
            LoadOrder();

            grbInfo.Enabled = false;
            grbInfo.BackColor = Color.Gray;
            btnSave.Enabled = false;
            btnSave.BackColor = Color.Gray;
           
        }

        void loadFormReceipt()
        {
            cbbREmployee.Items.Clear();
            cbbRSupID.Items.Clear();

            DataTable emp = (new BUS_Acoountant()).getALL();// fill data accountant
            foreach (DataRow r in emp.Rows)
            {
                cbbREmployee.Items.Add(r[0].ToString());
            }
            emp = (new BUS_Supplier()).getALL(); // fill data supplier
            foreach (DataRow r in emp.Rows)
            {
                cbbRSupID.Items.Add(r[0].ToString());
            }
        }

        void createList_Goods()
        {
            ListGoods = new DataTable();
            indexList = 0;
            ListGoods.Columns.Add("ID", typeof(string));
            ListGoods.Columns.Add("Name", typeof(string));
            ListGoods.Columns.Add("Price", typeof(double));
            ListGoods.Columns.Add("Quantity", typeof(int));
        }
      

        void addGoods() // add values for list item befor create Oder and Oder detail
        {
            if (cbbRGoodsID.Text == "")
            {
                MessageBox.Show("Please input ID item");
                cbbRGoodsID.DroppedDown = true;
                //cbbRGoodsID.Focus();
                return;
            }
            if (txtGQuan.Text == "")
            {
                MessageBox.Show("Please input Quantity");
                txtGQuan.Focus();
                return;
            }

            string id = cbbRGoodsID.Text;
            int quan = int.Parse(txtGQuan.Text);


            BUS_Goods goods = new BUS_Goods(id);
            bool is_GoodsExists = goods.is_Exists();

            //Get Values from id
            DataTable RowsGoods = goods.getGoods();

            if (!is_GoodsExists) // id not exists 
            {
                MessageBox.Show("This Item is not exists in data of Item");
                cbbRGoodsID.Text = "";
                cbbRGoodsID.DroppedDown = true;
                return;
            }
            else
            {

                if (!is_edit_Item) // add
                {
                    foreach (DataRow dr in RowsGoods.Rows)
                    {
                        string ids = dr[0].ToString();
                        string name = dr[1].ToString();
                        double price = double.Parse(dr[3].ToString());
                        int Quan = int.Parse(dr[5].ToString());// in ware house

                        DataRow[] foundRows = ListGoods.Select("ID = '" + ids + "'");

                        if (foundRows.Length > 0)
                        {
                            MessageBox.Show("This Item is already in list");
                            cbbRGoodsID.Text = "";
                            cbbRGoodsID.DroppedDown = true;
                            return;
                            // id exists in the DataTable
                        }
                        //else if (quan > Quan)
                        //{
                        //    MessageBox.Show("In warehouse only have: " + Quan);
                        //    txtGQuan.Text = "";
                        //    return;
                        //}
                        else
                        {
                            ListGoods.Rows.Add(ids, name, price, quan); // add to list
                            // id does not exist in the DataTable
                        }
                    }

                }
                else // edit
                {
                    foreach (DataRow dr in RowsGoods.Rows)
                    {


                        DataRow[] foundRows = ListGoods.Select("ID = '" + id + "'");

                        // Get values from id in data
                        string ids = dr[0].ToString();
                        string name = dr[1].ToString();
                        double price = double.Parse(dr[3].ToString());
                        int Quan = int.Parse(dr[5].ToString());// in ware house

                        if (foundRows.Length > 0) // if id is old and only want edit info
                        {

                            int rowIndex = ListGoods.Rows.IndexOf(foundRows[0]); // find index of id in listItem
                            //MessageBox.Show("" + rowIndex + " , " + indexList);
                            if (rowIndex != indexList)
                            {
                                MessageBox.Show("This Item is already in list");
                                cbbRGoodsID.Text = "";
                                return;

                            }
                            //else if (quan > Quan)
                            //{
                            //    MessageBox.Show("In warehouse only have: " + Quan);
                            //    txtGQuan.Text = "";
                            //    txtGQuan.Focus();
                            //    return;
                            //}
                            else // if id is old -> edit info
                            {
                                ListGoods.Rows[rowIndex]["ID"] = id;
                                ListGoods.Rows[rowIndex]["Name"] = name;
                                ListGoods.Rows[rowIndex]["Price"] = price;
                                ListGoods.Rows[rowIndex]["Quantity"] = quan;

                                cbbRGoodsID.Text = "";
                                txtGQuan.Text = "";
                            }
                        }
                        else // if new id not old -> update new id
                        {
                            ListGoods.Rows[indexList]["ID"] = id;
                            ListGoods.Rows[indexList]["Name"] = name;
                            ListGoods.Rows[indexList]["Price"] = price;
                            ListGoods.Rows[indexList]["Quantity"] = quan;

                        }
                        MessageBox.Show("Edit success 1 rows!");

                    }
                }

                cbbRGoodsID.Text = "";
                txtGName.Text = "";
                txtGQuan.Text = "";

                LoadListGoods();
                return;
            }
        }
        
        public void LoadListGoods()
        {
            dgvItem.DataSource = ListGoods;

            DataTable tbID = (new BUS_Goods()).getAll_ID();

            cbbRGoodsID.Items.Clear();
            foreach (DataRow r in tbID.Rows)
            {
                cbbRGoodsID.Items.Add(r[0].ToString());
            }
        }
        
        public void LoadOrder()
        {
            dgvViews.DataSource = (new BUS_GReceipt()).getAll();
            foreach (DataGridViewRow row in dgvViews.Rows)
            {
                row.Cells["TotalAmount"].Style.Format = "c";
                //row.Cells["Credit"].Style.Format = "c";
            }
        }
        
        public void changeColorBTN(System.Windows.Forms.Button btn, Color c)
        {
            btn.BackColor = c;
        }
       
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            //load data
            loadFormReceipt();
            loadReceipt();

            is_Receipt = true;
            
            Color thisBtn = ColorTranslator.FromHtml("0, 230, 230");
            Color ortherBtn = ColorTranslator.FromHtml("153, 255, 255");
            changeColorBTN(btnGR, thisBtn);
            changeColorBTN(btnGD, ortherBtn);

            grbReceipt.Show();
            grbDelivery.Hide();         
        }

        private void btnOpenEmployee_Click(object sender, EventArgs e)
        {
            frmViews views = new frmViews();
            views.Show();
        }

        private void btnOpenSup_Click(object sender, EventArgs e)
        {
            frmViews views = new frmViews(1);
            views.Show();
        }

        private void btnRaddG_Click(object sender, EventArgs e)
        {
            is_edit_Item = false;
            cbbRGoodsID.Text = "";
            txtGQuan.Text = "";
            txtGName.Text = "";
            cbbRGoodsID.DroppedDown = true;
        }

        private void btnRupdateListG_Click(object sender, EventArgs e)
        {
            addGoods();
        }

        private void txtGQuan_TextChanged(object sender, EventArgs e)
        {
            if (txtGQuan.Text == "")
            {
                return;
            }
            if (!int.TryParse(txtGQuan.Text, out int n))
            {
                MessageBox.Show("Please input Quantity is number");
                txtGQuan.Text = "";
                return;
            }

        }


        private void cbbRGoodsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRGoodsID.Text == "")
            {
                return;
            }
            txtGName.Text = (new BUS_Goods(cbbRGoodsID.Text)).getName_from_ID();
        }

        void SaveReceipt()
        {
            string rid = txtRID.Text;
            string date = dateR.Value.ToString("yyyy/MM/dd");
            string supp = cbbRSupID.Text;
            string emp = cbbREmployee.Text;

            double total = 0;
            double money = 0;
            int quan = 0;
            double price = 0;
            //ListItem.Columns.Add("ID", typeof(string)); - 0 
            //ListItem.Columns.Add("Name", typeof(string)); - 1 
            //ListItem.Columns.Add("Price", typeof(double)); - 2
            //ListItem.Columns.Add("Quantity", typeof(int)); - 3
            BUS_GR_Detail gr;
            BUS_GReceipt r = new BUS_GReceipt(rid, date, supp, emp, total); // create new Receipt rows

            if (!r.add())
            {
                MessageBox.Show("Can not create Receipt Order!.");
                MessageBox.Show("ID Receipt invalid or Goods/Supplier/Employee not Exists");
                return;
            }

            foreach (DataRow row in ListGoods.Rows)
            {
                string idRDetail = (new BUS_GR_Detail()).getNextID();
                string goodsID = row[0].ToString();
                quan = int.Parse(row[3].ToString());
                price = double.Parse(row[2].ToString());
                money = (double)quan * price;

                gr = new BUS_GR_Detail(idRDetail, rid, goodsID, quan, money); // create Detail for Receipt

                //MessageBox.Show("" + idRDetail + " ," + rid + ", " + goodsID + ", " + quan + ", " + money);
                if (!gr.add())
                {
                    MessageBox.Show("Can not create Receipt Detail!. Try Again");
                    return;
                }
                BUS_Goods goods = new BUS_Goods(goodsID);
                goods.updateQuan_a(quan); // update quan in warehouse

                total = total + money;
            }
            r.setTotal(total);
            r.edit(); // update total amount


        }




        //////// delivery
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            is_Receipt = false;
            Color thisBtn = ColorTranslator.FromHtml("0, 230, 230");
            Color ortherBtn = ColorTranslator.FromHtml("153, 255, 255");
            changeColorBTN(btnGD, thisBtn);
            changeColorBTN(btnGR, ortherBtn);

            grbDelivery.Show(); // show grb of Delivery
            grbReceipt.Hide(); // hide grb of Receipt

            loadDelivery();// load for delivery
           
        }
        void loadDelivery()
        {
            dgvItem.DataSource = null;
            // load list delivery
            DataTable data = (new BUS_GDelivery()).getALLs();
            dgvViews.DataSource = data;
            // block  input box
            grbInfoD.Enabled = false;
            grbInfoD.BackColor = Color.Gray;
            
            btnSave.Enabled = false;
            btnSave.BackColor = Color.Gray;

            // load id of accountant 
            DataTable emp = (new BUS_Acoountant()).getALL();
            foreach(DataRow r in emp.Rows)
            {
                cbbDEmp.Items.Add(r[0].ToString());
            }

            // load list order - if payment = cash(waiting) or online with status = 1(success)
            order = (new BUS_Order()).getOrder_from_Payment(Payment_cash, Payment_online);
            foreach (DataRow r in order.Rows)
            {
                cbbDorderID.Items.Add(r[0].ToString());
            }

            // load cbb status
            cbbDstatus.Items.Clear();
            cbbDstatus.DisplayMember = "Display";
            cbbDstatus.ValueMember = "Value";
            cbbDstatus.Items.Add(new { Value = -2, Display = "Choise Status Payment" });
            cbbDstatus.Items.Add(new { Value = 1, Display = "Success" });
            cbbDstatus.Items.Add(new { Value = 0, Display = "Waiting Delivery" });
            cbbDstatus.Items.Add(new { Value = -1, Display = "Failed" });

        }
        private void btnDorder_Click(object sender, EventArgs e)
        {
            frmViews views = new frmViews(2);
            views.Show();
        }

        private void cbbDorderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbDorderID.Text == "" )
            {
                return;
            }
            showGoods(cbbDorderID.Text);
            //showStatus(cbbDorderID.Text);
           
        }

        void showGoods(string idOrder)
        {
            DataTable dataGoods = (new BUS_Order(idOrder)).getGoods_Delivery(); // get all goods in order detail from id of order
            dgvItem.DataSource = dataGoods; // load list goods delivery to datagridviews

            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                row.Cells["Price"].Style.Format = "c"; // set format is currency
                row.Cells["Amount"].Style.Format = "c";
            }
        }

        //////////////////////// button - form

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            is_edit_Item= true;

            if (is_Receipt) // Goods Receipt
            {
                try
                {
                    indexList = dgvItem.CurrentRow.Index;
                }
                catch (Exception ex) { }
                //MessageBox.Show(indexList.ToString());

                cbbRGoodsID.Text = dgvItem.Rows[indexList].Cells[0].Value.ToString();
                txtGName.Text = dgvItem.Rows[indexList].Cells[1].Value.ToString();
                txtGQuan.Text = dgvItem.Rows[indexList].Cells[3].Value.ToString();
            }
            else // goods delivery
            {

            }
               
        }
      
        
        private void dgvViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //is_edit_Item = false;
            if(is_Receipt) // Goods Receipt
            {
                int index = dgvViews.CurrentRow.Index;
                txtRID.Text = dgvViews.Rows[index].Cells[0].Value.ToString();
            }
            else // Goods Delivery
            {
                is_edit = true;
                grbInfoD.Enabled = true;
                grbInfoD.BackColor = Color.Transparent;

                int index = dgvViews.CurrentRow.Index;
                string idOrder = dgvViews.Rows[index].Cells[1].Value.ToString(); // get order id
                
                //show id Delivery
                txtDid.Text = dgvViews.Rows[index].Cells[0].Value.ToString(); // get id delivery
                
                //show orderid
                cbbDorderID.Text = dgvViews.Rows[index].Cells[1].Value.ToString(); // get id order
                
                //show id accountant
                cbbDEmp.Text = dgvViews.Rows[index].Cells[2].Value.ToString(); // get id accountant


                //show value date
                string day = dgvViews.Rows[index].Cells[3].Value.ToString(); // get date
                DateTime date = DateTime.Parse(day);
                dateD.Value = date;

                // show status
                int status = int.Parse(dgvViews.Rows[index].Cells[4].Value.ToString());
                string displayMember = cbbDstatus.Items.Cast<dynamic>().Where(x => x.Value == status).Select(x => x.Display).FirstOrDefault();
                cbbDstatus.Text = displayMember;


                // show list goods
                showGoods(idOrder);

            }

        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            is_edit = false;
            dgvItem.DataSource = null; 
            if(is_Receipt) // for Receipt
            {
                grbInfo.Enabled = true;
                grbInfo.BackColor = Color.Transparent;
                btnSave.Enabled = true;
                btnSave.BackColor = Color.Transparent;

                cbbREmployee.Text = this.Accountant;
                txtRID.Text = (new BUS_GReceipt()).getNextID();
            }
            else// for delivery
            {
                grbInfoD.Enabled = true;
                grbInfoD.BackColor = Color.Transparent;
                btnSave.Enabled = true;
                btnSave.BackColor = Color.Transparent;

                cbbDEmp.Text = this.Accountant; // set auto id accountant when login
                txtDid.Text = (new BUS_GDelivery()).getNextID(); // auto get next id in data
                
                cbbDorderID.Text = "";
                cbbDstatus.SelectedIndex = 0;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(is_Receipt)
            {
                loadReceipt();
            }
            else
            {
                loadDelivery();
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_Receipt) // for Receipt
            {
                if (txtRID.Text == "" || cbbREmployee.Text == "" || dateR.Value.ToString("yyyy/MM/dd") == "" || cbbRSupID.Text == "")
                {
                    MessageBox.Show("Input Invalid");
                    return;
                }
                if(ListGoods.Rows.Count < 1)
                {
                    MessageBox.Show("Null data for list Item");
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to save?. That will not edit or remove!", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) // confirm save
                {
                    // Call restore                       
                    SaveReceipt();
                    loadReceipt();
                }
                else if (result == DialogResult.No) //
                {
                    

                }
               
                
            }
            else// for delivery
            {
                string did = txtDid.Text;
                string orderID = cbbDorderID.Text;
                string emp = cbbDEmp.Text;
                string date = dateD.Value.ToString("yyyy/MM/dd");
                int status = (cbbDstatus.SelectedItem as dynamic).Value;
                if(did == "" || orderID =="" || emp =="" || date =="" || (status > 1 || status < -1) )
                {
                    MessageBox.Show("Invalid Input");
                    return;
                }

                bool is_Exists_Order = (new BUS_GDelivery(orderID)).is_Exists_Order();
                if(is_Exists_Order) // if have order and delivery for it = 0 or = 1
                {
                    MessageBox.Show("This Order is exists. Please update status!");
                    return;
                }
                else // not have delivery for order or that delivery = -1
                {
                    DialogResult result = MessageBox.Show("Do you want to save?. That will not edit or remove!", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes) // confirm save
                    {
                        // Call restore                       
                        BUS_GDelivery delivery = new BUS_GDelivery(did, orderID, emp, date, status);
                        
                        DataTable dataGoods = (new BUS_Order(orderID)).getGoods_Delivery(); // get all goods in order detail from id of order
                        
                        bool is_can_delivery = true;// check quantity of goods when delivery with warehouse
                        
                        foreach(DataRow r in dataGoods.Rows)
                        {
                            BUS_Goods goods = new BUS_Goods(r[0].ToString());// create goods with id
                            int quan_Delivery = int.Parse(r[0].ToString()); // get quantity delivery
                            if (!goods.checkQuan(quan_Delivery));
                            {
                                is_can_delivery = false;
                                MessageBox.Show("The goods " + goods.getID() + " more than warehouse. Can not create delivery");
                            }
                        }
                        if(!is_can_delivery)
                        {
                            return;
                        }
                        if (!delivery.add())
                        {
                            MessageBox.Show("Error, Try Again!");
                            return;
                        }
                        //update warehouse when delivery
                        (new BUS_Goods()).update_warehouse(dataGoods, 3); // quantity of goods in index 3
                        loadDelivery();
                    }
                    else if (result == DialogResult.No) //
                    {


                    }
                   
                   
                }
            }
            btnSave.Enabled = false;

        }

        // only remove for delivery
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (is_Receipt) // for Receipt
            {
               
            }
            else// for delivery
            {

            }
        }

        private void grbInfoD_Enter(object sender, EventArgs e)
        {

        }
    }
}
