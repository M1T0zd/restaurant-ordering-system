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
   
        public Login_Form()
        {
            InitializeComponent();
        }

        public Login_Service Login_Service { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //GetAllLoginInfo
            Restaurant_Logic.Login_Service login_Service = new Login_Service();
            loginList = login_Service.GetLogin();
            //
            CurrentLogin = new Login();
            foreach (Login login in loginList)
            {
                if (login.Username == txtusername.Text && login.Password == txtpassword.Text)
                {
                    CurrentLogin.RoleName = login.RoleName;
          
                    //Hide login form
                    this.Hide();

                    if (CurrentLogin.RoleName == "Chef")
                    {
                        //Display Chef UI
                        Kitchen_Form kitchen_Form = new Kitchen_Form();
                        kitchen_Form.Show();
                    }
                    else if (CurrentLogin.RoleName == "Barman")
                    {
                        //Display BarmanUI
                        Bar_Form bar_Form = new Bar_Form();
                        bar_Form.Show();
                    }
                    else if (CurrentLogin.RoleName == "Waiter")
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
