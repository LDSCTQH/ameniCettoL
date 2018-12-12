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
        public fTicketClerk()
        {
            InitializeComponent();
        }

        private void loadFilmList()
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_LietKeSuatChieu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteScalar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_film.DataSource = dt;
                conn.Close();
            }
        }

        private void loadShowtimes()
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_LietKeSuatChieu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteScalar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_film.DataSource = dt;
                conn.Close();
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddMember form = new fAddMember();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void tp_filmlist_Click(object sender, EventArgs e)
        {
            loadFilmList();
        }

        private void tp_showtimes_Click(object sender, EventArgs e)
        {
            loadShowtimes();
        }

        private void fTicketClerk_Load(object sender, EventArgs e)
        {
            loadFilmList();
        }
    }
}
