using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
	public class OrderItem
	{
        public int Amount { get; set; }
        public string Comment { get; set; }
        public string ItemName { get; set; }
        public int MenuItemId { get; set; }
        public int OrderItemId { get; set; }
        public DateTime Taken { get; set; }
        public DateTime DateReady { get; set; }
        public OrderStatus Status { get; set; }
		public Category Category { get; set; }

		public OrderStatus OrderStatus
		{
			get => default;
			set
			{
			}
		}

		public Category Category1
		{
			get => default;
			set
			{
			}
		}

		public MenuItem MenuItem
		{
			get => default;
			set
			{
			}
		}
	}
}
