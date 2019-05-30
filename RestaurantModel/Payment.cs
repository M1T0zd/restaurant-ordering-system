using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Payment
    {


        public float tip { get; set; }
        public DateTime paymentDate { get; set; }
        public float tax { get; set; }
        public float Total { get; set; }
        public int orderNumber { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public int employeeId { get; set; }


    }
}
