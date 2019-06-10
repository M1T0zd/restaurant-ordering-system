using System;
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
    public partial class Account_Form : Form
    {
        Login login;
        Login_Form loginform;
        public Account_Form(Login login,Login_Form login_Form)
        {
            InitializeComponent();
            this.loginform = login_Form;
            this.login = login;
            lblname.Text = $"Your Email: {login.Username}";
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            loginform.Show();
            this.Hide();

        }
    }
}
