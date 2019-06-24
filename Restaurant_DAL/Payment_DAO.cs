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

        public void SavePaidOrder(Payment payment, Session session)
        {
            string query = $"INSERT INTO  Payments(SessionId,PayMethod,Tip,Total_ExclTip,Date) VALUES ({session.Id}, {payment.PaymentMethod},{payment.Tip},{payment.Total},'{payment.Date}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

          
        }
        public List<OrderItem> GetOrderItemPayment()
        {
            string query = "SELECT M.Name,M.Price,M.CategoryId,OI.Quantity FROM OrderItems AS OI" +
                " JOIN Orders AS O ON OI.OrderId = O.Id JOIN MenuItems AS M ON OI.MenuItemId = M.Id WHERE O.Id = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesPayment(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadTablesPayment(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    ItemName = (String)dr["Name"],
                    Price = (decimal)dr["Price"],
                    Amount = (int)dr["Quantity"],
                    Category = (Category)dr["CategoryId"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public void UpdateTable(Table table)
        {
            string query = ($"UPDATE Tables SET StatusId = {(int)table.Status} where Number = {table.Number}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}