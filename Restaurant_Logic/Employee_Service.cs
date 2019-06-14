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
    public class Employee_Service
    {
        Employee_DAO employee_db = new Employee_DAO();

        public Employee_DAO Employee_db
        {
            get { return employee_db; }
            set
            {
                employee_db = value;
            }
        }

        public List<Employee> GetEmployee()
        {
            try
            {
                List<Employee> employees = employee_db.GetEmployees();
                return employees;
            }
            catch (Exception e)
            {
               // ErrorLogging(e);

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
