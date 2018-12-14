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
    public partial class GetTicket : Form
    {
        public delegate void DoEvent(int idve, int nhanvienbanhang, string uudai, string loaive);
        public event DoEvent RefreshDgv;

        public GetTicket()
        {
            InitializeComponent();
        }

        public void setData(DataGridViewRow row)
        {
            tb_ttve_idve.Text = row.Cells["idve"].Value.ToString();
            tb_ttve_suatchieu.Text = row.Cells["idsuatchieu"].Value.ToString();
            tb_ttve_rap.Text = row.Cells["idrap"].Value.ToString();
            tb_ttve_phong.Text = row.Cells["idphong"].Value.ToString();
            tb_ttve_mathanhvien.Text = row.Cells["cmnd"].Value.ToString();
            tb_ttve_tenthanhvien.Text = row.Cells["tenthanhvien"].Value.ToString();
            tb_ttve_tenphim.Text = row.Cells["tuaphim"].Value.ToString();
        }

        private void cb_uudai_Load()
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("SP_LietKeUuDai", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.NewRow();
                row["iduudai"] = "Không";
                dt.Rows.InsertAt(row, 0);
                cb_uudai.DataSource = dt;
                cb_uudai.ValueMember = "iduudai";
                cb_uudai.DisplayMember = "iduudai";
                cb_uudai.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void cb_loaive_Load()
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("SP_LietKeLoaiVe", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb_loaive.DataSource = dt;
                cb_loaive.ValueMember = "idloaive";
                cb_loaive.DisplayMember = "idloaive";
                cb_loaive.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void GetTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataSet.SP_LietKeUuDai' table. You can move, or remove it, as needed.
            try
            {
                cb_loaive_Load();
                cb_uudai_Load();
            }
            catch
            {
            }
        }

        private void btm_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            int idve = Convert.ToInt32(tb_ttve_idve.Text);
            int nhanvienbanhang = fLogin.employeeID;
            string uudai = cb_uudai.GetItemText(cb_uudai.SelectedItem);
            string loaive = cb_loaive.GetItemText(cb_loaive.SelectedItem);

            string mess = "Lấy vé thành công";
            string caption = "Thông báo";
            MessageBox.Show(mess, caption);

            this.RefreshDgv(idve, nhanvienbanhang, uudai, loaive);
            this.Close();
        }
    }
}
