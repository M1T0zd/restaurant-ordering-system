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
using RestaurantModel;

namespace Restaurant_UI
{
    public partial class Order_Form : Form
    {
		//Make Panel Status with orders capability in OrderForm
        List<Order> orders;
        List<RestaurantModel.MenuItem> menuItems = new List<RestaurantModel.MenuItem>();
        Table_Form table_Form;
        Table table;
        Employee employee;

        public Order_Form(Table table, Table_Form table_Form,Employee employee)
        {
            InitializeComponent();
			Initialize(table, table_Form);
            this.employee = employee;
		}

        void Initialize(Table table, Table_Form table_Form)
        {
			this.table_Form = table_Form;
			this.table = table;

			orders = table.orders;
        }
       
        private void Order_Form_Load(object sender, EventArgs e)
        {
			lblNumber.Text = $"Table {table.Number}";
			lblNumber2.Text = $"Table {table.Number}";

			UpdateStatusButtons();

			if (table.Status == TableStatus.Occupied)
			{
				pnlChangeStatus.Hide();
				pnlDefault.Show();
			} else {
				pnlChangeStatus.Show();
				pnlDefault.Hide();
			}

			ListViewSetups();
		}

        private void ListViewSetups()
        {
			lvMenuItems.Columns.Add("Name", 150, HorizontalAlignment.Left);
			lvMenuItems.Columns.Add("Price", 50, HorizontalAlignment.Left);
			lvMenuItems.Columns.Add("Stock", 50, HorizontalAlignment.Left);

			lvOrderItems.Columns.Add("Name", 150, HorizontalAlignment.Left);
			lvOrderItems.Columns.Add("Price", 50, HorizontalAlignment.Left);
			lvOrderItems.Columns.Add("Stock", 50, HorizontalAlignment.Left);

			MenuItem_Service menuItem_Service = new MenuItem_Service();
			List<RestaurantModel.MenuItem> menuItems = menuItem_Service.GetMenuItems();

			foreach(RestaurantModel.MenuItem menuItem in menuItems)
			{
				ListViewItem lvi = new ListViewItem(menuItem.Name);
				lvi.SubItems.Add(menuItem.Price.ToString());
				lvi.SubItems.Add(menuItem.Stock.ToString());
				lvi.Tag = menuItem;
				lvMenuItems.Items.Add(lvi);
			}
        }

		private void BtnOccupied_Click(object sender, EventArgs e)
		{
			table.Status = TableStatus.Occupied;
			table_Form.GiveColor();
			pnlChangeStatus.Hide();
			pnlDefault.Show();           
            
		}

		private void BtnAvailable_Click(object sender, EventArgs e)
		{
			table.Status = TableStatus.Available;
			table_Form.GiveColor();
			table_Form.Show();
			this.Close();
		}

		private void BtnReserved_Click(object sender, EventArgs e)
		{
			table.Status = TableStatus.Reserved;
			table_Form.GiveColor();
			table_Form.Show();
			this.Close();
		}




		private void BtnOrder_Click(object sender, EventArgs e)
		{
			if(lvOrderItems.Items.Count != 0)
			{
				Order order = new Order(DateTime.Now);

				foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
				{
					order.OrderItems.Add((OrderItem)lvi.Tag);
				}

				orders.Add(order);
			} else {
				MessageBox.Show("Please add an OrderItem to the OrderItem list first.", "OrderItems list empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in lvMenuItems.SelectedItems)
			{
				RestaurantModel.MenuItem menuItem = (RestaurantModel.MenuItem)lvi.Tag;

				OrderItem orderItem = new OrderItem
				{
					Amount = 1,
					MenuItem = menuItem,
					Status = OrderStatus.Waiting
				};

				ListViewItem lviNew = new ListViewItem(orderItem.MenuItem.Name);// menuItem.Name);
				lviNew.SubItems.Add(orderItem.MenuItem.Price.ToString());
				lviNew.SubItems.Add(orderItem.MenuItem.Stock.ToString());
				lviNew.Tag = orderItem;

				lvOrderItems.Items.Add(lviNew);
			}
		}

		private void BtnRemove_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				lvOrderItems.Items.Remove(lvi);
			}
		}

		private void BtnChangeStatus_Click(object sender, EventArgs e)
		{
			UpdateStatusButtons();
			pnlChangeStatus.Show();
			pnlDefault.Hide();
		}

		private void BtnPay_Click(object sender, EventArgs e)
		{
			Payment_Form form = new Payment_Form(table_Form, table);
			form.Show();
			this.Close();
		}

		//TOOLS
		private void UpdateStatusButtons()
		{
			btnOccupied.Show();
			btnAvailable.Show();
			btnReserved.Show();

			if (table.Status == TableStatus.Occupied)
			{
				btnOccupied.Hide();
			}
			else if (table.Status == TableStatus.Available)
			{
				btnAvailable.Hide();
			}
			else if (table.Status == TableStatus.Reserved)
			{

				btnReserved.Hide();
			}
		}

		private void TxtComment_Leave(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				OrderItem orderItem = (OrderItem)lvi.Tag;

				orderItem.Comment = txtComment.Text;
			}
		}

		private void LvOrderItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if(lvOrderItems.SelectedItems.Count == 1)
			{
				OrderItem orderItem = (OrderItem)lvOrderItems.SelectedItems[0].Tag;

				txtComment.Text = orderItem.Comment;
				txtQuantity.Text = orderItem.Amount.ToString();
			} else {
				txtComment.Text = "";
				txtQuantity.Text = "";
			}
		}

		private void TxtQuantity_Leave(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				OrderItem orderItem = (OrderItem)lvi.Tag;

				/*try
				{*/
					orderItem.Amount = int.Parse(txtComment.Text);
				/*}
				catch(FormatException)
				{
					orderItem.Amount = 1;
				}*/
			}
		}
	}
}
