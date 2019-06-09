using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_DAL
{
    public class Payment_DAO : Base
    {
        // save payment to database
        public void InsertDetails(Payment payment)
        {
            string query = $"INSERT INTO  Payment VALUES ({payment.OrderNumber}, {payment.PaymentMethod}, '{payment.Comments}', {payment.Tip}, {payment.Total})";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        // get order items from database.
        public List<Order> Db_Get_Order()
        {
            Order_DAO order_ = new Order_DAO();
            List<Order>order =  order_.GetOrders();
            return order;
        }
    }
}