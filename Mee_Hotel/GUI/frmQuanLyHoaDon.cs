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
    public partial class frmQuanLyHoaDon : Form
    {
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHet();
            Data_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_HD.AllowUserToResizeColumns = false;
            Data_HD.AllowUserToResizeRows = false;
            Data_HD.AllowUserToAddRows = false;
            Data_HD.AllowUserToDeleteRows = false;
            Data_HD.ReadOnly = true;
            Data_HD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_HD.MultiSelect = false;
            Data_HD.BorderStyle = BorderStyle.None;
            // Font + màu nền
            Data_HD.Font = new Font("Segoe UI", 10F);
            Data_HD.BackgroundColor = Color.White;
            Data_HD.GridColor = Color.LightGray;

            // Header
            Data_HD.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            Data_HD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Data_HD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_HD.EnableHeadersVisualStyles = false;
            Data_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_HD.ColumnHeadersHeight = 75;   // bạn muốn cao bao nhiêu thì ghi vào đây
            Data_HD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in Data_HD.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (Data_HD.Rows.Count > 0)
            {
                Data_HD.Rows[0].Height = 55;
                Data_HD.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                Data_HD.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 215);
            }
            Data_HD.RowTemplate.Height = 50;
            // Tạo chữ mờ
            txtHoten.PlaceholderText = "Nhập họ tên";
            txtHoten.PlaceholderForeColor = Color.Silver;
            txtMaHD.PlaceholderText = "Nhập mã hóa đơn";
            txtMaHD.PlaceholderForeColor = Color.Silver;
            txtSDT.PlaceholderText = "Nhập số điện thoại";
            txtSDT.PlaceholderForeColor = Color.Silver;
            LoadHet();
        }

        private void LoadHet()
        {
            Data_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_HD.AllowUserToResizeColumns = false;
            Data_HD.AllowUserToResizeRows = false;
            DataTable bangcheckout = HoaDonDAL.Instance.HienThiHoaDon();
            Data_HD.DataSource = bangcheckout;
            if (bangcheckout != null)
            {
                Data_HD.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                Data_HD.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                Data_HD.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
                Data_HD.Columns["TongTien"].HeaderText = "Tổng tiền";
                Data_HD.Columns["Thue"].HeaderText = "Thuế";
                Data_HD.Columns["PhiDichVu"].HeaderText = "Phí dịch vụ";
                Data_HD.Columns["TrangThaiThanhToan"].HeaderText = "Trạng thái thanh toán";
            }
        }

        private void LoadDSHD_TK()
        {
            Data_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_HD.AllowUserToResizeColumns = false;
            Data_HD.AllowUserToResizeRows = false;
            DataTable bangcheckout = HoaDonDAL.Instance.getDanhSachHD(txtMaHD.Text, txtHoten.Text, txtSDT.Text, dtpTu.Value, dtpDen.Value);
            Data_HD.DataSource = bangcheckout;
            if (bangcheckout != null)
            {
                Data_HD.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                Data_HD.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                Data_HD.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
                Data_HD.Columns["TongTien"].HeaderText = "Tổng tiền";
                Data_HD.Columns["Thue"].HeaderText = "Thuế";
                Data_HD.Columns["PhiDichVu"].HeaderText = "Phí dịch vụ";
                Data_HD.Columns["TrangThaiThanhToan"].HeaderText = "Trạng thái thanh toán";
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "Nhập họ tên" && txtMaHD.Text == "Nhập phòng" && txtSDT.Text == "Nhập số điện thoại")
            {
                LoadHet();
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                LoadDSHD_TK();
                if (Data_HD.Rows.Count <= 0)
                {
                    LoadHet();
                    MessageBox.Show("Không thấy thông tin tìm kiếm");
                }
            }
        }

        private void Data_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_HD.Rows[e.RowIndex];
                MaHD_lb.Text = row.Cells["MaHoaDon"].Value?.ToString();
                TenKH_lb.Text = row.Cells["TenKhachHang"].Value?.ToString();
                NgayTT_lb.Text = row.Cells["NgayThanhToan"].Value?.ToString();
                TongTien_lb.Text = row.Cells["TongTien"].Value?.ToString();
                PhiDV_lb.Text = row.Cells["PhiDichVu"].Value?.ToString();
                TTThanhToan_lb.Text = row.Cells["TrangThaiThanhToan"].Value?.ToString();
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaHD_lb.Text))
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
            int check = HoaDonDAL.Instance.XoaHD(MaHD_lb.Text);
            if (check > 0) MessageBox.Show("Xóa hóa đơn thành công!!");
            else MessageBox.Show("Xóa hóa đơn không thành công!!");
            LoadHet();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            ThongTinDonHang.MaHD = MaHD_lb.Text;
            if (TTThanhToan_lb.Text == "Đã thanh toán")
            {
                MessageBox.Show("Đã thanh toán hóa đơn!!");
                return;
            }
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
            this.Close();
        }

        private void Data_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            LoadDSHD_TK();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            LoadDSHD_TK();

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            LoadDSHD_TK();
        }
    }
}
