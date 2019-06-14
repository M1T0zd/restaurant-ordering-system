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

        Payment_DAO payementDao = new Payment_DAO();

        public void insertOrder(int method, Decimal total, Decimal tax)
        {
            payementDao.InsertDetails(method, total, tax);
        }
        public Payment ProcessPayment(int TabelID)
        {
           return  payementDao.processPayment(TabelID);
        }
    }
}
