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
    public partial class Process_payment : Form
    {
        Payment_Form form;
        Payment_confirmation payment_Confirmation;
        Table_Form table_Form;
        public Process_payment(Payment_Form form , Table_Form table_Form)
        {
            InitializeComponent();
            this.form = form;
            this.table_Form = table_Form;
            payment_Confirmation = new Payment_confirmation(table_Form,form);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
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
