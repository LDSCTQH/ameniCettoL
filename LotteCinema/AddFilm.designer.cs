namespace LotteCinema
{
    partial class AddFilm
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
            this.tbTuaPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDaoDien = new System.Windows.Forms.TextBox();
            this.dtpkNgayCongChieu = new System.Windows.Forms.DateTimePicker();
            this.tbNgayCongChieu = new System.Windows.Forms.TextBox();
            this.lb_startday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.tbNuocSanXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNamSanXuat = new System.Windows.Forms.NumericUpDown();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThoiLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTuaPhim
            // 
            this.tbTuaPhim.Location = new System.Drawing.Point(97, 56);
            this.tbTuaPhim.Name = "tbTuaPhim";
            this.tbTuaPhim.Size = new System.Drawing.Size(213, 20);
            this.tbTuaPhim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tựa phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đạo diễn";
            // 
            // tbDaoDien
            // 
            this.tbDaoDien.Location = new System.Drawing.Point(97, 118);
            this.tbDaoDien.Name = "tbDaoDien";
            this.tbDaoDien.Size = new System.Drawing.Size(213, 20);
            this.tbDaoDien.TabIndex = 4;
            // 
            // dtpkNgayCongChieu
            // 
            this.dtpkNgayCongChieu.Location = new System.Drawing.Point(198, 144);
            this.dtpkNgayCongChieu.Name = "dtpkNgayCongChieu";
            this.dtpkNgayCongChieu.Size = new System.Drawing.Size(19, 20);
            this.dtpkNgayCongChieu.TabIndex = 13;
            this.dtpkNgayCongChieu.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpkNgayCongChieu.ValueChanged += new System.EventHandler(this.dtpkNgayCongChieu_ValueChanged);
            // 
            // tbNgayCongChieu
            // 
            this.tbNgayCongChieu.Location = new System.Drawing.Point(97, 144);
            this.tbNgayCongChieu.Name = "tbNgayCongChieu";
            this.tbNgayCongChieu.Size = new System.Drawing.Size(100, 20);
            this.tbNgayCongChieu.TabIndex = 12;
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(3, 147);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(88, 13);
            this.lb_startday.TabIndex = 11;
            this.lb_startday.Text = "Ngày công chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thời lượng";
            // 
            // numericUpDownThoiLuong
            // 
            this.numericUpDownThoiLuong.Location = new System.Drawing.Point(97, 170);
            this.numericUpDownThoiLuong.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numericUpDownThoiLuong.Name = "numericUpDownThoiLuong";
            this.numericUpDownThoiLuong.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownThoiLuong.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nước sản xuất";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Học đường",
            "Tình cảm",
            "Hành động",
            "Dã sử",
            "Viễn tưởng"});
            this.cbTheLoai.Location = new System.Drawing.Point(96, 89);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(137, 21);
            this.cbTheLoai.TabIndex = 18;
            // 
            // tbNuocSanXuat
            // 
            this.tbNuocSanXuat.Location = new System.Drawing.Point(97, 200);
            this.tbNuocSanXuat.Name = "tbNuocSanXuat";
            this.tbNuocSanXuat.Size = new System.Drawing.Size(213, 20);
            this.tbNuocSanXuat.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Năm sản xuất";
            // 
            // numericUpDownNamSanXuat
            // 
            this.numericUpDownNamSanXuat.Location = new System.Drawing.Point(97, 226);
            this.numericUpDownNamSanXuat.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownNamSanXuat.Name = "numericUpDownNamSanXuat";
            this.numericUpDownNamSanXuat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNamSanXuat.TabIndex = 21;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang chiếu",
            "Ngừng chiếu",
            "Sắp chiếu"});
            this.cbTinhTrang.Location = new System.Drawing.Point(96, 252);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(137, 21);
            this.cbTinhTrang.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tình Trạng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm Phim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownNamSanXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNuocSanXuat);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownThoiLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpkNgayCongChieu);
            this.Controls.Add(this.tbNgayCongChieu);
            this.Controls.Add(this.lb_startday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDaoDien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuaPhim);
            this.Name = "AddFilm";
            this.Text = "AddFilm";
            this.Load += new System.EventHandler(this.AddFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThoiLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSanXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTuaPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDaoDien;
        private System.Windows.Forms.DateTimePicker dtpkNgayCongChieu;
        private System.Windows.Forms.TextBox tbNgayCongChieu;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownThoiLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.TextBox tbNuocSanXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNamSanXuat;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}