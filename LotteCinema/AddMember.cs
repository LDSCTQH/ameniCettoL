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
    public partial class fAddMember : Form
    {
        public fAddMember()
        {
            InitializeComponent();
        }

        private string Date(DateTime dt)
        {
            return dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_ThemThanhVien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char);
                cmd.Parameters.Add("@sdt", SqlDbType.Char);
                cmd.Parameters.Add("@tenthanhvien", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters["@cmnd"].Value = tb_identityCard.Text;
                cmd.Parameters["@sdt"].Value = tb_phoneNumber.Text;
                cmd.Parameters["@tenthanhvien"].Value = tb_name.Text;
                cmd.Parameters["@ngaysinh"].Value = dtpk_dob.Value.Date;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thêm thành viên thành công!");
        }

        private void fAddMember_Load(object sender, EventArgs e)
        {
            dtpk_dob.Value = DateTime.Today;
            tb_dob.Text = Date(dtpk_dob.Value);
        }

        private void dtpk_dob_ValueChanged(object sender, EventArgs e)
        {
            tb_dob.Text = Date(dtpk_dob.Value);
        }
    }
}
