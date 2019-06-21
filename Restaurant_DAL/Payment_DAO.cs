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

        public Payment processPayment(int TabelID)
        {
            OpenConnection();
            string query = @"select m.Name,i.Quantity, m.Price ,i.Quantity*Price as Total ,d.IsAlcoholic 
                                    from Sessions se 
                                    join Orders o on o.SessionId=se.Id
                                    join  OrderItems i on i.OrderId=o.Id
                                    join MenuItems m on m.Id=i.Id
                                    join Drinks d on m.Id=d.Id where se.TableId =@Id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Id", TabelID);
            SqlDataReader reader = cmd.ExecuteReader();
            Payment payment = null;
            if (reader.Read())
            {
                payment = ReadPayment(reader);
            }
            reader.Close();
            CloseConnection();
            return payment;
        }
        private Payment ReadPayment(SqlDataReader reader)
        {
            Payment p = new Payment();
            p.ItemName = (string)reader["Name"];
            p.quantity = (int)reader["Quantity"];
            p.price =(decimal)reader["Price"];
            p.Total = (int)reader["Total"];
            p.IsAlchoholic= (bool)reader["IsAlcoholic"];
            return p;
        }
    }
}