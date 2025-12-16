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
    public partial class frmKiemTraDV : Form
    {
        public frmKiemTraDV()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadFullDichVu()
        {
            
        }

        private void LoadDVTheoPhong(string MaPhong)
        {
            Data_DV_KT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DV_KT.AllowUserToResizeColumns = false;
            Data_DV_KT.AllowUserToResizeRows = false;
            DataTable dt = HoaDon_DVDAL.Instance.HienThiDV_Phong(MaPhong);
            Data_DV_KT.DataSource = dt;
            if (dt != null)
            {
                Data_DV_KT.Columns["MaPhong"].HeaderText = "Mã phòng";
                Data_DV_KT.Columns["MaDV"].HeaderText = "Mã dịch vụ";
                Data_DV_KT.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
                Data_DV_KT.Columns["SoLuong"].HeaderText = "Số lượng";
                Data_DV_KT.Columns["DonGiaLucDung"].HeaderText = "Đơn giá lúc dùng";
                Data_DV_KT.Columns["GhiChu"].HeaderText = "Ghi chú";
                Data_DV_KT.Columns["MaNV"].HeaderText = "Mã nhân viên";
            }
            int SumDV = 0;
            decimal tongTien = 0;
            foreach (DataGridViewRow row in Data_DV_KT.Rows)
            {
                int tg;
                bool haiz = int.TryParse(row.Cells["SoLuong"].Value?.ToString(),out tg);
                if (haiz) SumDV += tg;
                tongTien += Convert.ToDecimal(row.Cells["DonGiaLucDung"].Value?.ToString()) * Convert.ToDecimal(row.Cells["SoLuong"].Value?.ToString());
            }
            SlDVlb.Text = SumDV.ToString();
            txtTongTien.Text = tongTien.ToString();
            //MaPhong, MaDV, NgaySuDung, SoLuong, DonGiaLucDung, GhiChu, MaNV
        }

        private void LoadDSPhong()
        {
            TenKH_DVlb.Text = ThongTinDonHang.TenKH;
            MaDP_DVlb.Text = ThongTinDonHang.MaDP;
            ChonPhongcbb.DataSource = HoaDon_DVDAL.Instance.GetDanhSachPhong(ThongTinDonHang.MaDP);
            ChonPhongcbb.DisplayMember = "TenPhong";
            ChonPhongcbb.ValueMember = "MaPhong";
            ChonPhongcbb.SelectedIndex = -1;
        }

        private void frmKiemTraDV_Load(object sender, EventArgs e)
        {
            LoadDSPhong();
            Data_DV_KT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DV_KT.AllowUserToResizeColumns = false;
            Data_DV_KT.AllowUserToResizeRows = false;
            Data_DV_KT.AllowUserToAddRows = false;
            Data_DV_KT.AllowUserToDeleteRows = false;
            Data_DV_KT.ReadOnly = true;
            Data_DV_KT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_DV_KT.MultiSelect = false;
            Data_DV_KT.BorderStyle = BorderStyle.None;
            // Font + màu nền
            Data_DV_KT.Font = new Font("Segoe UI", 10F);
            Data_DV_KT.BackgroundColor = Color.White;
            Data_DV_KT.GridColor = Color.LightGray;

            // Header
            Data_DV_KT.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            Data_DV_KT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Data_DV_KT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_DV_KT.EnableHeadersVisualStyles = false;
            Data_DV_KT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_DV_KT.ColumnHeadersHeight = 75;   // bạn muốn cao bao nhiêu thì ghi vào đây
            Data_DV_KT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in Data_DV_KT.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (Data_DV_KT.Rows.Count > 0)
            {
                Data_DV_KT.Rows[0].Height = 55;
                Data_DV_KT.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                Data_DV_KT.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 215);
            }
            Data_DV_KT.RowTemplate.Height = 50;
        }

        private void ChonPhongcbb_StyleChanged(object sender, EventArgs e)
        {

        }

        private void ChonPhongcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChonPhongcbb.SelectedValue == null) return;
            if (ChonPhongcbb.SelectedValue is DataRowView) return;

            string maPhong = ChonPhongcbb.SelectedValue.ToString();
            LoadDVTheoPhong(maPhong);
        }

        private void siticoneShapes2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinDonHang.TongTienDV = Convert.ToDecimal(txtTongTien.Text);
            MessageBox.Show("Kiểm tra dịch vụ thành công");
            this.Close();
        }
    }
}
