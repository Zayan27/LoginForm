namespace OOADproject_CarRental
{
    partial class Rental
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustid = new System.Windows.Forms.TextBox();
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.txtRfee = new System.Windows.Forms.TextBox();
            this.txtIssuedate = new System.Windows.Forms.DateTimePicker();
            this.txtDuedate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RentInset_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCarid = new System.Windows.Forms.ComboBox();
            this.ext_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(63, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(107, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(94, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rental Fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(103, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Issued";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(85, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date Due";
            // 
            // txtCustid
            // 
            this.txtCustid.Location = new System.Drawing.Point(194, 140);
            this.txtCustid.Name = "txtCustid";
            this.txtCustid.Size = new System.Drawing.Size(234, 20);
            this.txtCustid.TabIndex = 8;
            this.txtCustid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustid_KeyPress);
            // 
            // txtCustname
            // 
            this.txtCustname.Location = new System.Drawing.Point(194, 188);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(234, 20);
            this.txtCustname.TabIndex = 9;
            // 
            // txtRfee
            // 
            this.txtRfee.Location = new System.Drawing.Point(194, 229);
            this.txtRfee.Name = "txtRfee";
            this.txtRfee.Size = new System.Drawing.Size(234, 20);
            this.txtRfee.TabIndex = 10;
            // 
            // txtIssuedate
            // 
            this.txtIssuedate.Location = new System.Drawing.Point(194, 274);
            this.txtIssuedate.Name = "txtIssuedate";
            this.txtIssuedate.Size = new System.Drawing.Size(234, 20);
            this.txtIssuedate.TabIndex = 11;
            // 
            // txtDuedate
            // 
            this.txtDuedate.Location = new System.Drawing.Point(194, 319);
            this.txtDuedate.Name = "txtDuedate";
            this.txtDuedate.Size = new System.Drawing.Size(234, 20);
            this.txtDuedate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(320, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Availability";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RentInset_btn
            // 
            this.RentInset_btn.Location = new System.Drawing.Point(70, 398);
            this.RentInset_btn.Name = "RentInset_btn";
            this.RentInset_btn.Size = new System.Drawing.Size(110, 43);
            this.RentInset_btn.TabIndex = 15;
            this.RentInset_btn.Text = "ADD";
            this.RentInset_btn.UseVisualStyleBackColor = true;
            this.RentInset_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 395);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtCarid
            // 
            this.txtCarid.FormattingEnabled = true;
            this.txtCarid.Location = new System.Drawing.Point(194, 95);
            this.txtCarid.Name = "txtCarid";
            this.txtCarid.Size = new System.Drawing.Size(234, 21);
            this.txtCarid.TabIndex = 17;
            this.txtCarid.SelectedIndexChanged += new System.EventHandler(this.txtCarid_SelectedIndexChanged);
            // 
            // ext_btn
            // 
            this.ext_btn.Location = new System.Drawing.Point(70, 447);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(110, 43);
            this.ext_btn.TabIndex = 18;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(927, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.txtCarid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RentInset_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDuedate);
            this.Controls.Add(this.txtIssuedate);
            this.Controls.Add(this.txtRfee);
            this.Controls.Add(this.txtCustname);
            this.Controls.Add(this.txtCustid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustid;
        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.TextBox txtRfee;
        private System.Windows.Forms.DateTimePicker txtIssuedate;
        private System.Windows.Forms.DateTimePicker txtDuedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RentInset_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtCarid;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button button1;
    }
}