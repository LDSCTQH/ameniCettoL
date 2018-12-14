namespace LotteCinema
{
    partial class UpdateLichChieu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbThoiGianBatDau = new System.Windows.Forms.ComboBox();
            this.tbphim = new System.Windows.Forms.TextBox();
            this.tbidsuatchieu = new System.Windows.Forms.TextBox();
            this.idsuatchieu = new System.Windows.Forms.Label();
            this.dtpk_dateForm = new System.Windows.Forms.DateTimePicker();
            this.tb_dateForm = new System.Windows.Forms.TextBox();
            this.cbdinhdang = new System.Windows.Forms.ComboBox();
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbThoiGianBatDau);
            this.groupBox1.Controls.Add(this.tbphim);
            this.groupBox1.Controls.Add(this.tbidsuatchieu);
            this.groupBox1.Controls.Add(this.idsuatchieu);
            this.groupBox1.Controls.Add(this.dtpk_dateForm);
            this.groupBox1.Controls.Add(this.tb_dateForm);
            this.groupBox1.Controls.Add(this.cbdinhdang);
            this.groupBox1.Controls.Add(this.cbphong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 271);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cbThoiGianBatDau
            // 
            this.cbThoiGianBatDau.FormattingEnabled = true;
            this.cbThoiGianBatDau.Items.AddRange(new object[] {
            "09:30:00",
            "11:00:00",
            "13:00:00",
            "15:00:00",
            "17:00:00",
            "19:00:00",
            "21:00:00"});
            this.cbThoiGianBatDau.Location = new System.Drawing.Point(142, 159);
            this.cbThoiGianBatDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbThoiGianBatDau.Name = "cbThoiGianBatDau";
            this.cbThoiGianBatDau.Size = new System.Drawing.Size(125, 21);
            this.cbThoiGianBatDau.TabIndex = 17;
            // 
            // tbphim
            // 
            this.tbphim.Enabled = false;
            this.tbphim.Location = new System.Drawing.Point(364, 69);
            this.tbphim.Name = "tbphim";
            this.tbphim.Size = new System.Drawing.Size(124, 20);
            this.tbphim.TabIndex = 16;
            // 
            // tbidsuatchieu
            // 
            this.tbidsuatchieu.Enabled = false;
            this.tbidsuatchieu.Location = new System.Drawing.Point(142, 23);
            this.tbidsuatchieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbidsuatchieu.Name = "tbidsuatchieu";
            this.tbidsuatchieu.Size = new System.Drawing.Size(125, 20);
            this.tbidsuatchieu.TabIndex = 15;
            // 
            // idsuatchieu
            // 
            this.idsuatchieu.AutoSize = true;
            this.idsuatchieu.Location = new System.Drawing.Point(43, 27);
            this.idsuatchieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idsuatchieu.Name = "idsuatchieu";
            this.idsuatchieu.Size = new System.Drawing.Size(70, 13);
            this.idsuatchieu.TabIndex = 14;
            this.idsuatchieu.Text = "Id Suất chiếu";
            // 
            // dtpk_dateForm
            // 
            this.dtpk_dateForm.Location = new System.Drawing.Point(248, 114);
            this.dtpk_dateForm.Name = "dtpk_dateForm";
            this.dtpk_dateForm.Size = new System.Drawing.Size(20, 20);
            this.dtpk_dateForm.TabIndex = 12;
            this.dtpk_dateForm.Value = new System.DateTime(2018, 12, 13, 3, 58, 34, 0);
            this.dtpk_dateForm.ValueChanged += new System.EventHandler(this.dtpk_dateForm_ValueChanged);
            // 
            // tb_dateForm
            // 
            this.tb_dateForm.Location = new System.Drawing.Point(142, 114);
            this.tb_dateForm.Name = "tb_dateForm";
            this.tb_dateForm.Size = new System.Drawing.Size(101, 20);
            this.tb_dateForm.TabIndex = 11;
            // 
            // cbdinhdang
            // 
            this.cbdinhdang.FormattingEnabled = true;
            this.cbdinhdang.Location = new System.Drawing.Point(364, 110);
            this.cbdinhdang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdinhdang.Name = "cbdinhdang";
            this.cbdinhdang.Size = new System.Drawing.Size(124, 21);
            this.cbdinhdang.TabIndex = 9;
            // 
            // cbphong
            // 
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Location = new System.Drawing.Point(142, 67);
            this.cbphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(124, 21);
            this.cbphong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Định dạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(430, 304);
            this.btupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(82, 25);
            this.btupdate.TabIndex = 16;
            this.btupdate.Text = "Sửa";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.UseWaitCursor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // UpdateLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btupdate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateLichChieu";
            this.Text = "UpdateLichChieu";
            this.Load += new System.EventHandler(this.UpdateLichChieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbidsuatchieu;
        private System.Windows.Forms.Label idsuatchieu;
        private System.Windows.Forms.DateTimePicker dtpk_dateForm;
        private System.Windows.Forms.TextBox tb_dateForm;
        private System.Windows.Forms.ComboBox cbdinhdang;
        private System.Windows.Forms.ComboBox cbphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox tbphim;
        private System.Windows.Forms.ComboBox cbThoiGianBatDau;
    }
}