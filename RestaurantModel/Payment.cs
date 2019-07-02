using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantModel
{
    public class Payment
    {
        public Decimal Total { get; set; }
        public DateTime Date { get; set; }
        public Decimal Tip { get; set; }
        public Decimal Tax { get; set; }

        public PaymentMethod PaymentMethod;

        public void CalculateVAT_TotalPrice(ListView listView)
        {
            decimal taxPerItem;
            decimal totalTax = 0;
            decimal totalPrice = 0;
            foreach (ListViewItem listViewItem in listView.Items)
            {
                OrderItem orderItem = (OrderItem)listViewItem.Tag;
                if (orderItem.Category == Category.Alcoholic)
                {
                    taxPerItem = (orderItem.Price * Convert.ToDecimal(0.21));
                }
                else
                {
                    taxPerItem = ((orderItem.Price) * Convert.ToDecimal(0.06));
                }
                totalTax += taxPerItem;
                totalPrice += (orderItem.Price + taxPerItem);
            }
            Total = totalPrice;
            Tax = totalTax;

        }
    }
}


                



