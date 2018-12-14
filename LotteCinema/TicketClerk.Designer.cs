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
            this.tp_member = new System.Windows.Forms.TabPage();
            this.btn_suathongtin = new System.Windows.Forms.Button();
            this.btn_themthanhvien = new System.Windows.Forms.Button();
            this.tb_timkiemthanhvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_timkiemthanhvien = new System.Windows.Forms.Label();
            this.dgv_danhsachthanhvien = new System.Windows.Forms.DataGridView();
            this.tp_ticket = new System.Windows.Forms.TabPage();
            this.btn_huytatca = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_layve = new System.Windows.Forms.Button();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tb_idve = new System.Windows.Forms.TextBox();
            this.dgv_vedat = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_showtimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showtimes)).BeginInit();
            this.tp_member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachthanhvien)).BeginInit();
            this.tp_ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vedat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_showtimes);
            this.tabControl1.Controls.Add(this.tp_member);
            this.tabControl1.Controls.Add(this.tp_ticket);
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
            this.dgv_showtimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showtimes_CellClick);
            // 
            // tp_member
            // 
            this.tp_member.Controls.Add(this.btn_suathongtin);
            this.tp_member.Controls.Add(this.btn_themthanhvien);
            this.tp_member.Controls.Add(this.tb_timkiemthanhvien);
            this.tp_member.Controls.Add(this.label1);
            this.tp_member.Controls.Add(this.lb_timkiemthanhvien);
            this.tp_member.Controls.Add(this.dgv_danhsachthanhvien);
            this.tp_member.Location = new System.Drawing.Point(4, 22);
            this.tp_member.Name = "tp_member";
            this.tp_member.Size = new System.Drawing.Size(767, 399);
            this.tp_member.TabIndex = 3;
            this.tp_member.Text = "Thành viên";
            this.tp_member.UseVisualStyleBackColor = true;
            // 
            // btn_suathongtin
            // 
            this.btn_suathongtin.Location = new System.Drawing.Point(139, 361);
            this.btn_suathongtin.Name = "btn_suathongtin";
            this.btn_suathongtin.Size = new System.Drawing.Size(146, 23);
            this.btn_suathongtin.TabIndex = 14;
            this.btn_suathongtin.Text = "Sửa thông tin ";
            this.btn_suathongtin.UseVisualStyleBackColor = true;
            // 
            // btn_themthanhvien
            // 
            this.btn_themthanhvien.Location = new System.Drawing.Point(353, 361);
            this.btn_themthanhvien.Name = "btn_themthanhvien";
            this.btn_themthanhvien.Size = new System.Drawing.Size(146, 23);
            this.btn_themthanhvien.TabIndex = 13;
            this.btn_themthanhvien.Text = "Thêm thành viên";
            this.btn_themthanhvien.UseVisualStyleBackColor = true;
            this.btn_themthanhvien.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_timkiemthanhvien
            // 
            this.tb_timkiemthanhvien.Location = new System.Drawing.Point(238, 66);
            this.tb_timkiemthanhvien.Name = "tb_timkiemthanhvien";
            this.tb_timkiemthanhvien.Size = new System.Drawing.Size(244, 20);
            this.tb_timkiemthanhvien.TabIndex = 12;
            this.tb_timkiemthanhvien.Text = "CMND, Tên thành viên";
            this.tb_timkiemthanhvien.TextChanged += new System.EventHandler(this.tb_timkiemthanhvien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm thành viên";
            // 
            // lb_timkiemthanhvien
            // 
            this.lb_timkiemthanhvien.AutoSize = true;
            this.lb_timkiemthanhvien.Location = new System.Drawing.Point(182, 70);
            this.lb_timkiemthanhvien.Name = "lb_timkiemthanhvien";
            this.lb_timkiemthanhvien.Size = new System.Drawing.Size(49, 13);
            this.lb_timkiemthanhvien.TabIndex = 10;
            this.lb_timkiemthanhvien.Text = "Tìm kiếm";
            // 
            // dgv_danhsachthanhvien
            // 
            this.dgv_danhsachthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachthanhvien.Location = new System.Drawing.Point(27, 141);
            this.dgv_danhsachthanhvien.Name = "dgv_danhsachthanhvien";
            this.dgv_danhsachthanhvien.Size = new System.Drawing.Size(712, 175);
            this.dgv_danhsachthanhvien.TabIndex = 9;
            // 
            // tp_ticket
            // 
            this.tp_ticket.Controls.Add(this.btn_huytatca);
            this.tp_ticket.Controls.Add(this.btn_huy);
            this.tp_ticket.Controls.Add(this.btn_layve);
            this.tp_ticket.Controls.Add(this.lb_timkiem);
            this.tp_ticket.Controls.Add(this.tb_idve);
            this.tp_ticket.Controls.Add(this.dgv_vedat);
            this.tp_ticket.Controls.Add(this.label4);
            this.tp_ticket.Location = new System.Drawing.Point(4, 22);
            this.tp_ticket.Name = "tp_ticket";
            this.tp_ticket.Size = new System.Drawing.Size(767, 399);
            this.tp_ticket.TabIndex = 4;
            this.tp_ticket.Text = "Danh sách đặt vé";
            this.tp_ticket.UseVisualStyleBackColor = true;
            // 
            // btn_huytatca
            // 
            this.btn_huytatca.Location = new System.Drawing.Point(469, 358);
            this.btn_huytatca.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huytatca.Name = "btn_huytatca";
            this.btn_huytatca.Size = new System.Drawing.Size(76, 23);
            this.btn_huytatca.TabIndex = 13;
            this.btn_huytatca.Text = "Hủy tất cả";
            this.btn_huytatca.UseVisualStyleBackColor = true;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(349, 358);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 12;
            this.btn_huy.Text = "Hủy đặt chỗ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_layve
            // 
            this.btn_layve.Location = new System.Drawing.Point(223, 358);
            this.btn_layve.Name = "btn_layve";
            this.btn_layve.Size = new System.Drawing.Size(75, 23);
            this.btn_layve.TabIndex = 11;
            this.btn_layve.Text = "Lấy vé";
            this.btn_layve.UseVisualStyleBackColor = true;
            this.btn_layve.Click += new System.EventHandler(this.btn_layve_Click);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(221, 62);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(58, 15);
            this.lb_timkiem.TabIndex = 10;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // tb_idve
            // 
            this.tb_idve.Location = new System.Drawing.Point(286, 59);
            this.tb_idve.Name = "tb_idve";
            this.tb_idve.Size = new System.Drawing.Size(194, 20);
            this.tb_idve.TabIndex = 9;
            this.tb_idve.Text = "Mã vé, CMND, Tên thành viên";
            this.tb_idve.TextChanged += new System.EventHandler(this.tb_idve_TextChanged);
            // 
            // dgv_vedat
            // 
            this.dgv_vedat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vedat.Location = new System.Drawing.Point(43, 102);
            this.dgv_vedat.Name = "dgv_vedat";
            this.dgv_vedat.Size = new System.Drawing.Size(680, 228);
            this.dgv_vedat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(216, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách vé đặt";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachthanhvien)).EndInit();
            this.tp_ticket.ResumeLayout(false);
            this.tp_ticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vedat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_showtimes;
        private System.Windows.Forms.TabPage tp_member;
        private System.Windows.Forms.DataGridView dgv_showtimes;
        private System.Windows.Forms.TabPage tp_ticket;
        private System.Windows.Forms.Button btn_huytatca;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_layve;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tb_idve;
        private System.Windows.Forms.DataGridView dgv_vedat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_suathongtin;
        private System.Windows.Forms.Button btn_themthanhvien;
        private System.Windows.Forms.TextBox tb_timkiemthanhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_timkiemthanhvien;
        private System.Windows.Forms.DataGridView dgv_danhsachthanhvien;
    }
}