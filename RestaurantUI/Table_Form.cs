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
        List<Table> tables = new List<Table>();

        public Table_Form()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                tables.Add(new Table(i+1));
            }
        }

        public Table_Service Table_Service { get; set; }
     

        private void Table_Form_Load(object sender, EventArgs e)
        {
           
        }
   
        private void Button_Click(object sender, EventArgs e)
        {
            //Make Panel Status with orders capability in OrderForm
            Button button = (Button)sender;

            Table table = tables[button.TabIndex];

            Order_Form order_Form = new Order_Form(table);

            order_Form.Show();
            if (table.Status == "Available")
            {
                //Background Green
                btntbl1.BackColor = Color.Green;
            }
            else if (table.Status == "Reserve")
            {
                btntbl1.BackColor = Color.Yellow;
            }
            else
            {
                btntbl1.BackColor = Color.Red;

            }
        }
    }
}
