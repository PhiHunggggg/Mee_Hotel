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
    public partial class frmPhieuKiemTraHuHong : Form
    {
        public frmPhieuKiemTraHuHong()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhieu(string tuKhoa = "", DateTime? ngayTim = null)
        {
            DataTable dt = PhieuKiemTraHuHongDAL.Instance.GetDanhSachPhieu(tuKhoa, ngayTim); // Cập nhật DAL để hỗ trợ tuKhoa tìm nhiều trường
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                FormatDataGridViewColumns();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        void FormatDataGridViewColumns()
        {
            if (dataGridView1.Columns.Contains("MaPhieu")) dataGridView1.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
            if (dataGridView1.Columns.Contains("MaPhong")) dataGridView1.Columns["MaPhong"].HeaderText = "Mã Phòng";
            if (dataGridView1.Columns.Contains("TenPhong")) dataGridView1.Columns["TenPhong"].HeaderText = "Tên Phòng";
            if (dataGridView1.Columns.Contains("MaNV")) dataGridView1.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            if (dataGridView1.Columns.Contains("NgayKiemTra"))
            {
                dataGridView1.Columns["NgayKiemTra"].HeaderText = "Ngày Kiểm Tra";
                dataGridView1.Columns["NgayKiemTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dataGridView1.Columns.Contains("TongTien"))
            {
                dataGridView1.Columns["TongTien"].HeaderText = "Tổng Tiền";
                dataGridView1.Columns["TongTien"].DefaultCellStyle.Format = "0 VND";
            }

            // Căn giữa header
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridView1.RowTemplate.Height = 50;
        }

        private void frmPhieuKiemTraHuHong_Load(object sender, EventArgs e)
        {
            // Cấu hình DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 75;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;





            LoadDanhSachPhieu();
        }

        private void chkTimTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayTim.Enabled = chkTimTheoNgay.Checked;
            LoadDanhSachPhieu(txtTimKiem.Text.Trim(), chkTimTheoNgay.Checked ? (DateTime?)dtpNgayTim.Value.Date : null);
        }

        private void dtpNgayTim_ValueChanged(object sender, EventArgs e)
        {
            if (chkTimTheoNgay.Checked)
            {
                LoadDanhSachPhieu(txtTimKiem.Text.Trim(), dtpNgayTim.Value.Date);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieu(txtTimKiem.Text.Trim(), chkTimTheoNgay.Checked ? (DateTime?)dtpNgayTim.Value.Date : null);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            frmThemPhieuKTHH f = new frmThemPhieuKTHH();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachPhieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu để sửa!");
                return;
            }
            string maPhieu = dataGridView1.CurrentRow.Cells["MaPhieu"].Value.ToString();
            frmThemPhieuKTHH f = new frmThemPhieuKTHH(maPhieu);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachPhieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu để xóa!");
                return;
            }
            string maPhieu = dataGridView1.CurrentRow.Cells["MaPhieu"].Value.ToString();
            if (MessageBox.Show($"Xác nhận xóa phiếu {maPhieu}?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (PhieuKiemTraHuHongDAL.Instance.XoaPhieu(maPhieu))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachPhieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            chkTimTheoNgay.Checked = false;
            LoadDanhSachPhieu();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu để xem chi tiết!");
                return;
            }

           
            string columnName = dataGridView1.Columns.Contains("MaPhieu") ? "MaPhieu" : "MaPhieu_KTHH";
            if (dataGridView1.CurrentRow.Cells[columnName].Value == null)
            {
                MessageBox.Show("Không tìm thấy mã phiếu trong dòng chọn!");
                return;
            }

            string maPhieu = dataGridView1.CurrentRow.Cells[columnName].Value.ToString();
            frmChiTietKiemTraHuHong f = new frmChiTietKiemTraHuHong(maPhieu);
            f.ShowDialog();
        }
    }
}