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
        List<Login> loginList;
        Login CurrentLogin;
        List<Employee> employees;
        Employee currentEmployee;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //GetAllEmployeeInfo
            Restaurant_Logic.Employee_Service employee_Service = new Employee_Service();
            employees = employee_Service.GetEmployee();
            //GetAllLoginInfo
            Restaurant_Logic.Login_Service login_Service = new Login_Service();
            loginList = login_Service.GetLogin();
            //
            CurrentLogin = new Login();
            currentEmployee = new Employee();
            foreach (Login login in loginList)
            {
                if (login.username == txtusername.Text && login.password == txtpassword.Text)
                {
                    //CurrentLogin.username = login.username;
                    //CurrentLogin.password = login.password;
                    CurrentLogin.employeenumber = login.employeenumber;
                    foreach (Employee employee in employees)
                    {
                        if (CurrentLogin.employeenumber == employee.Number)
                        {
                            currentEmployee.Role = employee.Role;
                        }
                    }
                    //Hide login form
                    this.Hide();

                    if (currentEmployee.Role == 1)
                    {
                        //Display Chef UI
                        Kitchen_Form kitchen_Form = new Kitchen_Form();
                        kitchen_Form.Show();
                    }
                    else if (currentEmployee.Role == 2)
                    {
                        //Display BarmanUI
                        Bar_Form bar_Form = new Bar_Form();
                        bar_Form.Show();
                    }
                    else if (currentEmployee.Role == 3)
                    {
                        //Display WaiterUI
                        Table_Form table_Form = new Table_Form();
                        table_Form.Show();
                    }
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
}
