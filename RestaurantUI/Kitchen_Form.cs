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
        List<OrderItem> Orders = new List<OrderItem>();// refreching use
        private Employee CurrentEmployee = new Employee();
        //***************************************************
        public Kitchen_Form(Employee employee)
        {
            InitializeComponent();
            this.CurrentEmployee = employee; // get the current Employee
            this.Text ="Welcome   "+ CurrentEmployee.Name;
            LoadingData(CurrentEmployee);// load Data depend on the current Employee
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            DisplayFood();
            dgviewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// make the column adjust to fit the content 
            lbl_Datetime.Text ="Current time : "+ DateTime.Now.ToString("h:mm:ss tt");
            lbl_PreparedOrders.Text ="";// to modify later 
            timerRefrech.Interval = 1000;//refresh every 20 seconds 
            timerRefrech.Enabled = false;
        }
        private void timerRefrech_Tick(object sender, EventArgs e)
        {
                LoadingData(CurrentEmployee);
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
                            LoadingData(CurrentEmployee);
                    }
                }
            }
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();// exit and go to the default form (login form )
            this.Hide();
        }

        private void dgviewOrders_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; // to avoid error when the column is empty
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
                        Items.Add(currentObject.Id);// get the ID of each Object
                }
            }
            if (MessageBox.Show(" are you sure you want to mark all these orders as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (int Id in Items)
                    OrderItem_Service.MarkAsReady(Id, OrderStatus.Ready);
                  LoadingData(CurrentEmployee);// refrech after deleting
                MessageBox.Show(Items.Count + " Items were marked as ready"); // notify the user how many items were deleted
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

        private void LoadingData(Employee CurrentEmp)
        {
            // make only once the test for the current user and display his data 
            if (CurrentEmp.Role.ToString() == "Chef")
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
                                Ordertime = a.Ordertime,
                                Id = a.Id,
                            };
                dgviewOrders.DataSource = _bind.ToList(); 
                DisplayFood();
            }
            else if (CurrentEmp.Role.ToString() == "Barman")
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
                                Ordertime = a.Ordertime,
                                Id = a.Id,
                            };
                dgviewOrders.DataSource = _bind.ToList();
                DisplayFood();
            }
        }
    }
}
