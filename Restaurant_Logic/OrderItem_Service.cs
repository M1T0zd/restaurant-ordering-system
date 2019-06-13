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
        OrderItem_DAO order_DAO = new OrderItem_DAO();// not my code 

        OrderItem_DAO orderItem_DAO = new OrderItem_DAO();
        List<KitchenOrderItems> orderItems = new List<KitchenOrderItems>();
        public List<KitchenOrderItems> GetFoodOrders(int OrderID)
        {
            return orderItems = orderItem_DAO.GetFoodItems(OrderID);
        }
        public List<KitchenOrderItems> GetDrinksOrders(int OrderID)
        {
            return orderItems = orderItem_DAO.GetDrinkItems(OrderID);
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders = orderItem_DAO.GetOrders_();
        }
        public void UpdateOrderItemState(int orderItem, OrderState newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }
        public void MarkAsRaady(int orderItem, OrderState newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }

        public List<OrderItem> GetOrder()
        {
           
                List<OrderItem> orders = order_DAO.GetOrders();
                return orders;
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
