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

        public Payment_DAO Registration_db
        {
            get { return registration_db; }
            set
            {
                registration_db = value;
            }
        }

        public void InsertDetails(Payment payment)
        {
            Registration_db.InsertDetails(payment);
        }

    }
}
