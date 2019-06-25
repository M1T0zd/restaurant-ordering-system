using RestaurantModel;
using Restaurant_Logic;
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
    public partial class Login_Form : Form
    {
        int check = 0;
        public Login_Form()
        {
            InitializeComponent();         
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //GetAllLoginInfo
            Login_Service Login_Service = new Login_Service();
            List<Login> loginList = Login_Service.GetLogin();

            Employee currentemployee = new Employee();
            foreach (Login login in loginList)
            {
                if (login.Username == txtusername.Text && login.Password == txtpassword.Text)
                {
                    //Getting current employee
                    currentemployee = GetCurrentEmployee(login);
                    check++;         
                }           
            }
            //Show which form belongs to which employee
            ShowForm(currentemployee);
            //ClearingTextBoxt for logging in after logging out
            ClearTextBox();
        }
        void ClearTextBox()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        Employee GetCurrentEmployee(Login login)
        {
            Employee_Service employee_Service = new Employee_Service();
            Employee employee = employee_Service.GetCurrentEmployee(login);
            return employee;
        }
      
        private void ShowForm(Employee currentemployee)
        {
            if (check == 1)
            {
                //Hide login form
                if (currentemployee.Role == EmployeeRole.Chef)
                {
                    //Display Chef UI
                    Kitchen_Form kitchen_Form = new Kitchen_Form(currentemployee);
                    kitchen_Form.Show();
                }
                else if (currentemployee.Role == EmployeeRole.Barman)
                {
                    //Display BarmanUI
                    Kitchen_Form kitchen_Form = new Kitchen_Form(currentemployee);
                    kitchen_Form.Show();
                }
                else if (currentemployee.Role == EmployeeRole.Waiter)
                {
                    //Display WaiterUI
                    Table_Form table_Form = new Table_Form(currentemployee,this);
                    table_Form.Show();
                }
                this.Hide();
                check = 0;
            }
            else
            {
                //Show Message Box
                string message = "Wrong Username / Password";
                string title = "Enter valid login credentials";
                MessageBox.Show(message, title);
            }        
        }
    }
}
