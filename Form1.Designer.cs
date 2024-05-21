namespace LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_serverip = new System.Windows.Forms.TextBox();
            this.Server_ip = new System.Windows.Forms.Label();
            this.textbox_dbname = new System.Windows.Forms.TextBox();
            this.db_name = new System.Windows.Forms.Label();
            this.textbox_userid = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.Label();
            this.textbox_userpass = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.dlt_regbtn = new System.Windows.Forms.Button();
            this.save_regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbox_serverip
            // 
            this.textbox_serverip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbox_serverip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_serverip.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_serverip.Location = new System.Drawing.Point(27, 122);
            this.textbox_serverip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_serverip.Multiline = true;
            this.textbox_serverip.Name = "textbox_serverip";
            this.textbox_serverip.Size = new System.Drawing.Size(261, 27);
            this.textbox_serverip.TabIndex = 1;
            this.textbox_serverip.TextChanged += new System.EventHandler(this.textbox_serverip_TextChanged);
            // 
            // Server_ip
            // 
            this.Server_ip.AutoSize = true;
            this.Server_ip.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_ip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Server_ip.Location = new System.Drawing.Point(23, 100);
            this.Server_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Server_ip.Name = "Server_ip";
            this.Server_ip.Size = new System.Drawing.Size(69, 18);
            this.Server_ip.TabIndex = 2;
            this.Server_ip.Text = "Server ip";
            // 
            // textbox_dbname
            // 
            this.textbox_dbname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbox_dbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_dbname.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textbox_dbname.Location = new System.Drawing.Point(27, 200);
            this.textbox_dbname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_dbname.Multiline = true;
            this.textbox_dbname.Name = "textbox_dbname";
            this.textbox_dbname.Size = new System.Drawing.Size(261, 27);
            this.textbox_dbname.TabIndex = 1;
            // 
            // db_name
            // 
            this.db_name.AutoSize = true;
            this.db_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.db_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.db_name.Location = new System.Drawing.Point(23, 177);
            this.db_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(115, 18);
            this.db_name.TabIndex = 2;
            this.db_name.Text = "Database Name";
            // 
            // textbox_userid
            // 
            this.textbox_userid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbox_userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_userid.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textbox_userid.Location = new System.Drawing.Point(27, 272);
            this.textbox_userid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_userid.Multiline = true;
            this.textbox_userid.Name = "textbox_userid";
            this.textbox_userid.Size = new System.Drawing.Size(261, 27);
            this.textbox_userid.TabIndex = 1;
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.user_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.user_id.Location = new System.Drawing.Point(23, 249);
            this.user_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(58, 18);
            this.user_id.TabIndex = 2;
            this.user_id.Text = "User ID";
            // 
            // textbox_userpass
            // 
            this.textbox_userpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbox_userpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_userpass.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textbox_userpass.Location = new System.Drawing.Point(27, 346);
            this.textbox_userpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_userpass.Multiline = true;
            this.textbox_userpass.Name = "textbox_userpass";
            this.textbox_userpass.Size = new System.Drawing.Size(261, 27);
            this.textbox_userpass.TabIndex = 1;
            // 
            // user_pass
            // 
            this.user_pass.AutoSize = true;
            this.user_pass.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.user_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.user_pass.Location = new System.Drawing.Point(23, 324);
            this.user_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(111, 18);
            this.user_pass.TabIndex = 2;
            this.user_pass.Text = "User Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.login_btn.Location = new System.Drawing.Point(26, 525);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(261, 40);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.clr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_btn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clr_btn.Location = new System.Drawing.Point(27, 465);
            this.clr_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(261, 43);
            this.clr_btn.TabIndex = 3;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(286, -1);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 31);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // dlt_regbtn
            // 
            this.dlt_regbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dlt_regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dlt_regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlt_regbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dlt_regbtn.ForeColor = System.Drawing.Color.White;
            this.dlt_regbtn.Location = new System.Drawing.Point(187, 401);
            this.dlt_regbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dlt_regbtn.Name = "dlt_regbtn";
            this.dlt_regbtn.Size = new System.Drawing.Size(101, 33);
            this.dlt_regbtn.TabIndex = 5;
            this.dlt_regbtn.Text = "Clear Passwords";
            this.dlt_regbtn.UseVisualStyleBackColor = false;
            this.dlt_regbtn.Click += new System.EventHandler(this.dlt_regbtn_Click);
            // 
            // save_regbtn
            // 
            this.save_regbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.save_regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_regbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_regbtn.ForeColor = System.Drawing.Color.White;
            this.save_regbtn.Location = new System.Drawing.Point(27, 401);
            this.save_regbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_regbtn.Name = "save_regbtn";
            this.save_regbtn.Size = new System.Drawing.Size(101, 33);
            this.save_regbtn.TabIndex = 6;
            this.save_regbtn.Text = "Save Password";
            this.save_regbtn.UseVisualStyleBackColor = false;
            this.save_regbtn.Click += new System.EventHandler(this.save_regbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(321, 617);
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
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_serverip;
        private System.Windows.Forms.Label Server_ip;
        private System.Windows.Forms.TextBox textbox_dbname;
        private System.Windows.Forms.Label db_name;
        private System.Windows.Forms.TextBox textbox_userid;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.TextBox textbox_userpass;
        private System.Windows.Forms.Label user_pass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button dlt_regbtn;
        private System.Windows.Forms.Button save_regbtn;
    }
}

