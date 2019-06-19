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
        OrderItem_DAO orderItem_DAO = new OrderItem_DAO();
        List<OrderItem> orderItems = new List<OrderItem>();
        public List<OrderItem> GetFoodOrders()
        {
            return orderItems = orderItem_DAO.GetFoodItems();
        }
        public List<OrderItem> GetDrinksOrders()
        {
            return orderItems = orderItem_DAO.GetDrinkItems();
        }
		public void PushOrder(OrderItem orderItem)
		{
			try
			{
				orderItem_DAO.PushOrderItem(orderItem);
			}
			catch (Exception e)
			{
				ErrorLogging(e);
			}
		}

		public void PushOrderItems(List<OrderItem> orderItems)
		{
			try
			{
				foreach (OrderItem orderItem in orderItems)
				{
					orderItem_DAO.PushOrderItem(orderItem);
				}
			}
			catch (Exception e)
			{
				ErrorLogging(e);
			}
		}

		public void UpdateOrderItemState(int orderItem, OrderStatus newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }
        public void MarkAsReady(int orderItem, OrderStatus newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }

        public List<OrderItem> GetOrderWaiter()
        {
           
                List<OrderItem> orders = orderItem_DAO.GetOrdersWaiter();
                return orders;
        }
        public void UpdateStatus(OrderItem orderItem)
        {
            orderItem_DAO.UpdateStatus(orderItem);
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
