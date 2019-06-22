using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Logic
{
    public class Payment_Service
    {
        Payment_DAO payementDao = new Payment_DAO();

        public void SavePaidOrder(Payment payment, Session session, int tableNumber)
        {
            payementDao.SavePaidOrder(payment, session, tableNumber);
           
        }
      
        public List<OrderItem> GetOrderItemPayment()
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            return orderItems = payementDao.GetOrderItemPayment();
        }
    }
}
