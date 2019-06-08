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
        private void Button2_Click(object sender, EventArgs e)
        {
            Process_payment process_ = new Process_payment(this, table_Form);
            process_.Show();
        }
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            table_Form.Show();
            

        }
    }
}
