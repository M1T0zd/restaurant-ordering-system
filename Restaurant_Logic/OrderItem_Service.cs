using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Debug.WriteLine("=============Error Logging ===========");
            Debug.WriteLine("===========Start============= " + DateTime.Now);
            Debug.WriteLine("Error Message: " + e.Message);
            Debug.WriteLine("Stack Trace: " + e.StackTrace);
            Debug.WriteLine("===========End============= " + DateTime.Now + "\n");
        }
    }
}
