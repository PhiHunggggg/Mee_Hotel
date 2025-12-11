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
    public partial class frmThemPhieuKTHH : Form
    {
        private string _maPhieu = null; // Null: thêm mới; Không null: sửa

        public frmThemPhieuKTHH(string maPhieu = null)
        {
            InitializeComponent();
            _maPhieu = maPhieu;
        }

        private void LoadDanhSachThietBi()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            DataTable dt = PhieuKiemTraHuHongDAL.Instance.GetThietBiTheoPhong(cmbPhong.SelectedValue?.ToString() ?? "");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MaThietBi"].Visible = false;
               
                dataGridView1.Columns["TenTB"].HeaderText = "Tên thiết bị";
                dataGridView1.Columns["SoLuongHienTai"].HeaderText = "Số lượng hiện tại ";
                dataGridView1.Columns["GiaThietBi"].HeaderText = "Giá Đền Bù";
                dataGridView1.Columns["SoLuongHong"].HeaderText = "Số lượng hỏng";
                dataGridView1.Columns["PhanTramHong"].HeaderText = "% hỏng";
                dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
              
                dataGridView1.Columns["TenTB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView1.Columns["SoLuongHienTai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["SoLuongHong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["PhanTramHong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
               
                dataGridView1.Columns["SoLuongHienTai"].ReadOnly = true;
                dataGridView1.Columns["GiaThietBi"].ReadOnly = true;
            }
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null && !row.IsNewRow)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("0") + " VND";
        }

        private void frmThemPhieuKTHH_Load(object sender, EventArgs e)
        {
            // Load danh sách phòng
            DataTable dtPhong = PhieuKiemTraHuHongDAL.Instance.GetDanhSachPhongDangO();
            if (dtPhong != null)
            {
                cmbPhong.DataSource = dtPhong;
                cmbPhong.DisplayMember = "TenPhong";
                cmbPhong.ValueMember = "MaPhong";
            }

            // Cấu hình DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 75;
            dataGridView1.RowTemplate.Height = 50;

            if (_maPhieu != null) // Chế độ sửa
            {
                this.Text = "Sửa Phiếu Kiểm Tra Hư Hỏng";
                btnLuu.Text = "Cập Nhật";
                DataRow phieu = PhieuKiemTraHuHongDAL.Instance.GetPhieuByMa(_maPhieu); // Giả định DAL có method này
                if (phieu != null)
                {
                    txtMaPhieu.Text = _maPhieu;
                    cmbPhong.SelectedValue = phieu["MaPhong"];
                    txtNhanVien.Text = phieu["MaNV"].ToString();
                    dtpNgayKiemTra.Value = Convert.ToDateTime(phieu["NgayKiemTra"]);
                   ;
                    // Load chi tiết thiết bị
                    LoadDanhSachThietBi();
                    DataTable chiTiet = PhieuKiemTraHuHongDAL.Instance.GetChiTietPhieu(_maPhieu);
                    if (chiTiet != null)
                    {
                        foreach (DataRow row in chiTiet.Rows)
                        {
                            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
                            {
                                if (dgvRow.Cells["MaThietBi"].Value.ToString() == row["MaThietBi"].ToString())
                                {
                                    dgvRow.Cells["SoLuongHong"].Value = row["SoLuongHong"];
                                    dgvRow.Cells["PhanTramHong"].Value = row["PhanTramHong"];
                                    dgvRow.Cells["GhiChu"].Value = row["GhiChu"];
                                    // Tính ThanhTien
                                    decimal gia = Convert.ToDecimal(dgvRow.Cells["GiaThietBi"].Value);
                                    int slHong = Convert.ToInt32(row["SoLuongHong"]);
                                    int ptHong = Convert.ToInt32(row["PhanTramHong"]);
                                    dgvRow.Cells["ThanhTien"].Value = gia * slHong * (ptHong / 100m);
                                    break;
                                }
                            }
                        }
                        TinhTongTien();
                    }
                }
            }
            else // Thêm mới
            {
                this.Text = "Thêm Phiếu Kiểm Tra Hư Hỏng";
                txtMaPhieu.Text = PhieuKiemTraHuHongDAL.Instance.TaoMaPhieuMoi(); // Giả định DAL sinh mã mới (ví dụ: PKTH001)
                txtNhanVien.Text = "NV001"; // Lấy từ session login
                dtpNgayKiemTra.Value = DateTime.Now;
                cmbPhong.SelectedIndex = -1;
            }
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue != null)
            {
                LoadDanhSachThietBi();
                TinhTongTien(); // Reset tổng tiền
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (dataGridView1.Columns[e.ColumnIndex].Name == "SoLuongHong" || dataGridView1.Columns[e.ColumnIndex].Name == "PhanTramHong")
                {
                    int soLuongHong = row.Cells["SoLuongHong"].Value != null ? Convert.ToInt32(row.Cells["SoLuongHong"].Value) : 0;
                    int phanTramHong = row.Cells["PhanTramHong"].Value != null ? Convert.ToInt32(row.Cells["PhanTramHong"].Value) : 0;
                    decimal giaThietBi = Convert.ToDecimal(row.Cells["GiaThietBi"].Value);

                    if (soLuongHong > Convert.ToInt32(row.Cells["SoLuongHienTai"].Value))
                    {
                        MessageBox.Show("Số lượng hỏng không vượt quá số lượng hiện tại !");
                        row.Cells["SoLuongHong"].Value = 0;
                        return;
                    }

                    if (phanTramHong > 100 || phanTramHong < 0)
                    {
                        MessageBox.Show("% hỏng phải từ 0 đến 100!");
                        row.Cells["PhanTramHong"].Value = 0;
                        return;
                    }

                    decimal thanhTien = giaThietBi * soLuongHong * (phanTramHong / 100m);
                    row.Cells["ThanhTien"].Value = thanhTien;
                    TinhTongTien();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue == null || string.IsNullOrEmpty(txtNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string maPhieu = txtMaPhieu.Text;
            string maPhong = cmbPhong.SelectedValue.ToString();
            string maNV = txtNhanVien.Text;
            DateTime ngayKiemTra = dtpNgayKiemTra.Value;

            // Tạo bảng chi tiết (giữ nguyên như cũ)
            DataTable chiTiet = new DataTable();
            chiTiet.Columns.Add("MaThietBi", typeof(string));
            chiTiet.Columns.Add("SoLuongHong", typeof(int));
            chiTiet.Columns.Add("PhanTramHong", typeof(int));
            chiTiet.Columns.Add("ThanhTien", typeof(decimal));
            chiTiet.Columns.Add("GhiChu", typeof(string));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                int slHong = row.Cells["SoLuongHong"].Value != null ? Convert.ToInt32(row.Cells["SoLuongHong"].Value) : 0;
                if (slHong > 0)
                {
                    chiTiet.Rows.Add(
                        row.Cells["MaThietBi"].Value,
                        slHong,
                        row.Cells["PhanTramHong"].Value,
                        row.Cells["ThanhTien"].Value,
                        row.Cells["GhiChu"].Value
                    );
                }
            }

            bool success = _maPhieu == null
                ? PhieuKiemTraHuHongDAL.Instance.ThemPhieu(maPhieu, maPhong, maNV, ngayKiemTra, chiTiet)
                : PhieuKiemTraHuHongDAL.Instance.SuaPhieu(maPhieu, maPhong, maNV, ngayKiemTra, chiTiet);

            if (success)
            {
                MessageBox.Show("Lưu thành công!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}