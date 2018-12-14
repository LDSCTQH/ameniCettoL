using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteCinema
{
    public partial class fBuyBooking : Form
    {
        string showtimeID, roomID, filmID;

        private void fBuyBooking_Load(object sender, EventArgs e)
        {
            lb_cinema.Text = "Rạp: " + fLogin.cinemaID;
            lb_room.Text = "Phòng: " + roomID;
            lb_film.Text = "Phim: " + filmID;
            loadSeat();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            int index = dgv_seat.CurrentCell.RowIndex;
            String veTrong = dgv_seat.Rows[index].Cells[5].Value.ToString();
            if (veTrong.Equals("Trống"))
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_BanVe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ve", SqlDbType.Int);
                    cmd.Parameters.Add("@thanhvien", SqlDbType.Char);
                    cmd.Parameters.Add("@nhanvienbanhang", SqlDbType.Int);
                    cmd.Parameters.Add("@uudai", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@loaive", SqlDbType.NVarChar);

                    cmd.Parameters["@ve"].Value = int.Parse(dgv_seat.Rows[index].Cells[1].Value.ToString());
                    cmd.Parameters["@thanhvien"].Value = tb_identity.Text;
                    cmd.Parameters["@nhanvienbanhang"].Value = fLogin.employeeID;

                    if (rb_monday.Checked)
                        cmd.Parameters["@uudai"].Value = "Monday";
                    else if (rb_giasoc.Checked)
                        cmd.Parameters["@uudai"].Value = "GiaSoc";
                    else if (rb_birthday.Checked)
                        cmd.Parameters["@uudai"].Value = "SinhNhat";
                    else
                        cmd.Parameters["@uudai"].Value = DBNull.Value;

                    if (rb_adult.Checked)
                        cmd.Parameters["@loaive"].Value = "NL";
                    else if (rb_child.Checked)
                        cmd.Parameters["@loaive"].Value = "TE";
                    else if (rb_student.Checked)
                        cmd.Parameters["@loaive"].Value = "HSSV";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xong chưa?");
                }
            }
            else
            {
                MessageBox.Show("Khong the mua duoc");
            }
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            
            int index = dgv_seat.CurrentCell.RowIndex;
            String veTrong = dgv_seat.Rows[index].Cells[5].Value.ToString();
            if (veTrong.Equals("Trống"))
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_DatCho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ve", SqlDbType.Int);
                    cmd.Parameters.Add("@thanhvien", SqlDbType.Char);
                    cmd.Parameters["@ve"].Value = int.Parse(dgv_seat.Rows[index].Cells[1].Value.ToString());
                    cmd.Parameters["@thanhvien"].Value = tb_identity.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Khong the dat duoc");
            }
        }
        
        public fBuyBooking()
        {
            InitializeComponent();
            showtimeID = fTicketClerk.showtimeID;
            roomID = fTicketClerk.roomID;
            filmID = fTicketClerk.filmID;

            for(int i = 0; i < groupBoxUuDai.Controls.Count; ++i)
            {
                ((RadioButton)groupBoxUuDai.Controls[i]).CheckedChanged += new System.EventHandler(gbxIconType_CheckedChanged);
            }
            for (int i = 0; i < groupBoxLoaiVe.Controls.Count; ++i)
            {
                ((RadioButton)groupBoxLoaiVe.Controls[i]).CheckedChanged += new System.EventHandler(gbxIconType_CheckedChanged);
            }
        }
        int index = -1;
        private void dgv_seat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void loadSeat()
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_XemChoNgoi", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idsuatchieu", SqlDbType.Int);
                cmd.Parameters["@idsuatchieu"].Value = int.Parse(showtimeID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_seat.DataSource = dt;
                conn.Close();
            }
        }

        private void gbxIconType_CheckedChanged(object sender, EventArgs e)
        {
            if(index != -1)
            {
                float giaVe;
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_laygiave", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idghe", SqlDbType.Int);
                    cmd.Parameters.Add("@loaive", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@uudai", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@giave", SqlDbType.Float);
                    cmd.Parameters["@idghe"].Value = int.Parse(dgv_seat.Rows[index].Cells[2].Value.ToString());
                    if (rb_monday.Checked)
                        cmd.Parameters["@uudai"].Value = "Monday";
                    else if (rb_giasoc.Checked)
                        cmd.Parameters["@uudai"].Value = "GiaSoc";
                    else if (rb_birthday.Checked)
                        cmd.Parameters["@uudai"].Value = "SinhNhat";
                    else
                        cmd.Parameters["@uudai"].Value = DBNull.Value;

                    if (rb_adult.Checked)
                        cmd.Parameters["@loaive"].Value = "NL";
                    else if (rb_child.Checked)
                        cmd.Parameters["@loaive"].Value = "TE";
                    else if (rb_student.Checked)
                        cmd.Parameters["@loaive"].Value = "HSSV";
                    cmd.Parameters["@giave"].Direction = ParameterDirection.Output;
                    conn.Open();
                    cmd.ExecuteScalar();
                    giaVe = float.Parse(cmd.Parameters["@giave"].Value.ToString());
                    conn.Close();
                }
                tb_price.Text = ((int)((int)(giaVe / 1000) * 1000)).ToString();
            }
            
        }

    }
}
