using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Payment
    {
        public string ItemName { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public Decimal Total { get; set; }
        public bool IsAlchoholic { get; set; }
        public string Date { get; set; }
        public int IDpayment { get; set; }
        public Decimal Tip { get; set; }
        public Decimal Tax { get; set; }
        public int PaymentMethod;
        
        
	}
}
