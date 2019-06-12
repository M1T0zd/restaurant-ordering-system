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


    }
}
