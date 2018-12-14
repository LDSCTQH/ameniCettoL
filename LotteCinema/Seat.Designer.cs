namespace LotteCinema
{
    partial class fBuyBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.lb_cinema = new System.Windows.Forms.Label();
            this.lb_room = new System.Windows.Forms.Label();
            this.lb_film = new System.Windows.Forms.Label();
            this.tb_identity = new System.Windows.Forms.TextBox();
            this.groupBoxUuDai = new System.Windows.Forms.GroupBox();
            this.rb_noEndow = new System.Windows.Forms.RadioButton();
            this.rb_birthday = new System.Windows.Forms.RadioButton();
            this.rb_giasoc = new System.Windows.Forms.RadioButton();
            this.rb_monday = new System.Windows.Forms.RadioButton();
            this.groupBoxLoaiVe = new System.Windows.Forms.GroupBox();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.rb_child = new System.Windows.Forms.RadioButton();
            this.rb_adult = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_seat = new System.Windows.Forms.DataGridView();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxUuDai.SuspendLayout();
            this.groupBoxLoaiVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_book);
            this.panel1.Controls.Add(this.btn_buy);
            this.panel1.Location = new System.Drawing.Point(552, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 46);
            this.panel1.TabIndex = 0;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(125, 13);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 23);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Đặt vé";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(16, 13);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 0;
            this.btn_buy.Text = "Mua vé";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // lb_cinema
            // 
            this.lb_cinema.AutoSize = true;
            this.lb_cinema.Location = new System.Drawing.Point(32, 23);
            this.lb_cinema.Name = "lb_cinema";
            this.lb_cinema.Size = new System.Drawing.Size(30, 13);
            this.lb_cinema.TabIndex = 1;
            this.lb_cinema.Text = "Rạp:";
            // 
            // lb_room
            // 
            this.lb_room.AutoSize = true;
            this.lb_room.Location = new System.Drawing.Point(151, 23);
            this.lb_room.Name = "lb_room";
            this.lb_room.Size = new System.Drawing.Size(41, 13);
            this.lb_room.TabIndex = 2;
            this.lb_room.Text = "Phòng:";
            // 
            // lb_film
            // 
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(298, 23);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(33, 13);
            this.lb_film.TabIndex = 6;
            this.lb_film.Text = "Phim:";
            // 
            // tb_identity
            // 
            this.tb_identity.Location = new System.Drawing.Point(602, 331);
            this.tb_identity.Name = "tb_identity";
            this.tb_identity.Size = new System.Drawing.Size(155, 20);
            this.tb_identity.TabIndex = 9;
            // 
            // groupBoxUuDai
            // 
            this.groupBoxUuDai.Controls.Add(this.rb_noEndow);
            this.groupBoxUuDai.Controls.Add(this.rb_birthday);
            this.groupBoxUuDai.Controls.Add(this.rb_giasoc);
            this.groupBoxUuDai.Controls.Add(this.rb_monday);
            this.groupBoxUuDai.Location = new System.Drawing.Point(557, 34);
            this.groupBoxUuDai.Name = "groupBoxUuDai";
            this.groupBoxUuDai.Size = new System.Drawing.Size(200, 129);
            this.groupBoxUuDai.TabIndex = 0;
            this.groupBoxUuDai.TabStop = false;
            this.groupBoxUuDai.Text = "Ưu đãi";
            // 
            // rb_noEndow
            // 
            this.rb_noEndow.AutoSize = true;
            this.rb_noEndow.Checked = true;
            this.rb_noEndow.Location = new System.Drawing.Point(60, 94);
            this.rb_noEndow.Name = "rb_noEndow";
            this.rb_noEndow.Size = new System.Drawing.Size(56, 17);
            this.rb_noEndow.TabIndex = 3;
            this.rb_noEndow.TabStop = true;
            this.rb_noEndow.Text = "Không";
            this.rb_noEndow.UseVisualStyleBackColor = true;
            // 
            // rb_birthday
            // 
            this.rb_birthday.AutoSize = true;
            this.rb_birthday.Location = new System.Drawing.Point(60, 69);
            this.rb_birthday.Name = "rb_birthday";
            this.rb_birthday.Size = new System.Drawing.Size(70, 17);
            this.rb_birthday.TabIndex = 2;
            this.rb_birthday.TabStop = true;
            this.rb_birthday.Text = "Sinh nhật";
            this.rb_birthday.UseVisualStyleBackColor = true;
            // 
            // rb_giasoc
            // 
            this.rb_giasoc.AutoSize = true;
            this.rb_giasoc.Location = new System.Drawing.Point(60, 44);
            this.rb_giasoc.Name = "rb_giasoc";
            this.rb_giasoc.Size = new System.Drawing.Size(61, 17);
            this.rb_giasoc.TabIndex = 1;
            this.rb_giasoc.TabStop = true;
            this.rb_giasoc.Text = "Giá sốc";
            this.rb_giasoc.UseVisualStyleBackColor = true;
            // 
            // rb_monday
            // 
            this.rb_monday.AutoSize = true;
            this.rb_monday.Location = new System.Drawing.Point(60, 19);
            this.rb_monday.Name = "rb_monday";
            this.rb_monday.Size = new System.Drawing.Size(61, 17);
            this.rb_monday.TabIndex = 0;
            this.rb_monday.TabStop = true;
            this.rb_monday.Text = "Thứ hai";
            this.rb_monday.UseVisualStyleBackColor = true;
            // 
            // groupBoxLoaiVe
            // 
            this.groupBoxLoaiVe.Controls.Add(this.rb_student);
            this.groupBoxLoaiVe.Controls.Add(this.rb_child);
            this.groupBoxLoaiVe.Controls.Add(this.rb_adult);
            this.groupBoxLoaiVe.Location = new System.Drawing.Point(557, 184);
            this.groupBoxLoaiVe.Name = "groupBoxLoaiVe";
            this.groupBoxLoaiVe.Size = new System.Drawing.Size(200, 102);
            this.groupBoxLoaiVe.TabIndex = 1;
            this.groupBoxLoaiVe.TabStop = false;
            this.groupBoxLoaiVe.Text = "Loại vé";
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(60, 68);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(67, 17);
            this.rb_student.TabIndex = 2;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Học sinh";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // rb_child
            // 
            this.rb_child.AutoSize = true;
            this.rb_child.Location = new System.Drawing.Point(60, 44);
            this.rb_child.Name = "rb_child";
            this.rb_child.Size = new System.Drawing.Size(58, 17);
            this.rb_child.TabIndex = 1;
            this.rb_child.TabStop = true;
            this.rb_child.Text = "Trẻ em";
            this.rb_child.UseVisualStyleBackColor = true;
            // 
            // rb_adult
            // 
            this.rb_adult.AutoSize = true;
            this.rb_adult.Checked = true;
            this.rb_adult.Location = new System.Drawing.Point(60, 20);
            this.rb_adult.Name = "rb_adult";
            this.rb_adult.Size = new System.Drawing.Size(70, 17);
            this.rb_adult.TabIndex = 0;
            this.rb_adult.TabStop = true;
            this.rb_adult.Text = "Người lớn";
            this.rb_adult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CMND:";
            // 
            // dgv_seat
            // 
            this.dgv_seat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seat.Location = new System.Drawing.Point(35, 63);
            this.dgv_seat.Name = "dgv_seat";
            this.dgv_seat.Size = new System.Drawing.Size(486, 355);
            this.dgv_seat.TabIndex = 11;
            this.dgv_seat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seat_CellClick);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(602, 295);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(155, 20);
            this.tb_price.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giá vé";
            // 
            // fBuyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.dgv_seat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxLoaiVe);
            this.Controls.Add(this.groupBoxUuDai);
            this.Controls.Add(this.tb_identity);
            this.Controls.Add(this.lb_film);
            this.Controls.Add(this.lb_room);
            this.Controls.Add(this.lb_cinema);
            this.Controls.Add(this.panel1);
            this.Name = "fBuyBooking";
            this.Text = "Mua/đặt vé";
            this.Load += new System.EventHandler(this.fBuyBooking_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxUuDai.ResumeLayout(false);
            this.groupBoxUuDai.PerformLayout();
            this.groupBoxLoaiVe.ResumeLayout(false);
            this.groupBoxLoaiVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label lb_cinema;
        private System.Windows.Forms.Label lb_room;
        private System.Windows.Forms.Label lb_film;
        private System.Windows.Forms.TextBox tb_identity;
        private System.Windows.Forms.GroupBox groupBoxUuDai;
        private System.Windows.Forms.GroupBox groupBoxLoaiVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_birthday;
        private System.Windows.Forms.RadioButton rb_giasoc;
        private System.Windows.Forms.RadioButton rb_monday;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.RadioButton rb_child;
        private System.Windows.Forms.RadioButton rb_adult;
        private System.Windows.Forms.DataGridView dgv_seat;
        private System.Windows.Forms.RadioButton rb_noEndow;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}