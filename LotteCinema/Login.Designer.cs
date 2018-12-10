namespace LotteCinema
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.chk_showpass = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.rb_seller = new System.Windows.Forms.RadioButton();
            this.rb_manager = new System.Windows.Forms.RadioButton();
            this.gb_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(481, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(228, 95);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(227, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(228, 133);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(227, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // chk_showpass
            // 
            this.chk_showpass.AutoSize = true;
            this.chk_showpass.Location = new System.Drawing.Point(360, 168);
            this.chk_showpass.Name = "chk_showpass";
            this.chk_showpass.Size = new System.Drawing.Size(95, 17);
            this.chk_showpass.TabIndex = 3;
            this.chk_showpass.Text = "Hiện mật khẩu";
            this.chk_showpass.UseVisualStyleBackColor = true;
            this.chk_showpass.CheckedChanged += new System.EventHandler(this.chk_showpass_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(36, 195);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.rb_seller);
            this.gb_1.Controls.Add(this.rb_manager);
            this.gb_1.Location = new System.Drawing.Point(132, 15);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(323, 61);
            this.gb_1.TabIndex = 6;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Loại nhân viên";
            // 
            // rb_seller
            // 
            this.rb_seller.AutoSize = true;
            this.rb_seller.Location = new System.Drawing.Point(201, 29);
            this.rb_seller.Name = "rb_seller";
            this.rb_seller.Size = new System.Drawing.Size(59, 17);
            this.rb_seller.TabIndex = 3;
            this.rb_seller.Text = "Bán vé";
            this.rb_seller.UseVisualStyleBackColor = true;
            // 
            // rb_manager
            // 
            this.rb_manager.AutoSize = true;
            this.rb_manager.Checked = true;
            this.rb_manager.Location = new System.Drawing.Point(63, 29);
            this.rb_manager.Name = "rb_manager";
            this.rb_manager.Size = new System.Drawing.Size(61, 17);
            this.rb_manager.TabIndex = 2;
            this.rb_manager.TabStop = true;
            this.rb_manager.Text = "Quản lý";
            this.rb_manager.UseVisualStyleBackColor = true;
            // 
            // fLogin
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 239);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.chk_showpass);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.CheckBox chk_showpass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.RadioButton rb_manager;
        private System.Windows.Forms.RadioButton rb_seller;
    }
}

