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
            string query = "SELECT m.Name,OS.State FROM MenuItems AS M JOIN " +
                "OrderItems as O on o.MenuItemId = m.Id JOIN ORDERSTATE as OS on o.StateId = OS.id";
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
                    Status = (OrderStatus)dr["State"],
                    ItemName = (String)dr["Name"],
                };
                orderItems.Add(order);
            }
            return orderItems;
        }
    }
}
