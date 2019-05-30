using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Logic
{
   public class Payment_Service
    {

        Payment_DAO registration_db = new Payment_DAO();

        public void InsertDetails(Payment payment)
        {
            registration_db.InsertDetails(payment);
        }

    }
}
