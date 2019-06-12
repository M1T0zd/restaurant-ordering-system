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
    public class Order_DAO : Base
    {
		public List<Order> GetOrders()
		{
			string query = "SELECT Id, TakenAt, Status FROM [Orders]";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		//TODO: Status, Comment and Quantity should go to OrderItem, not Order.

		private List<Order> ReadTables(DataTable dataTable)
		{
			List<Order> orders = new List<Order>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Order order = new Order()
				{
					Id = (int)dr["Id"],
					TakenAt = (DateTime)dr["TakenAt"],
				};
				orders.Add(order);
			}
			return orders;
		}
	}
}
