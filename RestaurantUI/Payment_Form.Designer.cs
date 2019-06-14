namespace Restaurant_UI
{
    partial class Payment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tax_txt_bx = new System.Windows.Forms.TextBox();
            this.Tiptxt_bx = new System.Windows.Forms.TextBox();
            this.Total_txt_bx = new System.Windows.Forms.TextBox();
            this.listView1Items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashRadiobtn = new System.Windows.Forms.RadioButton();
            this.PinRadiobtn = new System.Windows.Forms.RadioButton();
            this.creditCardRdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayOrderbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Table_Numberlbl = new System.Windows.Forms.TextBox();
            this.tbNumberlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.commentstxt_box = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

           this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tax 21%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total";
            // 
            // Tax_txt_bx
            this.Tax_txt_bx.BackColor = System.Drawing.SystemColors.Control;
            this.Tax_txt_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tax_txt_bx.Location = new System.Drawing.Point(314, 217);
            this.Tax_txt_bx.Name = "Tax_txt_bx";
            this.Tax_txt_bx.ReadOnly = true;
            this.Tax_txt_bx.Size = new System.Drawing.Size(64, 13);
            this.Tax_txt_bx.TabIndex = 39;
            // 
            // Tiptxt_bx
            // 
            this.Tiptxt_bx.Location = new System.Drawing.Point(314, 240);
            this.Tiptxt_bx.Name = "Tiptxt_bx";
            this.Tiptxt_bx.Size = new System.Drawing.Size(64, 20);
            this.Tiptxt_bx.TabIndex = 38;
            this.Tiptxt_bx.TextChanged += new System.EventHandler(this.Tiptxt_bx_TextChanged);
            // 
            // Total_txt_bx
            // 
            this.Total_txt_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_txt_bx.Location = new System.Drawing.Point(314, 277);
            this.Total_txt_bx.Name = "Total_txt_bx";
            this.Total_txt_bx.ReadOnly = true;
            this.Total_txt_bx.Size = new System.Drawing.Size(64, 13);
            this.Vattxtbx.Location = new System.Drawing.Point(419, 295);
            this.Vattxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.Vattxtbx.Name = "Vattxtbx";
            this.Vattxtbx.Size = new System.Drawing.Size(84, 22);
            this.Vattxtbx.TabIndex = 38;
            // 
            this.Total_txt_bx.TabIndex = 37;
            // 
            // listView1Items
            // 
            this.listView1Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1Items.Location = new System.Drawing.Point(29, 73);
            this.listView1Items.Margin = new System.Windows.Forms.Padding(4);
            this.listView1Items.Name = "listView1Items";
            this.listView1Items.Size = new System.Drawing.Size(474, 178);
            this.listView1Items.TabIndex = 36;
            this.listView1Items.UseCompatibleStateImageBehavior = false;
            this.listView1Items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "item";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 224;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 36;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 43;
            // 
            // tableNumbertxtbx
            // 
            this.tableNumbertxtbx.BackColor = System.Drawing.SystemColors.Menu;
            this.tableNumbertxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableNumbertxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumbertxtbx.Location = new System.Drawing.Point(320, 47);
            this.tableNumbertxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.tableNumbertxtbx.Name = "tableNumbertxtbx";
            this.tableNumbertxtbx.Size = new System.Drawing.Size(52, 19);
            this.tableNumbertxtbx.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cashRadiobtn);
            this.groupBox1.Controls.Add(this.PinRadiobtn);
            this.groupBox1.Controls.Add(this.creditCardRdbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(47, 375);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 117);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select payment method ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_UI.Properties.Resources.Custom_Icon_Design_Flatastic_3_Payment_creditcard_visa;
            this.pictureBox1.Location = new System.Drawing.Point(273, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(188, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "(Mandatory)";
            // 
            // cashRadiobtn
            // 
            this.cashRadiobtn.AutoSize = true;
            this.cashRadiobtn.Location = new System.Drawing.Point(23, 34);
            this.cashRadiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.cashRadiobtn.Name = "cashRadiobtn";
            this.cashRadiobtn.Size = new System.Drawing.Size(64, 22);
            this.cashRadiobtn.TabIndex = 18;
            this.cashRadiobtn.TabStop = true;
            this.cashRadiobtn.Text = "Cash";
            this.cashRadiobtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Restaurant_UI.Properties.Resources.Designbolts_Credit_Card_Payment_American_Express;
            this.pictureBox4.Location = new System.Drawing.Point(320, 100);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // PinRadiobtn
            // 
            this.PinRadiobtn.AutoSize = true;
            this.PinRadiobtn.Location = new System.Drawing.Point(23, 103);
            this.PinRadiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.PinRadiobtn.Name = "PinRadiobtn";
            this.PinRadiobtn.Size = new System.Drawing.Size(50, 22);
            this.PinRadiobtn.TabIndex = 17;
            this.PinRadiobtn.TabStop = true;
            this.PinRadiobtn.Text = "Pin";
            this.PinRadiobtn.UseVisualStyleBackColor = true;
            // 
            // creditCardRdbtn
            // 
            this.creditCardRdbtn.AutoSize = true;
            this.creditCardRdbtn.Location = new System.Drawing.Point(169, 103);
            this.creditCardRdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.creditCardRdbtn.Name = "creditCardRdbtn";
            this.creditCardRdbtn.Size = new System.Drawing.Size(100, 22);
            this.creditCardRdbtn.TabIndex = 28;
            this.creditCardRdbtn.TabStop = true;
            this.creditCardRdbtn.Text = "CreditCard";
            this.creditCardRdbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayOrderbtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CancelBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 662);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(453, 128);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process payment ";
            // 
            // PayOrderbtn
            // 
            this.PayOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayOrderbtn.Image = global::Restaurant_UI.Properties.Resources.Tatice_Cristal_Intense_Ok1;
            this.PayOrderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayOrderbtn.Location = new System.Drawing.Point(23, 53);
            this.PayOrderbtn.Margin = new System.Windows.Forms.Padding(4);
            this.PayOrderbtn.Name = "PayOrderbtn";
            this.PayOrderbtn.Size = new System.Drawing.Size(175, 49);
            this.PayOrderbtn.TabIndex = 54;
            this.PayOrderbtn.Text = "      Pay Order";
            this.PayOrderbtn.UseVisualStyleBackColor = true;
            this.PayOrderbtn.Click += new System.EventHandler(this.PayOrderbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(145, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "(Mandatory)";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Image = global::Restaurant_UI.Properties.Resources.Gakuseisean_Ivista_Error;
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(249, 53);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(175, 49);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = " Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 532);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Comments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(145, 532);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "(Optional)";
            // 
            // Table_Numberlbl
            // 
            this.Table_Numberlbl.BackColor = System.Drawing.SystemColors.Menu;
            this.Table_Numberlbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_Numberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table_Numberlbl.ForeColor = System.Drawing.Color.Red;
            this.Table_Numberlbl.Location = new System.Drawing.Point(240, 22);
            this.Table_Numberlbl.Location = new System.Drawing.Point(320, 11);
            this.Table_Numberlbl.Margin = new System.Windows.Forms.Padding(4);
            this.Table_Numberlbl.Name = "Table_Numberlbl";
            this.Table_Numberlbl.Size = new System.Drawing.Size(52, 19);
            this.Table_Numberlbl.TabIndex = 52;
            // 
            // tbNumberlbl
            // 
            this.tbNumberlbl.AutoSize = true;
            this.tbNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberlbl.Location = new System.Drawing.Point(168, 11);
            this.tbNumberlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNumberlbl.Name = "tbNumberlbl";
            this.tbNumberlbl.Size = new System.Drawing.Size(129, 20);
            this.tbNumberlbl.TabIndex = 51;
            this.tbNumberlbl.Text = "Table number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Order number:";
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(327, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Add Tip";
            // 
            // commentstxt_box
            // 
            this.commentstxt_box.Location = new System.Drawing.Point(52, 554);
            this.commentstxt_box.Margin = new System.Windows.Forms.Padding(4);
            this.commentstxt_box.Multiline = true;
            this.commentstxt_box.Name = "commentstxt_box";
            this.commentstxt_box.Size = new System.Drawing.Size(447, 90);
            this.commentstxt_box.TabIndex = 54;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 805);
            this.Controls.Add(this.commentstxt_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Table_Numberlbl);
            this.Controls.Add(this.tbNumberlbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tax_txt_bx);
            this.Controls.Add(this.Tiptxt_bx);
            this.Controls.Add(this.Total_txt_bx);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tableNumbertxtbx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tax_txt_bx;
        private System.Windows.Forms.TextBox Tiptxt_bx;
        private System.Windows.Forms.TextBox Total_txt_bx;
        private System.Windows.Forms.ListView listView1Items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PinRadiobtn;
        private System.Windows.Forms.RadioButton cashRadiobtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Pay_Order_btn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RadioButton creditCardRdbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Table_Numberlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PayOrderbtn;
        private System.Windows.Forms.TextBox commentstxt_box;
    }
}