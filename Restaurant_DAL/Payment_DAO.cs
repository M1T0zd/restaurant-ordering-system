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
        public List<Payment> processPayment(int TabelID)
        {
            string query = @"select m.Name,i.Quantity, m.Price ,i.Quantity*Price as Total ,d.IsAlcoholic 
                                    from Sessions se 
                                    join Orders o on o.SessionId=se.Id
                                    join  OrderItems i on i.OrderId=o.Id
                                    join MenuItems m on m.Id=i.Id
                                    join Drinks d on m.Id=d.Id where se.TableId =@Id";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_OrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
     private pay-adTables_OrderItems(DataTable dataTable)
        {
            List<Payment> pay= new List<Payment>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payn= new Payment()
                {
                    ItemName = (string)dr["Name"],
                    quantity= (int)dr["Quantity"],
                    price = (string)dr["Price"],
                    Total = (int)dr["Total"],
                };
                OrderItems.Add(OrderItem);
            }
            return pay;
        }
    }
}