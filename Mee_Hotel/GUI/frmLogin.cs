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
                if (TaiKhoan.VaiTro == "Nhân viên")
                {
                    StaticThing.LoaiTaiKhoan = "NV";
                    try
                    {
                        StaticThing.MaNV = TaiKhoan.MaNV;
                        StaticThing.TenNV = TaiKhoan.TenDangNhap;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy ID bệnh nhân: " + ex.Message);
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
                        MessageBox.Show("Lỗi khi lấy ID bệnh nhân: " + ex.Message);
                    }
                }
                else if (TaiKhoan.VaiTro == "Quản lý")
                {
                    StaticThing.LoaiTaiKhoan = "QL";
                }
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
                txtMat_khau.Font = txtTai_khoan.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTai_khoan.ForeColor = txtMat_khau.ForeColor = Color.DarkGray;
                txtTai_khoan.Text = "(Account)";
                txtMat_khau.Clear();
                txtMat_khau.Text = "(Password)";
                txtMat_khau.PasswordChar = '\0';
                txtTai_khoan.Focus();
                this.DialogResult = DialogResult.None;
            }
        }
        private void btnsign_Leave(object sender, EventArgs e)
        {
            btnsign.FillColor = Color.MediumBlue;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
