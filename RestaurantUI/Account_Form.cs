using System;
using RestaurantModel;
using Restaurant_Logic;
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
    public partial class Account_Form : Form
    {
        Login_Form loginform;
        Employee Employee;
        Table_Form Table_Form;
        Kitchen_Form Kitchen_Form;
        public Account_Form(Employee employee,Login_Form login_Form,Table_Form table_Form)
        {
            InitializeComponent();
            this.loginform = login_Form;
            this.Employee = employee;
            Table_Form = table_Form;
          
            lblname.Text = $"{employee.Name}";
            lbljob.Text = $"{employee.Role}";         
        }
        public Account_Form(Employee employee, Login_Form login_Form,Kitchen_Form kitchen_Form)
        {
            this.Kitchen_Form = kitchen_Form;
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            loginform.Show();
            this.Close();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            if (Employee.Role == "Waiter")
            {
                Table_Form.Show();
            }
            else
            {
                Kitchen_Form.Show();
            }
            this.Hide();
        }
    }
}
