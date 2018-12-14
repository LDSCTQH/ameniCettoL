using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LotteCinema
{
    public partial class UpdateFilm : Form
    {
        int idPhim;
        String tuaphim;
        String theloai;
        String daodien;
        DateTime ngaycongchieu;
        int thoiluong;
        String nuocsx;
        int namsx;
        String tinhtrang;
        public UpdateFilm(int id,String tua,String theloai,String daodien,DateTime ngaycongchieu,int thoiluong,
            String nuocsx,int namsx,String tinhtrang)
        {        
            InitializeComponent();
            this.idPhim = id;
            this.tuaphim = tua;
            this.theloai = theloai;
            this.daodien = daodien;
            this.ngaycongchieu = ngaycongchieu;
            this.thoiluong = thoiluong;
            this.nuocsx = nuocsx;
            this.namsx = namsx;
            this.tinhtrang = tinhtrang;
        }

        private void UpdateFilm_Load(object sender, EventArgs e)
        {
            tbTuaPhim.Text = tuaphim;
            cbTheLoai.Text = theloai;
            tbDaoDien.Text = daodien;
            tbNgayCongChieu.Text = Date(ngaycongchieu);
            dtpkNgayCongChieu.Value = ngaycongchieu;
            numericUpDownThoiLuong.Value = thoiluong;
            tbNuocSanXuat.Text = nuocsx;
            numericUpDownNamSanXuat.Value = namsx;
            cbTinhTrang.Text = tinhtrang;

        }
        private string Date(DateTime dt)
        {
            return dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTuaPhim.Text) || String.IsNullOrWhiteSpace(tbTuaPhim.Text) ||
                String.IsNullOrEmpty(tbDaoDien.Text) || String.IsNullOrWhiteSpace(tbDaoDien.Text) ||
                String.IsNullOrEmpty(cbTheLoai.Text) || String.IsNullOrWhiteSpace(cbTheLoai.Text) ||
                String.IsNullOrEmpty(cbTheLoai.Text) || String.IsNullOrWhiteSpace(cbTheLoai.Text) ||
                String.IsNullOrEmpty(tbNuocSanXuat.Text) || String.IsNullOrWhiteSpace(tbNuocSanXuat.Text) ||
                String.IsNullOrEmpty(tbNgayCongChieu.Text) || String.IsNullOrWhiteSpace(tbNgayCongChieu.Text) ||
                String.IsNullOrEmpty(cbTinhTrang.Text) || String.IsNullOrWhiteSpace(cbTinhTrang.Text)
                )
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("SP_CapNhatPhim", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //MessageBox.Show(cb_film.SelectedValue.ToString(), "id film");
                    cmd.Parameters.Add("@idphim", SqlDbType.Int);
                    cmd.Parameters.Add("@tuaphim", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@theloai", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@daodien", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ngaycongchieu", SqlDbType.Date);
                    cmd.Parameters.Add("@thoiluong", SqlDbType.Int);
                    cmd.Parameters.Add("@nuocsx", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@namsx", SqlDbType.Int);
                    cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar);

                    cmd.Parameters["@idphim"].Value = idPhim;
                    cmd.Parameters["@tuaphim"].Value = tbTuaPhim.Text;
                    cmd.Parameters["@theloai"].Value = cbTheLoai.Text;
                    cmd.Parameters["@daodien"].Value = tbDaoDien.Text;
                    cmd.Parameters["@ngaycongchieu"].Value = dtpkNgayCongChieu.Value.Date;
                    cmd.Parameters["@thoiluong"].Value = numericUpDownThoiLuong.Value;
                    cmd.Parameters["@nuocsx"].Value = tbNuocSanXuat.Text;
                    cmd.Parameters["@namsx"].Value = numericUpDownNamSanXuat.Value;
                    cmd.Parameters["@tinhtrang"].Value = cbTinhTrang.Text;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void dtpkNgayCongChieu_ValueChanged(object sender, EventArgs e)
        {
            tbNgayCongChieu.Text = Date(dtpkNgayCongChieu.Value);
        }

    }
}
