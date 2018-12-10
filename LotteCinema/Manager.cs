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
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void loadFilmList()
        {
            using (SqlConnection conn = new SqlConnection(Connection.connectionString()))
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
            using (SqlConnection conn = new SqlConnection(Connection.connectionString()))
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

        private void tp_film_Click(object sender, EventArgs e)
        {
            loadFilmList();
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            loadFilmList();
        }

        private void tp_showtimes_Click(object sender, EventArgs e)
        {
            loadShowtimes();
        }
    }
}
