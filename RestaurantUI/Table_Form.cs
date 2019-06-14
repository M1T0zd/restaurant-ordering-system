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
        Button button;
        Table table;
        Account_Form form;
        Employee Employee;
        List<OrderItem> orderItems;
        Session currentsession;
        
        public Table_Service Table_Service { get; set; }


        public Table_Form(Employee employee, Login_Form login_Form)
        {
            InitializeComponent();
            form = new Account_Form(employee,login_Form,this);
            currentsession = new Session();
            this.Employee = employee;
            //Get Notification List If Order Is ready
            GetList();
        }

        private void Table_Form_Load(object sender, EventArgs e)
        {
            Initialize();          
        }

        private void Initialize()
        {
            Table_Service = new Table_Service();
            tables = Table_Service.GetTables();
            currentsession.HostId = Employee.Number;
            GiveColor();

        }
      
        public void GiveName()
        {
            List<Label> labels = new List<Label>
            {
               lbltable1,lbltable2,lbltable3,lbltable4,lbltable5,lbltable6,lbltable7,lbltable8,lbltable9,lbltable10
            };

            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Status == TableStatus.Available)
                {
                    labels[i].Text = "";
                }
                else if (tables[i].Status == TableStatus.Reserved)
                {
                    labels[i].Text = "";
                }
                else
                {
                    labels[i].Text = $"Taken by: {tables[i].Employee.Name}";
                }
            }
        }
        public void GiveColor()
        {
            List<Button> buttons = new List<Button>
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
        private void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            //If button clicked, get table from list based on it's TabIndex
            table = tables[button.TabIndex];
            currentsession.TableId = table.Number;

            Order_Form order_Form = new Order_Form(table,this,Employee,currentsession);
            order_Form.Show();
            this.Hide();
      
        }
        private void Btnaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            
        }
        //Below Code is for the Notification Panel
      
        private void Btnnotif_Click(object sender, EventArgs e)
        {
            pnltable.Hide();
            pnlnotif.Show();
        }
        private void GetList()
        {
            listviewnotif.View = View.Details;
            listviewnotif.Columns.Add("Name");
            listviewnotif.Columns.Add("Status");
            listviewnotif.Columns.Add("Table");

            OrderItem_Service order_Service = new OrderItem_Service();
            orderItems = order_Service.GetOrder();

            foreach (OrderItem order in orderItems)
            {
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
            OrderItem orderItem = orderItems[index];
            selectedorderItem = orderItem;
        }     
        private void Btnserveitem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedorderItem.Status = OrderStatus.Served;
                OrderItem_Service item_Service = new OrderItem_Service();
                item_Service.UpdateStatus(selectedorderItem);
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
            listviewnotif.Clear();
            GetList();
        }
    }
}
