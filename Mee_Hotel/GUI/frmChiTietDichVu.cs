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
    public partial class frmChiTietDichVu : Form
    {
        public frmChiTietDichVu()
        {
            InitializeComponent();
        }
        private void LoadChiTietDichVu()
        {
                DataTable dt = DichVuDAL.Instance.getChiTietDichVu(); 
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["TenPhong"].HeaderText = "Tên phòng";
                    dataGridView1.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                    dataGridView1.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                    dataGridView1.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
                    dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
                    dataGridView1.Columns["DonGiaLucDung"].HeaderText = "Đơn giá lúc dùng";
                    dataGridView1.Columns["TenNhanVien"].HeaderText = "Tên nhân viên phục vụ";
                    dataGridView1.Columns["GhiChu"].Visible = false;
                    dataGridView1.Columns["NgayDen"].Visible = false;
                    dataGridView1.Columns["NgayTra"].Visible = false;
                    dataGridView1.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns["NgaySuDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
        }
        private void LoadDanhSachDichVu()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            DataTable bangDichVu = DichVuDAL.Instance.getDanhSachDichVu(txtTimKiem.Text,dtpTu.Value,dtpDen.Value);
            dataGridView1.DataSource = bangDichVu;
            if (bangDichVu != null)
            {
                dataGridView1.Columns["TenPhong"].HeaderText = "Tên phòng";
                dataGridView1.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                dataGridView1.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dataGridView1.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
                dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGridView1.Columns["DonGiaLucDung"].HeaderText = "Đơn giá lúc dùng";
                dataGridView1.Columns["TenNhanVien"].HeaderText = "Tên nhân viên phục vụ";
                dataGridView1.Columns["GhiChu"].Visible = false;
                dataGridView1.Columns["NgayDen"].Visible = false;
                dataGridView1.Columns["NgayTra"].Visible = false;
                dataGridView1.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["NgaySuDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
        {
            LoadChiTietDichVu();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            // Font + màu nền
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;

            // Header
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 75;   // bạn muốn cao bao nhiêu thì ghi vào đây
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Height = 55;
                dataGridView1.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 215);
            }
            dataGridView1.RowTemplate.Height = 50;

            LoadChiTietDichVu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadChiTietDichVu();
            }
            else
            {
                LoadDanhSachDichVu();
            }
        }

        private void dtpTu_ValueChanged_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadChiTietDichVu();
            }
            else
            {
                LoadDanhSachDichVu();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                lblTenKH.Text= row.Cells["TenKhachHang"].Value.ToString();
                lblPhong.Text = row.Cells["TenPhong"].Value.ToString();
                lblNgayDen.Text= Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayDen"].Value)
                                       .ToString("dd/MM/yyyy");
                lblNgayTra.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayTra"].Value)
                                       .ToString("dd/MM/yyyy");
            }
        }
    }
}
