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
            payment_Services = new Payment_Service();
            Payment payment = new Payment()
            {
                PaymentDate = Convert.ToDateTime(datetxtbx.Text),
                OrderNumber = Convert.ToInt16(orderNumbertxtbx.Text),
            };

            payment_Services.InsertDetails(payment);
            MessageBox.Show("Payment Successful");

        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
