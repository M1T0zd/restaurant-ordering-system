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

        Payment_DAO insertDetails = new Payment_DAO();

      public void insertOrder(int method, Decimal total, Decimal taxt)
        {
            insertDetails.InsertDetails(method, total, taxt);
        }
       
    }
}
