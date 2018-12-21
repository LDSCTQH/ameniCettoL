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
    public partial class fTicketClerk : Form
    {
        public static string showtimeID, roomID, filmID;

        public fTicketClerk()
        {
            InitializeComponent();
        }

        private void loadTabShowtimes(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("sp_XemSuatChieu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idrap", SqlDbType.Int);
                cmd.Parameters.Add("@idphim", SqlDbType.Int);
                cmd.Parameters.Add("@ngay", SqlDbType.Date);
                cmd.Parameters["@idrap"].Value = fLogin.cinemaID;
                cmd.Parameters["@idphim"].Value = DBNull.Value;
                cmd.Parameters["@ngay"].Value = DateTime.Today;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_showtimes.DataSource = dt;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddMember form = new fAddMember();
            this.Hide();
            form.RefreshDgv += new fAddMember.DoEvent(Refresh_form_fAddMember);
            form.ShowDialog();
            this.Show();
        }

        private void fTicketClerk_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();
                loadTabShowtimes(conn);
                loadBookedTicket(conn);
                loadMembers(conn);
                conn.Close();
            }
        }

        private void dgv_showtimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_showtimes.CurrentCell.RowIndex;
            showtimeID = dgv_showtimes.Rows[index].Cells[0].Value.ToString();
            roomID = dgv_showtimes.Rows[index].Cells[1].Value.ToString();
            filmID = dgv_showtimes.Rows[index].Cells[4].Value.ToString();

            fBuyBooking form = new fBuyBooking();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }


        private void tb_idve_TextChanged(object sender, EventArgs e)
        {
            (dgv_vedat.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert([idve], System.String) LIKE '%{0}%' OR [tenthanhvien] LIKE '%{0}%'", tb_idve.Text);
        }

        private void loadBookedTicket(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("SP_DANHSACHVEDAT", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_vedat.DataSource = dt;
            }
        }

        void Refresh_form_fAddMember(string cmnd, string sdt, string tenthanhvien, DateTime ngaysinh)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_ThemThanhVien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char);
                cmd.Parameters.Add("@sdt", SqlDbType.Char);
                cmd.Parameters.Add("@tenthanhvien", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters["@cmnd"].Value = cmnd;
                cmd.Parameters["@sdt"].Value = sdt;
                cmd.Parameters["@tenthanhvien"].Value = tenthanhvien;
                cmd.Parameters["@ngaysinh"].Value = ngaysinh.Date;
                conn.Open();
                cmd.ExecuteNonQuery();
                loadMembers(conn);
                conn.Close();
            }
        }

        void refresh_form_GetTicket(int idve, int nhanvienbanhang, string uudai, string loaive)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_LayVe", conn))
            {
                //Cấu trúc: procedure sp_LayVe @ve int, @nhanvienbanhang int, @uudai nvarchar(20), @loaive nvarchar(5)
                cmd.CommandType = CommandType.StoredProcedure;
                //Thêm tham số
                cmd.Parameters.Add("@ve", SqlDbType.Int);
                cmd.Parameters.Add("@nhanvienbanhang", SqlDbType.Int);
                cmd.Parameters.Add("@uudai", SqlDbType.NVarChar, 20);
                cmd.Parameters.Add("@loaive", SqlDbType.NVarChar, 5);

                cmd.Parameters["@ve"].Value = idve;
                cmd.Parameters["@nhanvienbanhang"].Value = nhanvienbanhang;
                if (uudai == "Không") cmd.Parameters["@uudai"].Value = DBNull.Value;
                else cmd.Parameters["@uudai"].Value = uudai;
                cmd.Parameters["@loaive"].Value = loaive;

                conn.Open();
                cmd.ExecuteNonQuery();
                loadBookedTicket(conn);
                conn.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_vedat.SelectedCells.Count > 0)
                {
                    int idve = Convert.ToInt32(dgv_vedat[0, dgv_vedat.CurrentRow.Index].Value.ToString());

                    using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_HuyDatCho", conn);

                        // set the command object so it knows to execute a stored procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        // add parameter to command, which will be passed to the stored procedure
                        cmd.Parameters.Add(new SqlParameter("@idve", idve));

                        cmd.ExecuteNonQuery();

                        loadBookedTicket(conn);
                        conn.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_layve_Click(object sender, EventArgs e)
        {
            GetTicket getTicket = new GetTicket();
            getTicket.setData(dgv_vedat.CurrentRow);
            getTicket.RefreshDgv += new GetTicket.DoEvent(refresh_form_GetTicket);
            getTicket.Show();
        }

        private void tp_ticket_Click(object sender, EventArgs e)
        {

        }

        private void loadMembers(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("SP_LIETKETHANHVIEN", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_danhsachthanhvien.DataSource = dt;
            }
        }


        private void tb_timkiemthanhvien_TextChanged(object sender, EventArgs e)
        {
            (dgv_danhsachthanhvien.DataSource as DataTable).DefaultView.RowFilter = string.Format("[cmnd] LIKE '%{0}%' OR [tenthanhvien] LIKE '%{0}%'", tb_timkiemthanhvien.Text);
        }

    }
}
