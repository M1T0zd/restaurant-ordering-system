using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public enum OrderState { Waiting=1, Processing=2, Ready=3, Served=4 }
    public class KitchenOrderItems 
    {
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public OrderState state { get; set; }
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }


    }
}
