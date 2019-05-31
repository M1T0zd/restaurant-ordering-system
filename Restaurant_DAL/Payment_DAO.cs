using RestaurantModel;
using System;
using System.Collections.Generic;
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
            string query = $"INSERT INTO  [User] VALUES ({payment.OrderNumber}, {payment.PaymentDate}, {payment.Tax}, {payment.Tip}, {payment.Total})";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}