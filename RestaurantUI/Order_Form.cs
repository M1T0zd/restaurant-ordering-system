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

        public Order_Form(Table table)
        {
            InitializeComponent();

            Initialize(table);
        }

        void Initialize(Table table)
        {
            orders = table.orders;
        }
        

        private void Order_Form_Load(object sender, EventArgs e)
        {

        }

        void MakeMenuItems()
        {

        }
    }
}
