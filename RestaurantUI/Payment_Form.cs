using Restaurant_Logic;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_UI
{
    public partial class Payment_Form : Form
    {

        public Payment_Service payment_Services;
        Table_Form table_Form;
        Table table;
        Payment payment;
        Session currentsession;
        public Payment_Form(Table_Form table_Form, Table table,Session session)
        {
            InitializeComponent();
            this.currentsession = session;
            this.table_Form = table_Form;
            this.table = table;
            Table_Numberlbl.Text = table.Number.ToString();
            this.Text = $"Payment From   {DateTime.Now.ToShortDateString()}  [ {DateTime.Now.ToShortTimeString()} ]";
            payment_Services = new Payment_Service();
            displayOrderDetails();

        }

        private void displayOrderDetails()
        {
            payment.Total = 89;
            payment.Tax = payment.Total * Convert.ToDecimal(0.15);
            Total_txt_bx.Text = payment.Total.ToString() + payment.Tax.ToString();
            Tax_txt_bx.Text = payment.Tax.ToString();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            table_Form.Show();

        }
        //select payment method
        public int selectedPaymentMethod()
        {
            int payment_Method;
            if (PinRadiobtn.Checked == true)
            {
                payment_Method = (int)PaymentMethod.Pin;
            }
            else if (cashRadiobtn.Checked == true)
            {
                payment_Method =(int) PaymentMethod.Cash;
            }
            else
            {
                payment_Method = (int)PaymentMethod.CreditCard;
            }

            return payment_Method;
        }

        // process payment 
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
                Confirm_payment_Method process_ = new Confirm_payment_Method(this, table_Form, table);
                process_.Show();
            }
        }

        public void SaveOrderDetails()
        {
            int paymentMethod = selectedPaymentMethod();
            payment_Services.insertOrder (paymentMethod, payment.Total, payment.Tax);
        }

        //write comments to text file
        public void WriteComments()
        {
            string file = "Comments.txt";
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            StreamWriter writer = File.AppendText(file);
            writer.WriteLine(commentstxt_box.Text);
            writer.Close();
        }
    }
}
