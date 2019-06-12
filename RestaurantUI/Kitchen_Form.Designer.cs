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
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.btn_PrepareFood = new System.Windows.Forms.Button();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.dgviewFood = new System.Windows.Forms.DataGridView();
            this.timerRefrech = new System.Windows.Forms.Timer(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.listViewDrink = new System.Windows.Forms.ListView();
            this.dgviewDrinks = new System.Windows.Forms.DataGridView();
            this.btnMarkready = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Controls.Add(this.btn_PrepareFood);
            this.panelKitchen.Controls.Add(this.listViewFood);
            this.panelKitchen.Controls.Add(this.dgviewFood);
            this.panelKitchen.Location = new System.Drawing.Point(12, 27);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(420, 535);
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
            this.listViewFood.Size = new System.Drawing.Size(364, 157);
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
            this.dgviewFood.Size = new System.Drawing.Size(364, 256);
            this.dgviewFood.TabIndex = 1;
            // 
            // timerRefrech
            // 
            this.timerRefrech.Tick += new System.EventHandler(this.timerRefrech_Tick);
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.listViewDrink);
            this.panelBar.Controls.Add(this.dgviewDrinks);
            this.panelBar.Location = new System.Drawing.Point(477, 47);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(608, 535);
            this.panelBar.TabIndex = 3;
            // 
            // listViewDrink
            // 
            this.listViewDrink.Location = new System.Drawing.Point(19, 19);
            this.listViewDrink.Name = "listViewDrink";
            this.listViewDrink.Size = new System.Drawing.Size(498, 157);
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
            this.dgviewDrinks.Size = new System.Drawing.Size(498, 256);
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
            // Kitchen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 631);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelKitchen);
            this.Name = "Kitchen_Form";
            this.Text = "Kitchen_Form";
            this.Load += new System.EventHandler(this.Kitchen_Form_Load);
            this.panelKitchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDrinks)).EndInit();
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
    }
}