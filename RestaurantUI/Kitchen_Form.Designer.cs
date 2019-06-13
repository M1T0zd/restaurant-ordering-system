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
            this.panelBar = new System.Windows.Forms.Panel();
            this.dgviewOrders = new System.Windows.Forms.DataGridView();
            this.btnMarkready = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerRefrech = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrders = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.chapeau1819sdb02DataSet2 = new Restaurant_UI.chapeau1819sdb02DataSet2();
            this.foodOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodOrdersTableAdapter = new Restaurant_UI.chapeau1819sdb02DataSet2TableAdapters.FoodOrdersTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewOrders)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau1819sdb02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.dgviewOrders);
            this.panelBar.Location = new System.Drawing.Point(107, 89);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1005, 521);
            this.panelBar.TabIndex = 3;
            // 
            // dgviewOrders
            // 
            this.dgviewOrders.AutoGenerateColumns = false;
            this.dgviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnMarkready,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.takenAtDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.tableIdDataGridViewTextBoxColumn});
            this.dgviewOrders.DataSource = this.foodOrdersBindingSource;
            this.dgviewOrders.Location = new System.Drawing.Point(15, 25);
            this.dgviewOrders.Name = "dgviewOrders";
            this.dgviewOrders.RowTemplate.Height = 24;
            this.dgviewOrders.Size = new System.Drawing.Size(949, 367);
            this.dgviewOrders.TabIndex = 1;
            this.dgviewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewDrinks_CellContentClick);
            this.dgviewOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgviewOrders_CellFormatting);
            this.dgviewOrders.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgviewOrders_CellPainting);
            this.dgviewOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgviewOrders_DataError_1);
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
            this.panelMenu.Size = new System.Drawing.Size(1058, 68);
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
            this.pictureBoxExit.Location = new System.Drawing.Point(945, 7);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Location = new System.Drawing.Point(12, 89);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(89, 106);
            this.listViewOrders.TabIndex = 9;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // chapeau1819sdb02DataSet2
            // 
            this.chapeau1819sdb02DataSet2.DataSetName = "chapeau1819sdb02DataSet2";
            this.chapeau1819sdb02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodOrdersBindingSource
            // 
            this.foodOrdersBindingSource.DataMember = "FoodOrders";
            this.foodOrdersBindingSource.DataSource = this.chapeau1819sdb02DataSet2;
            // 
            // foodOrdersTableAdapter
            // 
            this.foodOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // takenAtDataGridViewTextBoxColumn
            // 
            this.takenAtDataGridViewTextBoxColumn.DataPropertyName = "TakenAt";
            this.takenAtDataGridViewTextBoxColumn.HeaderText = "TakenAt";
            this.takenAtDataGridViewTextBoxColumn.Name = "takenAtDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "TableId";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            // 
            // Kitchen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 684);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Kitchen_Form";
            this.Text = "Kitchen_Form";
            this.Load += new System.EventHandler(this.Kitchen_Form_Load);
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewOrders)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau1819sdb02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRefrech;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.DataGridView dgviewOrders;
        private System.Windows.Forms.DataGridViewButtonColumn btnMarkready;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxComments;
        private System.Windows.Forms.PictureBox pictureBoxOrders;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.ListView listViewOrders;
        private chapeau1819sdb02DataSet2 chapeau1819sdb02DataSet2;
        private System.Windows.Forms.BindingSource foodOrdersBindingSource;
        private chapeau1819sdb02DataSet2TableAdapters.FoodOrdersTableAdapter foodOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
    }
}