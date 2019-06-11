namespace Restaurant_UI
{
    partial class Account_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblnm = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(270, 152);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 25);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "label2";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(131, 270);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(245, 47);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.Location = new System.Drawing.Point(139, 152);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(64, 25);
            this.lblnm.TabIndex = 3;
            this.lblnm.Text = "Name";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(25, 34);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(136, 39);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.Btnback_Click);
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 499);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblnm);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Name = "Account_Form";
            this.Text = "Account_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Button btnback;
    }
}