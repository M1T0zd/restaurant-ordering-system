using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Payment
    {


        public float Tip { get; set; }
        public string Comments { get; set; }
        public float Tax { get; set; }
        public float Total { get; set; }
        public int OrderNumber { get; set; }

        public PaymentMethod PaymentMethod;
        public int EmployeeId { get; set; }

	}
}
