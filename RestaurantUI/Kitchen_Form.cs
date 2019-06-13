using RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Logic;

namespace Restaurant_UI
{
    public partial class Kitchen_Form : Form
    {
        OrderItem_Service OrderItem_Service = new OrderItem_Service();
        DesignHelper designHelper = new DesignHelper();
        List<OrderItem> Orders = new List<OrderItem>();// refreching use
        public static string Role = "Barman";
        public Kitchen_Form(string role/*Employee employee*/)
        {
            InitializeComponent();
            Role = role;
            if (Role.ToString() == "Chef")
            {
                Orders = OrderItem_Service.GetFoodOrders();
                // FillOrdersItemList();
                dgviewOrders.DataSource = OrderItem_Service.GetFoodOrders();
                DisplayFood();
            }
            else if (Role.ToString() == "Barman")
            {
                Orders = OrderItem_Service.GetDrinksOrders();
                dgviewOrders.DataSource = OrderItem_Service.GetDrinksOrders();
                DisplayFood();
            }
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            timerRefrech.Interval = 100; //refresh every 20 seconds 
            timerRefrech.Enabled = true;
        }
        public void DisplayFood()
        {
            try
            {
                foreach (DataGridViewRow row in dgviewOrders.Rows)
                {
                    if (row.Index >= 0)
                    {
                        string State = Convert.ToString(row.Cells[5].Value);
                        if (State.ToLower().Trim() == "waiting")

                            dgviewOrders.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;

                        else if (State.ToLower().Trim() == "processing")
                            dgviewOrders.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
                        else if (State.ToLower().Trim() == "ready")
                            dgviewOrders.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                        else if (State.ToLower().Trim() == "served")
                            dgviewOrders.Rows[row.Index].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(" something went wrong :" + k.Message);
            }

        }
       
        private void refrech(string FoodOrDrinks)
        {
            if (FoodOrDrinks == "drink")
            {
                dgviewOrders.DataSource = OrderItem_Service.GetDrinksOrders();
                DisplayFood();
            }
        }
        private void timerRefrech_Tick(object sender, EventArgs e)
        {
            Orders = OrderItem_Service.GetFoodOrders();
            //dgviewOrders.DataSource = OrderItem_Service.GetFoodOrders();
            //DisplayFood();
        }
        private void dgviewDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (OrderStatus.Ready== designHelper.getDGcellState(dgviewFood, 0))//*** only confirmation for ready
            //{
            //    if (MessageBox.Show(" are you sure you want to mark this order as : Ready " , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        OrderItem_Service.UpdateOrderItemState(designHelper.GetGgridIndex(dgviewFood, "OrderItemId"), designHelper.getDGcellState(dgviewFood,0));
            //        refrech("food");
            //    }
            //}
            var OrderItemIndex = dgviewOrders.CurrentRow.Cells["Id"].FormattedValue;// get the id of the orderItem
            int ItemId = Convert.ToInt32(OrderItemIndex);
            if (dgviewOrders.Columns[e.ColumnIndex].Name == "btnMarkready")
            {
                OrderItem_Service.MarkAsReady(ItemId, OrderStatus.Ready);
                refrech("drink");
                DisplayFood();
            }

        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgviewOrders_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_PrepareMany_Click(object sender, EventArgs e)
        {
            List<int> Items = new List<int>();
            foreach (DataGridViewRow row in dgviewOrders.SelectedRows)
            {
                int ItemId  = int.Parse( dgviewOrders.Rows[row.Index].Cells["Id"].Value.ToString());
                // Items.Add(ItemId);
                OrderItem_Service.MarkAsReady(ItemId, OrderStatus.Ready);
            }
            //foreach (int i in Items)
            //{
            //    MessageBox.Show(i.ToString());
            //}
        }
    }
}
