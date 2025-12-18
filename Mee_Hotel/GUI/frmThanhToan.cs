using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mee_Hotel.DAL;

namespace Mee_Hotel.GUI
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            ThongTinDonHang.TongTien = HoaDonDAL.Instance.LayTongTienHoaDon(ThongTinDonHang.MaHD);
            txtTongTienHD.Text = ThongTinDonHang.TongTien.ToString() + " VND";
            txtThoiGianTT.Text = DateTime.UtcNow.ToString();
            if (ThongTinDonHang.NgayTT < DateTime.Now.AddHours(-4))
            {
                MessageBox.Show("Bạn phải trả thêm 5% phụ phí do trả muộn");
                txtTongTienTra.Text = (1.05m * ThongTinDonHang.TongTien).ToString() + " VND";
            }
            else txtTongTienTra.Text = ThongTinDonHang.TongTien.ToString() + " VND";
            ThongTinDonHang.GhiChu += "Nộp muộn + ";
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PTcb.Text))
            {
                MessageBox.Show("Chưa chọn phương thức");
                return;
            }
            ThongTinDonHang.GhiChu += PTcb.Text;
            int check = HoaDonDAL.Instance.ThanhToan(ThongTinDonHang.MaHD, ThongTinDonHang.GhiChu, "Đã thanh toán");
            if (check > 0)
            {
                MessageBox.Show("Thanh Toán thành công!!");
            }
            else MessageBox.Show("Thanh Toán không thành công!!");
            this.Close();

        }
    }
}
