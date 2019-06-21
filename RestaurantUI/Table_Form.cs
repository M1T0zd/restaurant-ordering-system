using RestaurantModel;
using Restaurant_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_UI
{
    public partial class Table_Form : Form
    {
        List<Table> tables;
        Login_Form login_Form;
        Button button;
        Table table;
        Employee Employee;
        List<OrderItem> orderItems;
        Session currentsession;
        List<Button> buttons;
        Payment_Service Payment_Service = new Payment_Service();
        Payment payment = new Payment();
        public Table_Service Table_Service { get; set; }
       // Employee employee, Login_Form login_Form
        public Table_Form(/*Employee employee, Login_Form login_Form*/)
        {
            InitializeComponent();
            currentsession = new Session();
           // this.Employee = employee;
            Initialize(login_Form);
        }

        private void Table_Form_Load(object sender, EventArgs e)
        {
        }

        private void Initialize(Login_Form login_Form)
        {
            Table_Service = new Table_Service();
            this.login_Form = login_Form;
            tables = Table_Service.GetTables();
            currentsession.Host = Employee;
            buttons = new List<Button>
            {
                btntbl1,
                btntbl2,
                btntbl3,
                btntbl4,
                btntbl5,
                btntbl6,
                btntbl7,
                btntbl8,
                btntable9,
                btntable10
            };
            GiveColor();
            //Get Notification List If Order Is ready
        }
        public void GiveColor()
        {
            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Status == TableStatus.Available)
                {
                    //Background Green
                    buttons[i].BackColor = Color.Green;
                }
                else if (tables[i].Status == TableStatus.Reserved)
                {
                    buttons[i].BackColor = Color.Yellow;
                }
                else
                {
                    buttons[i].BackColor = Color.Red;
                }
            } 
        }
        public static int tableID = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            //If button clicked, get table from list based on it's TabIndex
            table = tables[button.TabIndex];

             tableID = tables.Find(x => x.Number == table.Number).Number;
            currentsession.Table = table;
           // Payment_Form payment_Form = new Payment_Form(tableID);
            Order_Form order_Form = new Order_Form(table,this,Employee,currentsession);
            order_Form.Show();
            this.Hide();
      
        }
        //Below Code is for the Notification Panel
      
        private void Btnnotif_Click(object sender, EventArgs e)
        {
            ShowList();

            pnltable.Hide();
            pnlnotif.Show();
        }
        private void ShowList()
        {
            listviewnotif.View = View.Details;
            listviewnotif.Columns.Add("Name");
            listviewnotif.Columns.Add("Status");
            listviewnotif.Columns.Add("Table");

            OrderItem_Service order_Service = new OrderItem_Service();
            orderItems = order_Service.GetOrderWaiter();

            foreach (OrderItem order in orderItems)
            {
               // ListViewItem listViewItem = new ListViewItem(order.MenuItem.Name);
                ListViewItem listViewItem = new ListViewItem(order.ItemName);
                listViewItem.SubItems.Add(order.Status.ToString());
                listViewItem.SubItems.Add(order.TableNumber.ToString());


                listviewnotif.Items.Add(listViewItem);
            }
        }

        private void Btnpanelback_Click(object sender, EventArgs e)
        {
            pnlnotif.Hide();
            pnltable.Show();
        }
        OrderItem selectedorderItem;
        private void Listviewnotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listviewnotif.SelectedIndices[0];
            selectedorderItem = orderItems[index];
        }
        private void Btnserveitem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedorderItem.Status = OrderStatus.Served;
                OrderItem_Service item_Service = new OrderItem_Service();
                item_Service.UpdateStatus(selectedorderItem);

                RefreshForm();
            }
            catch (Exception)
            {
                //Show Message Box
                string message = "Please Select An Item";
                string title = "You haven't selected An item";
                MessageBox.Show(message, title);
            }        
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        void RefreshForm()
        {
            listviewnotif.Clear();
            ShowList();
        }

        private void Btnrefreshtableview_Click(object sender, EventArgs e)
        {
            GiveColor();
        }
    
		private void Table_Form_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

        private void Btllogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log Out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                login_Form.Show();
            }
            else
            {
                // Go Back
            }
        }
    }
}
