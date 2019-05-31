using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Order
    {
		public int Id { get; set; }
		public int Table { get; set; }
		public string Status { get; set; }
		public DateTime TakenAt { get; set; }

		public OrderItem OrderItem
		{
			get => default;
			set
			{
			}
		}

		//TODO: Status, Comment and Quantity should go to OrderItem, not Order.
	}
}
