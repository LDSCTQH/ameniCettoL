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
            this.btn_deleteFilm = new System.Windows.Forms.Button();
            this.btn_updateFilm = new System.Windows.Forms.Button();
            this.btn_insertFilm = new System.Windows.Forms.Button();
            this.btn_insertShowtime = new System.Windows.Forms.Button();
            this.btn_updateShowtime = new System.Windows.Forms.Button();
            this.btn_deleteShowtime = new System.Windows.Forms.Button();
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
            this.tp_film.Controls.Add(this.btn_insertFilm);
            this.tp_film.Controls.Add(this.btn_updateFilm);
            this.tp_film.Controls.Add(this.btn_deleteFilm);
            this.tp_film.Controls.Add(this.dgv_film);
            this.tp_film.Location = new System.Drawing.Point(4, 22);
            this.tp_film.Name = "tp_film";
            this.tp_film.Padding = new System.Windows.Forms.Padding(3);
            this.tp_film.Size = new System.Drawing.Size(767, 399);
            this.tp_film.TabIndex = 0;
            this.tp_film.Text = "Phim";
            this.tp_film.UseVisualStyleBackColor = true;
            // 
            // dgv_film
            // 
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_film.Location = new System.Drawing.Point(29, 23);
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.Size = new System.Drawing.Size(704, 293);
            this.dgv_film.TabIndex = 0;
            // 
            // tp_showtimes
            // 
            this.tp_showtimes.Controls.Add(this.btn_insertShowtime);
            this.tp_showtimes.Controls.Add(this.btn_updateShowtime);
            this.tp_showtimes.Controls.Add(this.btn_deleteShowtime);
            this.tp_showtimes.Controls.Add(this.dgv_showtime);
            this.tp_showtimes.Location = new System.Drawing.Point(4, 22);
            this.tp_showtimes.Name = "tp_showtimes";
            this.tp_showtimes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_showtimes.Size = new System.Drawing.Size(767, 399);
            this.tp_showtimes.TabIndex = 1;
            this.tp_showtimes.Text = "Lịch chiếu";
            this.tp_showtimes.UseVisualStyleBackColor = true;
            // 
            // dgv_showtime
            // 
            this.dgv_showtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showtime.Location = new System.Drawing.Point(32, 38);
            this.dgv_showtime.Name = "dgv_showtime";
            this.dgv_showtime.Size = new System.Drawing.Size(704, 280);
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
            this.gb_statistic.Controls.Add(this.btn_statistic);
            this.gb_statistic.Controls.Add(this.dtpk_dateTo);
            this.gb_statistic.Controls.Add(this.dtpk_dateFrom);
            this.gb_statistic.Controls.Add(this.tb_dateTo);
            this.gb_statistic.Controls.Add(this.tb_dateFrom);
            this.gb_statistic.Controls.Add(this.lb_endday);
            this.gb_statistic.Controls.Add(this.lb_startday);
            this.gb_statistic.Controls.Add(this.lb_film);
            this.gb_statistic.Controls.Add(this.cb_film);
            this.gb_statistic.Location = new System.Drawing.Point(15, 65);
            this.gb_statistic.Name = "gb_statistic";
            this.gb_statistic.Size = new System.Drawing.Size(312, 282);
            this.gb_statistic.TabIndex = 4;
            this.gb_statistic.TabStop = false;
            this.gb_statistic.Text = "Thống kê";
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(111, 237);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(96, 23);
            this.btn_statistic.TabIndex = 12;
            this.btn_statistic.Text = "Thống kê";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // dtpk_dateTo
            // 
            this.dtpk_dateTo.Location = new System.Drawing.Point(247, 198);
            this.dtpk_dateTo.Name = "dtpk_dateTo";
            this.dtpk_dateTo.Size = new System.Drawing.Size(19, 20);
            this.dtpk_dateTo.TabIndex = 11;
            this.dtpk_dateTo.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpk_dateTo.ValueChanged += new System.EventHandler(this.dtpk_dateTo_ValueChanged);
            // 
            // dtpk_dateFrom
            // 
            this.dtpk_dateFrom.Location = new System.Drawing.Point(247, 148);
            this.dtpk_dateFrom.Name = "dtpk_dateFrom";
            this.dtpk_dateFrom.Size = new System.Drawing.Size(19, 20);
            this.dtpk_dateFrom.TabIndex = 10;
            this.dtpk_dateFrom.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpk_dateFrom.ValueChanged += new System.EventHandler(this.dtpk_dateFrom_ValueChanged);
            // 
            // tb_dateTo
            // 
            this.tb_dateTo.Location = new System.Drawing.Point(145, 198);
            this.tb_dateTo.Name = "tb_dateTo";
            this.tb_dateTo.Size = new System.Drawing.Size(100, 20);
            this.tb_dateTo.TabIndex = 9;
            // 
            // tb_dateFrom
            // 
            this.tb_dateFrom.Location = new System.Drawing.Point(145, 148);
            this.tb_dateFrom.Name = "tb_dateFrom";
            this.tb_dateFrom.Size = new System.Drawing.Size(100, 20);
            this.tb_dateFrom.TabIndex = 8;
            // 
            // lb_endday
            // 
            this.lb_endday.AutoSize = true;
            this.lb_endday.Location = new System.Drawing.Point(40, 201);
            this.lb_endday.Name = "lb_endday";
            this.lb_endday.Size = new System.Drawing.Size(74, 13);
            this.lb_endday.TabIndex = 7;
            this.lb_endday.Text = "Ngày kết thúc";
            // 
            // lb_startday
            // 
            this.lb_startday.AutoSize = true;
            this.lb_startday.Location = new System.Drawing.Point(40, 151);
            this.lb_startday.Name = "lb_startday";
            this.lb_startday.Size = new System.Drawing.Size(72, 13);
            this.lb_startday.TabIndex = 6;
            this.lb_startday.Text = "Ngày bắt đầu";
            // 
            // lb_film
            // 
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(40, 101);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(30, 13);
            this.lb_film.TabIndex = 5;
            this.lb_film.Text = "Phim";
            // 
            // cb_film
            // 
            this.cb_film.FormattingEnabled = true;
            this.cb_film.Location = new System.Drawing.Point(145, 98);
            this.cb_film.Name = "cb_film";
            this.cb_film.Size = new System.Drawing.Size(121, 21);
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
            // btn_deleteFilm
            // 
            this.btn_deleteFilm.Location = new System.Drawing.Point(190, 339);
            this.btn_deleteFilm.Name = "btn_deleteFilm";
            this.btn_deleteFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteFilm.TabIndex = 1;
            this.btn_deleteFilm.Text = "Delete";
            this.btn_deleteFilm.UseVisualStyleBackColor = true;
            // 
            // btn_updateFilm
            // 
            this.btn_updateFilm.Location = new System.Drawing.Point(338, 339);
            this.btn_updateFilm.Name = "btn_updateFilm";
            this.btn_updateFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_updateFilm.TabIndex = 2;
            this.btn_updateFilm.Text = "Update";
            this.btn_updateFilm.UseVisualStyleBackColor = true;
            // 
            // btn_insertFilm
            // 
            this.btn_insertFilm.Location = new System.Drawing.Point(487, 339);
            this.btn_insertFilm.Name = "btn_insertFilm";
            this.btn_insertFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_insertFilm.TabIndex = 3;
            this.btn_insertFilm.Text = "Insert";
            this.btn_insertFilm.UseVisualStyleBackColor = true;
            // 
            // btn_insertShowtime
            // 
            this.btn_insertShowtime.Location = new System.Drawing.Point(491, 348);
            this.btn_insertShowtime.Name = "btn_insertShowtime";
            this.btn_insertShowtime.Size = new System.Drawing.Size(75, 23);
            this.btn_insertShowtime.TabIndex = 6;
            this.btn_insertShowtime.Text = "Insert";
            this.btn_insertShowtime.UseVisualStyleBackColor = true;
            // 
            // btn_updateShowtime
            // 
            this.btn_updateShowtime.Location = new System.Drawing.Point(342, 348);
            this.btn_updateShowtime.Name = "btn_updateShowtime";
            this.btn_updateShowtime.Size = new System.Drawing.Size(75, 23);
            this.btn_updateShowtime.TabIndex = 5;
            this.btn_updateShowtime.Text = "Update";
            this.btn_updateShowtime.UseVisualStyleBackColor = true;
            // 
            // btn_deleteShowtime
            // 
            this.btn_deleteShowtime.Location = new System.Drawing.Point(194, 348);
            this.btn_deleteShowtime.Name = "btn_deleteShowtime";
            this.btn_deleteShowtime.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteShowtime.TabIndex = 4;
            this.btn_deleteShowtime.Text = "Delete";
            this.btn_deleteShowtime.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox cb_film;
        private System.Windows.Forms.DataGridView dgv_statistic;
        private System.Windows.Forms.DateTimePicker dtpk_dateTo;
        private System.Windows.Forms.DateTimePicker dtpk_dateFrom;
        private System.Windows.Forms.TextBox tb_dateTo;
        private System.Windows.Forms.TextBox tb_dateFrom;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_insertFilm;
        private System.Windows.Forms.Button btn_updateFilm;
        private System.Windows.Forms.Button btn_deleteFilm;
        private System.Windows.Forms.Button btn_insertShowtime;
        private System.Windows.Forms.Button btn_updateShowtime;
        private System.Windows.Forms.Button btn_deleteShowtime;
    }
}