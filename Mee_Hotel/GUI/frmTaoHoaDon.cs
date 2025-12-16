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
    public partial class frmTaoHoaDon : Form
    {
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            TienDP_tb.Text = ThongTinDonHang.TongTienDP.ToString() + " VND";
            TienDV_tb.Text = ThongTinDonHang.TongTienDV.ToString() + " VND";
            TienBT_tb.Text = ThongTinDonHang.TongTienBT.ToString() + " VND";
            TenKH_lb.Text = ThongTinDonHang.TenKH;
            MaDP_lb.Text = ThongTinDonHang.MaDP;
            NgayTT_lb.Text = DateTime.UtcNow.ToString();
            TenNV_lb.Text = StaticThing.TenNV;
            ThongTinDonHang.TongTien = ThongTinDonHang.TongTienDV + ThongTinDonHang.TongTienBT + ThongTinDonHang.TongTienDP;
            TongTT_tb.Text = ThongTinDonHang.TongTien.ToString() + " VND";
        }
    }
}
