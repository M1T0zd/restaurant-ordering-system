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
    public class Order_Service
    {
        Order_DAO order_DAO = new Order_DAO();

		public Order_DAO Order_DAO
		{
			get => default;
			set
			{
			}
		}

		public List<Order> GetOrder()
        {
            try
            {
                List<Order> orders = order_DAO.GetOrders();
                return orders;
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
