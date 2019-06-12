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
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.dgviewFood = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.panelKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Controls.Add(this.listViewFood);
            this.panelKitchen.Controls.Add(this.dgviewFood);
            this.panelKitchen.Location = new System.Drawing.Point(12, 12);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(725, 535);
            this.panelKitchen.TabIndex = 0;
            // 
            // dgviewFood
            // 
            this.dgviewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewFood.Location = new System.Drawing.Point(19, 235);
            this.dgviewFood.Name = "dgviewFood";
            this.dgviewFood.RowTemplate.Height = 24;
            this.dgviewFood.Size = new System.Drawing.Size(643, 256);
            this.dgviewFood.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewFood
            // 
            this.listViewFood.Location = new System.Drawing.Point(19, 35);
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(643, 157);
            this.listViewFood.TabIndex = 2;
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            this.listViewFood.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFood_MouseClick_1);
            // 
            // Kitchen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelKitchen);
            this.Name = "Kitchen_Form";
            this.Text = "Kitchen_Form";
            this.Load += new System.EventHandler(this.Kitchen_Form_Load);
            this.panelKitchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.DataGridView dgviewFood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewFood;
    }
}