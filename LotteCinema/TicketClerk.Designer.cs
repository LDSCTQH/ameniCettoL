namespace LotteCinema
{
    partial class fTicketClerk
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_showtimes = new System.Windows.Forms.TabPage();
            this.dgv_showtimes = new System.Windows.Forms.DataGridView();
            this.tp_booking = new System.Windows.Forms.TabPage();
            this.tp_member = new System.Windows.Forms.TabPage();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_identitycard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tp_showtimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showtimes)).BeginInit();
            this.tp_member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_showtimes);
            this.tabControl1.Controls.Add(this.tp_booking);
            this.tabControl1.Controls.Add(this.tp_member);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tp_showtimes
            // 
            this.tp_showtimes.Controls.Add(this.dgv_showtimes);
            this.tp_showtimes.Location = new System.Drawing.Point(4, 22);
            this.tp_showtimes.Name = "tp_showtimes";
            this.tp_showtimes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_showtimes.Size = new System.Drawing.Size(767, 399);
            this.tp_showtimes.TabIndex = 0;
            this.tp_showtimes.Text = "Lịch chiếu";
            this.tp_showtimes.UseVisualStyleBackColor = true;
            // 
            // dgv_showtimes
            // 
            this.dgv_showtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showtimes.Location = new System.Drawing.Point(27, 30);
            this.dgv_showtimes.Name = "dgv_showtimes";
            this.dgv_showtimes.Size = new System.Drawing.Size(708, 347);
            this.dgv_showtimes.TabIndex = 0;
            // 
            // tp_booking
            // 
            this.tp_booking.Location = new System.Drawing.Point(4, 22);
            this.tp_booking.Name = "tp_booking";
            this.tp_booking.Size = new System.Drawing.Size(767, 399);
            this.tp_booking.TabIndex = 2;
            this.tp_booking.Text = "Đặt vé";
            this.tp_booking.UseVisualStyleBackColor = true;
            // 
            // tp_member
            // 
            this.tp_member.Controls.Add(this.btn_add);
            this.tp_member.Controls.Add(this.tb_name);
            this.tp_member.Controls.Add(this.tb_identitycard);
            this.tp_member.Controls.Add(this.label1);
            this.tp_member.Controls.Add(this.label3);
            this.tp_member.Controls.Add(this.label2);
            this.tp_member.Controls.Add(this.dataGridView1);
            this.tp_member.Location = new System.Drawing.Point(4, 22);
            this.tp_member.Name = "tp_member";
            this.tp_member.Size = new System.Drawing.Size(767, 399);
            this.tp_member.TabIndex = 3;
            this.tp_member.Text = "Thành viên";
            this.tp_member.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(298, 357);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm thành viên";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(493, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(244, 20);
            this.tb_name.TabIndex = 6;
            // 
            // tb_identitycard
            // 
            this.tb_identitycard.Location = new System.Drawing.Point(77, 52);
            this.tb_identitycard.Name = "tb_identitycard";
            this.tb_identitycard.Size = new System.Drawing.Size(244, 20);
            this.tb_identitycard.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm thành viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên thành viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // fTicketClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "fTicketClerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé";
            this.Load += new System.EventHandler(this.fTicketClerk_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_showtimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showtimes)).EndInit();
            this.tp_member.ResumeLayout(false);
            this.tp_member.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_showtimes;
        private System.Windows.Forms.TabPage tp_booking;
        private System.Windows.Forms.TabPage tp_member;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_identitycard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_showtimes;
    }
}