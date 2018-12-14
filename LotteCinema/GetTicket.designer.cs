namespace LotteCinema
{
    partial class GetTicket
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
            this.components = new System.ComponentModel.Container();
            this.lb_thongtinlayve = new System.Windows.Forms.Label();
            this.lb_idve = new System.Windows.Forms.Label();
            this.tb_ttve_tenphim = new System.Windows.Forms.TextBox();
            this.lb_tenphim = new System.Windows.Forms.Label();
            this.tb_ttve_rap = new System.Windows.Forms.TextBox();
            this.lb_rap = new System.Windows.Forms.Label();
            this.tb_ttve_phong = new System.Windows.Forms.TextBox();
            this.lb_phong = new System.Windows.Forms.Label();
            this.tb_ttve_idve = new System.Windows.Forms.TextBox();
            this.tb_ttve_suatchieu = new System.Windows.Forms.TextBox();
            this.lb_suatchieu = new System.Windows.Forms.Label();
            this.tb_ttve_tenthanhvien = new System.Windows.Forms.TextBox();
            this.lb_thanhvien = new System.Windows.Forms.Label();
            this.tb_ttve_mathanhvien = new System.Windows.Forms.TextBox();
            this.lb_mathanhvien = new System.Windows.Forms.Label();
            this.lb_ttve_uudai = new System.Windows.Forms.Label();
            this.cb_uudai = new System.Windows.Forms.ComboBox();
            this.sPLietKeUuDaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new LotteCinema.cinemaDataSet();
            
            this.cinemaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LietKeUuDaiTableAdapter = new LotteCinema.cinemaDataSetTableAdapters.SP_LietKeUuDaiTableAdapter();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btm_thoat = new System.Windows.Forms.Button();
            this.cb_loaive = new System.Windows.Forms.ComboBox();
            this.lb_loaive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sPLietKeUuDaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_thongtinlayve
            // 
            this.lb_thongtinlayve.AutoSize = true;
            this.lb_thongtinlayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinlayve.ForeColor = System.Drawing.Color.Red;
            this.lb_thongtinlayve.Location = new System.Drawing.Point(348, 31);
            this.lb_thongtinlayve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongtinlayve.Name = "lb_thongtinlayve";
            this.lb_thongtinlayve.Size = new System.Drawing.Size(351, 54);
            this.lb_thongtinlayve.TabIndex = 0;
            this.lb_thongtinlayve.Text = "Thông tin lấy vé";
            // 
            // lb_idve
            // 
            this.lb_idve.AutoSize = true;
            this.lb_idve.Location = new System.Drawing.Point(245, 135);
            this.lb_idve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idve.Name = "lb_idve";
            this.lb_idve.Size = new System.Drawing.Size(46, 17);
            this.lb_idve.TabIndex = 1;
            this.lb_idve.Text = "Mã vé";
            // 
            // tb_ttve_tenphim
            // 
            this.tb_ttve_tenphim.Enabled = false;
            this.tb_ttve_tenphim.Location = new System.Drawing.Point(333, 261);
            this.tb_ttve_tenphim.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_tenphim.Name = "tb_ttve_tenphim";
            this.tb_ttve_tenphim.ReadOnly = true;
            this.tb_ttve_tenphim.Size = new System.Drawing.Size(195, 22);
            this.tb_ttve_tenphim.TabIndex = 4;
            // 
            // lb_tenphim
            // 
            this.lb_tenphim.AutoSize = true;
            this.lb_tenphim.Location = new System.Drawing.Point(245, 265);
            this.lb_tenphim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenphim.Name = "lb_tenphim";
            this.lb_tenphim.Size = new System.Drawing.Size(68, 17);
            this.lb_tenphim.TabIndex = 3;
            this.lb_tenphim.Text = "Tên Phim";
            // 
            // tb_ttve_rap
            // 
            this.tb_ttve_rap.Enabled = false;
            this.tb_ttve_rap.Location = new System.Drawing.Point(333, 190);
            this.tb_ttve_rap.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_rap.Name = "tb_ttve_rap";
            this.tb_ttve_rap.ReadOnly = true;
            this.tb_ttve_rap.Size = new System.Drawing.Size(195, 22);
            this.tb_ttve_rap.TabIndex = 6;
            // 
            // lb_rap
            // 
            this.lb_rap.AutoSize = true;
            this.lb_rap.Location = new System.Drawing.Point(245, 193);
            this.lb_rap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rap.Name = "lb_rap";
            this.lb_rap.Size = new System.Drawing.Size(34, 17);
            this.lb_rap.TabIndex = 5;
            this.lb_rap.Text = "Rạp";
            // 
            // tb_ttve_phong
            // 
            this.tb_ttve_phong.Enabled = false;
            this.tb_ttve_phong.Location = new System.Drawing.Point(708, 193);
            this.tb_ttve_phong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_phong.Name = "tb_ttve_phong";
            this.tb_ttve_phong.ReadOnly = true;
            this.tb_ttve_phong.Size = new System.Drawing.Size(132, 22);
            this.tb_ttve_phong.TabIndex = 8;
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Location = new System.Drawing.Point(620, 197);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(49, 17);
            this.lb_phong.TabIndex = 7;
            this.lb_phong.Text = "Phòng";
            // 
            // tb_ttve_idve
            // 
            this.tb_ttve_idve.Enabled = false;
            this.tb_ttve_idve.Location = new System.Drawing.Point(333, 132);
            this.tb_ttve_idve.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_idve.Name = "tb_ttve_idve";
            this.tb_ttve_idve.ReadOnly = true;
            this.tb_ttve_idve.Size = new System.Drawing.Size(195, 22);
            this.tb_ttve_idve.TabIndex = 2;
            // 
            // tb_ttve_suatchieu
            // 
            this.tb_ttve_suatchieu.Enabled = false;
            this.tb_ttve_suatchieu.Location = new System.Drawing.Point(708, 261);
            this.tb_ttve_suatchieu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_suatchieu.Name = "tb_ttve_suatchieu";
            this.tb_ttve_suatchieu.ReadOnly = true;
            this.tb_ttve_suatchieu.Size = new System.Drawing.Size(132, 22);
            this.tb_ttve_suatchieu.TabIndex = 10;
            // 
            // lb_suatchieu
            // 
            this.lb_suatchieu.AutoSize = true;
            this.lb_suatchieu.Location = new System.Drawing.Point(620, 265);
            this.lb_suatchieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_suatchieu.Name = "lb_suatchieu";
            this.lb_suatchieu.Size = new System.Drawing.Size(75, 17);
            this.lb_suatchieu.TabIndex = 9;
            this.lb_suatchieu.Text = "Suất chiếu";
            // 
            // tb_ttve_tenthanhvien
            // 
            this.tb_ttve_tenthanhvien.Enabled = false;
            this.tb_ttve_tenthanhvien.Location = new System.Drawing.Point(333, 335);
            this.tb_ttve_tenthanhvien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_tenthanhvien.Name = "tb_ttve_tenthanhvien";
            this.tb_ttve_tenthanhvien.ReadOnly = true;
            this.tb_ttve_tenthanhvien.Size = new System.Drawing.Size(195, 22);
            this.tb_ttve_tenthanhvien.TabIndex = 12;
            this.tb_ttve_tenthanhvien.TabStop = false;
            // 
            // lb_thanhvien
            // 
            this.lb_thanhvien.AutoSize = true;
            this.lb_thanhvien.Location = new System.Drawing.Point(245, 338);
            this.lb_thanhvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thanhvien.Name = "lb_thanhvien";
            this.lb_thanhvien.Size = new System.Drawing.Size(79, 17);
            this.lb_thanhvien.TabIndex = 11;
            this.lb_thanhvien.Text = "Thành viên";
            // 
            // tb_ttve_mathanhvien
            // 
            this.tb_ttve_mathanhvien.Enabled = false;
            this.tb_ttve_mathanhvien.Location = new System.Drawing.Point(708, 330);
            this.tb_ttve_mathanhvien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ttve_mathanhvien.Name = "tb_ttve_mathanhvien";
            this.tb_ttve_mathanhvien.ReadOnly = true;
            this.tb_ttve_mathanhvien.Size = new System.Drawing.Size(132, 22);
            this.tb_ttve_mathanhvien.TabIndex = 14;
            // 
            // lb_mathanhvien
            // 
            this.lb_mathanhvien.AutoSize = true;
            this.lb_mathanhvien.Location = new System.Drawing.Point(601, 334);
            this.lb_mathanhvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mathanhvien.Name = "lb_mathanhvien";
            this.lb_mathanhvien.Size = new System.Drawing.Size(97, 17);
            this.lb_mathanhvien.TabIndex = 13;
            this.lb_mathanhvien.Text = "Mã thành viên";
            // 
            // lb_ttve_uudai
            // 
            this.lb_ttve_uudai.AutoSize = true;
            this.lb_ttve_uudai.Location = new System.Drawing.Point(263, 414);
            this.lb_ttve_uudai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ttve_uudai.Name = "lb_ttve_uudai";
            this.lb_ttve_uudai.Size = new System.Drawing.Size(49, 17);
            this.lb_ttve_uudai.TabIndex = 16;
            this.lb_ttve_uudai.Text = "Ưu đãi";
            // 
            // cb_uudai
            // 
            this.cb_uudai.AllowDrop = true;
            this.cb_uudai.FormattingEnabled = true;
            this.cb_uudai.Location = new System.Drawing.Point(333, 404);
            this.cb_uudai.Margin = new System.Windows.Forms.Padding(4);
            this.cb_uudai.Name = "cb_uudai";
            this.cb_uudai.Size = new System.Drawing.Size(195, 24);
            this.cb_uudai.TabIndex = 17;
            this.cb_uudai.ValueMember = "iduudai";
            // 
            // sPLietKeUuDaiBindingSource
            // 
            this.sPLietKeUuDaiBindingSource.DataMember = "SP_LietKeUuDai";
            this.sPLietKeUuDaiBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaDataSet1
            // 
             // 
            // cinemaDataSet1BindingSource
            // 
            
            this.cinemaDataSet1BindingSource.Position = 0;
            // 
            // cinemaDataSet1BindingSource1
            // 
  
            this.cinemaDataSet1BindingSource1.Position = 0;
            // 
            // sP_LietKeUuDaiTableAdapter
            // 
            this.sP_LietKeUuDaiTableAdapter.ClearBeforeFill = true;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(385, 478);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(100, 28);
            this.btn_xacnhan.TabIndex = 18;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btm_thoat
            // 
            this.btm_thoat.Location = new System.Drawing.Point(571, 478);
            this.btm_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btm_thoat.Name = "btm_thoat";
            this.btm_thoat.Size = new System.Drawing.Size(100, 28);
            this.btm_thoat.TabIndex = 19;
            this.btm_thoat.Text = "Thoát";
            this.btm_thoat.UseVisualStyleBackColor = true;
            this.btm_thoat.Click += new System.EventHandler(this.btm_thoat_Click);
            // 
            // cb_loaive
            // 
            this.cb_loaive.DataSource = this.sPLietKeUuDaiBindingSource;
            this.cb_loaive.DisplayMember = "iduudai";
            this.cb_loaive.FormattingEnabled = true;
            this.cb_loaive.Location = new System.Drawing.Point(645, 404);
            this.cb_loaive.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loaive.Name = "cb_loaive";
            this.cb_loaive.Size = new System.Drawing.Size(195, 24);
            this.cb_loaive.TabIndex = 21;
            // 
            // lb_loaive
            // 
            this.lb_loaive.AutoSize = true;
            this.lb_loaive.Location = new System.Drawing.Point(575, 414);
            this.lb_loaive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaive.Name = "lb_loaive";
            this.lb_loaive.Size = new System.Drawing.Size(54, 17);
            this.lb_loaive.TabIndex = 20;
            this.lb_loaive.Text = "Loại vé";
            // 
            // GetTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cb_loaive);
            this.Controls.Add(this.lb_loaive);
            this.Controls.Add(this.btm_thoat);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.cb_uudai);
            this.Controls.Add(this.lb_ttve_uudai);
            this.Controls.Add(this.tb_ttve_mathanhvien);
            this.Controls.Add(this.lb_mathanhvien);
            this.Controls.Add(this.tb_ttve_tenthanhvien);
            this.Controls.Add(this.lb_thanhvien);
            this.Controls.Add(this.tb_ttve_suatchieu);
            this.Controls.Add(this.lb_suatchieu);
            this.Controls.Add(this.tb_ttve_phong);
            this.Controls.Add(this.lb_phong);
            this.Controls.Add(this.tb_ttve_rap);
            this.Controls.Add(this.lb_rap);
            this.Controls.Add(this.tb_ttve_tenphim);
            this.Controls.Add(this.lb_tenphim);
            this.Controls.Add(this.tb_ttve_idve);
            this.Controls.Add(this.lb_idve);
            this.Controls.Add(this.lb_thongtinlayve);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GetTicket";
            this.Text = "GetTicket";
            this.Load += new System.EventHandler(this.GetTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPLietKeUuDaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongtinlayve;
        private System.Windows.Forms.Label lb_idve;
        private System.Windows.Forms.TextBox tb_ttve_tenphim;
        private System.Windows.Forms.Label lb_tenphim;
        private System.Windows.Forms.TextBox tb_ttve_rap;
        private System.Windows.Forms.Label lb_rap;
        private System.Windows.Forms.TextBox tb_ttve_phong;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.TextBox tb_ttve_idve;
        private System.Windows.Forms.TextBox tb_ttve_suatchieu;
        private System.Windows.Forms.Label lb_suatchieu;
        private System.Windows.Forms.Label lb_thanhvien;
        private System.Windows.Forms.TextBox tb_ttve_mathanhvien;
        private System.Windows.Forms.Label lb_mathanhvien;
        private System.Windows.Forms.Label lb_ttve_uudai;
        private System.Windows.Forms.ComboBox cb_uudai;
        private System.Windows.Forms.BindingSource cinemaDataSet1BindingSource;
   
        private System.Windows.Forms.BindingSource cinemaDataSet1BindingSource1;
        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource sPLietKeUuDaiBindingSource;
        private cinemaDataSetTableAdapters.SP_LietKeUuDaiTableAdapter sP_LietKeUuDaiTableAdapter;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btm_thoat;
        private System.Windows.Forms.ComboBox cb_loaive;
        private System.Windows.Forms.Label lb_loaive;
        private System.Windows.Forms.TextBox tb_ttve_tenthanhvien;
    }
}