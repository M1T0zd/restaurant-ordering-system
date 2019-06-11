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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlchangestatus = new System.Windows.Forms.Panel();
            this.btnreserve = new System.Windows.Forms.Button();
            this.btnsetoccupy = new System.Windows.Forms.Button();
            this.lblnumber = new System.Windows.Forms.Label();
            this.pnldefault = new System.Windows.Forms.Panel();
            this.btnavailable = new System.Windows.Forms.Button();
            this.pnlchangestatus.SuspendLayout();
            this.pnldefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnlchangestatus
            // 
            this.pnlchangestatus.Controls.Add(this.btnavailable);
            this.pnlchangestatus.Controls.Add(this.btnreserve);
            this.pnlchangestatus.Controls.Add(this.btnsetoccupy);
            this.pnlchangestatus.Controls.Add(this.lblnumber);
            this.pnlchangestatus.Location = new System.Drawing.Point(41, 9);
            this.pnlchangestatus.Name = "pnlchangestatus";
            this.pnlchangestatus.Size = new System.Drawing.Size(738, 537);
            this.pnlchangestatus.TabIndex = 13;
            // 
            // btnreserve
            // 
            this.btnreserve.Location = new System.Drawing.Point(244, 303);
            this.btnreserve.Name = "btnreserve";
            this.btnreserve.Size = new System.Drawing.Size(206, 45);
            this.btnreserve.TabIndex = 2;
            this.btnreserve.Text = "Reserve";
            this.btnreserve.UseVisualStyleBackColor = true;
            this.btnreserve.Click += new System.EventHandler(this.Btnreserve_Click);
            // 
            // btnsetoccupy
            // 
            this.btnsetoccupy.Location = new System.Drawing.Point(244, 216);
            this.btnsetoccupy.Name = "btnsetoccupy";
            this.btnsetoccupy.Size = new System.Drawing.Size(206, 45);
            this.btnsetoccupy.TabIndex = 1;
            this.btnsetoccupy.Text = "Set Occupy";
            this.btnsetoccupy.UseVisualStyleBackColor = true;
            this.btnsetoccupy.Click += new System.EventHandler(this.Btnsetoccupy_Click);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(273, 48);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(156, 24);
            this.lblnumber.TabIndex = 0;
            this.lblnumber.Text = "TABLE NUMBER";
            // 
            // pnldefault
            // 
            this.pnldefault.Controls.Add(this.button1);
            this.pnldefault.Location = new System.Drawing.Point(12, 40);
            this.pnldefault.Name = "pnldefault";
            this.pnldefault.Size = new System.Drawing.Size(719, 503);
            this.pnldefault.TabIndex = 14;
            // 
            // btnavailable
            // 
            this.btnavailable.Location = new System.Drawing.Point(244, 127);
            this.btnavailable.Name = "btnavailable";
            this.btnavailable.Size = new System.Drawing.Size(206, 45);
            this.btnavailable.TabIndex = 3;
            this.btnavailable.Text = "Available";
            this.btnavailable.UseVisualStyleBackColor = true;
            this.btnavailable.Click += new System.EventHandler(this.Btnavailable_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 514);
            this.Controls.Add(this.pnlchangestatus);
            this.Controls.Add(this.pnldefault);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order_Form";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.pnlchangestatus.ResumeLayout(false);
            this.pnlchangestatus.PerformLayout();
            this.pnldefault.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlchangestatus;
        private System.Windows.Forms.Button btnreserve;
        private System.Windows.Forms.Button btnsetoccupy;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Panel pnldefault;
        private System.Windows.Forms.Button btnavailable;
    }
}