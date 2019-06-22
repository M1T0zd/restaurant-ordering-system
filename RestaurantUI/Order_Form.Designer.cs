namespace Restaurant_UI
{
    partial class Order_Form
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
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDrinks = new System.Windows.Forms.RadioButton();
            this.rdoDinner = new System.Windows.Forms.RadioButton();
            this.rdoLunch = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMenuItems = new System.Windows.Forms.ListView();
            this.lvOrderItems = new System.Windows.Forms.ListView();
            this.pnlDefault.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(111, 409);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(89, 24);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // pnlDefault
            // 
            this.pnlDefault.Controls.Add(this.groupBox1);
            this.pnlDefault.Controls.Add(this.nudQuantity);
            this.pnlDefault.Controls.Add(this.label4);
            this.pnlDefault.Controls.Add(this.btnPay);
            this.pnlDefault.Controls.Add(this.btnChangeStatus);
            this.pnlDefault.Controls.Add(this.lblNumber2);
            this.pnlDefault.Controls.Add(this.txtComment);
            this.pnlDefault.Controls.Add(this.label3);
            this.pnlDefault.Controls.Add(this.btnRemove);
            this.pnlDefault.Controls.Add(this.btnAdd);
            this.pnlDefault.Controls.Add(this.btnOrder);
            this.pnlDefault.Controls.Add(this.label2);
            this.pnlDefault.Controls.Add(this.label1);
            this.pnlDefault.Controls.Add(this.lvMenuItems);
            this.pnlDefault.Controls.Add(this.lvOrderItems);
            this.pnlDefault.Location = new System.Drawing.Point(0, 0);
            this.pnlDefault.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(605, 506);
            this.pnlDefault.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDrinks);
            this.groupBox1.Controls.Add(this.rdoDinner);
            this.groupBox1.Controls.Add(this.rdoLunch);
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(57, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // rdoDrinks
            // 
            this.rdoDrinks.AutoSize = true;
            this.rdoDrinks.Location = new System.Drawing.Point(3, 63);
            this.rdoDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDrinks.Name = "rdoDrinks";
            this.rdoDrinks.Size = new System.Drawing.Size(55, 17);
            this.rdoDrinks.TabIndex = 3;
            this.rdoDrinks.TabStop = true;
            this.rdoDrinks.Text = "Drinks";
            this.rdoDrinks.UseVisualStyleBackColor = true;
            this.rdoDrinks.CheckedChanged += new System.EventHandler(this.RdoButtons_Changed);
            // 
            // rdoDinner
            // 
            this.rdoDinner.AutoSize = true;
            this.rdoDinner.Location = new System.Drawing.Point(3, 47);
            this.rdoDinner.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDinner.Name = "rdoDinner";
            this.rdoDinner.Size = new System.Drawing.Size(56, 17);
            this.rdoDinner.TabIndex = 2;
            this.rdoDinner.TabStop = true;
            this.rdoDinner.Text = "Dinner";
            this.rdoDinner.UseVisualStyleBackColor = true;
            this.rdoDinner.CheckedChanged += new System.EventHandler(this.RdoButtons_Changed);
            // 
            // rdoLunch
            // 
            this.rdoLunch.AutoSize = true;
            this.rdoLunch.Location = new System.Drawing.Point(3, 33);
            this.rdoLunch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLunch.Name = "rdoLunch";
            this.rdoLunch.Size = new System.Drawing.Size(55, 17);
            this.rdoLunch.TabIndex = 1;
            this.rdoLunch.TabStop = true;
            this.rdoLunch.Text = "Lunch";
            this.rdoLunch.UseVisualStyleBackColor = true;
            this.rdoLunch.CheckedChanged += new System.EventHandler(this.RdoButtons_Changed);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(3, 19);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(36, 17);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = false;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.RdoButtons_Changed);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(310, 334);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(44, 20);
            this.nudQuantity.TabIndex = 15;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.NudQuantity_ValueChanged);
            this.nudQuantity.Leave += new System.EventHandler(this.NudQuantity_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(334, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Qty.";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btnChangeStatus.Location = new System.Drawing.Point(5, 6);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(89, 23);
            this.btnChangeStatus.TabIndex = 12;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.BtnChangeStatus_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(291, 15);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(70, 20);
            this.lblNumber2.TabIndex = 11;
            this.lblNumber2.Text = "Table X";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(433, 334);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(111, 61);
            this.txtComment.TabIndex = 10;
            this.txtComment.Leave += new System.EventHandler(this.TxtComment_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(457, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comment";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(330, 195);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 32);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOrder.Location = new System.Drawing.Point(111, 319);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(128, 47);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(446, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "OrderItems";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(165, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MenuItems";
            // 
            // lvMenuItems
            // 
            this.lvMenuItems.HideSelection = false;
            this.lvMenuItems.Location = new System.Drawing.Point(111, 74);
            this.lvMenuItems.Name = "lvMenuItems";
            this.lvMenuItems.Size = new System.Drawing.Size(187, 225);
            this.lvMenuItems.TabIndex = 2;
            this.lvMenuItems.UseCompatibleStateImageBehavior = false;
            this.lvMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // lvOrderItems
            // 
            this.lvOrderItems.HideSelection = false;
            this.lvOrderItems.Location = new System.Drawing.Point(386, 74);
            this.lvOrderItems.Name = "lvOrderItems";
            this.lvOrderItems.Size = new System.Drawing.Size(192, 225);
            this.lvOrderItems.TabIndex = 1;
            this.lvOrderItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderItems.View = System.Windows.Forms.View.Details;
            this.lvOrderItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvOrderItems_ItemSelectionChanged);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 469);
            this.Controls.Add(this.pnlDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Order_Form";
            this.Text = "Table Service";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.pnlDefault.ResumeLayout(false);
            this.pnlDefault.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlDefault;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMenuItems;
        private System.Windows.Forms.ListView lvOrderItems;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoDrinks;
        private System.Windows.Forms.RadioButton rdoDinner;
        private System.Windows.Forms.RadioButton rdoLunch;
    }
}