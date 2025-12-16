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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHet();
            Data_DP_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DP_HD.AllowUserToResizeColumns = false;
            Data_DP_HD.AllowUserToResizeRows = false;
            Data_DP_HD.AllowUserToAddRows = false;
            Data_DP_HD.AllowUserToDeleteRows = false;
            Data_DP_HD.ReadOnly = true;
            Data_DP_HD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_DP_HD.MultiSelect = false;
            Data_DP_HD.BorderStyle = BorderStyle.None;
            // Font + màu nền
            Data_DP_HD.Font = new Font("Segoe UI", 10F);
            Data_DP_HD.BackgroundColor = Color.White;
            Data_DP_HD.GridColor = Color.LightGray;

            // Header
            Data_DP_HD.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            Data_DP_HD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Data_DP_HD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_DP_HD.EnableHeadersVisualStyles = false;
            Data_DP_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_DP_HD.ColumnHeadersHeight = 75;   
            Data_DP_HD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in Data_DP_HD.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (Data_DP_HD.Rows.Count > 0)
            {
                Data_DP_HD.Rows[0].Height = 55;
                Data_DP_HD.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                Data_DP_HD.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 215);
            }
            Data_DP_HD.RowTemplate.Height = 50;
            // Tạo chữ mờ
            txtHoten.PlaceholderText = "Nhập họ tên";
            txtHoten.PlaceholderForeColor = Color.Silver;
            txtPhong.PlaceholderText = "Nhập phòng";
            txtPhong.PlaceholderForeColor = Color.Silver;
            txtSDT.PlaceholderText = "Nhập số điện thoại";
            txtSDT.PlaceholderForeColor = Color.Silver;

            LoadHet();
        }

        private void LoadHet()
        {
            Data_DP_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DP_HD.AllowUserToResizeColumns = false;
            Data_DP_HD.AllowUserToResizeRows = false;
            DataTable bangcheckout = HoaDonDAL.Instance.getDanhSachCO();
            Data_DP_HD.DataSource = bangcheckout;
            if (bangcheckout != null)
            {
                Data_DP_HD.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                Data_DP_HD.Columns["SDT"].HeaderText = "Số điện thoại";
                Data_DP_HD.Columns["NgayDat"].HeaderText = "Ngày đặt";
                Data_DP_HD.Columns["TenLoaiPhong "].HeaderText = "Tên loại phòng";
                Data_DP_HD.Columns["SoLuongPhong"].HeaderText = "Số lượng phòng";
                Data_DP_HD.Columns["GiaLucDat"].HeaderText = "Giá lúc đặt";
                Data_DP_HD.Columns["MaDP"].HeaderText = "Mã đặt phòng";
                Data_DP_HD.Columns["MaKH"].HeaderText = "Mã khách hàng";
            }
        }
        private void LoadDSCheckOut()
        {
            Data_DP_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DP_HD.AllowUserToResizeColumns = false;
            Data_DP_HD.AllowUserToResizeRows = false;
            DataTable bangcheckout = HoaDonDAL.Instance.getDanhSachCheckOut(txtPhong.Text, txtHoten.Text, txtSDT.Text, dtpTu.Value, dtpDen.Value);
            Data_DP_HD.DataSource = bangcheckout;
            if (bangcheckout != null)
            {
                Data_DP_HD.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                Data_DP_HD.Columns["SDT"].HeaderText = "Số điện thoại";
                Data_DP_HD.Columns["NgayDat"].HeaderText = "Ngày đặt";
                Data_DP_HD.Columns["TenLoaiPhong "].HeaderText = "Tên loại phòng";
                Data_DP_HD.Columns["SoLuongPhong"].HeaderText = "Số lượng phòng";
                Data_DP_HD.Columns["GiaLucDat"].HeaderText = "Giá lúc đặt";
                Data_DP_HD.Columns["MaDP"].HeaderText = "Mã đặt phòng";
                Data_DP_HD.Columns["MaKH"].HeaderText = "Mã khách hàng";
            }
        }

        private void Data_DP_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DP_HD.Rows[e.RowIndex];
                TenKHlb.Text = row.Cells["TenKhachHang"].Value?.ToString();
                LoaiPhonglb.Text = row.Cells["TenLoaiPhong "].Value?.ToString();
                SoPhongDatlb.Text = row.Cells["SoLuongPhong"].Value?.ToString();
                SDTlb.Text = row.Cells["SDT"].Value?.ToString();
                NgayDatlb.Text = row.Cells["NgayDat"].Value?.ToString();
                GiaLucDatlb.Text = row.Cells["GiaLucDat"].Value?.ToString();
                ThongTinDonHang.MaKH = row.Cells["MaKH"].Value?.ToString();
                ThongTinDonHang.MaDP = row.Cells["MaDP"].Value?.ToString();
                ThongTinDonHang.TongTienDP = Convert.ToDecimal(row.Cells["GiaLucDat"].Value?.ToString());
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "Nhập họ tên" && txtPhong.Text == "Nhập phòng" && txtSDT.Text == "Nhập số điện thoại")
            {
                LoadHet();
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                LoadDSCheckOut();
                if (Data_DP_HD.Rows.Count <= 0 )
                {
                    LoadHet();
                    MessageBox.Show("Không thấy thông tin tìm kiếm");
                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            ThongTinDonHang.TenKH = TenKHlb.Text;
            this.Hide();
            frmKiemTraDV frm = new frmKiemTraDV();
            frm.ShowDialog();
            this.Show();
            
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            frmTaoHoaDon frm = new frmTaoHoaDon();
            frm.ShowDialog();
        }
    }
}
