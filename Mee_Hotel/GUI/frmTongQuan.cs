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
using Mee_Hotel.Entity;
namespace Mee_Hotel.GUI
{
    public partial class frmTongQuan : Form
    {
        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadThongKetTinhTrangPhong()
        {
            ThongKePhongcs bangThongKePhong = PhongDAL.Instance.getThongKeTinhTrangPhong();
            int TongSoPhong = bangThongKePhong.TongPhong;
            int SoPhongTrong = bangThongKePhong.PhongTrong;
            int SoPhongDon = bangThongKePhong.PhongDangDon;
            int SoPhongO = bangThongKePhong.PhongDangO;

            int TyLePhongTrong = bangThongKePhong.TyLeTrong;
            int TyLeDangDon = bangThongKePhong.TyLeDangDon;
            int TuLeDangO = bangThongKePhong.TyLeDangO;
            int TyLeLapDay = bangThongKePhong.TyLeLapDay;

            circlePhongTrong.Value = TyLePhongTrong;
            CircelPhongO.Value = TuLeDangO;
            circlePhongDon.Value = TyLeDangDon;

            // Gán text hiển thị ở giữa vòng tròn
            lblPhongTrong.Text = $"{SoPhongTrong}/{TongSoPhong}\n{TyLePhongTrong}%";
            lblPhongO.Text = $"{SoPhongO}/{TongSoPhong}\n{TuLeDangO}%";
            lblPhongDon.Text = $"{SoPhongDon}/{TongSoPhong}\n{TyLeDangDon}%";

            // Tùy chỉnh màu theo trạng thái
            circlePhongTrong.ProgressColor = Color.FromArgb(0, 170, 140);   // Xanh lá - tốt
            CircelPhongO.ProgressColor = Color.Orange;
            circlePhongDon.ProgressColor = Color.Gold;


            string loi;
            var kq = ThongKeDAL.Instance.ThongKeThongTinPhong();
            loi = kq.Loi;
            if (kq.Loi != "OK")
            {
                MessageBox.Show(kq.Loi, "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var p = kq.ThongTinChiTietPhong;
            txtCheckInt.Text = p["SoCheckIn"].ToString();
            txtCheckOut.Text = p["SoCheckOut"].ToString();
            lblSoNguoiOHienTai.Text= p["SoNguoiHienTai"].ToString();

            var h = kq.ThongTinDatPhong;
            lblSoNguoiDatHomNay.Text = h["SoLuotDatHomNay"].ToString();
            lblSoLuongDatPhongThangNay.Text = h["SoLuotDatThangNay"].ToString();
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            dtpTu.Value = dtpDen.Value = DateTime.Today.Date;
            LoadThongKetTinhTrangPhong();
            LoadThongKeDoanhThu();
            lblNgayHomNay.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
        }
        void LoadThongKeDoanhThu()
        {
            DateTime ngayDen = dtpDen.Value.Date;
            DateTime ngayTu = dtpTu.Value.Date;
            DataTable bangThongKeDoanhThu = ThongKeDAL.Instance.ThongKeDoanhThu(ngayTu, ngayDen);

            if (bangThongKeDoanhThu == null || bangThongKeDoanhThu.Rows.Count == 0)
            {
                // Nếu không có dữ liệu → đặt về 0
                circleDoanhThuDatPhong.Value = 0;
                circleDoanhThuDichVu.Value = 0;
                lblPhanTramDatPhong.Text = "0%";
                lblDoanhThuPhong.Text = "00,00đ";
                lblDoanhThuDichVu.Text = "00,00đ";
                lblPhanTramDichVu.Text = "0%";
                lblDoanhThuNgay.Text = "0 đ";
                return;
            }

            DataRow row = bangThongKeDoanhThu.Rows[0];

            // Lấy giá trị an toàn, tránh DBNull
            decimal doanhThuPhong = row["DoanhThuPhong"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DoanhThuPhong"]);
            decimal doanhThuDichVu = row["DoanhThuDichVu"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DoanhThuDichVu"]);
            decimal doanhThuHuHong = row["DoanhThuHuHong"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DoanhThuHuHong"]);

            decimal tongDoanhThu = doanhThuPhong + doanhThuDichVu + doanhThuHuHong;

            // Tính tỷ lệ phần trăm (làm tròn)
            int tyLePhong = tongDoanhThu > 0 ? (int)Math.Round((double)(doanhThuPhong * 100 / tongDoanhThu)) : 0;
            int tyLeDichVu = tongDoanhThu > 0 ? (int)Math.Round((double)(doanhThuDichVu * 100 / tongDoanhThu)) : 0;
            // tyLeHuHong = 100 - tyLePhong - tyLeDichVu (nếu muốn hiển thị thêm)

            // Gán vào Circle Progress
            circleDoanhThuDatPhong.Value = tyLePhong;
            circleDoanhThuDichVu.Value = tyLeDichVu;

            // Hiển thị số tiền + % trên Label (tùy chỉnh theo control bạn có)
            lblPhanTramDatPhong.Text = $"{tyLePhong}%";
            lblPhanTramDichVu.Text = $"{tyLeDichVu}%";
            lblDoanhThuPhong.Text = $"{doanhThuPhong:N0} đ";
            lblDoanhThuDichVu.Text = $"{doanhThuDichVu:N0} đ";
            lblDoanhThuNgay.Text = $"{tongDoanhThu:N0} đ";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpTu_ValueChanged(object sender, EventArgs e)
        {
            LoadThongKeDoanhThu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayHomNay_Click(object sender, EventArgs e)
        {

        }
    }
}
