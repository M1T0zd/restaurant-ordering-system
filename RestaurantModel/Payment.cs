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
        public DateTime PaymentDate { get; set; }
        public float Tax { get; set; }
        public float Total { get; set; }
        public int OrderNumber { get; set; }
        public PaymentMethod paymentMethod;
        public int EmployeeId { get; set; }

		public PaymentMethod PaymentMethod1
		{
            get { return paymentMethod; }
			set
			{
                paymentMethod = value;
			}
		}
	}
}
