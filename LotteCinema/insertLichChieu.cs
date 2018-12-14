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
    public partial class insertLichChieu : Form
    {
        int employeeID;
      

        public insertLichChieu()
        {
            InitializeComponent();
            employeeID = fLogin.employeeID;
        }

        

        private string Date(DateTime dt)
        {
            return dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
        }

        private void insertLichChieu_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                loadPhim(conn);
                loadPhong(conn);
            }

            dtpk_dateInsertLichChieu.Value = DateTime.Today;
            tb_dateFrom.Text = Date(dtpk_dateInsertLichChieu.Value);
          
            this.cbdinhdang.Items.AddRange(new object[] { "2D", "3D" });
        }

   
        private int getCinemaID()
        {
            int cinemaID = 0;
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_LamViecORap", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nhanvien", SqlDbType.Int);
                cmd.Parameters.Add("@rap", SqlDbType.Int);
                cmd.Parameters["@nhanvien"].Value = employeeID;
                cmd.Parameters["@rap"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteScalar();
                cinemaID = (int)cmd.Parameters["@rap"].Value;
                conn.Close();
            }
            return cinemaID;
        }

        private void loadPhong(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("sp_LietKePhong", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@rap", SqlDbType.Int);
                cmd.Parameters["@rap"].Value = getCinemaID();

                conn.Open();
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbphong.DataSource = dt;
                cbphong.ValueMember = "idphong";
                cbphong.DisplayMember = "idphong";
         
            }
        }

        private void loadPhim(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("sp_LietKePhim", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbphim.DataSource = dt;
                cbphim.ValueMember = "idphim";
                cbphim.DisplayMember = "tuaphim";
            }

        }

        

        private void btinsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_ThemSuatChieu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //MessageBox.Show(cb_film.SelectedValue.ToString(), "id film");
                    cmd.Parameters.Add("@idphong", SqlDbType.Int);
                    cmd.Parameters.Add("@ngay", SqlDbType.Date);
                    cmd.Parameters.Add("@thoigianbd", SqlDbType.DateTime);
                    cmd.Parameters.Add("@idphim", SqlDbType.Int);
                    cmd.Parameters.Add("@iddinhdang", SqlDbType.Char);

                    cmd.Parameters["@idphong"].Value = int.Parse(cbphong.SelectedValue.ToString());
                    cmd.Parameters["@ngay"].Value = dtpk_dateInsertLichChieu.Value.ToString();
                    cmd.Parameters["@thoigianbd"].Value = cbThoiGianBatDau.Text;
                    cmd.Parameters["@idphim"].Value = int.Parse(cbphim.SelectedValue.ToString());
                    cmd.Parameters["@iddinhdang"].Value = cbdinhdang.Text;
                    conn.Open();
                    cmd.ExecuteScalar();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);


                    conn.Close();
                    MessageBox.Show("Them thanh cong");
                }
                this.Close();
            }catch(Exception err)
            {
                MessageBox.Show("Khong the them");
            }
        }

        private void dtpk_dateInsertLichChieu_ValueChanged(object sender, EventArgs e)
        {
            tb_dateFrom.Text = Date(dtpk_dateInsertLichChieu.Value);
        }
    }
}
