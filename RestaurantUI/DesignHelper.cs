using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_UI
{
    public class DesignHelper
    {
        public int GetGgridIndex( DataGridView dgv , string cell)
        {
            var OrderItemIndex = dgv.CurrentRow.Cells[cell].FormattedValue;// get the id of the orderItem
            int ItemId = Convert.ToInt32(OrderItemIndex);
            return ItemId;
        }
        public OrderStatus getDGcellState(DataGridView dgv, int cellIndex)
        {
            var StateValue = dgv.CurrentRow.Cells[cellIndex].FormattedValue;// first get the value of the cell
            OrderStatus state = (OrderStatus)Enum.Parse(typeof(OrderStatus), Convert.ToString(StateValue));// then parse to the enum value 
            return state;
        }
        public void ListViewDesign(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.Columns.Add("Name", 20, HorizontalAlignment.Center);
            listView.Columns.Add("Quanity", 20, HorizontalAlignment.Center);
            listView.Columns.Add("Comment", 20, HorizontalAlignment.Center);
            listView.Columns.Add("State", 20, HorizontalAlignment.Center);
            listView.Columns.Add("Taken at", 20, HorizontalAlignment.Center);
            listView.Columns.Add("Ordr ID", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Item ID", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Tabel Number", 100, HorizontalAlignment.Center);
            listView.FullRowSelect = true;

         
        }
        public void AutoRefrech(ListView listView , List<Order> orders )
        {
            //************ new orders will be displyed automatically here 
            listView.Items.Clear();
            foreach (Order o in orders)
            {
                ListViewItem li = new ListViewItem(o.Id.ToString());
                li.Tag = o;
                li.SubItems.Add(o.TakenAt.ToShortDateString());
                li.SubItems.Add(o.Table.ToString());
                listView.Items.Add(li);
            }
        }

    }
}
