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

        Payment_DAO GetOrder = new Payment_DAO();

        public List<Order> Get_Order()
        {
            List<Order> orders = GetOrder.Db_Get_Order();
            return orders;
        }

       
    }
}
