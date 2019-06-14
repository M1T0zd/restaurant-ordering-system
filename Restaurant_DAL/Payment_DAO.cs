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
        
        public void InsertOrder(Payment payment)
        {
            string query = $"INSERT INTO  Payments VALUES ({payment.Tip}, {payment.Tax},{payment.PaymentMethod})";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}