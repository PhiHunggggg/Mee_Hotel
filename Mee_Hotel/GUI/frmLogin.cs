using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mee_Hotel.Entity;
using Mee_Hotel.DAL;
namespace Mee_Hotel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTai_khoan.Text.Trim() == "" || txtTai_khoan.Text == "(Account)") { MessageBox.Show("Vui lòng nhập tên tài khoản. "); return; }
            if (txtMat_khau.Text.Trim() == "" || txtMat_khau.Text == "(Password)") { MessageBox.Show("Vui lòng nhập mật khẩu."); return; }
            string username = txtTai_khoan.Text;
            string password = txtMat_khau.Text;

            // Kiểm tra tài khoản
            TaiKhoan TaiKhoan = TaiKhoanDAL.Instance.Login(username, password);
            if (TaiKhoan != null)
            {

                if (TaiKhoan.VaiTro == "Lễ tân")
                {
                    StaticThing.LoaiTaiKhoan = "NV";
                    try
                    {
                        StaticThing.MaNV = TaiKhoan.MaNV;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
                    }
                }
                else if (TaiKhoan.VaiTro == "Khách hàng")
                {
                    StaticThing.LoaiTaiKhoan = "KH";
                    try
                    {
                        StaticThing.MaKH = TaiKhoan.MaKH;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
                    }
                }
                else if (TaiKhoan.VaiTro == "Quản lý")
                {
                    StaticThing.LoaiTaiKhoan = "QL";
                }
                StaticThing.MaNV = TaiKhoan.MaNV;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login successful !!!");
                string taiKhoanID = TaiKhoan.MaTaiKhoan;
                StaticThing.idTaiKhoan = taiKhoanID;
                StaticThing.mk = password;
                StaticThing.TenDangNhap = username;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản, mật khẩu hoặc email! Vui lòng thử lại.");
                txtTai_khoan.Clear();
                txtMat_khau.Clear();
                txtTai_khoan.Focus();
                this.DialogResult = DialogResult.None;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMat_khau.UseSystemPasswordChar = true;
        }

        private void ckbHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbHienthimatkhau.Checked)
            {
                txtMat_khau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMat_khau.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.Purple;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.DeepSkyBlue;
        }

    }
}
