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

        private TableStatus status = TableStatus.Available;
        
        public TableStatus Status
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
     
        public List<Order> orders = new List<Order>();
    }
}