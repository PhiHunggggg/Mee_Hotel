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
    public partial class frmChiTietKiemTraHuHong : Form
    {
        private string _maPhieu;

        public frmChiTietKiemTraHuHong(string maPhieu)
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

        private void frmChiTietKiemTraHuHong_Load(object sender, EventArgs e)
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
            dataGridView1.ReadOnly = true;
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

            // Chế độ xem chi tiết
            this.Text = "Xem Chi Tiết Phiếu Kiểm Tra Hư Hỏng";
           
            btnHuy.Text = "Đóng"; // Đổi nút Hủy thành Đóng

            // Disable các control chỉnh sửa
            txtMaPhieu.ReadOnly = true;
            cmbPhong.Enabled = false;
            txtNhanVien.ReadOnly = true;
            dtpNgayKiemTra.Enabled = false;
            dataGridView1.ReadOnly = true; // DataGridView chỉ đọc

            DataRow phieu = PhieuKiemTraHuHongDAL.Instance.GetPhieuByMa(_maPhieu); // Giả định DAL có method này
            if (phieu != null)
            {
                txtMaPhieu.Text = _maPhieu;
                cmbPhong.SelectedValue = phieu["MaPhong"];
                txtNhanVien.Text = phieu["MaNV"].ToString();
                dtpNgayKiemTra.Value = Convert.ToDateTime(phieu["NgayKiemTra"]);

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

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần vì disable
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần vì read-only
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}