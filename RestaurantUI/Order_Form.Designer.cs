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
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(66, 26);
			this.nudQuantity.TabIndex = 15;
			this.nudQuantity.ValueChanged += new System.EventHandler(this.NudQuantity_ValueChanged);
			this.nudQuantity.Leave += new System.EventHandler(this.NudQuantity_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label4.Location = new System.Drawing.Point(517, 606);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Qty.";
			// 
			// btnChangeStatus
			// 
			this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
			this.btnChangeStatus.Location = new System.Drawing.Point(8, 10);
			this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnChangeStatus.Name = "btnChangeStatus";
			this.btnChangeStatus.Size = new System.Drawing.Size(134, 35);
			this.btnChangeStatus.TabIndex = 12;
			this.btnChangeStatus.Text = "Change Status";
			this.btnChangeStatus.UseVisualStyleBackColor = true;
			this.btnChangeStatus.Click += new System.EventHandler(this.BtnChangeStatus_Click);
			// 
			// lblNumber2
			// 
			this.lblNumber2.AutoSize = true;
			this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber2.Location = new System.Drawing.Point(437, 22);
			this.lblNumber2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNumber2.Name = "lblNumber2";
			this.lblNumber2.Size = new System.Drawing.Size(106, 29);
			this.lblNumber2.TabIndex = 11;
			this.lblNumber2.Text = "Table X";
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(601, 516);
			this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(246, 139);
			this.txtComment.TabIndex = 10;
			this.txtComment.Leave += new System.EventHandler(this.TxtComment_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label3.Location = new System.Drawing.Point(685, 487);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Comment";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(495, 300);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(36, 49);
			this.btnRemove.TabIndex = 7;
			this.btnRemove.Text = "<";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(495, 205);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(36, 49);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = ">";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnOrder.Location = new System.Drawing.Point(167, 583);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(192, 72);
			this.btnOrder.TabIndex = 5;
			this.btnOrder.Text = "Place Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(669, 74);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "OrderItems";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(248, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "MenuItems";
			// 
			// lvMenuItems
			// 
			this.lvMenuItems.HideSelection = false;
			this.lvMenuItems.Location = new System.Drawing.Point(167, 114);
			this.lvMenuItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvMenuItems.Name = "lvMenuItems";
			this.lvMenuItems.Size = new System.Drawing.Size(279, 344);
			this.lvMenuItems.TabIndex = 2;
			this.lvMenuItems.UseCompatibleStateImageBehavior = false;
			this.lvMenuItems.View = System.Windows.Forms.View.Details;
			// 
			// lvOrderItems
			// 
			this.lvOrderItems.HideSelection = false;
			this.lvOrderItems.Location = new System.Drawing.Point(579, 114);
			this.lvOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvOrderItems.Name = "lvOrderItems";
			this.lvOrderItems.Size = new System.Drawing.Size(285, 344);
			this.lvOrderItems.TabIndex = 1;
			this.lvOrderItems.UseCompatibleStateImageBehavior = false;
			this.lvOrderItems.View = System.Windows.Forms.View.Details;
			this.lvOrderItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvOrderItems_ItemSelectionChanged);
			// 
			// Order_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 793);
			this.Controls.Add(this.pnlDefault);
			this.Controls.Add(this.pnlChangeStatus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Order_Form";
			this.Text = "Table Service";
			this.Load += new System.EventHandler(this.Order_Form_Load);
			this.pnlChangeStatus.ResumeLayout(false);
			this.pnlChangeStatus.PerformLayout();
			this.pnlDefault.ResumeLayout(false);
			this.pnlDefault.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlChangeStatus;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Label lblNumber;
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
		private System.Windows.Forms.Button btnAvailable;
		private System.Windows.Forms.NumericUpDown nudQuantity;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoAll;
		private System.Windows.Forms.RadioButton rdoDrinks;
		private System.Windows.Forms.RadioButton rdoDinner;
		private System.Windows.Forms.RadioButton rdoLunch;
	}
}