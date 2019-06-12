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
    public partial class Payment_confirmation : Form
    {
        Table_Form form;
        Payment_Form payment_Form;
        public Payment_confirmation(Table_Form form, Payment_Form payment_Form)
        {
            InitializeComponent();
            this.form = form;
            this.payment_Form = payment_Form;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            payment_Form.SaveOrderDetails();
            payment_Form.WriteComments();
            form.Show();
            this.Close();
            payment_Form.Close();
        }
    }
}
