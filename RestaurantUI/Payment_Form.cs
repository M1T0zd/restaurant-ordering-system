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
        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Payment_Service payment_Services = new Payment_Service();
            Payment payment = new Payment()
            {
                paymentDate = Convert.ToDateTime(datetxtbx.Text),
                orderNumber = Convert.ToInt16(orderNumbertxtbx.Text),
            };

            payment_Services.InsertDetails(payment);
            MessageBox.Show("Payment Successful");

        }
    }
}
