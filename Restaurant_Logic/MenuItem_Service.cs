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
    public class MenuItem_Service
    {
        MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

		public MenuItem_DAO MenuItem_DAO
		{
			get => default;
			set
			{
			}
		}

		public List<MenuItem> GetMenuItem()
        {
            try
            {
                List<MenuItem> menuitems = MenuItem_DAO.GetMenuItems();
                return menuitems;
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
