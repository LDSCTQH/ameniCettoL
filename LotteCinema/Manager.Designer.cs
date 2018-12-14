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
            this.buttonReFreshPhim = new System.Windows.Forms.Button();
            this.btn_insertFilm = new System.Windows.Forms.Button();
            this.btn_updateFilm = new System.Windows.Forms.Button();
            this.dgv_film = new System.Windows.Forms.DataGridView();
            this.tp_showtimes = new System.Windows.Forms.TabPage();
            this.buttonRefreshLichChieu = new System.Windows.Forms.Button();
            this.btn_insertShowtime = new System.Windows.Forms.Button();
            this.btn_updateShowtime = new System.Windows.Forms.Button();
            this.btn_deleteShowtime = new System.Windows.Forms.Button();
            this.dgv_showtime = new System.Windows.Forms.DataGridView();
            this.tp_statistic = new System.Windows.Forms.TabPage();
            this.dgv_statistic = new System.Windows.Forms.DataGridView();
            this.gb_statistic = new System.Windows.Forms.GroupBox();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.dtpk_dateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpk_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.tb_dateTo = new System.Windows.Forms.TextBox();
            this.tb_dateFrom = new System.Windows.Forms.TextBox();
            this.lb_endday = new System.Windows.Forms.Label();
            this.lb_startday = new System.Windows.Forms.Label();
            this.lb_film = new System.Windows.Forms.Label();
            this.cb_film = new System.Windows.Forms.ComboBox();
            this.cinemaDataSet = new LotteCinema.cinemaDataSet();
            this.cinemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbThongKeChonTatCA = new System.Windows.Forms.CheckBox();
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
            this.tapControl1.Location = new System.Drawing.Point(17, 16);
            this.tapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tapControl1.Name = "tapControl1";
            this.tapControl1.SelectedIndex = 0;
            this.tapControl1.Size = new System.Drawing.Size(1033, 523);
            this.tapControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tapControl1.TabIndex = 0;
            // 
            // tp_film
            // 
            this.tp_film.Controls.Add(this.buttonReFreshPhim);
            this.tp_film.Controls.Add(this.btn_insertFilm);
            this.tp_film.Controls.Add(this.btn_updateFilm);
            this.tp_film.Controls.Add(this.dgv_film);
            this.tp_film.Location = new System.Drawing.Point(4, 25);
            this.tp_film.Margin = new System.Windows.Forms.Padding(4);
            this.tp_film.Name = "tp_film";
            this.tp_film.Padding = new System.Windows.Forms.Padding(4);
            this.tp_film.Size = new System.Drawing.Size(1025, 494);
            this.tp_film.TabIndex = 0;
            this.tp_film.Text = "Phim";
            this.tp_film.UseVisualStyleBackColor = true;
            // 
            // buttonReFreshPhim
            // 
            this.buttonReFreshPhim.Location = new System.Drawing.Point(18, 14);
            this.buttonReFreshPhim.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReFreshPhim.Name = "buttonReFreshPhim";
            this.buttonReFreshPhim.Size = new System.Drawing.Size(100, 28);
            this.buttonReFreshPhim.TabIndex = 4;
            this.buttonReFreshPhim.Text = "Refresh";
            this.buttonReFreshPhim.UseVisualStyleBackColor = true;
            this.buttonReFreshPhim.Click += new System.EventHandler(this.buttonReFreshPhim_Click);
            // 
            // btn_insertFilm
            // 
            this.btn_insertFilm.Location = new System.Drawing.Point(640, 439);
            this.btn_insertFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertFilm.Name = "btn_insertFilm";
            this.btn_insertFilm.Size = new System.Drawing.Size(100, 28);
            this.btn_insertFilm.TabIndex = 3;
            this.btn_insertFilm.Text = "Insert";
            this.btn_insertFilm.UseVisualStyleBackColor = true;
            this.btn_insertFilm.Click += new System.EventHandler(this.btn_insertFilm_Click);
            // 
            // btn_updateFilm
            // 
            this.btn_updateFilm.Location = new System.Drawing.Point(442, 439);
            this.btn_updateFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateFilm.Name = "btn_updateFilm";
            this.btn_updateFilm.Size = new System.Drawing.Size(100, 28);
            this.btn_updateFilm.TabIndex = 2;
            this.btn_updateFilm.Text = "Update";
            this.btn_updateFilm.UseVisualStyleBackColor = true;
            this.btn_updateFilm.Click += new System.EventHandler(this.btn_updateFilm_Click);
            // 
            // dgv_film
            // 
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_film.Location = new System.Drawing.Point(30, 50);
            this.dgv_film.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.Size = new System.Drawing.Size(939, 361);
            this.dgv_film.TabIndex = 0;
            this.dgv_film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_film_CellClick_1);
            // 
            // tp_showtimes
            // 
            this.tp_showtimes.Controls.Add(this.buttonRefreshLichChieu);
            this.tp_showtimes.Controls.Add(this.btn_insertShowtime);
            this.tp_showtimes.Controls.Add(this.btn_updateShowtime);
            this.tp_showtimes.Controls.Add(this.btn_deleteShowtime);
            this.tp_showtimes.Controls.Add(this.dgv_showtime);
            this.tp_showtimes.Location = new System.Drawing.Point(4, 25);
            this.tp_showtimes.Margin = new System.Windows.Forms.Padding(4);
            this.tp_showtimes.Name = "tp_showtimes";
            this.tp_showtimes.Padding = new System.Windows.Forms.Padding(4);
            this.tp_showtimes.Size = new System.Drawing.Size(1025, 494);
            this.tp_showtimes.TabIndex = 1;
            this.tp_showtimes.Text = "Lịch chiếu";
            this.tp_showtimes.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshLichChieu
            // 
            this.buttonRefreshLichChieu.Location = new System.Drawing.Point(8, 8);
            this.buttonRefreshLichChieu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshLichChieu.Name = "buttonRefreshLichChieu";
            this.buttonRefreshLichChieu.Size = new System.Drawing.Size(100, 28);
            this.buttonRefreshLichChieu.TabIndex = 7;
            this.buttonRefreshLichChieu.Text = "Refresh";
            this.buttonRefreshLichChieu.UseVisualStyleBackColor = true;
            this.buttonRefreshLichChieu.Click += new System.EventHandler(this.buttonRefreshLichChieu_Click);
            // 
            // btn_insertShowtime
            // 
            this.btn_insertShowtime.Location = new System.Drawing.Point(655, 428);
            this.btn_insertShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertShowtime.Name = "btn_insertShowtime";
            this.btn_insertShowtime.Size = new System.Drawing.Size(100, 28);
            this.btn_insertShowtime.TabIndex = 6;
            this.btn_insertShowtime.Text = "Insert";
            this.btn_insertShowtime.UseVisualStyleBackColor = true;
            this.btn_insertShowtime.Click += new System.EventHandler(this.btn_insertShowtime_Click);
            // 
            // btn_updateShowtime
            // 
            this.btn_updateShowtime.Location = new System.Drawing.Point(456, 428);
            this.btn_updateShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateShowtime.Name = "btn_updateShowtime";
            this.btn_updateShowtime.Size = new System.Drawing.Size(100, 28);
            this.btn_updateShowtime.TabIndex = 5;
            this.btn_updateShowtime.Text = "Update";
            this.btn_updateShowtime.UseVisualStyleBackColor = true;
            this.btn_updateShowtime.Click += new System.EventHandler(this.btn_updateShowtime_Click);
            // 
            // btn_deleteShowtime
            // 
            this.btn_deleteShowtime.Location = new System.Drawing.Point(259, 428);
            this.btn_deleteShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteShowtime.Name = "btn_deleteShowtime";
            this.btn_deleteShowtime.Size = new System.Drawing.Size(100, 28);
            this.btn_deleteShowtime.TabIndex = 4;
            this.btn_deleteShowtime.Text = "Delete";
            this.btn_deleteShowtime.UseVisualStyleBackColor = true;
            this.btn_deleteShowtime.Click += new System.EventHandler(this.btn_deleteShowtime_Click);
            // 
            // dgv_showtime
            // 
            this.dgv_showtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showtime.Location = new System.Drawing.Point(43, 47);
            this.dgv_showtime.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_showtime.Name = "dgv_showtime";
            this.dgv_showtime.Size = new System.Drawing.Size(939, 345);
            this.dgv_showtime.TabIndex = 0;
            this.dgv_showtime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showtime_CellClick);
            // 
            // tp_statistic
            // 
            this.tp_statistic.Controls.Add(this.dgv_statistic);
            this.tp_statistic.Controls.Add(this.gb_statistic);
            this.tp_statistic.Location = new System.Drawing.Point(4, 25);
            this.tp_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.tp_statistic.Name = "tp_statistic";
            this.tp_statistic.Size = new System.Drawing.Size(1025, 494);
            this.tp_statistic.TabIndex = 2;
            this.tp_statistic.Text = "Thống kê";
            this.tp_statistic.UseVisualStyleBackColor = true;
            // 
            // dgv_statistic
            // 
            this.dgv_statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_statistic.Location = new System.Drawing.Point(473, 37);
            this.dgv_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_statistic.Name = "dgv_statistic";
            this.dgv_statistic.Size = new System.Drawing.Size(519, 422);
            this.dgv_statistic.TabIndex = 5;
            // 
            // gb_statistic
            // 
            this.gb_statistic.Controls.Add(this.cbThongKeChonTatCA);
            this.gb_statistic.Controls.Add(this.btn_statistic);
            this.gb_statistic.Controls.Add(this.dtpk_dateTo);
            this.gb_statistic.Controls.Add(this.dtpk_dateFrom);
            this.gb_statistic.Controls.Add(this.tb_dateTo);
            this.gb_statistic.Controls.Add(this.tb_dateFrom);
            this.gb_statistic.Controls.Add(this.lb_endday);
            this.gb_statistic.Controls.Add(this.lb_startday);
            this.gb_statistic.Controls.Add(this.lb_film);
            this.gb_statistic.Controls.Add(this.cb_film);
            this.gb_statistic.Location = new System.Drawing.Point(20, 80);
            this.gb_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.gb_statistic.Name = "gb_statistic";
            this.gb_statistic.Padding = new System.Windows.Forms.Padding(4);
            this.gb_statistic.Size = new System.Drawing.Size(416, 347);
            this.gb_statistic.TabIndex = 4;
            this.gb_statistic.TabStop = false;
            this.gb_statistic.Text = "Thống kê";
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(148, 292);
            this.btn_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(128, 28);
            this.btn_statistic.TabIndex = 12;
            this.btn_statistic.Text = "Thống kê";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // dtpk_dateTo
            // 
            this.dtpk_dateTo.Location = new System.Drawing.Point(329, 244);
            this.dtpk_dateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpk_dateTo.Name = "dtpk_dateTo";
            this.dtpk_dateTo.Size = new System.Drawing.Size(24, 22);
            this.dtpk_dateTo.TabIndex = 11;
            this.dtpk_dateTo.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpk_dateTo.ValueChanged += new System.EventHandler(this.dtpk_dateTo_ValueChanged);
            // 
            // dtpk_dateFrom
            // 
            this.dtpk_dateFrom.Location = new System.Drawing.Point(329, 182);
            this.dtpk_dateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpk_dateFrom.Name = "dtpk_dateFrom";
            this.dtpk_dateFrom.Size = new System.Drawing.Size(24, 22);
            this.dtpk_dateFrom.TabIndex = 10;
            this.dtpk_dateFrom.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpk_dateFrom.ValueChanged += new System.EventHandler(this.dtpk_dateFrom_ValueChanged);
            // 
            // tb_dateTo
            // 
            this.tb_dateTo.Location = new System.Drawing.Point(193, 244);
            this.tb_dateTo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dateTo.Name = "tb_dateTo";
            this.tb_dateTo.Size = new System.Drawing.Size(132, 22);
            this.tb_dateTo.TabIndex = 9;
            // 
            // tb_dateFrom
            // 
            this.tb_dateFrom.Location = new System.Drawing.Point(193, 182);
            this.tb_dateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dateFrom.Name = "tb_dateFrom";
            this.tb_dateFrom.Size = new System.Drawing.Size(132, 22);
            this.tb_dateFrom.TabIndex = 8;
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(53, 247);
            this.lb_endday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(95, 17);
            this.lb_endday.TabIndex = 7;
            this.lb_endday.Text = "Ngày kết thúc";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(53, 186);
            this.lb_startday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(93, 17);
            this.lb_startday.TabIndex = 6;
            this.lb_startday.Text = "Ngày bắt đầu";
            // 
            // lb_film
            // 
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(53, 124);
            this.lb_film.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(39, 17);
            this.lb_film.TabIndex = 5;
            this.lb_film.Text = "Phim";
            // 
            // cb_film
            // 
            this.cb_film.FormattingEnabled = true;
            this.cb_film.Location = new System.Drawing.Point(193, 121);
            this.cb_film.Margin = new System.Windows.Forms.Padding(4);
            this.cb_film.Name = "cb_film";
            this.cb_film.Size = new System.Drawing.Size(160, 24);
            this.cb_film.TabIndex = 1;
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
            // cbThongKeChonTatCA
            // 
            this.cbThongKeChonTatCA.AutoSize = true;
            this.cbThongKeChonTatCA.Location = new System.Drawing.Point(193, 153);
            this.cbThongKeChonTatCA.Name = "cbThongKeChonTatCA";
            this.cbThongKeChonTatCA.Size = new System.Drawing.Size(109, 21);
            this.cbThongKeChonTatCA.TabIndex = 13;
            this.cbThongKeChonTatCA.Text = "Chọn Tất Cả";
            this.cbThongKeChonTatCA.UseVisualStyleBackColor = true;
            this.cbThongKeChonTatCA.CheckedChanged += new System.EventHandler(this.cbThongKeChonTatCA_CheckedChanged);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tapControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cb_film;
        private System.Windows.Forms.DataGridView dgv_statistic;
        private System.Windows.Forms.DateTimePicker dtpk_dateTo;
        private System.Windows.Forms.DateTimePicker dtpk_dateFrom;
        private System.Windows.Forms.TextBox tb_dateTo;
        private System.Windows.Forms.TextBox tb_dateFrom;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_insertFilm;
        private System.Windows.Forms.Button btn_updateFilm;
        private System.Windows.Forms.Button btn_insertShowtime;
        private System.Windows.Forms.Button btn_updateShowtime;
        private System.Windows.Forms.Button btn_deleteShowtime;
        private System.Windows.Forms.Button buttonReFreshPhim;
        private System.Windows.Forms.Button buttonRefreshLichChieu;
        private System.Windows.Forms.CheckBox cbThongKeChonTatCA;
    }
}