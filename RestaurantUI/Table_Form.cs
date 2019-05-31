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
        Table table1 = new Table();

        public Table_Form()
        {
            InitializeComponent();
        }

        public Table_Service Table_Service { get; set; }
     

        private void Table_Form_Load(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Order_Form order_Form1 = new Order_Form();
            order_Form1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl2_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl4_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl5_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl6_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl7_Click(object sender, EventArgs e)
        {

        }

        private void Btntbl8_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }
    }
}
