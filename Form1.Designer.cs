namespace OOADproject_CarRental
{
    partial class Form1
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
            this.save_regbtn = new System.Windows.Forms.Button();
            this.dlt_regbtn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.user_pass = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.db_name = new System.Windows.Forms.Label();
            this.Server_ip = new System.Windows.Forms.Label();
            this.textbox_userpass = new System.Windows.Forms.TextBox();
            this.textbox_userid = new System.Windows.Forms.TextBox();
            this.textbox_dbname = new System.Windows.Forms.TextBox();
            this.textbox_serverip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_regbtn
            // 
            this.save_regbtn.Location = new System.Drawing.Point(159, 340);
            this.save_regbtn.Name = "save_regbtn";
            this.save_regbtn.Size = new System.Drawing.Size(85, 36);
            this.save_regbtn.TabIndex = 20;
            this.save_regbtn.Text = "save passwords";
            this.save_regbtn.UseVisualStyleBackColor = true;
            this.save_regbtn.Click += new System.EventHandler(this.save_regbtn_Click);
            // 
            // dlt_regbtn
            // 
            this.dlt_regbtn.Location = new System.Drawing.Point(468, 340);
            this.dlt_regbtn.Name = "dlt_regbtn";
            this.dlt_regbtn.Size = new System.Drawing.Size(85, 36);
            this.dlt_regbtn.TabIndex = 19;
            this.dlt_regbtn.Text = "clear saved passwords";
            this.dlt_regbtn.UseVisualStyleBackColor = true;
            this.dlt_regbtn.Click += new System.EventHandler(this.dlt_regbtn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightCoral;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(775, 32);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(40, 36);
            this.exit_btn.TabIndex = 18;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clr_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clr_btn.Location = new System.Drawing.Point(95, 479);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(164, 45);
            this.clr_btn.TabIndex = 16;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.login_btn.Location = new System.Drawing.Point(582, 479);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(164, 45);
            this.login_btn.TabIndex = 17;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // user_pass
            // 
            this.user_pass.AutoSize = true;
            this.user_pass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.Location = new System.Drawing.Point(156, 302);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(103, 16);
            this.user_pass.TabIndex = 12;
            this.user_pass.Text = "User Password";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.Location = new System.Drawing.Point(156, 245);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(55, 16);
            this.user_id.TabIndex = 13;
            this.user_id.Text = "User ID";
            // 
            // db_name
            // 
            this.db_name.AutoSize = true;
            this.db_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_name.Location = new System.Drawing.Point(156, 188);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(110, 16);
            this.db_name.TabIndex = 14;
            this.db_name.Text = "Database Name";
            // 
            // Server_ip
            // 
            this.Server_ip.AutoSize = true;
            this.Server_ip.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_ip.Location = new System.Drawing.Point(156, 131);
            this.Server_ip.Name = "Server_ip";
            this.Server_ip.Size = new System.Drawing.Size(66, 16);
            this.Server_ip.TabIndex = 15;
            this.Server_ip.Text = "Server ip";
            // 
            // textbox_userpass
            // 
            this.textbox_userpass.Location = new System.Drawing.Point(298, 302);
            this.textbox_userpass.Name = "textbox_userpass";
            this.textbox_userpass.PasswordChar = '*';
            this.textbox_userpass.Size = new System.Drawing.Size(256, 20);
            this.textbox_userpass.TabIndex = 8;
            // 
            // textbox_userid
            // 
            this.textbox_userid.Location = new System.Drawing.Point(298, 245);
            this.textbox_userid.Name = "textbox_userid";
            this.textbox_userid.Size = new System.Drawing.Size(256, 20);
            this.textbox_userid.TabIndex = 9;
            // 
            // textbox_dbname
            // 
            this.textbox_dbname.Location = new System.Drawing.Point(298, 188);
            this.textbox_dbname.Name = "textbox_dbname";
            this.textbox_dbname.Size = new System.Drawing.Size(256, 20);
            this.textbox_dbname.TabIndex = 10;
            // 
            // textbox_serverip
            // 
            this.textbox_serverip.Location = new System.Drawing.Point(298, 131);
            this.textbox_serverip.Name = "textbox_serverip";
            this.textbox_serverip.Size = new System.Drawing.Size(256, 20);
            this.textbox_serverip.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "SQL Connection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 577);
            this.Controls.Add(this.save_regbtn);
            this.Controls.Add(this.dlt_regbtn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.db_name);
            this.Controls.Add(this.Server_ip);
            this.Controls.Add(this.textbox_userpass);
            this.Controls.Add(this.textbox_userid);
            this.Controls.Add(this.textbox_dbname);
            this.Controls.Add(this.textbox_serverip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_regbtn;
        private System.Windows.Forms.Button dlt_regbtn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label user_pass;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label db_name;
        private System.Windows.Forms.Label Server_ip;
        private System.Windows.Forms.TextBox textbox_userpass;
        private System.Windows.Forms.TextBox textbox_userid;
        private System.Windows.Forms.TextBox textbox_dbname;
        private System.Windows.Forms.TextBox textbox_serverip;
        private System.Windows.Forms.Label label1;
    }
}

