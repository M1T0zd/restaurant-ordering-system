namespace Restaurant_UI
{
    partial class Kitchen_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen_Form));
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.btn_PrepareFood = new System.Windows.Forms.Button();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.dgviewFood = new System.Windows.Forms.DataGridView();
            this.panelBar = new System.Windows.Forms.Panel();
            this.listViewDrink = new System.Windows.Forms.ListView();
            this.dgviewDrinks = new System.Windows.Forms.DataGridView();
            this.btnMarkready = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerRefrech = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrders = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.panelKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDrinks)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Controls.Add(this.btn_PrepareFood);
            this.panelKitchen.Controls.Add(this.listViewFood);
            this.panelKitchen.Controls.Add(this.dgviewFood);
            this.panelKitchen.Location = new System.Drawing.Point(12, 86);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(223, 535);
            this.panelKitchen.TabIndex = 0;
            // 
            // btn_PrepareFood
            // 
            this.btn_PrepareFood.Location = new System.Drawing.Point(19, 470);
            this.btn_PrepareFood.Name = "btn_PrepareFood";
            this.btn_PrepareFood.Size = new System.Drawing.Size(232, 46);
            this.btn_PrepareFood.TabIndex = 1;
            this.btn_PrepareFood.Text = "Process Order";
            this.btn_PrepareFood.UseVisualStyleBackColor = true;
            this.btn_PrepareFood.Click += new System.EventHandler(this.btn_PrepareFood_Click);
            // 
            // listViewFood
            // 
            this.listViewFood.Location = new System.Drawing.Point(19, 19);
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(800, 157);
            this.listViewFood.TabIndex = 2;
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            this.listViewFood.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFood_MouseClick_1);
            // 
            // dgviewFood
            // 
            this.dgviewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewFood.Location = new System.Drawing.Point(19, 196);
            this.dgviewFood.Name = "dgviewFood";
            this.dgviewFood.RowTemplate.Height = 24;
            this.dgviewFood.Size = new System.Drawing.Size(800, 256);
            this.dgviewFood.TabIndex = 1;
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.listViewDrink);
            this.panelBar.Controls.Add(this.dgviewDrinks);
            this.panelBar.Location = new System.Drawing.Point(12, 89);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(223, 532);
            this.panelBar.TabIndex = 3;
            // 
            // listViewDrink
            // 
            this.listViewDrink.Location = new System.Drawing.Point(19, 19);
            this.listViewDrink.Name = "listViewDrink";
            this.listViewDrink.Size = new System.Drawing.Size(797, 157);
            this.listViewDrink.TabIndex = 2;
            this.listViewDrink.UseCompatibleStateImageBehavior = false;
            this.listViewDrink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDrink_MouseClick);
            // 
            // dgviewDrinks
            // 
            this.dgviewDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnMarkready});
            this.dgviewDrinks.Location = new System.Drawing.Point(19, 196);
            this.dgviewDrinks.Name = "dgviewDrinks";
            this.dgviewDrinks.RowTemplate.Height = 24;
            this.dgviewDrinks.Size = new System.Drawing.Size(797, 256);
            this.dgviewDrinks.TabIndex = 1;
            this.dgviewDrinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewDrinks_CellContentClick);
            // 
            // btnMarkready
            // 
            this.btnMarkready.HeaderText = "Mark Ready";
            this.btnMarkready.Name = "btnMarkready";
            this.btnMarkready.Text = "Mark as Ready";
            this.btnMarkready.ToolTipText = "mark ready";
            this.btnMarkready.UseColumnTextForButtonValue = true;
            // 
            // timerRefrech
            // 
            this.timerRefrech.Tick += new System.EventHandler(this.timerRefrech_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.pictureBoxComments);
            this.panelMenu.Controls.Add(this.pictureBoxOrders);
            this.panelMenu.Controls.Add(this.pictureBoxExit);
            this.panelMenu.Location = new System.Drawing.Point(12, 15);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(432, 68);
            this.panelMenu.TabIndex = 8;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(21, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxComments
            // 
            this.pictureBoxComments.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxComments.Image")));
            this.pictureBoxComments.Location = new System.Drawing.Point(319, 4);
            this.pictureBoxComments.Name = "pictureBoxComments";
            this.pictureBoxComments.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxComments.TabIndex = 2;
            this.pictureBoxComments.TabStop = false;
            // 
            // pictureBoxOrders
            // 
            this.pictureBoxOrders.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrders.Image")));
            this.pictureBoxOrders.Location = new System.Drawing.Point(155, 4);
            this.pictureBoxOrders.Name = "pictureBoxOrders";
            this.pictureBoxOrders.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrders.TabIndex = 1;
            this.pictureBoxOrders.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(722, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Location = new System.Drawing.Point(485, 35);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(808, 586);
            this.listViewOrders.TabIndex = 9;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // Kitchen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 725);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelKitchen);
            this.Name = "Kitchen_Form";
            this.Text = "Kitchen_Form";
            this.Load += new System.EventHandler(this.Kitchen_Form_Load);
            this.panelKitchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDrinks)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.DataGridView dgviewFood;
        private System.Windows.Forms.Button btn_PrepareFood;
        private System.Windows.Forms.ListView listViewFood;
        private System.Windows.Forms.Timer timerRefrech;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.ListView listViewDrink;
        private System.Windows.Forms.DataGridView dgviewDrinks;
        private System.Windows.Forms.DataGridViewButtonColumn btnMarkready;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxComments;
        private System.Windows.Forms.PictureBox pictureBoxOrders;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.ListView listViewOrders;
    }
}