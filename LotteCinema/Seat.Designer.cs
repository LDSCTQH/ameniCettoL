namespace LotteCinema
{
    partial class fSeat
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
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cinema = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_room = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_book);
            this.panel1.Controls.Add(this.btn_buy);
            this.panel1.Location = new System.Drawing.Point(199, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 52);
            this.panel1.TabIndex = 0;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(40, 13);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 0;
            this.btn_buy.Text = "Mua vé";
            this.btn_buy.UseVisualStyleBackColor = true;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(283, 13);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 23);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Đặt vé";
            this.btn_book.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rạp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng:";
            // 
            // lb_cinema
            // 
            this.lb_cinema.AutoSize = true;
            this.lb_cinema.Location = new System.Drawing.Point(65, 23);
            this.lb_cinema.Name = "lb_cinema";
            this.lb_cinema.Size = new System.Drawing.Size(13, 13);
            this.lb_cinema.TabIndex = 3;
            this.lb_cinema.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // lb_room
            // 
            this.lb_room.AutoSize = true;
            this.lb_room.Location = new System.Drawing.Point(304, 23);
            this.lb_room.Name = "lb_room";
            this.lb_room.Size = new System.Drawing.Size(13, 13);
            this.lb_room.TabIndex = 5;
            this.lb_room.Text = "1";
            // 
            // fSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_room);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_cinema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fSeat";
            this.Text = "Chổ ngồi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_cinema;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_room;
    }
}