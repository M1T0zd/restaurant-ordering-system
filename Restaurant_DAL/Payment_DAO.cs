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
        public void InsertDetails( int method, Decimal total, Decimal tax)
        {
            string query = $"INSERT INTO  Payments VALUES ( {method}, {total},{tax})";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}