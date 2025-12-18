using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private string _currentMaDP = null;

        private void LoadPhieuDaCheckIn(string searchTerm = "")
        {
            try
            {
                DataTable dt = CheckOutDAL.Instance.GetPhieuDaCheckIn(searchTerm, searchTerm, searchTerm, searchTerm);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu nào. Kiểm tra dữ liệu hoặc từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvPhieuDP.DataSource = dt;

                if (dgvPhieuDP.Columns.Contains("NgayDen"))
                    dgvPhieuDP.Columns["NgayDen"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                if (dgvPhieuDP.Columns.Contains("NgayTraDuKien"))
                    dgvPhieuDP.Columns["NgayTraDuKien"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                ConfigGrid(dgvPhieuDP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu: " + ex.Message + "\nKiểm tra kết nối DB hoặc stored procedure.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPhongCuaPhieu(string maDP)
        {

            try
            {
                DataTable dt = CheckOutDAL.Instance.GetPhongCuaPhieu(maDP);
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
                ClearChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadChiTietSelectedRooms()
        {
            List<string> selectedRooms = GetSelectedRooms();
            if (selectedRooms.Count == 0)
            {
                ClearChiTiet();
                return;
            }
            string maPhongList = string.Join(",", selectedRooms);
            // Số ngày ở thực tế
            DataTable dtSoNgay = CheckOutDAL.Instance.GetSoNgayOThucTeList(maPhongList);
            dgvSoNgayO.DataSource = dtSoNgay;
            ConfigGrid(dgvSoNgayO);
            // Dịch vụ
            DataTable dtDV = CheckOutDAL.Instance.GetDichVuTheoPhongList(maPhongList);
            dataGridDichVu.DataSource = dtDV;
            ConfigGrid(dataGridDichVu);
            // Hư hỏng
            DataTable dtHH = CheckOutDAL.Instance.GetHuHongTheoPhongList(maPhongList);
            dataGridHuHong.DataSource = dtHH;
            ConfigGrid(dataGridHuHong);
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
        private void ClearChiTiet()
        {
            dgvSoNgayO.DataSource = null;
            dataGridDichVu.DataSource = null;
            dataGridHuHong.DataSource = null;
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
            grid.ColumnHeadersHeight = 60 ;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            grid.RowTemplate.Height = 40;
        }
        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            LoadPhieuDaCheckIn();
            ConfigGrid(dgvPhieuDP);
            ConfigGrid(dgvPhongBatch);
            ConfigGrid(dgvSoNgayO);
            ConfigGrid(dataGridDichVu);
            ConfigGrid(dataGridHuHong);
            dgvPhongBatch.CurrentCellDirtyStateChanged += dgvPhongBatch_CurrentCellDirtyStateChanged;

        }
        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            LoadPhieuDaCheckIn(txtSearch.Text.Trim());
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPhieuDaCheckIn(txtSearch.Text.Trim());
                e.SuppressKeyPress = true;
            }
        }
        private void dgvPhieuDP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuDP.CurrentRow == null) return;

            string maDP = dgvPhieuDP.CurrentRow.Cells["MaDP"].Value?.ToString();
            if (string.IsNullOrEmpty(maDP)) return;

            // LOAD KHI ĐỔI PHIẾU
            if (_currentMaDP != maDP)
            {
                _currentMaDP = maDP;
                LoadPhongCuaPhieu(maDP);
            }
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
            if (dgvPhieuDP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maDP = dgvPhieuDP.CurrentRow.Cells["MaDP"].Value.ToString();
            List<string> selectedRooms = GetSelectedRooms();
            if (selectedRooms.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng để check-out!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string roomList = string.Join(",", selectedRooms);
            if (MessageBox.Show($"Xác nhận check-out {selectedRooms.Count} phòng đã chọn trong phiếu {maDP}?",
            "Xác nhận check-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = CheckOutDAL.Instance.CheckOutTheoPhieu(maDP, 0, 0, roomList);
                if (success)
                {
                    MessageBox.Show("Check-out thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuDaCheckIn();
                    ClearChiTiet();
                    dgvPhongBatch.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Check-out thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPhieuDaCheckIn(txtSearch.Text.Trim());
        }

    }
}