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
            if(ThongTinDonHang.MaKTHH == null || ThongTinDonHang.MaDP == null || ThongTinDonHang.MaKTHH == null)
            {
                MessageBox.Show("Bạn chưa check hết các thông tin!!");
                return;
            }
            int tst = HoaDonDAL.Instance.TaoHoaDon(ThongTinDonHang.MaKH, ThongTinDonHang.MaDP, DateTime.UtcNow, ThongTinDonHang.TongTien, ThongTinDonHang.PhanTramThue, ThongTinDonHang.TongTienDV, "Đã thanh toán", PTcb.SelectedValue?.ToString(), ThongTinDonHang.MaKTHH);
            if (tst > 0) MessageBox.Show("Thêm hóa đơn thành công");
            else MessageBox.Show("Thêm hóa đơn không thành công");
            this.Close();
        }
    }
}
