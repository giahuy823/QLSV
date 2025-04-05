using System;
using System.Windows.Forms;
using BLL;

namespace QLSV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            txt_Password.PasswordChar = '*';
        }
        CheckLogin checkLogin = new CheckLogin();
        NhanVien nv = new NhanVien();
        SinhVien sv = new SinhVien();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;


            // Kiểm tra đăng nhập
            if (checkLogin.CheckUserType(username, password) != null)
            {
                UserInfo.ChucVu = checkLogin.CheckUserType(username, password);
                UserInfo.Username = username;
                if (UserInfo.ChucVu == "NHANVIEN") {
                    UserInfo.ID = nv.LayMaNV(username);
                }
                else UserInfo.ID = sv.LayMaSV(username);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                using (FormMenu formMenu = new FormMenu())
                {
                    formMenu.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ckb_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = ckb_Password.Checked ? '\0' : '*';
        }
    }
}
