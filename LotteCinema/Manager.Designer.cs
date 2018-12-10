namespace LotteCinema
{
    partial class fManager
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
            this.tapControl1 = new System.Windows.Forms.TabControl();
            this.tp_film = new System.Windows.Forms.TabPage();
            this.dgv_film = new System.Windows.Forms.DataGridView();
            this.tp_showtimes = new System.Windows.Forms.TabPage();
            this.dgv_showtime = new System.Windows.Forms.DataGridView();
            this.tp_statistic = new System.Windows.Forms.TabPage();
            this.dgv_statistic = new System.Windows.Forms.DataGridView();
            this.gb_statistic = new System.Windows.Forms.GroupBox();
            this.lb_endday = new System.Windows.Forms.Label();
            this.lb_startday = new System.Windows.Forms.Label();
            this.lb_film = new System.Windows.Forms.Label();
            this.lb_cinema = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cinemaDataSet = new LotteCinema.cinemaDataSet();
            this.cinemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapControl1.SuspendLayout();
            this.tp_film.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).BeginInit();
            this.tp_showtimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showtime)).BeginInit();
            this.tp_statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistic)).BeginInit();
            this.gb_statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tapControl1
            // 
            this.tapControl1.Controls.Add(this.tp_film);
            this.tapControl1.Controls.Add(this.tp_showtimes);
            this.tapControl1.Controls.Add(this.tp_statistic);
            this.tapControl1.Location = new System.Drawing.Point(13, 13);
            this.tapControl1.Name = "tapControl1";
            this.tapControl1.SelectedIndex = 0;
            this.tapControl1.Size = new System.Drawing.Size(775, 425);
            this.tapControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tapControl1.TabIndex = 0;
            // 
            // tp_film
            // 
            this.tp_film.Controls.Add(this.dgv_film);
            this.tp_film.Location = new System.Drawing.Point(4, 22);
            this.tp_film.Name = "tp_film";
            this.tp_film.Padding = new System.Windows.Forms.Padding(3);
            this.tp_film.Size = new System.Drawing.Size(767, 399);
            this.tp_film.TabIndex = 0;
            this.tp_film.Text = "Phim";
            this.tp_film.UseVisualStyleBackColor = true;
            this.tp_film.Click += new System.EventHandler(this.tp_film_Click);
            // 
            // dgv_film
            // 
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_film.Location = new System.Drawing.Point(29, 48);
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.Size = new System.Drawing.Size(704, 320);
            this.dgv_film.TabIndex = 0;
            // 
            // tp_showtimes
            // 
            this.tp_showtimes.Controls.Add(this.dgv_showtime);
            this.tp_showtimes.Location = new System.Drawing.Point(4, 22);
            this.tp_showtimes.Name = "tp_showtimes";
            this.tp_showtimes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_showtimes.Size = new System.Drawing.Size(767, 399);
            this.tp_showtimes.TabIndex = 1;
            this.tp_showtimes.Text = "Lịch chiếu";
            this.tp_showtimes.UseVisualStyleBackColor = true;
            this.tp_showtimes.Click += new System.EventHandler(this.tp_showtimes_Click);
            // 
            // dgv_showtime
            // 
            this.dgv_showtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showtime.Location = new System.Drawing.Point(32, 38);
            this.dgv_showtime.Name = "dgv_showtime";
            this.dgv_showtime.Size = new System.Drawing.Size(704, 338);
            this.dgv_showtime.TabIndex = 0;
            // 
            // tp_statistic
            // 
            this.tp_statistic.Controls.Add(this.dgv_statistic);
            this.tp_statistic.Controls.Add(this.gb_statistic);
            this.tp_statistic.Location = new System.Drawing.Point(4, 22);
            this.tp_statistic.Name = "tp_statistic";
            this.tp_statistic.Size = new System.Drawing.Size(767, 399);
            this.tp_statistic.TabIndex = 2;
            this.tp_statistic.Text = "Thống kê";
            this.tp_statistic.UseVisualStyleBackColor = true;
            // 
            // dgv_statistic
            // 
            this.dgv_statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_statistic.Location = new System.Drawing.Point(355, 30);
            this.dgv_statistic.Name = "dgv_statistic";
            this.dgv_statistic.Size = new System.Drawing.Size(389, 343);
            this.dgv_statistic.TabIndex = 5;
            // 
            // gb_statistic
            // 
            this.gb_statistic.Controls.Add(this.lb_endday);
            this.gb_statistic.Controls.Add(this.lb_startday);
            this.gb_statistic.Controls.Add(this.lb_film);
            this.gb_statistic.Controls.Add(this.lb_cinema);
            this.gb_statistic.Controls.Add(this.comboBox4);
            this.gb_statistic.Controls.Add(this.comboBox3);
            this.gb_statistic.Controls.Add(this.comboBox1);
            this.gb_statistic.Controls.Add(this.comboBox2);
            this.gb_statistic.Location = new System.Drawing.Point(15, 65);
            this.gb_statistic.Name = "gb_statistic";
            this.gb_statistic.Size = new System.Drawing.Size(312, 282);
            this.gb_statistic.TabIndex = 4;
            this.gb_statistic.TabStop = false;
            this.gb_statistic.Text = "Thống kê";
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(17, 200);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(74, 13);
            this.lb_endday.TabIndex = 7;
            this.lb_endday.Text = "Ngày kết thúc";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(17, 150);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(72, 13);
            this.lb_startday.TabIndex = 6;
            this.lb_startday.Text = "Ngày bắt đầu";
            // 
            // lb_film
            // 
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(17, 100);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(30, 13);
            this.lb_film.TabIndex = 5;
            this.lb_film.Text = "Phim";
            // 
            // lb_cinema
            // 
            this.lb_cinema.AutoSize = true;
            this.lb_cinema.Location = new System.Drawing.Point(17, 50);
            this.lb_cinema.Name = "lb_cinema";
            this.lb_cinema.Size = new System.Drawing.Size(27, 13);
            this.lb_cinema.TabIndex = 4;
            this.lb_cinema.Text = "Rạp";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(122, 197);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(122, 147);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "cinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaDataSetBindingSource
            // 
            this.cinemaDataSetBindingSource.DataSource = this.cinemaDataSet;
            this.cinemaDataSetBindingSource.Position = 0;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tapControl1);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.fManager_Load);
            this.tapControl1.ResumeLayout(false);
            this.tp_film.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).EndInit();
            this.tp_showtimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showtime)).EndInit();
            this.tp_statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistic)).EndInit();
            this.gb_statistic.ResumeLayout(false);
            this.gb_statistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tapControl1;
        private System.Windows.Forms.TabPage tp_film;
        private System.Windows.Forms.DataGridView dgv_film;
        private System.Windows.Forms.TabPage tp_showtimes;
        private System.Windows.Forms.TabPage tp_statistic;
        private System.Windows.Forms.DataGridView dgv_showtime;
        private cinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource cinemaDataSetBindingSource;
        private System.Windows.Forms.GroupBox gb_statistic;
        private System.Windows.Forms.Label lb_endday;
        private System.Windows.Forms.Label lb_startday;
        private System.Windows.Forms.Label lb_film;
        private System.Windows.Forms.Label lb_cinema;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgv_statistic;
    }
}