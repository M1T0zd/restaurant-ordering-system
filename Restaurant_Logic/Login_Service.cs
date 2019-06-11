using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Restaurant_Logic
{
    public class Login_Service
    {
        private Login_DAO login_db = new Login_DAO();

        public List<Login> GetLogin()
        {
            try
            {
                List<Login> logins = login_db.Db_Get_All_Login();
                return logins;
            }
            catch (Exception e)
            {
                ErrorLogging(e);
                return null;
            }
        }
        private static void ErrorLogging(Exception e)
        {
			Debug.WriteLine("=============Error Logging ===========");
			Debug.WriteLine("===========Start============= " + DateTime.Now);
			Debug.WriteLine("Error Message: " + e.Message);
			Debug.WriteLine("Stack Trace: " + e.StackTrace);
			Debug.WriteLine("===========End============= " + DateTime.Now + "\n");
        }
    }
}
