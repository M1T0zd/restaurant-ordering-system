using Restaurant_Logic;
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

namespace Restaurant_UI
{
    public partial class Kitchen_Form : Form
    {

        Order_Service Order_Service = new Order_Service();
        OrderItems_Service OrderItem_Service = new OrderItems_Service();
        DesignHelper designHelper = new DesignHelper();
        List<Order> Orders = new List<Order>();// refreching use
        public static string employeeRole;
        public Kitchen_Form(Employee employee)
        {
            InitializeComponent();
            //employeeRole = employee.Role;
            Orders = OrderItem_Service.GetOrders();
            if (employee.Role=="Chef")
            {
                panelKitchen.Visible = true;
                panelBar.Visible = false;
                designHelper.ListViewDesign(listViewFood);
                FillFoodList(listViewFood);
            }
            else if (employee.Role=="Barman")
            {
                panelKitchen.Visible = false;
                panelBar.Visible = true;
                designHelper.ListViewDesign(listViewDrink);
                FillDrinksList(listViewDrink);
            }
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            ///// chef
            //designHelper.ListViewDesign(listViewFood);
            //FillFoodList(listViewFood);

            //// barman
            //designHelper.ListViewDesign(listViewDrink);
            //FillDrinksList(listViewDrink);

            timerRefrech.Interval = 20000; //refresh every 20 seconds 
            timerRefrech.Enabled = true;
        }
        public void DisplayDrinks()
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
        private void FillDrinksList(ListView listView)
        {
            designHelper.ListViewDesign(listViewDrink);
            foreach (Order o in Orders)
            {
                ListViewItem li = new ListViewItem(o.Id.ToString());
                li.Tag = o.Id;
                li.SubItems.Add(o.TakenAt.ToShortDateString());
                li.SubItems.Add(o.Table.ToString());
                listView.Items.Add(li);
            }
        }
        private void refrech(string FoodOrDrinks)
        {
            if (FoodOrDrinks == "food")
            {
                dgviewFood.DataSource = OrderItem_Service.GetFoodOrders(designHelper.GetslectedIndexOfListview(listViewFood));
                DisplayFood();
            }
            else if (FoodOrDrinks == "drink")
            {
                dgviewDrinks.DataSource = OrderItem_Service.GetDrinksOrders(designHelper.GetslectedIndexOfListview(listViewDrink));
                DisplayDrinks();
            }
        }
        private void listViewDrink_MouseClick(object sender, MouseEventArgs e)
        {
            refrech("drink");
        }
        private void listViewFood_MouseClick(object sender, MouseEventArgs e)
        {
            refrech("food");
        }

        private void listViewDrink_MouseClick_1(object sender, MouseEventArgs e)
        {
            refrech("drink");
        }

        private void dgviewDrinks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var OrderItemIndex = dgviewDrinks.CurrentRow.Cells["OrderItemId"].FormattedValue;// get the id of the orderItem
            int ItemId = Convert.ToInt32(OrderItemIndex);
            if (dgviewDrinks.Columns[e.ColumnIndex].Name == "btnMarkready")
            {
                OrderItem_Service.MarkAsRaady(ItemId, OrderState.Ready);
                refrech("drink");
            }
        }

        private void btn_PrepareFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (OrderState.Ready == designHelper.getDGcellState(dgviewFood, 0))//*** only confirmation for ready
                {
                    if (MessageBox.Show(" are you sure you want to mark this order as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        OrderItem_Service.UpdateOrderItemState(designHelper.GetGgridIndex(dgviewFood, "OrderItemId"), designHelper.getDGcellState(dgviewFood, 0));
                        refrech("food");
                    }
                }
                else
                {
                    OrderItem_Service.UpdateOrderItemState(designHelper.GetGgridIndex(dgviewFood, "OrderItemId"), designHelper.getDGcellState(dgviewFood, 0));
                    refrech("food");
                }

            }
            catch (Exception k)
            {

                MessageBox.Show("something went wrong while updating " + k.Message);
            }
        }

        private void timerRefrech_Tick_1(object sender, EventArgs e)
        {
           //Refresh("food");
           // Refresh("drink");
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxOrders_Click(object sender, EventArgs e)
        {
            panelKitchen.Visible = true;
        }
    }
}