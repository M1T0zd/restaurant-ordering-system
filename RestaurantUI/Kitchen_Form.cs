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
        public Employee employee = new Employee();
        //***************************************************
        public Kitchen_Form(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            timerRefrech.Interval = 1000;//efresh every 20 seconds 
            timerRefrech.Enabled = false;
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
            if (currentObject != null)
            {
                if (MessageBox.Show(" are you sure you want to mark this order as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (dgviewOrders.Columns[e.ColumnIndex].Name == "btnMarkready")
                    {
                        OrderItem_Service.MarkAsReady(currentObject.Id, OrderStatus.Ready);
                        if (employee.Role.ToString() == "Chef")
                            LoadingData("Chef");
                        else
                            LoadingData("Barman");
                    }
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
                    OrderItem currentObject = (OrderItem)row.DataBoundItem;
                    if (currentObject != null)
                        Items.Add(currentObject.Id);
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
                MessageBox.Show(Items.Count + " Items were marked as ready");
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
                Orders = OrderItem_Service.GetUnReadyFoodItemsOrderByTakenTimeDesc();
                var _bind =from a in Orders
                            select new   OrderItem
                            {
                                ItemName = a.ItemName,
                                Amount = a.Amount,
                                Comment = a.Comment,
                                Status = a.Status,
                                TableNumber = a.TableNumber,
                                ordertime = a.ordertime,
                                Id = a.Id,
                            };
                dgviewOrders.DataSource = _bind.ToList(); 
                DisplayFood();
            }
            else if (FoodOrDrinks == "Barman")
            {
                Orders = OrderItem_Service.GetDrinkItemsOrderByTakenTime();
                var _bind = from a in Orders
                            select new OrderItem
                            {
                                ItemName = a.ItemName,
                                Amount = a.Amount,
                                Comment = a.Comment,
                                Status = a.Status,
                                TableNumber = a.TableNumber,
                                ordertime = a.ordertime,
                                 Id = a.Id,
                            };
                dgviewOrders.DataSource = _bind.ToList();
                DisplayFood();
            }
        }

        private void pictureBoxOrders_Click(object sender, EventArgs e)
        {
            if (employee.Role.ToString() == "Chef")
                LoadingData("Chef");
            else if (employee.Role.ToString() == "Barman")
                LoadingData("Barman");
        }

        private void dgviewOrders_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dgviewOrders_MouseHover(object sender, EventArgs e)
        {
            if (employee.Role.ToString() == "Chef")
                LoadingData("Chef");
            else if (employee.Role.ToString() == "Barman")
                LoadingData("Barman");
        }
    }
}
