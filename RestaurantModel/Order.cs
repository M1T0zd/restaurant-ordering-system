using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    enum OrderStatu { Reday=0,notReady=1,Served=2
    }
    class Order
    {

        public int IdOrderItem { get; set; }
        public MenuItem MEnuItems { get; set; }
        public OrderStatu orderState { get; set; }

    }
}
