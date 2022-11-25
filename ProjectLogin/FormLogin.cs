using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtTaiKhoan;
            txtTaiKhoan.Focus();
        }

        public string ThongTin = string.Empty;
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tài khoản\n Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            else
            {

                if (String.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Mật khẩu\n Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtTaiKhoan.Text))
                    {
                        if (!String.IsNullOrEmpty(txtMatKhau.Text))
                        {
                            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                            {
                                trangThaiDongForm = true;
                                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTaiKhoan.ResetText();
                                txtMatKhau.ResetText();
                                txtTaiKhoan.Focus();
                            }

                        }
                    }
                }

            }
        }
        bool trangThaiDongForm = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                trangThaiDongForm = true;
                Application.Exit();
            }
        }

        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            if (taiKhoan.Equals("admin") && matKhau.Equals("admin"))
                return true;
            return false;
        }
        
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
