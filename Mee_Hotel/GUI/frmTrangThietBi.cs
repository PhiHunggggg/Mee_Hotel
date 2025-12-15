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
    public partial class frmTrangThietBi : Form
    {
        public frmTrangThietBi()
        {
            InitializeComponent();
        }

        private void LoadLoaiPhong()
        {
            DataTable dt = TrangThietBiDAL.Instance.GetLoaiPhong();
            if (dt != null)
            {
                cmbLoaiPhong.DataSource = dt;
                cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
                cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            }
        }

        private void LoadPhongTheoLoai(string maLoaiPhong)
        {
            DataTable dt = TrangThietBiDAL.Instance.GetPhongTheoLoai(maLoaiPhong);
            if (dt != null)
            {
                cmbPhong.DataSource = dt;
                cmbPhong.DisplayMember = "TenPhong";
                cmbPhong.ValueMember = "MaPhong";
            }
        }

        private void LoadAllTrangThietBi()
        {
            DataTable dt = TrangThietBiDAL.Instance.GetAllTrangThietBi();
            if (dt != null)
            {
                cmbThietBi.DataSource = dt;
                cmbThietBi.DisplayMember = "TenThietBi";
                cmbThietBi.ValueMember = "MaTB";
            }
        }

        private void LoadTrangThietBiTheoPhong(string maPhong)
        {
            DataTable dt = TrangThietBiDAL.Instance.GetTrangThietBiTheoPhong(maPhong);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MaTB"].Visible = false; // Ẩn mã
                dataGridView1.Columns["TenThietBi"].HeaderText = "Tên thiết bị";
                dataGridView1.Columns["SoLuongGoc"].HeaderText = "Số lượng gốc";
                dataGridView1.Columns["SoLuongHienTai"].HeaderText = "Số lượng hiện tại";

                dataGridView1.Columns["TenThietBi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView1.Columns["SoLuongGoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["SoLuongHienTai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void frmTrangThietBi_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            LoadAllTrangThietBi();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true; 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;

            // Header
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 75;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.RowTemplate.Height = 50;

            // Load mặc định nếu cần
            if (cmbLoaiPhong.Items.Count > 0)
            {
                cmbLoaiPhong.SelectedIndex = 0;
            }
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
            LoadPhongTheoLoai(maLoaiPhong);
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue != null)
            {
                string maPhong = cmbPhong.SelectedValue.ToString();
                LoadTrangThietBiTheoPhong(maPhong);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbPhong.SelectedValue == null || cmbThietBi.SelectedValue == null || string.IsNullOrEmpty(txtSoLuongGoc.Text) || string.IsNullOrEmpty(txtSoLuongHienTai.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng, thiết bị và nhập số lượng!");
                return;
            }

            string maPhong = cmbPhong.SelectedValue.ToString();
            string maTB = cmbThietBi.SelectedValue.ToString();
            int soLuongGoc = int.Parse(txtSoLuongGoc.Text);
            int soLuongHienTai = int.Parse(txtSoLuongHienTai.Text);

            if (TrangThietBiDAL.Instance.ThemTrangThietBiPhong(maPhong, maTB, soLuongGoc, soLuongHienTai))
            {
                MessageBox.Show("Thêm thiết bị thành công!");
                LoadTrangThietBiTheoPhong(maPhong);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || cmbPhong.SelectedValue == null || string.IsNullOrEmpty(txtSoLuongGoc.Text) || string.IsNullOrEmpty(txtSoLuongHienTai.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa và nhập số lượng mới!");
                return;
            }

            string maPhong = cmbPhong.SelectedValue.ToString();
            string maTB = dataGridView1.CurrentRow.Cells["MaTB"].Value.ToString();
            int soLuongGocMoi = int.Parse(txtSoLuongGoc.Text);
            int soLuongHienTaiMoi = int.Parse(txtSoLuongHienTai.Text);

            if (TrangThietBiDAL.Instance.SuaTrangThietBiPhong(maPhong, maTB, soLuongGocMoi, soLuongHienTaiMoi))
            {
                MessageBox.Show("Sửa thành công!");
                LoadTrangThietBiTheoPhong(maPhong);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            string maPhong = cmbPhong.SelectedValue.ToString();
            string maTB = dataGridView1.CurrentRow.Cells["MaTB"].Value.ToString();

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TrangThietBiDAL.Instance.XoaTrangThietBiPhong(maPhong, maTB))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadTrangThietBiTheoPhong(maPhong);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSoLuongGoc.Text = row.Cells["SoLuongGoc"].Value.ToString();
                txtSoLuongHienTai.Text = row.Cells["SoLuongHienTai"].Value.ToString();
                // cmbThietBi có thể set nếu cần, nhưng vì sửa thì không cần
            }
        }
    }
}