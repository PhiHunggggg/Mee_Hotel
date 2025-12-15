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
using Microsoft.VisualBasic;
namespace Mee_Hotel.GUI.Phong
{
    public partial class frmPhieuDP : Form
    {
        public frmPhieuDP()
        {
            InitializeComponent();
        }
        private string maPhieuDat;
        private void LoadDanhSachPhieuDP()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            string tuKhoa = txtTimKiem.Text.Trim();
            DateTime? ngayDen1 = null;
            DateTime? ngayDen2 = null;

            DateTime? ngayTra1 = null;
            DateTime? ngayTra2 = null;

            if (ckbDen.Checked)
            {
                ngayDen1 = dtpDen1.Value.Date;
                ngayDen2 = dtpDen2.Value.Date;
            }
            else
            {
                ngayDen1 = null;
                ngayDen2 = null;
            }
            if (ckbTra.Checked)
            {
                ngayTra1 = dtpDen1.Value.Date;
                ngayTra2 = dtpDen2.Value.Date;
            }
            else
            {
                ngayTra1 = null;
                ngayTra2 = null;
            }

            string loi;
            DataTable dt = PhongDAL.Instance.TimKiemPhieuDatPhong(
                 out loi,
                tuKhoa: tuKhoa == "" ? null : tuKhoa,
                ngayDenTu: ngayDen1,
                ngayDenDen: ngayDen2,
                ngayTraTu: ngayTra1,
                ngayTraDen: ngayTra2,
                trangThai: null
               );
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["MaKH"].Visible = false;
            dataGridView1.Columns["DanhSachLoaiPhong"].Visible = false;
            dataGridView1.Columns["Ghi chú"].Visible = false;
            dataGridView1.Columns["Mail"].Visible = false;
            dataGridView1.Columns["Số người đăng kí"].HeaderText = "Số người";
            dataGridView1.Columns["Số người đăng kí"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Số người đăng kí"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Số người đăng kí"].FillWeight =35;


        }
        private void frmPhieuDP_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDP();
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
            LoadDanhSachPhieuDP();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDP();
        }

        private void siticoneShapes2_Click(object sender, EventArgs e)
        {

        }
        private int Check = 1;
        private int Check2 = 1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    lblTenKH.Text = row.Cells["Tên khách"].Value.ToString();
                    txtGhiChu.Text = row.Cells["Ghi chú"].Value.ToString();
                txtLoaiPhongDat.Text = row.Cells["DanhSachLoaiPhong"].Value.ToString();
                maPhieuDat = row.Cells["Mã phiếu"].Value.ToString();
                Check = Convert.ToInt32(row.Cells["TrangThai"].Value);
                if(row.Cells["Trạng thái"].Value.ToString()!="Đã đặt")
                {
                    Check2 = 0;
                }
                else if(row.Cells["Trạng thái"].Value.ToString() == "Đã hủy")
                {
                    Check2 = 3;
                }
                else
                {
                    Check2 = 1;
                }
            }
        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void ckbDen_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDP();
        }

        private void dtpDen1_ValueChanged(object sender, EventArgs e)
        {
            if (ckbDen.Checked)
            {
                LoadDanhSachPhieuDP();
            }
        }

        private void dtpTra1_ValueChanged(object sender, EventArgs e)
        {
            if (ckbTra.Checked)
            {
                LoadDanhSachPhieuDP();
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (Check == 2&&Check2!=3)
            {
                MessageBox.Show("Phiếu đã bị từ chối !!!");
                return;
            }
            if( (Check == 3 || Check == 4)&&Check2!=3)
            {
                MessageBox.Show("Đã nhận phòng không thể sửa");
                return;
            }
            if (Check2 == 0)
            {
                MessageBox.Show("Đã nhận phòng không thể sửa");
                return;
            }
            if (Check2 == 3)
            {
                MessageBox.Show("Đã hủy phiếu không thể sửa");
                return;
            }
            SuaPhieuDP SuaDP = new SuaPhieuDP(maPhieuDat);
            SuaDP.ShowDialog();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if ((Check == 3 || Check == 4)&&Check2!=3)
            {
                MessageBox.Show("Đã nhận phòng không thể xóa");
                return;
            }
            if (Check2 == 0)
            {
                MessageBox.Show("Đã nhận phòng không thể xóa");
                return;
            }
            if (Check2 == 3)
            {
                MessageBox.Show("Đã hủy phiếu");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn hủy phiếu đặt phòng này?\nPhiếu sẽ được đánh dấu là ĐÃ HỦY và không thể khôi phục trạng thái cũ.",
        "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            string lyDo = "";
            using (var form = new Form()
            {
                Width = 400,
                Height = 150,
                Text = "Lý do hủy phiếu",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            })
            {
                var txt = new TextBox() { Left = 20, Top = 20, Width = 340 };
                var btnOk = new Button() { Text = "OK", Left = 280, Top = 60, DialogResult = DialogResult.OK };
                var btnCancel = new Button() { Text = "Cancel", Left = 200, Top = 60, DialogResult = DialogResult.Cancel };

                form.Controls.Add(txt);
                form.Controls.Add(btnOk);
                form.Controls.Add(btnCancel);
                form.AcceptButton = btnOk;
                form.CancelButton = btnCancel;

                if (form.ShowDialog() == DialogResult.OK)
                    lyDo = txt.Text;
            }
            string loi;
            bool ketQua = PhongDAL.Instance.XoaPhieuDatPhong(maPhieuDat, lyDo, out loi);

            if (ketQua)
            {
                MessageBox.Show("Hủy phiếu đặt phòng thành công!", "Thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(loi, "Lỗi hủy phiếu");
            }
        }
    }
}
