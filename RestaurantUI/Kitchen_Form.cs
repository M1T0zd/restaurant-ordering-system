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
        Order_Service Order_Service = new Order_Service();
        OrderItem_Service OrderItem_Service = new OrderItem_Service();
        DesignHelper designHelper = new DesignHelper();
        List<OrderItem> Orders = new List<OrderItem>();// refreching use
        public static string Role="Chef";
        public Kitchen_Form( string role/*Employee employee*/)
        {
            InitializeComponent();
            Role = role;
            if (Role.ToString() == "Chef")
            {
                panelBar.Visible = false;
                Orders = OrderItem_Service.GetFoodOrders();
                designHelper.ListViewDesign(listViewOrders);
                FillFoodList(listViewOrders);
            }
            else if (Role.ToString() == "Barman")
            {
                Orders = OrderItem_Service.GetFoodOrders();
                FillFoodList(listViewOrders);
            }
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            timerRefrech.Interval =20000; //refresh every 20 seconds 
            timerRefrech.Enabled = true;
        }
        public void DisplayFood()
        {
            try
            {
                foreach (DataGridViewRow row in dgviewDrinks.Rows)
                {
                    if (row.Index >= 0)
                    {
                        string State = Convert.ToString(row.Cells[4].Value);// every time verify the value of the cell state
                        if (State.ToLower().Trim() == "waiting")
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;

                        }
                        else if (State.ToLower().Trim() == "processing")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if (State.ToLower().Trim() == "ready")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else if (State.ToLower().Trim() == "served")
                        {
                            row.DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }

                }
            }
            catch (Exception k)
            {
                MessageBox.Show(" something went wrong :" + k.Message);
            }

        }
        private void FillFoodList(ListView listView)
        {
            designHelper.ListViewDesign(listViewOrders);
            foreach (OrderItem o in Orders)
            {
                ListViewItem li = new ListViewItem(o.Id.ToString());
                li.Tag = o;
                li.SubItems.Add(o.ItemName);
                li.SubItems.Add(o.Amount.ToString());
                li.SubItems.Add(o.Comment.ToString());
                li.SubItems.Add(o.Comment.ToString());
                li.SubItems.Add(o.Status.ToString());
                li.SubItems.Add(o.OrderTime.TakenAt.ToString());
                li.SubItems.Add(o.OrderId.ToString());
                li.SubItems.Add(o.TableNumber.ToString());
                li.SubItems.Add(o.Id.ToString());
                listView.Items.Add(li);
            }
        }
        private void refrech(string FoodOrDrinks)
        {
            if (FoodOrDrinks=="food")
            {
                dgviewDrinks.DataSource = OrderItem_Service.GetFoodOrders();
                DisplayFood();
            }
            else if (FoodOrDrinks=="drink")
            {
                dgviewDrinks.DataSource = OrderItem_Service.GetDrinksOrders();
                DisplayFood();
            }
        }
        private void btn_PrepareFood_Click(object sender, EventArgs e)
        {
            try
            {
                //if (OrderStatus.Ready== designHelper.getDGcellState(dgviewFood, 0))//*** only confirmation for ready
                //{
                //    if (MessageBox.Show(" are you sure you want to mark this order as : Ready " , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                //    {
                //        OrderItem_Service.UpdateOrderItemState(designHelper.GetGgridIndex(dgviewFood, "OrderItemId"), designHelper.getDGcellState(dgviewFood,0));
                //        refrech("food");
                //    }
                //}
                //else
                //{
                //    OrderItem_Service.UpdateOrderItemState(designHelper.GetGgridIndex(dgviewFood, "OrderItemId"), designHelper.getDGcellState(dgviewFood, 0));
                //    refrech("food");
                //}
               
            }
            catch (Exception k)
            {

                MessageBox.Show("something went wrong while updating " + k.Message);
            }
        }

        private void timerRefrech_Tick(object sender, EventArgs e)
        {
            Orders = OrderItem_Service.GetFoodOrders();
           // designHelper.AutoRefrech(listViewFood,Orders);
            //designHelper.AutoRefrech(listViewDrink,Orders);
           // AutoRefrech(listViewDrink);
        }
        private void dgviewDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OrderItemIndex = dgviewDrinks.CurrentRow.Cells["OrderItemId"].FormattedValue;// get the id of the orderItem
            int ItemId = Convert.ToInt32(OrderItemIndex);
            if (dgviewDrinks.Columns[e.ColumnIndex].Name == "btnMarkready")
            {
                OrderItem_Service.MarkAsRaady(ItemId, OrderStatus.Ready);
                refrech("drink");
            }
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
