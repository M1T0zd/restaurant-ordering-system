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
        int tableNumber;
        Payment payment = new Payment();
        Payment_Service payment_Service = new Payment_Service();
        public Payment_Form(Table_Form table_Form, int tableNumber)
        {
            InitializeComponent();
            this.table_Form = table_Form;
            this.tableNumber = tableNumber;
            DisplayOrderItems();
        }
        private void DisplayOrderItems()
        {
            Table_Numberlbl.Text = tableNumber.ToString();
            List<OrderItem> orderItems = payment_Service.GetOrderItemPayment();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName);
                listViewItem.SubItems.Add(item.Category.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listView1.Items.Add(listViewItem);
            }
            CalculateTotal();
        }
        private void CalculateTotal() // add vat
        {
            int quantity = 0;
            decimal unitPrice = 0;
            decimal totalUnitPrice;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                totalUnitPrice = 0;
                quantity = Convert.ToInt16(listView1.Items[i].SubItems[2].Text);
                unitPrice = Convert.ToDecimal(listView1.Items[i].SubItems[3].Text);
                totalUnitPrice += (quantity * unitPrice);
                payment.Total += totalUnitPrice;
                CalculateVaT(totalUnitPrice);
            }

        }
        private void CalculateVaT(decimal totalUnitPrice)
        {
            decimal taxPerItem;
            bool isAlchoholic = IsAlchoholic();
            if (isAlchoholic == false)
            {
                taxPerItem = (totalUnitPrice * Convert.ToDecimal(0.06));
            }
            else
            {
                taxPerItem = ((totalUnitPrice) * Convert.ToDecimal(0.21));
            }
            payment.Tax += taxPerItem;
            payment.Total += taxPerItem;

            Tax_txt_bx.Text = string.Format("{0:c}", payment.Tax);
            Total_txt_bx.Text = string.Format("{0:c}", payment.Total);
        }
        private bool IsAlchoholic()
        {
            bool isAlchoholic = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if( listView1.Items[i].SubItems[1].Text == "Alchoholic") 
                {
                    isAlchoholic = true;
                }
            }
            return isAlchoholic;

        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel.", "Confirm cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                table_Form.Show(); //go to home page
            }
        }
        private int SelectPaymentMethod()
        {
            payment.PaymentMethod = 0;
            if (PinRadiobtn.Checked == true)
            {
                payment.PaymentMethod = (int)PaymentMethod.Pin;
            }
            if (cashRadiobtn.Checked == true)
            {
                payment.PaymentMethod = (int)PaymentMethod.Cash;
            }
            if (creditCardRdbtn.Checked == true)
            {
                payment.PaymentMethod = (int)PaymentMethod.CreditCard;
            }
            return payment.PaymentMethod;
        }
        // process payment 
        private void PayOrderbtn_Click(object sender, EventArgs e)
        {
            payment.PaymentMethod = SelectPaymentMethod();
            if (payment.PaymentMethod == 0)
            {
                MessageBox.Show("Please select payment method.", " payment method is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to make a payment.", "Confirm payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    WriteComments();
                    SavePaymentDetails();
                }
            }
        }
        //save paid order to database
        private void SavePaymentDetails()
        {
            int tbleNumber = Convert.ToInt16(tableNumber);
            payment.Date = DateTime.Now.ToString();
            Session session = new Session();
            payment_Service.SavePaidOrder(payment, session, tbleNumber);

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
            table_Form.BtnAvailable_Click(null,null);
            table_Form.Show(); // back to home page 
        }

        private void Tiptxt_bx_TextChanged(object sender, EventArgs e)
        {
            Tiptxt_bx.Text = Tiptxt_bx.Text.Trim();
            try
            {

                if (Tiptxt_bx.Text == "")
                {
                    payment.Tip = 0;
                }
                else
                {
                    payment.Tip = Decimal.Parse(Tiptxt_bx.Text);

                }
                decimal totalPrice = payment.Tip + payment.Total; 
                Total_txt_bx.Text = string.Format("{0:C}",totalPrice);
            }
            catch (Exception m)
            {
                MessageBox.Show("Enter numbers only", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    
 


