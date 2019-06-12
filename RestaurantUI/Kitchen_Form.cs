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
        OrderItems_Service OrderItem_Service = new OrderItems_Service();
        DesignHelper designHelper = new DesignHelper();
        List<Order> Orders = new List<Order>();// refreching use
        Payment_Service Payment_Service = new Payment_Service();
        public static string RoleState;//Barman  Chef
        public Kitchen_Form(Employee employee)
        {
            Orders = OrderItem_Service.GetOrders();
            InitializeComponent();
           // RoleState = role;
        }

        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            designHelper.ListViewDesign(listViewFood);
            FillFoodList(listViewFood);
        }

        public void DisplayFood()
        {
            try
            {
                foreach (DataGridViewRow row in dgviewFood.Rows)
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
            designHelper.fillInComboxob(dgviewFood);
            designHelper.ListViewDesign(listViewFood);
            foreach (Order o in Orders)
            {
                ListViewItem li = new ListViewItem(o.Id.ToString());
                li.Tag = o.Id;
                li.SubItems.Add(o.TakenAt.ToShortDateString());
                li.SubItems.Add(o.Table.ToString());
                listView.Items.Add(li);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var OrderItemIndex = dgviewFood.CurrentRow.Cells["OrderItemId"].FormattedValue;// get the id of the orderItem
                int ItemId = Convert.ToInt32(OrderItemIndex);
                var StateValue = dgviewFood.CurrentRow.Cells[0].FormattedValue;// first get the value of the cell
                OrderState state = (OrderState)Enum.Parse(typeof(OrderState), Convert.ToString(StateValue));// then parse to the enum value 
                if (state == OrderState.Ready)//*** only confirmation for ready
                {
                    if (MessageBox.Show(" are you sure you want to mark this order as : " + state.ToString(), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        OrderItem_Service.UpdateOrderItemState(ItemId, state);
                    }
                }
                else
                    OrderItem_Service.UpdateOrderItemState(ItemId, state);
            }
            catch (Exception k)
            {

                MessageBox.Show("something went wrong while updating " + k.Message);
            }
        }

        private void listViewFood_MouseClick_1(object sender, MouseEventArgs e)
        {
            //try
            //{
                dgviewFood.DataSource = OrderItem_Service.GetFoodOrders(designHelper.GetslectedIndexOfListview(listViewFood));
                DisplayFood();
            //}
            //catch (Exception k)
            //{
            //    MessageBox.Show("something went wrong while updating " + k.Message);
            //}
        }
    }
}
