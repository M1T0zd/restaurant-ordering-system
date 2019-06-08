using RestaurantModel;
using Restaurant_Logic;
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
    public partial class Table_Form : Form
    {
        List<Table> tables = new List<Table>();
        Button button;
        Table table;

        public Table_Form()
        {
            InitializeComponent();
        }

        private void Table_Form_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            Table_Service table_Service = new Table_Service();
            tables = table_Service.GetTables();



            GiveColor(tables);

        }
        void GiveColor(List<Table> tables)
        {
            List<Button> buttons = new List<Button>
            {
                btntbl1,
                btntbl2,
                btntbl3,
                btntbl4,
                btntbl5,
                btntbl6,
                btntbl7,
                btntbl8,
                btntable9,
                btntable10
            };


            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Status == TableStatus.Available)
                {
                    //Background Green
                    buttons[i].BackColor = Color.Green;
                }
                else if (tables[i].Status == TableStatus.Occupied)
                {
                    buttons[i].BackColor = Color.Yellow;
                }
                else
                {
                    buttons[i].BackColor = Color.Red;
                }
            }
         
        }

        public Table_Service Table_Service { get; set; }
     

       
   
        private void Button_Click(object sender, EventArgs e)
        {
            //Make Panel Status with orders capability in OrderForm
            button = (Button)sender;

            table = tables[button.TabIndex];

            Order_Form order_Form = new Order_Form(table,this);
            this.Hide();
            order_Form.Show();
      
        }
    }
}
