using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Session
    {
        public int Id = 1;
        public Employee Host { get; set; }
        public Table Table { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
		public List<Order> Orders { get; set; }

		public Session()
		{
			Orders = new List<Order>();
		}
	}
}
