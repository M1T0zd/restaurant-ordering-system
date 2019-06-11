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
        //Bar- and Kitchen-form can be the same form(if the logged in employee == bar then get drinks otherwise get food).
        List<Login> loginList = new List<Login>();
        List<Employee> employees = new List<Employee>();
        Login CurrentLogin;
        Employee currentemployee;
        int check = 0;
        Login_Service Login_Service { get; set; }

        public Login_Form()
        {
            InitializeComponent();
            GetEmployee();
        }
        void GetEmployee()
        {
            Employee_Service employee_Service = new Employee_Service();
            employees = employee_Service.GetEmployee();
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //GetAllLoginInfo
            Login_Service = new Login_Service();
            loginList = Login_Service.GetLogin();
            //Make new Current Login to save current login info
            CurrentLogin = new Login();
            foreach (Login login in loginList)
            {
                if (login.Username == txtusername.Text && login.Password == txtpassword.Text)
                {
                    CurrentLogin.EmployeeNumber = login.EmployeeNumber;
                    check++;
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }           
            }
            CheckEmployee();
            ShowForm();
        }
        void CheckEmployee()
        {
            foreach (Employee employee in employees)
            {
                if (employee.Number == CurrentLogin.EmployeeNumber)
                {
                    currentemployee = employee;
                }
            }
        }
        private void ShowForm()
        {
            if (check == 1)
            {
                //Hide login form
                this.Hide();
                if (currentemployee.Role == "Chef")
                {
                    //Display Chef UI
                    Kitchen_Form kitchen_Form = new Kitchen_Form(currentemployee);
                    kitchen_Form.Show();
                }
                else if (currentemployee.Role == "Barman")
                {
                    //Display BarmanUI
                    Bar_Form bar_Form = new Bar_Form();
                    bar_Form.Show();
                }
                else if (currentemployee.Role == "Waiter")
                {
                    //Display WaiterUI
                    Table_Form table_Form = new Table_Form(currentemployee, this);
                    table_Form.Show();
                }
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

		private void Login_Form_Load(object sender, EventArgs e)
		{

		}
	}
}
