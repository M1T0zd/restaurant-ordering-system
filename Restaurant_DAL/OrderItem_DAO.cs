using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using RestaurantModel;

namespace Restaurant_DAL
{
    public class OrderItem_DAO : Base
    {
        public List<OrderItem> GetOrders()
        {
            string query = "SELECT OI.Id, m.Name,OI.StateId,s.TableId " +
                "FROM MenuItems AS M JOIN OrderItems as OI on OI.MenuItemId = m.Id " +
                "JOIN Orders AS O on OI.OrderId = o.Id " +
                "JOIN Sessions AS S ON O.SessionId = S.Id " +
                "WHERE OI.StateId = 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem order = new OrderItem()
                {
                    TableNumber = (int)dr["tableid"],
                    Status = (OrderStatus)dr["StateId"],
                    ItemName = (String)dr["Name"],
                    Id = (int)dr["Id"]
                };
                orderItems.Add(order);
            }
            return orderItems;
        }
        public void UpdateStatus(OrderItem orderItem)
        {
            string query = ($"UPDATE Tables SET StatusId = {(int)orderItem.Status} where Number = {orderItem.Id}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
