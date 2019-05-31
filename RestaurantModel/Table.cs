using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Table
    {
        public int Number { get; set; }
        public string Status { get; set; }
		bool IsOccupied { get; set; }
    }
}
