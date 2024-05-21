namespace OOADproject_CarRental
{
    partial class MainMenu
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
            this.ext_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.rental_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.car_reg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ext_btn
            // 
            this.ext_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ext_btn.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.Location = new System.Drawing.Point(435, 277);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(172, 77);
            this.ext_btn.TabIndex = 9;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // return_btn
            // 
            this.return_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_btn.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(210, 277);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(172, 77);
            this.return_btn.TabIndex = 8;
            this.return_btn.Text = "RETURN";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // rental_btn
            // 
            this.rental_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rental_btn.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_btn.Location = new System.Drawing.Point(537, 97);
            this.rental_btn.Name = "rental_btn";
            this.rental_btn.Size = new System.Drawing.Size(172, 77);
            this.rental_btn.TabIndex = 7;
            this.rental_btn.Text = "RENTAL";
            this.rental_btn.UseVisualStyleBackColor = true;
            this.rental_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_btn.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.Location = new System.Drawing.Point(317, 97);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(172, 77);
            this.customer_btn.TabIndex = 6;
            this.customer_btn.Text = "CUSTOMER";
            this.customer_btn.UseVisualStyleBackColor = true;
            this.customer_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // car_reg_btn
            // 
            this.car_reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.car_reg_btn.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_reg_btn.Location = new System.Drawing.Point(92, 97);
            this.car_reg_btn.Name = "car_reg_btn";
            this.car_reg_btn.Size = new System.Drawing.Size(172, 77);
            this.car_reg_btn.TabIndex = 5;
            this.car_reg_btn.Text = "CAR REGISTERATION";
            this.car_reg_btn.UseVisualStyleBackColor = true;
            this.car_reg_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.rental_btn);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.car_reg_btn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button rental_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button car_reg_btn;
    }
}