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
    public partial class Confirm_payment_Method : Form
    {
        Payment_Form form;
        Payment_confirmation payment_Confirmation;
        Table_Form table_Form;
        Table table;
        public Confirm_payment_Method(Payment_Form form , Table_Form table_Form,Table table)
        {
            InitializeComponent();
            this.form = form;
            this.table_Form = table_Form;
            this.table = table;
            payment_Confirmation = new Payment_confirmation(table_Form,form);
            payMethodlbl.Text = form.selectedPaymentMethod();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            table.Status = TableStatus.Available;
            table_Form.GiveColor();
            this.Close();
            form.Hide();
            payment_Confirmation.Show();   
        }
      
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
