using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant_Logic
{
    public class Login_Service
    {
        Login_DAO login_db = new Login_DAO();

        public Login_DAO Login_DAO
        {
            get { return login_db; }
            set
            {
                login_db = value;
            }
        }

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
            string strPath = @"D:\Prins\Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + e.Message);
                sw.WriteLine("Stack Trace: " + e.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);
                sw.WriteLine();


            }
        }
    }
}
