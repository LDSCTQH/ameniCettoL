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

        

        private void loadTabShowtimes(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("sp_LietKeSuatChieu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@soluong", SqlDbType.Int);
                cmd.Parameters["@soluong"].Direction = ParameterDirection.Output;
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
            form.ShowDialog();
            this.Show();
        }

        private void fTicketClerk_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();
                loadTabShowtimes(conn);
                conn.Close();
            }
        }
    }
}
