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
    public class Table_Service
    {
        Table_DAO table_DAO;
   
        public Table_Service()
        {
            table_DAO = new Table_DAO();
        }

        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = table_DAO.GetTables();
                return tables;
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
