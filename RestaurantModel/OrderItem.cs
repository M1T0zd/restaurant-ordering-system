using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
	public class OrderItem
	{

		public int Id { get; set; }
		public int Amount { get; set; }
		public string Comment { get; set; }
		public string ItemName { get; set; }
		public int MenuItemId { get; set; }
		public DateTime DateReady { get; set; }
		public OrderStatus Status { get; set; }
		public Category Category { get; set; }
		public MenuItem MenuItem { get; set; }
        public int TableNumber { get; set; }


		public OrderItem()
		{

		}

		public OrderItem(OrderStatus status)
		{
			Status = status;
		}
	}
}
