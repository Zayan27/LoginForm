namespace OOADproject_CarRental
{
    partial class Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtc_name = new System.Windows.Forms.TextBox();
            this.txtc_add = new System.Windows.Forms.TextBox();
            this.txtc_mob = new System.Windows.Forms.TextBox();
            this.c_add_btn = new System.Windows.Forms.Button();
            this.c_dlt_btn = new System.Windows.Forms.Button();
            this.c_updt_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_ext_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile";
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(168, 138);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(172, 20);
            this.txtcid.TabIndex = 5;
            // 
            // txtc_name
            // 
            this.txtc_name.Location = new System.Drawing.Point(168, 177);
            this.txtc_name.Name = "txtc_name";
            this.txtc_name.Size = new System.Drawing.Size(172, 20);
            this.txtc_name.TabIndex = 6;
            // 
            // txtc_add
            // 
            this.txtc_add.Location = new System.Drawing.Point(168, 218);
            this.txtc_add.Name = "txtc_add";
            this.txtc_add.Size = new System.Drawing.Size(172, 20);
            this.txtc_add.TabIndex = 7;
            // 
            // txtc_mob
            // 
            this.txtc_mob.Location = new System.Drawing.Point(168, 266);
            this.txtc_mob.Name = "txtc_mob";
            this.txtc_mob.Size = new System.Drawing.Size(172, 20);
            this.txtc_mob.TabIndex = 8;
            // 
            // c_add_btn
            // 
            this.c_add_btn.Location = new System.Drawing.Point(38, 335);
            this.c_add_btn.Name = "c_add_btn";
            this.c_add_btn.Size = new System.Drawing.Size(113, 46);
            this.c_add_btn.TabIndex = 10;
            this.c_add_btn.Text = "ADD";
            this.c_add_btn.UseVisualStyleBackColor = true;
            this.c_add_btn.Click += new System.EventHandler(this.c_add_btn_Click);
            // 
            // c_dlt_btn
            // 
            this.c_dlt_btn.Location = new System.Drawing.Point(227, 335);
            this.c_dlt_btn.Name = "c_dlt_btn";
            this.c_dlt_btn.Size = new System.Drawing.Size(113, 46);
            this.c_dlt_btn.TabIndex = 11;
            this.c_dlt_btn.Text = "DELETE";
            this.c_dlt_btn.UseVisualStyleBackColor = true;
            this.c_dlt_btn.Click += new System.EventHandler(this.c_dlt_btn_Click);
            // 
            // c_updt_btn
            // 
            this.c_updt_btn.Location = new System.Drawing.Point(38, 405);
            this.c_updt_btn.Name = "c_updt_btn";
            this.c_updt_btn.Size = new System.Drawing.Size(114, 44);
            this.c_updt_btn.TabIndex = 12;
            this.c_updt_btn.Text = "UPDATE";
            this.c_updt_btn.UseVisualStyleBackColor = true;
            this.c_updt_btn.Click += new System.EventHandler(this.c_updt_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 385);
            this.dataGridView1.TabIndex = 13;
            // 
            // c_ext_btn
            // 
            this.c_ext_btn.Location = new System.Drawing.Point(227, 405);
            this.c_ext_btn.Name = "c_ext_btn";
            this.c_ext_btn.Size = new System.Drawing.Size(113, 46);
            this.c_ext_btn.TabIndex = 14;
            this.c_ext_btn.Text = "EXIT";
            this.c_ext_btn.UseVisualStyleBackColor = true;
            this.c_ext_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1041, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_ext_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.c_updt_btn);
            this.Controls.Add(this.c_dlt_btn);
            this.Controls.Add(this.c_add_btn);
            this.Controls.Add(this.txtc_mob);
            this.Controls.Add(this.txtc_add);
            this.Controls.Add(this.txtc_name);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txtc_name;
        private System.Windows.Forms.TextBox txtc_add;
        private System.Windows.Forms.TextBox txtc_mob;
        private System.Windows.Forms.Button c_add_btn;
        private System.Windows.Forms.Button c_dlt_btn;
        private System.Windows.Forms.Button c_updt_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button c_ext_btn;
        private System.Windows.Forms.Button button1;
    }
}