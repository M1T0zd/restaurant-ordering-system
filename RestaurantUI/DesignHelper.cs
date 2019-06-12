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
        public void fillInComboxob(DataGridView dataGridView)
        {

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.Name = "change the current state";
            col.Tag = "state";
            col.DataSource = Enum.GetValues(typeof(OrderStatus));
            col.ValueType = typeof(OrderStatus);
            dataGridView.Columns.Add(col);

            //*** to look at later 
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Name = "btnReady";
            //btn.Tag = "mark as ready ";
            //dataGridView.Columns.Add(btn);
        }
        public int GetslectedIndexOfListview(ListView listView)
        {
            int index = 0;
            if (listView.SelectedItems.Count > 0)
                index = Convert.ToInt16(listView.SelectedItems[0].Tag.ToString());
            return index;
        }
        public int GetGgridIndex( DataGridView dgv , string cell)
        {
            var OrderItemIndex = dgv.CurrentRow.Cells[cell].FormattedValue;// get the id of the orderItem
            int ItemId = Convert.ToInt32(OrderItemIndex);
            return ItemId;
        }
        public OrderState getDGcellState(DataGridView dgv, int cellIndex)
        {
            var StateValue = dgv.CurrentRow.Cells[cellIndex].FormattedValue;// first get the value of the cell
            OrderState state = (OrderState)Enum.Parse(typeof(OrderState), Convert.ToString(StateValue));// then parse to the enum value 
            return state;
        }
        public void ListViewDesign(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Taken at", 200, HorizontalAlignment.Center);
            listView.Columns.Add("Tabel number ", 100, HorizontalAlignment.Center);
            listView.FullRowSelect = true;
        }
        public void AutoRefrech(ListView listView , List<Order> orders )
        {
            //************ new orders will be displyed automatically here 
            listView.Items.Clear();
            foreach (Order o in orders)
            {
                ListViewItem li = new ListViewItem(o.Id.ToString());
                li.Tag = o.Id;
                li.SubItems.Add(o.TakenAt.ToShortDateString());
                li.SubItems.Add(o.Table.ToString());
                listView.Items.Add(li);
            }
        }

    }
}
