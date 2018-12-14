namespace LotteCinema
{
    partial class UpdateFilm
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
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownNamSanXuat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNuocSanXuat = new System.Windows.Forms.TextBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgayCongChieu = new System.Windows.Forms.DateTimePicker();
            this.tbNgayCongChieu = new System.Windows.Forms.TextBox();
            this.lb_startday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDaoDien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTuaPhim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThoiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Sửa Phim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang chiếu",
            "Ngừng chiếu",
            "Sắp chiếu"});
            this.cbTinhTrang.Location = new System.Drawing.Point(111, 223);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(137, 21);
            this.cbTinhTrang.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tình Trạng";
            // 
            // numericUpDownNamSanXuat
            // 
            this.numericUpDownNamSanXuat.Location = new System.Drawing.Point(112, 197);
            this.numericUpDownNamSanXuat.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownNamSanXuat.Name = "numericUpDownNamSanXuat";
            this.numericUpDownNamSanXuat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNamSanXuat.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Năm sản xuất";
            // 
            // tbNuocSanXuat
            // 
            this.tbNuocSanXuat.Location = new System.Drawing.Point(112, 171);
            this.tbNuocSanXuat.Name = "tbNuocSanXuat";
            this.tbNuocSanXuat.Size = new System.Drawing.Size(213, 20);
            this.tbNuocSanXuat.TabIndex = 37;
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
            this.cbTheLoai.Location = new System.Drawing.Point(111, 60);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(137, 21);
            this.cbTheLoai.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nước sản xuất";
            // 
            // numericUpDownThoiLuong
            // 
            this.numericUpDownThoiLuong.Location = new System.Drawing.Point(112, 141);
            this.numericUpDownThoiLuong.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownThoiLuong.Name = "numericUpDownThoiLuong";
            this.numericUpDownThoiLuong.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownThoiLuong.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thời lượng";
            // 
            // dtpkNgayCongChieu
            // 
            this.dtpkNgayCongChieu.Location = new System.Drawing.Point(213, 115);
            this.dtpkNgayCongChieu.Name = "dtpkNgayCongChieu";
            this.dtpkNgayCongChieu.Size = new System.Drawing.Size(19, 20);
            this.dtpkNgayCongChieu.TabIndex = 32;
            this.dtpkNgayCongChieu.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpkNgayCongChieu.ValueChanged += new System.EventHandler(this.dtpkNgayCongChieu_ValueChanged);
            // 
            // tbNgayCongChieu
            // 
            this.tbNgayCongChieu.Location = new System.Drawing.Point(112, 115);
            this.tbNgayCongChieu.Name = "tbNgayCongChieu";
            this.tbNgayCongChieu.Size = new System.Drawing.Size(100, 20);
            this.tbNgayCongChieu.TabIndex = 31;
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(18, 118);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(88, 13);
            this.lb_startday.TabIndex = 30;
            this.lb_startday.Text = "Ngày công chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đạo diễn";
            // 
            // tbDaoDien
            // 
            this.tbDaoDien.Location = new System.Drawing.Point(112, 89);
            this.tbDaoDien.Name = "tbDaoDien";
            this.tbDaoDien.Size = new System.Drawing.Size(213, 20);
            this.tbDaoDien.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tựa phim";
            // 
            // tbTuaPhim
            // 
            this.tbTuaPhim.Location = new System.Drawing.Point(112, 27);
            this.tbTuaPhim.Name = "tbTuaPhim";
            this.tbTuaPhim.Size = new System.Drawing.Size(213, 20);
            this.tbTuaPhim.TabIndex = 25;
            // 
            // UpdateFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 317);
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
            this.Name = "UpdateFilm";
            this.Text = "UpdateFilm";
            this.Load += new System.EventHandler(this.UpdateFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThoiLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownNamSanXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNuocSanXuat;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownThoiLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgayCongChieu;
        private System.Windows.Forms.TextBox tbNgayCongChieu;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDaoDien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTuaPhim;
    }
}