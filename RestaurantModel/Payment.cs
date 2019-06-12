using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Payment
    {


        public Decimal Tip { get; set; }

        public Decimal Tax { get; set; }
        public Decimal Total { get; set; }
       
        public PaymentMethod PaymentMethod;
        

	}
}
