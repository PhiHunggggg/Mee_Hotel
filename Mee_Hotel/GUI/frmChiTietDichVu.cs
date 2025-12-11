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
        private void LoadDanhSachDichVu()
        {
            DateTime? tuNgay =null, denNgay=null;
            if (ckbLocTheoNgay.Checked == true)
            {
                tuNgay = dtpTu.Value;
                denNgay = dtpDen.Value;
            }
                DataTable dt = DichVuDAL.Instance.getDanhSachDichVu(tuNgay,denNgay); 
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["NgayDen"].Visible = false;
                    dataGridView1.Columns["NgayTra"].Visible = false;
                    dataGridView1.Columns["GhiChu"].Visible = false;
                    dataGridView1.Columns["MaPhong"].Visible = false;
                    dataGridView1.Columns["MaDV"].Visible = false;

                    dataGridView1.Columns["Tên phòng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns["Ngày sử dụng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
        }
        private void LoadDanhSachDichVuKhachHang()
        {
            DateTime? tuNgay = null, denNgay = null;
            if (ckbLocTheoNgay.Checked == true)
            {
                tuNgay = dtpTu.Value;
                denNgay = dtpDen.Value;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            DataTable bangDichVu = DichVuDAL.Instance.getDanhSachDichVu(txtTimKiem.Text,tuNgay,denNgay);
            dataGridView1.DataSource = bangDichVu;
            if (bangDichVu != null)
            {
                dataGridView1.Columns["NgayDen"].Visible = false;
                dataGridView1.Columns["NgayTra"].Visible = false;
                dataGridView1.Columns["GhiChu"].Visible = false;
                dataGridView1.Columns["MaPhong"].Visible = false;
                dataGridView1.Columns["MaDV"].Visible = false;

                dataGridView1.Columns["Tên phòng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Ngày sử dụng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
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

            LoadDanhSachDichVu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string maPhong;
        private string maDichVu;
        private DateTime NgaySuDung;

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDanhSachDichVu();
            }
            else
            {
                LoadDanhSachDichVuKhachHang();
            }
        }

        private void dtpTu_ValueChanged_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDanhSachDichVu();
            }
            else
            {
                LoadDanhSachDichVuKhachHang();
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
                if (row.Cells["Tên khách hàng"].Value != null && row.Cells["Tên phòng"].Value != null && dataGridView1.CurrentRow.Cells["NgayDen"].Value != null && dataGridView1.CurrentRow.Cells["NgayTra"].Value != null)
                {
                    lblTenKH.Text = row.Cells["Tên khách hàng"].Value.ToString();
                    lblPhong.Text = row.Cells["Tên phòng"].Value.ToString();
                    lblNgayDen.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayDen"].Value)
                                           .ToString("dd/MM/yyyy");
                    lblNgayTra.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NgayTra"].Value)
                                           .ToString("dd/MM/yyyy");
                    txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                    maPhong = row.Cells["MaPhong"].Value.ToString();
                    maDichVu = row.Cells["MaDV"].Value.ToString();
                    NgaySuDung = Convert.ToDateTime( row.Cells["Ngày sử dụng"].Value);
                }
                else
                {
                    lblTenKH.Text = lblPhong.Text = lblNgayDen.Text = lblNgayTra.Text = "Không có dữ liêu";
                }
                }
        }
        private void ckbLocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDanhSachDichVu();
            }
            else
            {
                LoadDanhSachDichVuKhachHang();
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            frmThemDichVu frmThemDV = new frmThemDichVu(maPhong);
            frmThemDV.ShowDialog();
            LoadDanhSachDichVu();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            frmSuaDichVu frmSuaDV = new frmSuaDichVu(maPhong, maDichVu, NgaySuDung);
            frmSuaDV.ShowDialog();
            LoadDanhSachDichVu();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (maPhong == null || maDichVu == null || NgaySuDung == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa !!!");
                return;
            }
            else
            {
                var kq = DichVuDAL.Instance.XoaDichVuPhong(maPhong, maDichVu, NgaySuDung, StaticThing.MaNV);

                if (kq.Success)
                {
                    MessageBox.Show(kq.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDichVu(); 
                }
                else
                {
                    MessageBox.Show("Không thể xóa: " + kq.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
