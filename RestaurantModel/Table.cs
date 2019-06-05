using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RestaurantModel
{
    public class Table
    {
        public int Number { get; set; }
        private string status = "Available";
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public Table(int number)
        {
            Number = number;
        }
        public List<Order> orders = new List<Order>();
    }
}