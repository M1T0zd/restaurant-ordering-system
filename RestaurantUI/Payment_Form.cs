using Restaurant_Logic;
using RestaurantModel;
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
    public partial class Payment_Form : Form
    {
        Payment_Service payment_Services;
        public Payment_Form()
        {
            InitializeComponent();
            Payment_Service GetOrder = new Payment_Service();
            List<Order> payOrder = GetOrder.Get_Order();

            foreach (Order item in payOrder)
            {
                ListViewItem li = new ListViewItem(item.Id.ToString());
                li.SubItems.Add(item.TakenAt.ToString());
                li.SubItems.Add(item.Status);
                listView1.Items.Add(li);
            }

        }

        public Payment_Service Payment_Service
        {
            get { return payment_Services; }
            set
            {
                payment_Services = value;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {

        }

       
    }
}
