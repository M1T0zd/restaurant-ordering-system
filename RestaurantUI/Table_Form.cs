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
        List<OrderItem> orderItems;
        Session currentsession;
        List<Button> buttons;
        Employee employee;
       
        public Table_Form(Employee employee, Login_Form login_Form)
        {
            InitializeComponent();
            Initialize(login_Form,employee);
        }
        private void Initialize(Login_Form login_Form,Employee employee)
        {
            //Timer with 10 second interval
            timer1.Enabled = true;
            timer1.Interval = 10000;

            Table_Service table_Service = new Table_Service();
            currentsession = new Session();

            this.login_Form = login_Form;
            this.employee = employee;
            tables = table_Service.GetTables();
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
        }
        private void GiveColor()
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
       // public static int tableID = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            //If button clicked, get table from list based on it's TabIndex
            Table table = tables[button.TabIndex];
            currentsession.Table = table;

            // tableID = tables.Find(x => x.Number == table.Number).Number;
            CheckStatusPanel();
        }
        void CheckStatusPanel()
        {
            CheckStatusButton();
            lblNumber.Text = $"Table {currentsession.Table.Number.ToString()}";
            if (currentsession.Table.Status == TableStatus.Occupied)
            {
                Order_Form order_Form = new Order_Form(this, currentsession);
                order_Form.Show();
            }
            else
            {
                pnlnotif.Hide();
                pnltable.Hide();
                pnlChangeStatus.Show();
            }
        }
        public void CheckStatusButton()
        {
            btnOccupied.Show();
            btnAvailable.Show();
            btnReserved.Show();

            if (currentsession.Table.Status == TableStatus.Occupied)
            {
                btnOccupied.Hide();
            }
            else if (currentsession.Table.Status == TableStatus.Available)
            {
                btnAvailable.Hide();
            }
            else if (currentsession.Table.Status == TableStatus.Reserved)
            {
                btnReserved.Hide();
            }
        }
        
        //Below Code is for the Notification Panel
        private void Btnnotif_Click(object sender, EventArgs e)
        {
            UpdateList();

            pnltable.Hide();
            pnlChangeStatus.Hide();
            pnlnotif.Show();
        }
        private void UpdateList()
        {
            OrderItem_Service order_Service = new OrderItem_Service();
            orderItems = order_Service.GetOrderItemReady();

            listviewnotif.Clear();
            listviewnotif.View = View.Details;
            listviewnotif.Columns.Add("Name");
            listviewnotif.Columns.Add("Quantity");
            listviewnotif.Columns.Add("Status");
            listviewnotif.Columns.Add("Table");


            foreach (OrderItem order in orderItems)
            {
               // ListViewItem listViewItem = new ListViewItem(order.MenuItem.Name);
                ListViewItem listViewItem = new ListViewItem(order.ItemName);
                listViewItem.SubItems.Add(order.Amount.ToString());
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

                UpdateList();
            }
            catch (Exception)
            {
                //Show Message Box
                string message = "Please Select An Item";
                string title = "You haven't selected An item";
                MessageBox.Show(message, title);
            }        
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
        //Code for Status Panel

        private void CreateSession()
        {
            currentsession.Start = DateTime.Now;
            currentsession.Host = employee;
            currentsession.Table.Status = TableStatus.Occupied;
        }

        private void BtnOccupied_Click(object sender, EventArgs e)
        {
            CreateSession();
            Table_Service table_Service = new Table_Service();
            table_Service.UpdateStatus(currentsession.Table);
            GiveColor();

            Session_Service session_Service = new Session_Service();
            session_Service.UpdateTable(currentsession);
            session_Service.GetSessionId(currentsession);

            pnlChangeStatus.Hide();
            pnltable.Show();

            Order_Form order_Form = new Order_Form(this, currentsession);
            order_Form.Show();
        }

        private void BtnAvailable_Click(object sender, EventArgs e)
        {
            currentsession.Table.Status = TableStatus.Available;
            Table_Service table_Service = new Table_Service();
            table_Service.UpdateStatus(currentsession.Table);
            GiveColor();
            pnltable.Show();      
        }

        private void BtnReserved_Click(object sender, EventArgs e)
        {
            currentsession.Table.Status = TableStatus.Reserved;
            Table_Service table_Service = new Table_Service();
            table_Service.UpdateStatus(currentsession.Table);
            GiveColor();
            pnltable.Show();
        }
        private void Btnback_Click(object sender, EventArgs e)
        {
            pnltable.Show();
        }

        //
        private void Timer1_Tick(object sender, EventArgs e)
        {
            GiveColor();
            UpdateList();
            ShowNotification();
        }
        void ShowNotification()
        {
            //Show notification for ready orders
            if (listviewnotif.Items.Count > 0)
            {
                btnnotif.Text = $"{listviewnotif.Items.Count.ToString()} orders ready";
            }
        }
        public void ChangeStatusForOrder()
        {
            CheckStatusButton();
            Show();
            pnltable.Hide();
            pnlnotif.Hide();
            pnlChangeStatus.Show();
        }      
    }
}
