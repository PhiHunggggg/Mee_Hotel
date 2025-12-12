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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void LoadPhongDangO()
        {
            DataTable dt = CheckOutDAL.Instance.GetDanhSachPhongDangO();
            if (dt != null)
            {
                cmbPhong.DataSource = dt;
                cmbPhong.DisplayMember = "TenPhong";
                cmbPhong.ValueMember = "MaPhong";
            }
        }

        private void LoadThongTinCheckOut(string maPhong)
        {
            DataTable dt = CheckOutDAL.Instance.GetThongTinCheckOut(maPhong);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblMaPhong.Text = maPhong;
                lblTenPhong.Text = cmbPhong.Text;
                lblMaDP.Text = row["MaDP"].ToString();
                lblTenKH.Text = row["TenKhachHang"].ToString();
                lblNgayDen.Text = Convert.ToDateTime(row["NgayDen"]).ToString("dd/MM/yyyy");
                lblNgayTraDuKien.Text = Convert.ToDateTime(row["NgayTraDuKien"]).ToString("dd/MM/yyyy");
                lblSoNgayO.Text = CheckOutDAL.Instance.GetSoNgayOThucTe(maPhong).ToString() + " ngày";
            }
            else
            {
                ClearInfo();
            }
        }

        private void LoadDichVu(string maPhong)
        {
            DataTable dt = CheckOutDAL.Instance.GetDichVuTheoPhong(maPhong);
            if (dt != null)
            {
                dataGridDichVu.DataSource = dt;
                dataGridDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                dataGridDichVu.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
                dataGridDichVu.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGridDichVu.Columns["DonGiaLucDung"].HeaderText = "Đơn giá";

                dataGridDichVu.Columns["NgaySuDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridDichVu.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridDichVu.Columns["DonGiaLucDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Cấu hình grid tương tự frmChiTietDichVu
                ConfigGrid(dataGridDichVu);
            }
        }

        private void LoadHuHong(string maPhong)
        {
            DataTable dt = CheckOutDAL.Instance.GetHuHongTheoPhong(maPhong);
            if (dt != null)
            {
                dataGridHuHong.DataSource = dt;
                dataGridHuHong.Columns["TenTB"].HeaderText = "Tên thiết bị";
                dataGridHuHong.Columns["SoLuongHong"].HeaderText = "Số lượng hỏng";
                dataGridHuHong.Columns["PhanTramHong"].HeaderText = "% hỏng";
                dataGridHuHong.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGridHuHong.Columns["GhiChu"].HeaderText = "Ghi chú";

                dataGridHuHong.Columns["SoLuongHong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridHuHong.Columns["PhanTramHong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridHuHong.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Cấu hình grid
                ConfigGrid(dataGridHuHong);
            }
        }

        private void ConfigGrid(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.BorderStyle = BorderStyle.None;
            grid.Font = new Font("Segoe UI", 10F);
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.LightGray;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grid.ColumnHeadersHeight = 75;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            grid.RowTemplate.Height = 50;
        }

        private void ClearInfo()
        {
            lblMaPhong.Text = "";
            lblTenPhong.Text = "";
            lblMaDP.Text = "";
            lblTenKH.Text = "";
            lblNgayDen.Text = "";
            lblNgayTraDuKien.Text = "";
            lblSoNgayO.Text = "";
            dataGridDichVu.DataSource = null;
            dataGridHuHong.DataSource = null;
        }

        private decimal TinhTongTienDV()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dataGridDichVu.Rows)
            {
                tong += Convert.ToDecimal(row.Cells["SoLuong"].Value) * Convert.ToDecimal(row.Cells["DonGiaLucDung"].Value);
            }
            return tong;
        }

        private decimal TinhTongTienHuHong()
        {
            if (dataGridHuHong.Rows.Count > 0)
            {
                return Convert.ToDecimal(dataGridHuHong.Rows[0].Cells["TongTienHuHong"].Value); // Từ Proc
            }
            return 0;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            LoadPhongDangO();
            ConfigGrid(dataGridDichVu);
            ConfigGrid(dataGridHuHong);
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue != null)
            {
                string maPhong = cmbPhong.SelectedValue.ToString();
                LoadThongTinCheckOut(maPhong);
                LoadDichVu(maPhong);
                LoadHuHong(maPhong);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMaDP.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }

            if (MessageBox.Show("Xác nhận check out phòng " + cmbPhong.Text + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maPhong = cmbPhong.SelectedValue.ToString();
                string maDP = lblMaDP.Text;
                decimal tongTienDV = TinhTongTienDV();
                decimal tongTienHuHong = TinhTongTienHuHong();

                if (CheckOutDAL.Instance.CheckOut(maPhong, maDP, tongTienDV, tongTienHuHong))
                {
                    MessageBox.Show("Check out thành công!");
                    LoadPhongDangO(); // Refresh combo
                    ClearInfo();
                }
                else
                {
                    MessageBox.Show("Check out thất bại!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}