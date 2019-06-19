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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_UI
{
     partial class Payment_Form : Form
    {

        Table_Form table_Form;
        Table tableNumber;
        private Payment payment = new Payment();

        public Payment_Form(Table_Form table_Form, Table tableNumber)
        {
            InitializeComponent();
            this.table_Form = table_Form;
            this.tableNumber = tableNumber;
            DisplayOrderDetails();
        }
        private void DisplayOrderDetails()
        {
            Table_Numberlbl.Text = tableNumber.Number.ToString();
            for (int i = 1; i < 5; i++)
            {
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(i));
                listViewItem.SubItems.Add("1");
                listViewItem.SubItems.Add("10");
                listView1.Items.Add(listViewItem);
            }
            CalculateTotal();
        }
        private void CalculateTotal() // add vat
        {
            string total = null;
            for (int i = 1; i < listView1.Items.Count; i++)
            CalculateVaT(total);
            payment.Total = (Convert.ToDecimal(total) + payment.Tax);
            Total_txt_bx.Text = string.Format("{0:C}", payment.Total);
        }
        private void CalculateVaT(string total)
        {
            bool isAlchoholic = true;
            if (!isAlchoholic)
            {
                payment.Tax = (Convert.ToDecimal(total) * Convert.ToDecimal(0.06));
                VAT.Text = "6%";
            }
            else
            {
                payment.Tax = (Convert.ToDecimal(total) * Convert.ToDecimal(0.21));

                VAT.Text = "21%";
            }

            Tax_txt_bx.Text = string.Format("{0:C}", payment.Tax);
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel.", "Confirm cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                table_Form.Show(); //go to home page
            }
        }
        private int SelectPaymentMethod()
        {
            int payment_Method = 0;
            if (PinRadiobtn.Checked == true)
            {
                payment_Method = 1;
            }
            if (cashRadiobtn.Checked == true)
            {
                payment_Method = 2;
            }
            if (creditCardRdbtn.Checked == true)
            {
                payment_Method = 3;
            }
            return payment_Method;
        }
        // process payment 
        private void PayOrderbtn_Click(object sender, EventArgs e)
        {
            int paymentMethod = SelectPaymentMethod();
            if (paymentMethod == 0)
            {
                MessageBox.Show("Please select payment method.", "Error payment method is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to make payment.", "Confirm payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    WriteComments();
                    SavePaymentDetails();
                }
            }
        }
        private void SavePaymentDetails()// send to database
        {


            Payment_Service payment_Service = new Payment_Service();
            payment_Service.insertOrder(payment);

        }


        //write comments to text file
        private void WriteComments()// to text file
        {
            if (String.IsNullOrEmpty(commentstxt_box.Text))
            {
                PaymentConfirmation();
            }
            else
            {
                try
                {
                    string file = "Comments.txt";
    
                    if (!File.Exists(file))
                    {
                        File.Create(file);
                    }
                    StreamWriter writer = File.AppendText(file);
                    {
                        writer.WriteLine($"{DateTime.Now} : {commentstxt_box.Text}");
                    }
                    PaymentConfirmation();
                }
                catch (Exception e)
                {
                    MessageBox.Show("e");
                }
            }
        }
        private void PaymentConfirmation()
        {
            MessageBox.Show(" Payment successful.", "Payment recieved", MessageBoxButtons.OK, MessageBoxIcon.None);
            table_Form.Show(); // back to home page
        }
        // Add tip numeric only
        private void Tiptxt_bx_TextChanged(object sender, EventArgs e)
        {
            bool match = Regex.IsMatch(Tiptxt_bx.Text, "^1-9*$");
            try
            {
                if (match == false)
                {
                    string total = (Decimal.Parse(Tiptxt_bx.Text) + Decimal.Parse(Total_txt_bx.Text)).ToString();// add tip to total + Vat
                    Total_txt_bx.Text = total.ToString();
                    payment.Total = Convert.ToDecimal(total);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Enter numbers only", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
 }


