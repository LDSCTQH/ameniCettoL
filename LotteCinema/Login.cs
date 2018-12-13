using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LotteCinema
{
    public partial class fLogin : Form
    {

        public static int employeeID = 0;

        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
                MessageBox.Show("Hãy nhập tên đăng nhập!");
            else if (string.IsNullOrEmpty(tb_password.Text))
                MessageBox.Show("Hãy nhập mật khẩu!");
            else
            {
                string position = "";
                if (rb_manager.Checked)
                    position = "QL";
                else if (rb_seller.Checked)
                    position = "NV";

                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                using (SqlCommand cmd = new SqlCommand("sp_DangNhap", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@idnhanvien", SqlDbType.Int);
                    cmd.Parameters["@cmnd"].Value = tb_username.Text;
                    cmd.Parameters["@matKhau"].Value = tb_password.Text;
                    cmd.Parameters["@idnhanvien"].Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteScalar();
                    //cmd.ExecuteNonQuery();

                    employeeID = (int)cmd.Parameters["@idnhanvien"].Value;
                    if (employeeID > 0)
                    {
                        if (position == "QL")
                        {
                            fManager form = new fManager();
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            fTicketClerk form = new fTicketClerk();
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                        MessageBox.Show("Đăng nhập thất bại!");

                    conn.Close();
                }
            }
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_showpass.Checked)
                tb_password.UseSystemPasswordChar = true;
            else
                tb_password.UseSystemPasswordChar = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
