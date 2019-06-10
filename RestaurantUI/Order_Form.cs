using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Logic;
using RestaurantModel;

namespace Restaurant_UI
{
    public partial class Order_Form : Form
    {
        //Make Panel Status with orders capability in OrderForm
        List<Order> orders;
        List<RestaurantModel.MenuItem> menuItems = new List<RestaurantModel.MenuItem>();
        Table_Form table_Form;
        Table table;
        public Order_Form(Table table, Table_Form table_Form)
        {
            InitializeComponent();
            this.table_Form = table_Form;
            this.table = table;
            Initialize(table);
            lblnumber.Text = $"Table {table.Number}";        
        }

        void Initialize(Table table)
        {
            orders = table.orders;
        }
       
        private void Order_Form_Load(object sender, EventArgs e)
        {
            if (table.Status == TableStatus.Available)
            {
                pnldefault.Hide();
                pnlchangestatus.Show();
            }
            else
            {
                pnlchangestatus.Hide();
                pnldefault.Show();
            }
        }

        void MakeMenuItems()
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Payment_Form form = new Payment_Form(table_Form);
            this.Hide();
            form.Show();
        }

        private void Btnsetoccupy_Click(object sender, EventArgs e)
        {
            table.Status = TableStatus.Occupied;
            table_Form.GiveColor();
            pnlchangestatus.Hide();
            pnldefault.Show();
        }

        private void Btnreserve_Click(object sender, EventArgs e)
        {
            table.Status = TableStatus.Reserved;
            table_Form.GiveColor();
            this.Hide();
            table_Form.Show();
        }
    }
}
