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
    public partial class UpdateLichChieu : Form
    {
        string idsuat, idphong, idphim, ngay, time, iddinhdang;
        int employeeID;
        public UpdateLichChieu(string idsuatchieun, string idphongn, string ngayn, string timen, string idphimn, string iddinhdangn)
        {
            this.idsuat = idsuatchieun;
            this.idphong = idphongn;
            this.ngay = ngayn;
            this.time = timen;
            this.idphim = idphimn;
            this.iddinhdang = iddinhdangn;
            employeeID = fLogin.employeeID;
            InitializeComponent();

        }

        private string Date(DateTime dt)
        {
            return dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
        }

        private void dtpk_dateForm_ValueChanged(object sender, EventArgs e)
        {
            tb_dateForm.Text = Date(dtpk_dateForm.Value);
        }

        private void UpdateLichChieu_Load(object sender, EventArgs e)
        {
            tbidsuatchieu.Text = idsuat;
            cbphong.Text = idphong;
            tbphim.Text = idphim;
            dtpk_dateForm.Text = ngay;
            tb_dateForm.Text = ngay;
            cbThoiGianBatDau.Text = time;
            cbdinhdang.Text = iddinhdang;
            this.cbdinhdang.Items.AddRange(new object[] { "2D", "3D" });

            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {

                loadPhong(conn);
            }


        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_SuaSuatChieu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idsuatchieu", SqlDbType.Int);
                    cmd.Parameters.Add("@idphongmoi", SqlDbType.Int);
                    cmd.Parameters.Add("@ngaymoi", SqlDbType.Date);
                    cmd.Parameters.Add("@thoigianbdmoi", SqlDbType.Date);
                    cmd.Parameters.Add("@iddinhdangmoi", SqlDbType.Char);

                    cmd.Parameters["@idsuatchieu"].Value = this.idsuat;
                    cmd.Parameters["@idphongmoi"].Value = cbphong.Text;
                    cmd.Parameters["@ngaymoi"].Value = dtpk_dateForm.Value.Date;
                    cmd.Parameters["@thoigianbdmoi"].Value = cbThoiGianBatDau.Text;
                    cmd.Parameters["@iddinhdangmoi"].Value = cbdinhdang.Text;
                    conn.Open();
                    cmd.ExecuteScalar();
                    conn.Close();
                    MessageBox.Show("Sua thanh cong");
                }
            }catch (Exception err)
            {
            }
            
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

    
   

    }
}
