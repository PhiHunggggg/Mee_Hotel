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
    public partial class frmThemDichVu : Form
    {
        private string maPhong;
        public frmThemDichVu(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void frmThemDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Khach_SanDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quan_Ly_Khach_SanDataSet2.NhanVien);
            // TODO: This line of code loads data into the 'quan_Ly_Khach_SanDataSet1.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.quan_Ly_Khach_SanDataSet1.DichVu);
            // TODO: This line of code loads data into the 'quan_Ly_Khach_SanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quan_Ly_Khach_SanDataSet.Phong);
            siticoneButton1.Enabled = false;
            if (maPhong != null)
            {
                cbcPhong.SelectedValue = maPhong;
            }
            dtpNgaySuDung.Value = DateTime.Today.Date;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var kq = DichVuDAL.Instance.ThemDichVuPhong(cbcPhong.SelectedValue.ToString(), cbcDV.SelectedValue.ToString(), Convert.ToDateTime(dtpNgaySuDung.Value), Convert.ToInt32(cbcSoLuong.SelectedItem), cbcNhanVien.SelectedValue.ToString(), txtGhiChu.Text);

            if (kq.Success)
            {
                MessageBox.Show(kq.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + kq.Message, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadKhachHangHienTai()
        {
            DataTable bangThongTinKH = PhongDAL.Instance.getKhachHangHienTai(cbcPhong.SelectedValue.ToString());

            if (bangThongTinKH != null && bangThongTinKH.Rows.Count > 0)
            {
                DataRow row = bangThongTinKH.Rows[0];  // lấy dòng đầu tiên

                lblTenKhach.Text = row["TenKhachHang"].ToString();
                lblCCCD.Text = row["CCCD"].ToString();
                lblMaDP.Text = row["MaDP"].ToString();

                // Xử lý ngày nhận (an toàn với NULL)
                if (row["NgayNhan"] != DBNull.Value)
                    lblNgayNhanPhong.Text = Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy");
                else
                    lblNgayNhanPhong.Text = "Chưa check-in";
                siticoneButton1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Phòng đang không có khách ở !!!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa trắng các label
                lblTenKhach.Text = lblCCCD.Text = lblMaDP.Text = lblNgayNhanPhong.Text = "-";
                siticoneButton1.Enabled = false;
            }
        }
        private void cbcPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKhachHangHienTai();
        }

        private void cbcDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable bangDichVu = DichVuDAL.Instance.getDichVubyMaDichVu(cbcDV.SelectedValue.ToString());
            decimal donGia = Convert.ToDecimal(bangDichVu.Rows[0]["DonGia"]);
            decimal tongTien = 0; 
            if(cbcSoLuong.SelectedItem != null)
            {
                tongTien = donGia*Convert.ToInt32(cbcSoLuong.SelectedItem);
                lblTongTien.Text = "$ " + tongTien.ToString() + "đ";
            }
        }

        private void cbcSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbcSoLuong.SelectedItem != null)
            {
                DataTable bangDichVu = DichVuDAL.Instance.getDichVubyMaDichVu(cbcDV.SelectedValue.ToString());
                decimal donGia = Convert.ToDecimal(bangDichVu.Rows[0]["DonGia"]);
                decimal tongTien = donGia * Convert.ToInt32(cbcSoLuong.SelectedItem);
                lblTongTien.Text = "$ " + tongTien.ToString() + "đ";
            }
        }

        private void dtpNgaySuDung_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySuDung.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Không thể đặt dịch vụ trước ngày hôm nay !!!");
                dtpNgaySuDung.Value = DateTime.Today.Date;
            }
        }
    }
}
