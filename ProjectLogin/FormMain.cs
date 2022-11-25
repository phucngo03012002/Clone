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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiFormLogin();
        }
        private void HienThiFormLogin()
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ThongTin = "Chương trình đăng nhập";
            frmLogin.ShowDialog();
            lblThoiGian.Text = DateTime.Now.ToString();
            tmrGioHeThong.Start();
            lblThongTinDangNhap.Text = string.Format("Hệ thống được đăng nhập bởi: {0}", ClsMain.taiKhoan);
        }

        private void tmrGioHeThong_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            HienThiFormLogin();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers frmUser = new FormUsers();
            frmUser.ShowDialog();
        }
    }
}
