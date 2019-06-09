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

        private static Payment_Form form;
        private Payment_Service payment_Services;
        Table_Form table_Form;

        public Payment_Form(Table_Form table_Form)
        {
            InitializeComponent();
            this.table_Form = table_Form;
             
        }
       
        public Payment_Service Payment_Service
        {
            get { return payment_Services; }
            set
            {
                payment_Services = value;
            }
        }
      
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            table_Form.Show();
            
        }
        public string selectedPaymentMethod()
        {
            string  payment_Method;
            if(PinRadiobtn.Checked == true)
            {
                payment_Method = Enum.GetName(typeof(PaymentMethod), 2);
            }
            else if(cashRadiobtn.Checked == true)
            {
                payment_Method = Enum.GetName(typeof(PaymentMethod),0);
            }
            else 
            {
                payment_Method = Enum.GetName(typeof(PaymentMethod), 1);
            }

            return payment_Method;
        }

        private void PayOrderbtn_Click(object sender, EventArgs e)
        {
            if (cashRadiobtn.Checked == false && PinRadiobtn.Checked == false && creditCardRdbtn.Checked == false)
            {
                string message = "Select a payment method";
                string title = "Error";
                MessageBox.Show(message, title);
           
            }
            else
            {
                Confirm_payment_Method process_ = new Confirm_payment_Method(this, table_Form);
                process_.Show();
            }
        }
    }
}
