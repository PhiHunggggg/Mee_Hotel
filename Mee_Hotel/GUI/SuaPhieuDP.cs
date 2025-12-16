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
using System.Xml.Linq;
namespace Mee_Hotel.GUI
{
    public partial class SuaPhieuDP : Form
    {
        private string maPhieuDat;
        public SuaPhieuDP(string maPhieuDat)
        {
            InitializeComponent();
            this.maPhieuDat = maPhieuDat;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SuaPhieuDP_Load(object sender, EventArgs e)
        {
            string maDP = maPhieuDat;
            if (string.IsNullOrWhiteSpace(maDP))
            {
                MessageBox.Show("Nhập mã phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kq = PhongDAL.Instance.LayThongTinPhieuDat(maDP);
            if (kq.Loi != "OK")
            {
                MessageBox.Show(kq.Loi, "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var p = kq.ThongTin;
            dtpDen.Value = Convert.ToDateTime(p["NgayNhan"]);
            dtpTra.Value = Convert.ToDateTime(p["NgayTra"]);
            dgvChiTiet.DataSource = kq.ChiTiet;
            dgvChiTiet.Columns["GiaDat"].Visible = false;
            dgvChiTiet.Columns["SoNguoiToiDa"].Visible = false;
            dgvChiTiet.Columns["GiaHienTai"].Visible = false;
            dgvChiTiet.Columns["ThanhTien"].Visible = false;

            // Chỉ cho phép sửa cột "SoLuong"
            foreach (DataGridViewColumn col in dgvChiTiet.Columns)
            {
                if (col.Name == "SoLuong")
                {
                    col.ReadOnly = false;  // cho phép sửa
                }
                else
                {
                    col.ReadOnly = true;   // tất cả các cột khác không sửa được
                }
            }
            dgvChiTiet.Columns["MaLoaiPhong"].HeaderText = "Mã loại phòng";
            dgvChiTiet.Columns["LoaiPhong"].HeaderText = "Tên loại phòng";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số lượng";

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            {
                dgvChiTiet.EndEdit();

                DateTime ngayDenMoi = dtpDen.Value;
                DateTime ngayTraMoi = dtpTra.Value;

                if (ngayDenMoi >= ngayTraMoi)
                {
                    MessageBox.Show("Ngày đến phải trước ngày trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo XML từ grid
                XElement root = new XElement("Items");
                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maLoaiPhong = row.Cells["MaLoaiPhong"].Value?.ToString();
                    if (string.IsNullOrEmpty(maLoaiPhong)) continue;

                    if (!int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi");
                        return;
                    }

                    root.Add(new XElement("Item",
                        new XAttribute("MaLoaiPhong", maLoaiPhong),
                        new XAttribute("SoLuong", soLuong)));
                }

                string xmlLoaiPhong = root.HasElements ? root.ToString() : null;

                // ĐẢM BẢO KHAI BÁO BIẾN loi TRƯỚC
                string loi; // ← Phải có dòng này

                bool ketQua = PhongDAL.Instance.SuaPhieuDatPhong(
                    out loi,                  // ← Có từ khóa "out"
                    maDP: maPhieuDat,
                    ngayDenMoi: ngayDenMoi,
                    ngayTraMoi: ngayTraMoi,
                    soNguoiMoi: null,
                    ghiChuMoi: null,
                    xmlLoaiPhongMoi: xmlLoaiPhong
                );

                if (ketQua)
                {
                    MessageBox.Show("Sửa phiếu đặt phòng thành công!", "Thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi sửa phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
