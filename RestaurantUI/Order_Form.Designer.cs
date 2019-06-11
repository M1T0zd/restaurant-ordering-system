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
			this.pnlchangestatus = new System.Windows.Forms.Panel();
			this.btnreserve = new System.Windows.Forms.Button();
			this.btnsetoccupy = new System.Windows.Forms.Button();
			this.lblnumber = new System.Windows.Forms.Label();
			this.pnldefault = new System.Windows.Forms.Panel();
			this.lvOrderItems = new System.Windows.Forms.ListView();
			this.lvMenuItems = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pnlchangestatus.SuspendLayout();
			this.pnldefault.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPay
			// 
			this.btnPay.Location = new System.Drawing.Point(34, 383);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(134, 36);
			this.btnPay.TabIndex = 0;
			this.btnPay.Text = "Make Payment";
			this.btnPay.UseVisualStyleBackColor = true;
			this.btnPay.Click += new System.EventHandler(this.Button1_Click);
			// 
			// pnlchangestatus
			// 
			this.pnlchangestatus.Controls.Add(this.btnreserve);
			this.pnlchangestatus.Controls.Add(this.btnsetoccupy);
			this.pnlchangestatus.Controls.Add(this.lblnumber);
			this.pnlchangestatus.Location = new System.Drawing.Point(31, 7);
			this.pnlchangestatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlchangestatus.Name = "pnlchangestatus";
			this.pnlchangestatus.Size = new System.Drawing.Size(554, 436);
			this.pnlchangestatus.TabIndex = 13;
			// 
			// btnreserve
			// 
			this.btnreserve.Location = new System.Drawing.Point(183, 227);
			this.btnreserve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnreserve.Name = "btnreserve";
			this.btnreserve.Size = new System.Drawing.Size(154, 37);
			this.btnreserve.TabIndex = 2;
			this.btnreserve.Text = "Reserve";
			this.btnreserve.UseVisualStyleBackColor = true;
			this.btnreserve.Click += new System.EventHandler(this.Btnreserve_Click);
			// 
			// btnsetoccupy
			// 
			this.btnsetoccupy.Location = new System.Drawing.Point(183, 136);
			this.btnsetoccupy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnsetoccupy.Name = "btnsetoccupy";
			this.btnsetoccupy.Size = new System.Drawing.Size(154, 37);
			this.btnsetoccupy.TabIndex = 1;
			this.btnsetoccupy.Text = "Set Occupy";
			this.btnsetoccupy.UseVisualStyleBackColor = true;
			this.btnsetoccupy.Click += new System.EventHandler(this.Btnsetoccupy_Click);
			// 
			// lblnumber
			// 
			this.lblnumber.AutoSize = true;
			this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnumber.Location = new System.Drawing.Point(205, 39);
			this.lblnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblnumber.Name = "lblnumber";
			this.lblnumber.Size = new System.Drawing.Size(124, 18);
			this.lblnumber.TabIndex = 0;
			this.lblnumber.Text = "TABLE NUMBER";
			// 
			// pnldefault
			// 
			this.pnldefault.Controls.Add(this.textBox2);
			this.pnldefault.Controls.Add(this.label3);
			this.pnldefault.Controls.Add(this.btnRemove);
			this.pnldefault.Controls.Add(this.btnAdd);
			this.pnldefault.Controls.Add(this.btnOrder);
			this.pnldefault.Controls.Add(this.label2);
			this.pnldefault.Controls.Add(this.label1);
			this.pnldefault.Controls.Add(this.lvMenuItems);
			this.pnldefault.Controls.Add(this.lvOrderItems);
			this.pnldefault.Controls.Add(this.btnPay);
			this.pnldefault.Location = new System.Drawing.Point(9, 32);
			this.pnldefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnldefault.Name = "pnldefault";
			this.pnldefault.Size = new System.Drawing.Size(539, 437);
			this.pnldefault.TabIndex = 14;
			// 
			// lvOrderItems
			// 
			this.lvOrderItems.Location = new System.Drawing.Point(344, 40);
			this.lvOrderItems.Name = "lvOrderItems";
			this.lvOrderItems.Size = new System.Drawing.Size(165, 225);
			this.lvOrderItems.TabIndex = 1;
			this.lvOrderItems.UseCompatibleStateImageBehavior = false;
			// 
			// lvMenuItems
			// 
			this.lvMenuItems.Location = new System.Drawing.Point(34, 40);
			this.lvMenuItems.Name = "lvMenuItems";
			this.lvMenuItems.Size = new System.Drawing.Size(166, 225);
			this.lvMenuItems.TabIndex = 2;
			this.lvMenuItems.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(76, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "MenuItems";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(389, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "OrderItems";
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnOrder.Location = new System.Drawing.Point(34, 287);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(128, 47);
			this.btnOrder.TabIndex = 5;
			this.btnOrder.Text = "Place Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(260, 101);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(24, 32);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = ">";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(260, 163);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(24, 32);
			this.btnRemove.TabIndex = 7;
			this.btnRemove.Text = "<";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label3.Location = new System.Drawing.Point(400, 305);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Comment";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(344, 327);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(165, 92);
			this.textBox2.TabIndex = 10;
			// 
			// Order_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 480);
			this.Controls.Add(this.pnldefault);
			this.Controls.Add(this.pnlchangestatus);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Order_Form";
			this.Text = "z";
			this.Load += new System.EventHandler(this.Order_Form_Load);
			this.pnlchangestatus.ResumeLayout(false);
			this.pnlchangestatus.PerformLayout();
			this.pnldefault.ResumeLayout(false);
			this.pnldefault.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlchangestatus;
        private System.Windows.Forms.Button btnreserve;
        private System.Windows.Forms.Button btnsetoccupy;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Panel pnldefault;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvMenuItems;
		private System.Windows.Forms.ListView lvOrderItems;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
	}
}