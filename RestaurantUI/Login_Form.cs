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
        List<Login> loginList = new List<Login>();
        Login CurrentLogin;
        Kitchen_Form kitchen_Form;
        Bar_Form bar_Form;
        Table_Form table_Form;
        Login_Service Login_Service { get; set; }

        public Login_Form()
        {
            InitializeComponent();
            kitchen_Form = new Kitchen_Form();
            bar_Form = new Bar_Form();
            table_Form = new Table_Form();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
         
            int check = 0;
            //GetAllLoginInfo
            Login_Service = new Login_Service();
            loginList = Login_Service.GetLogin();
            //Make new Current Login to save current login info
            CurrentLogin = new Login();
            foreach (Login login in loginList)
            {
                if (login.Username == txtusername.Text && login.Password == txtpassword.Text)
                {
                    CurrentLogin.RoleName = login.RoleName;
                    check++;

                }   
            }
            if (check == 1)
            {
                //Hide login form

                if (CurrentLogin.RoleName == "Chef")
                {
                    //Display Chef UI
                    kitchen_Form.Show();
                }
                else if (CurrentLogin.RoleName == "Barman")
                {
                    //Display BarmanUI
                    bar_Form.Show();
                }
                else if (CurrentLogin.RoleName == "Waiter")
                {
                    //Display WaiterUI
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
            this.Hide();


        }
    }
}
