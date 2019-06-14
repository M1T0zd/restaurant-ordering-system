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
        Kitchen_Form kitchen_Form;
        public Login_Form()
        {
            InitializeComponent();         
        }
        public void DisplayFood()
        {
            try
            {
                foreach (DataGridViewRow row in kitchen_Form.dgviewOrders.Rows)
                {
                    if (row.Index >= 0)
                    {
                        string State = Convert.ToString(row.Cells[4].Value);
                        if (State.ToLower().Trim() == "waiting")
                            row.DefaultCellStyle.BackColor = Color.Red;
                        else if (State.ToLower().Trim() == "processing")
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        else if (State.ToLower().Trim() == "ready")
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else if (State.ToLower().Trim() == "served")
                            row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(" something went wrong :" + k.Message);
            }

        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //GetAllLoginInfo
            Login_Service Login_Service = new Login_Service();
            List<Login> loginList = Login_Service.GetLogin();
            //Make new Current Login to save current login info
            Login CurrentLogin = new Login();
            foreach (Login login in loginList)
            {
                if (login.Username == txtusername.Text && login.Password == txtpassword.Text)
                {
                    CurrentLogin.EmployeeNumber = login.EmployeeNumber;
                    check++;         
                }           
            }
            //ClearingTextBoxt for logging out
            ClearTextBox();      
            //Getting current employee
            Employee currentemployee = GetCurrentEmployee(CurrentLogin);
            //Show which form belongs to which employee
            ShowForm(currentemployee);
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
                   kitchen_Form = new Kitchen_Form("Chef");
                    kitchen_Form.Show();
                }
                else if (currentemployee.Role == EmployeeRole.Barman)
                {
                    //Display BarmanUI
                   
                    //Kitchen_Form kitchen_Form = new Kitchen_Form(currentemployee);
                    //kitchen_Form.Show();
                }
                else if (currentemployee.Role == EmployeeRole.Waiter)
                {
                    //Display WaiterUI
                    Table_Form table_Form = new Table_Form(currentemployee, this);
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

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
