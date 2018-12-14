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
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {
            tbNgayCongChieu.Text = Date(dtpkNgayCongChieu.Value);
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
                using (SqlCommand cmd = new SqlCommand("SP_ThemPhim", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //MessageBox.Show(cb_film.SelectedValue.ToString(), "id film");
                    cmd.Parameters.Add("@tuaphim", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@theloai", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@daodien", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ngaycongchieu", SqlDbType.Date);
                    cmd.Parameters.Add("@thoiluong", SqlDbType.Int);
                    cmd.Parameters.Add("@nuocsx", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@namsx", SqlDbType.Int);
                    cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar);

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
                MessageBox.Show("Them Thanh cong");
                this.Close();
            }
        }

        private void dtpkNgayCongChieu_ValueChanged(object sender, EventArgs e)
        {
            tbNgayCongChieu.Text = Date(dtpkNgayCongChieu.Value);
        }
    }
}
