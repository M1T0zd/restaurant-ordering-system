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
        public OrderItem_Service OrderItem_Service = new OrderItem_Service();
        DesignHelper designHelper = new DesignHelper();
        List<OrderItem> Orders = new List<OrderItem>();// refreching use
        public  Employee employee = new Employee();
        //***************************************************
        public Kitchen_Form(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            timerRefrech.Interval = 1000;//efresh every 20 seconds 
            timerRefrech.Enabled = true;
        }
        private void timerRefrech_Tick(object sender, EventArgs e)
        {
            if (employee.Role.ToString() == "Chef")
                LoadingData("Chef");
            else
                LoadingData("Barman");
        }
        private void dgviewDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderItem currentObject = (OrderItem)dgviewOrders.CurrentRow.DataBoundItem;
            int OrderItemIndex = currentObject.Id;
            if (MessageBox.Show(" are you sure you want to mark this order as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dgviewOrders.Columns[e.ColumnIndex].Name == "btnMarkready")
                {
                    OrderItem_Service.MarkAsReady(OrderItemIndex, OrderStatus.Ready);
                    if (employee.Role.ToString() == "Chef")
                        LoadingData("Chef");
                    else
                        LoadingData("Barman");
                }
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
            List<int> Items = new List<int>();// to remove later 
            foreach (DataGridViewRow row in dgviewOrders.SelectedRows)
            {
                if (row.Index >= 0)
                {
                    OrderItem currentObject = (OrderItem)row.DataBoundItem; // i use the current object in datagrid 
                    Items.Add(currentObject.Id);// i get the id from the object not from the interface 
                }
            }
            if (MessageBox.Show(" are you sure you want to mark all these orders as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (int Id in Items)
                    OrderItem_Service.MarkAsReady(Id, OrderStatus.Ready);
                if (employee.Role.ToString() == "Chef")
                    LoadingData("Chef");
                else
                    LoadingData("Barman");
            }
            else
                MessageBox.Show("Operation was aborted ");
        }

        public void DisplayFood()
        {
            try
            {
                foreach (DataGridViewRow row in dgviewOrders.Rows)
                {
                    if (row.Index >= 0)
                    {
                        string State = Convert.ToString(row.Cells[4].Value);
                        if (State.ToLower().Trim() == "waiting")
                            row.DefaultCellStyle.BackColor = Color.Red;
                        else if (State.ToLower().Trim() == "processing")
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        else if (State.ToLower().Trim() == "ready")
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else if (State.ToLower().Trim() == "served")
                            row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(" something went wrong :" + k.Message);
            }

        }

        private void LoadingData(string FoodOrDrinks)
        {
            if (FoodOrDrinks == "Chef")
            {
                Orders = OrderItem_Service.GetFoodOrders();
                //var _bind = from a in Orders
                //            select new
                //            {
                //                Name = a.ItemName,
                //                Quantity = a.Amount,
                //                TakenAt = a.ordertime,
                //                TabelNumber = a.TableNumber,
                //                State = a.Status,
                //                OrdrId = a.Id,
                //            };
                //dgviewOrders.DataSource = _bind.ToList();
                dgviewOrders.DataSource = Orders;
                DisplayFood();
            }
            else if (FoodOrDrinks == "Barman")
            {
                Orders = OrderItem_Service.GetDrinksOrders();
                dgviewOrders.DataSource = OrderItem_Service.GetDrinksOrders();
                 DisplayFood();
            }
        }

        private void pictureBoxOrders_Click(object sender, EventArgs e)
        {
            if (employee.Role.ToString()=="Chef")
                LoadingData("Chef");
            else
                LoadingData("Barman");
        }
    }
}
