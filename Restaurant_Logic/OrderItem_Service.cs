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
    public class OrderItem_Service
    {
        OrderItem_DAO order_DAO = new OrderItem_DAO();

        public List<OrderItem> GetOrder()
        {
            try
            {
                List<OrderItem> orders = order_DAO.GetOrders();
                return orders;
            }
            catch (Exception e)
            {
                ErrorLogging(e);

                return null;
            }
        }
        public void UpdateStatus(OrderItem orderItem)
        {
            order_DAO.UpdateStatus(orderItem);
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
