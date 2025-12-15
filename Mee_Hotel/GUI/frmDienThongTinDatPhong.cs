using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Dùng để kiểm tra định dạng (Regex)
using Mee_Hotel.DAL;
namespace Mee_Hotel.GUI.Phong
{
    public partial class frmDienThongTinDatPhong : Form
    {
        private string XMLPhongDat;
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private int soNguoi;
        public frmDienThongTinDatPhong(string XMLPhongDat,DateTime ngayNhan,DateTime ngayTra,int soNguoi)
        {
            InitializeComponent();
            this.XMLPhongDat = XMLPhongDat;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soNguoi = soNguoi;
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool CheckThongTin()
        {
            // 1. Kiểm tra để trống (Không được bỏ trống bất kỳ ô nào)
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                cbcQuocTich.SelectedItem == null) // Hoặc cboQuocTich.SelectedIndex == -1
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn quốc tịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Kiểm tra giới tính (Phải chọn ít nhất 1)
            if (!ckbNam.Checked && !ckbNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Kiểm tra Tuổi > 18
            DateTime birthDate = dtpNgaySinh.Value;
            int age = DateTime.Now.Year - birthDate.Year;

            // Nếu chưa đến sinh nhật trong năm nay thì trừ đi 1 tuổi
            if (birthDate > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Khách hàng phải đủ 18 tuổi để đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 4. Kiểm tra CCCD (Phải là số và đủ 12 ký tự - Theo chuẩn CCCD Việt Nam)
            // ^\d{12}$ nghĩa là: Bắt đầu và kết thúc đều là số, tổng cộng đúng 12 số
            if (!Regex.IsMatch(txtCCCD.Text, @"^\d{12}$"))
            {
                MessageBox.Show("CCCD không hợp lệ! Phải bao gồm đúng 12 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Focus();
                return false;
            }

            // 5. Kiểm tra Số điện thoại (Phải là số, 10 ký tự, bắt đầu bằng số 0 - Chuẩn VN)
            if (!Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! (Phải có 10 số và bắt đầu bằng số 0).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // 6. Kiểm tra Email đúng định dạng
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtMail.Text, emailPattern))
            {
                MessageBox.Show("Địa chỉ Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return false;
            }

            // Nếu tất cả đều đúng
            return true;
        }
        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNu.Checked == true)
            {
                ckbNam.Checked = false;
                GioiTinh = "Nữ";

            }
            else
            {
                ckbNam.Checked = true;
                GioiTinh = "Nam";
            }
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string GioiTinh;
        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            if (!CheckThongTin())
                return;

            try
            {
                var kq = PhongDAL.Instance.DatPhongTuXMLSan2(
                    ngayNhan: ngayNhan.Date,
                    ngayTra: ngayTra.Date,
                    hoTen: txtHoTen.Text.Trim(),
                    cccd: txtCCCD.Text.Trim(),
                    sdt: txtSDT.Text.Trim(),
                    ngaySinh: dtpNgaySinh.Value == dtpNgaySinh.MinDate ? null : (DateTime?)dtpNgaySinh.Value.Date,
                    gioiTinh: GioiTinh,
                    quocTich: cbcQuocTich.SelectedItem?.ToString() ?? "Việt Nam",
                    diaChi: txtDiaChi.Text.Trim(),
                    email: txtMail.Text.Trim(),
                    soNguoi: soNguoi,
                    xmlDaTaoSan: XMLPhongDat,                    // ← XML đã có sẵn
                    ghiChu: txtGhiChu.Text.Trim(),
                    maNV: StaticThing.MaNV ?? "NV001"
                );

                if (kq.KetQua)
                {
                    MessageBox.Show(
                        $"ĐẶT PHÒNG THÀNH CÔNG!\n" +
                        $"{kq.Loi}\n" +
                        $"Mã phiếu: {kq.MaPhieu}\n" +
                        $"Mã khách: {kq.MaKhach}",
                        "HOÀN TẤT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + kq.Loi, "Đặt phòng thất bại",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
