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
        public List<KitchenOrderItems> GetFoodItems(int orderId)
        {
            //************ get the Order itmes of an order
            string query = @"select m.Name,i.Quantity,i.Comment,s.State,o.Id as OrderID,i.Id from Orders o 
                                join OrderItems i on o.Id = i.OrderId
                                join OrderState s on s.Id = i.StateId
                                join MenuItems m on m.Id = i.MenuItemId
                                join Dishes d on m.Id = d.Id
                                join Sessions se on se.Id = o.SessionId
                                       where o.Id= @OrderId ";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderId", SqlDbType.Int) { Value = orderId };
            return ReadTables_OrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetOrders()
        {
            string query = @"select o.Id,o.TakenAt,s.TableId from Sessions s
                            join Orders o on s.Id=o.SessionId
                            where o.TakenAt is not null order by TakenAt asc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_GetOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables_GetOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Id = (int)dr["Id"],
                    TakenAt = (DateTime)dr["TakenAt"],
                    Table = (int)dr["TableId"],
                };
                orders.Add(order);
            }
            return orders;
        }
        public List<KitchenOrderItems> GetDrinkItems(int orderId)
        {
            //************ get the Order itmes of an order
            string query = @"select m.Name,i.Quantity,i.Comment,s.State,o.Id as OrderID,i.Id from Orders o 
								join OrderItems i on o.Id=i.OrderId
								join OrderState s on s.Id=i.StateId
								join MenuItems m on m.Id=i.MenuItemId
								join Drinks d on m.Id=d.Id
								join Sessions se on se.Id=o.SessionId
								where o.Id=@OrderId";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderId", SqlDbType.Int) { Value = orderId };
            return ReadTables_OrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<KitchenOrderItems> ReadTables_OrderItems(DataTable dataTable)
        {
            List<KitchenOrderItems> OrderItems = new List<KitchenOrderItems>();
            foreach (DataRow dr in dataTable.Rows)
            {
                KitchenOrderItems OrderItem = new KitchenOrderItems()
                {

                    ItemName = (string)dr["Name"],
                    Amount = (int)dr["Quantity"],
                    Comment = (string)dr["Comment"],
                    state = (OrderState)Enum.Parse(typeof(OrderState), Convert.ToString(dr["State"])),
                     OrderId = (int)dr["OrderID"],
                    OrderItemId = (int)dr["Id"],
                };
                OrderItems.Add(OrderItem);
            }
            return OrderItems;
        }
        //*******************updates only state of one item not the whole oorder
        public void UpdateOrdersItemsState(int OrderItemItemId, OrderState newState) //MarkAsProccessing
        {
            string query = @"update OrderItems set  StateId=@StateId where Id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@StateId", SqlDbType.Int) { Value = (int)newState };
            sqlParameters[1] = new SqlParameter("@Id", SqlDbType.Int) { Value = OrderItemItemId };
            ExecuteEditQuery(query, sqlParameters);
        }
        //**************************** is ready 
    }
}
