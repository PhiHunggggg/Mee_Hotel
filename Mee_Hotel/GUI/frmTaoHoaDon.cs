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
    public partial class frmTaoHoaDon : Form
    {
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadPhongCuaPhieu(ThongTinDonHang.MaDP);
            ConfigGrid(dgvPhongBatch);
            ConfigGrid(dgvSoNgayO);
            ConfigGrid(dataGridDichVu);
            ConfigGrid(dataGridHuHong);
            dgvPhongBatch.CurrentCellDirtyStateChanged += dgvPhongBatch_CurrentCellDirtyStateChanged;
            dgvPhongBatch.CellValueChanged += dgvPhongBatch_CellValueChanged;
            lbTenKH_new.Text = ThongTinDonHang.TenKH;
            lb_NgayTT_new.Text = ThongTinDonHang.NgayTT.ToString();
            lbMaDP_new.Text = ThongTinDonHang.MaDP;
            lbTenNV_moi.Text = StaticThing.TenNV;

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
            this.Close();
        }

        private string _currentMaDP = ThongTinDonHang.MaDP;

        private void LoadPhongCuaPhieu(string maDP)
        {

            try
            {
                DataTable dt = HoaDon_DVDAL.Instance.GetPhongCuaPhieuHD(maDP);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Phiếu này không có phòng đang ở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvPhongBatch.DataSource = dt; 
                if (dgvPhongBatch.Columns.Contains("chkSelect"))
                    dgvPhongBatch.Columns.Remove("chkSelect");

                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Chọn",
                    Name = "chkSelect",
                    Width = 60,
                    TrueValue = true,
                    FalseValue = false
                };
                dgvPhongBatch.Columns.Insert(0, chk);

                dgvPhongBatch.ReadOnly = false;
                foreach (DataGridViewColumn col in dgvPhongBatch.Columns)
                {
                    if (col.Name != "chkSelect")
                        col.ReadOnly = true;
                }
               
                ConfigGrid(dgvPhongBatch);
                dgvPhongBatch.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadChiTietSelectedRooms()
        {
            List<string> selectedRooms = GetSelectedRooms();
            string maPhongList = string.Join(",", selectedRooms);
            // Số ngày ở thực tế
            DataTable dtSoNgay = HoaDonDAL.Instance.GetSoNgayOThucHD(maPhongList);
            dgvSoNgayO.DataSource = dtSoNgay;
            ConfigGrid(dgvSoNgayO);
            decimal TienPhong = 0;
            foreach(DataGridViewRow row in dgvSoNgayO.Rows)
            {
                TienPhong += Convert.ToDecimal(row.Cells["GiaLucDat"].Value?.ToString());
            }
            ThongTinDonHang.TongTienDP = TienPhong;
            txtTongTienPhong.Text = TienPhong.ToString() + " VND";
            // Dịch vụ
            DataTable dtDV = CheckOutDAL.Instance.GetDichVuTheoPhongList(maPhongList);
            dataGridDichVu.DataSource = dtDV;
            ConfigGrid(dataGridDichVu);
            decimal TienDV = 0;
            foreach(DataGridViewRow row in dataGridDichVu.Rows)
            {
                TienDV += Convert.ToDecimal(row.Cells["DonGiaLucDung"].Value?.ToString());
            }
            ThongTinDonHang.TongTienDV = TienDV;
            txtTongTienDV.Text = TienDV.ToString() + " VND";
            // Hư hỏng
            DataTable dtHH = CheckOutDAL.Instance.GetHuHongTheoPhongList(maPhongList);
            dataGridHuHong.DataSource = dtHH;
            ConfigGrid(dataGridHuHong);
            decimal TienHH = 0;
            foreach(DataGridViewRow row in dataGridHuHong.Rows)
            {
                TienHH += Convert.ToDecimal(row.Cells["ThanhTien"].Value?.ToString());
            }
            ThongTinDonHang.TongTienBT = TienHH;
            txtTongTienHH.Text = TienHH.ToString() + " VND";
            int num = dataGridHuHong.RowCount;
            if (num > 0) ThongTinDonHang.MaKTHH = dataGridHuHong.Rows[0].Cells["MaPhieu_KTHH"].Value?.ToString();
            else ThongTinDonHang.MaKTHH = "";
        }
        private List<string> GetSelectedRooms()
        {
            List<string> rooms = new List<string>();
            foreach (DataGridViewRow row in dgvPhongBatch.Rows)
            {
                if (row.Cells["chkSelect"].Value != null && (bool)row.Cells["chkSelect"].Value)
                {
                    rooms.Add(row.Cells["MaPhong"].Value.ToString());
                }
            }
            return rooms;
        }
        private void ConfigGrid(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

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
            grid.ColumnHeadersHeight = 60;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            grid.RowTemplate.Height = 40;
        }
        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        
        private void dgvPhongBatch_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvPhongBatch.Columns[e.ColumnIndex].Name == "chkSelect")
            {
                LoadChiTietSelectedRooms();
            }
        }
        private void dgvPhongBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhongBatch.Columns[e.ColumnIndex].Name == "chkSelect")
            {
                bool current = Convert.ToBoolean(
                    dgvPhongBatch.Rows[e.RowIndex].Cells["chkSelect"].Value ?? false);

                dgvPhongBatch.Rows[e.RowIndex].Cells["chkSelect"].Value = !current;
            }
        }

        private void dgvPhongBatch_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPhongBatch.IsCurrentCellDirty)
            {
                dgvPhongBatch.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void btnCheckOutBatch_Click(object sender, EventArgs e)
        {
            
        }
        

        private void dgvPhieuDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnCheckOutBatch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ThongTinDonHang.MaHD))  ThongTinDonHang.MaHD = HoaDonDAL.Instance.TaoHoaDon(ThongTinDonHang.MaKH, ThongTinDonHang.MaDP, ThongTinDonHang.NgayTT, ThongTinDonHang.TongTienDP, ThongTinDonHang.TongTienBT,Convert.ToDecimal(Thueud.Value.ToString()), ThongTinDonHang.TongTienDV, "Chưa thanh toán", "", ThongTinDonHang.MaKTHH);
            else
            {
                MessageBox.Show("Đơn hàng đã có!!");
                ThongTinDonHang.MaHD = null;
                this.Close();
                return;
            }
            foreach (DataGridViewRow row in dgvSoNgayO.Rows)
            {
                // Bỏ qua dòng trống cuối
                if (row.IsNewRow) continue;

                string maPhong = row.Cells["MaPhong"].Value?.ToString();

                if (string.IsNullOrEmpty(maPhong)) continue;

                decimal soNgayO = Convert.ToDecimal(row.Cells["SoNgayO"].Value);
                decimal tienPhong = Convert.ToDecimal(row.Cells["GiaLucDat"].Value);
                decimal TienTra = soNgayO * tienPhong;

                // Gọi proc thêm chi tiết hóa đơn
                int tst = HoaDonDAL.Instance.Chitiethd_proc(
                    ThongTinDonHang.MaHD,
                    maPhong,
                    TienTra,
                    StaticThing.MaNV
                );
                if (tst > 0) MessageBox.Show(maPhong);
            }
            if (ThongTinDonHang.MaHD != null)
            {
                MessageBox.Show("Thêm hóa đơn thành công");
            }
            else MessageBox.Show("Chưa thêm dc hóa đơn");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSoNgayO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            bool xl = true;
            if (ThongTinDonHang.MaHD == null) ThongTinDonHang.MaHD = HoaDonDAL.Instance.TaoHoaDon(ThongTinDonHang.MaKH, ThongTinDonHang.MaDP, ThongTinDonHang.NgayTT, ThongTinDonHang.TongTienDP, ThongTinDonHang.TongTienBT, Convert.ToDecimal(Thueud.Value.ToString()), ThongTinDonHang.TongTienDV, "Chưa thanh toán", "", ThongTinDonHang.MaKTHH);
            else
            {
                MessageBox.Show("Đơn hàng đã có!!");
                xl = false;
                this.Close();
            }
            if (ThongTinDonHang.MaHD != null && xl)
            {
                MessageBox.Show("Thêm hóa đơn thành công");
            }
            else MessageBox.Show("Chưa thêm dc hóa đơn");
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
            this.Close();
        }
    }
}

