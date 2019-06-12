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
		public DateTime TakenAt { get; set; }

		public List<OrderItem> OrderItems { get; set; }

		public Order()
		{

		}

		public Order(DateTime takenAt)
		{
			TakenAt = takenAt;
		}

	}
}
