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
namespace Mee_Hotel.GUI.Phong
{
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        private string XMLPhongDat;
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private int soNguoi;
        private string TaoXMLTuDataGridView()
        {
            var root = new XElement("root");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Bỏ qua dòng mới (nếu có)
                if (row.IsNewRow) continue;

                // Lấy giá trị số lượng từ cột ComboBox
                var cellValue = 
                                row.Cells["SoPhongChon"]?.Value;  // tên cột bạn dùng

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int soLuong) || soLuong <= 0)
                    continue;

                // Lấy mã loại phòng (có thể từ cột ẩn hoặc cột hiện)
                string maLoaiPhong = row.Cells["MaLoaiPhong"]?.Value?.ToString() ??
                                row.Cells["Loại phòng"]?.Value?.ToString() ??
                                row.Cells["LoaiPhong"]?.Value?.ToString();

                if (string.IsNullOrWhiteSpace(maLoaiPhong))
                    continue;

                // Thêm vào XML
                root.Add(new XElement("r",
                    new XElement("lp", maLoaiPhong.Trim()),
                    new XElement("sl", soLuong)
                ));
            }

            return root.Elements().Any() ? root.ToString() : "<root></root>";
        }
        private void SetupDataGridView()
        {
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = false;                    // vẫn để false để ComboBox sống
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // === TẤT CẢ CÁC CỘT KHÁC ĐỀU READONLY ===
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewComboBoxColumn) && !(col is DataGridViewButtonColumn))
                {
                    col.ReadOnly = true;          // không cho sửa
                    col.DefaultCellStyle.SelectionBackColor = col.DefaultCellStyle.BackColor; // không hiện highlight khi chọn dòng
                }
            }

            // === CHỈ CHO PHÉP EDIT KHI CLICK VÀO CỘT COMBOBOX ===
            dataGridView1.CellBeginEdit += (s, e) =>
            {
                // Nếu không phải cột ComboBox → hủy edit ngay lập tức
                if (!(dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn))
                {
                    e.Cancel = true;
                }
            };

            // === TỰ ĐỘNG MỞ DROPDOWN KHI CLICK VÀO COMBOBOX ===
            dataGridView1.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count &&
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
                {
                    dataGridView1.BeginEdit(true);
                    if (dataGridView1.EditingControl is ComboBox cb)
                    {
                        cb.DroppedDown = true;  // mở dropdown ngay
                    }
                }
            };

            // Bonus: Enter = Tab (rất mượt khi chọn số phòng xong)
            dataGridView1.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            };
        }
        private void LoadDanhSachPhong()
        {
            DataTable bangPhong = PhongDAL.Instance.ThongKePhongTrongChoDatPhong(Convert.ToDateTime(dtpNgayDen.Value),Convert.ToDateTime(dtpNgayTra.Value));
            DataGridViewComboBoxColumn colChonPhong = new DataGridViewComboBoxColumn();
            colChonPhong.Name = "colChonPhong";
            colChonPhong.HeaderText = "Số phòng đặt";
            colChonPhong.FillWeight = 50;
            colChonPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colChonPhong.FlatStyle = FlatStyle.Flat;
            bangPhong.Columns.Add("SoPhongChon", typeof(int));   // ← CỘT NÀY PHẢI CÓ!!!
            // Quan trọng: phải Add đủ các giá trị từ 0 đến 10 (hoặc hơn)
            for (int i = 0; i <= 10; i++)
            {
                colChonPhong.Items.Add(i);
            }

            // Cột trong DataTable phải là int, mặc định = 0
            colChonPhong.DataPropertyName = "SoPhongChon"; // cột này trong DataTable phải tồn tại và mặc định = 0

            SetupDataGridView();

            dataGridView1.DataSource = bangPhong;
            dataGridView1.Columns["MaLoaiPhong"].Visible = false;
            dataGridView1.Columns["PhanTramPhongTrong"].Visible = false;
            dataGridView1.Columns["SoPhongChon"].Visible = false;
            dataGridView1.Columns["Tổng số phòng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Số phòng trống"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Số người tối đa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Giá tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Tổng số phòng"].FillWeight = 50;
            dataGridView1.Columns["Số phòng trống"].FillWeight = 50;
            dataGridView1.Columns["Số người tối đa"].FillWeight = 50;

            dataGridView1.Columns["Giá tiền"].FillWeight = 80;

            dataGridView1.Columns.Add(colChonPhong);
        }
        private void CapNhatTongHop()
        {
            int tongPhong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // bỏ qua dòng trống nếu có

                int soPhongChon = 0;
                int.TryParse(row.Cells["colChonPhong"].Value?.ToString(), out soPhongChon);

                decimal donGia = 0;
                decimal.TryParse(row.Cells["Giá tiền"].Value?.ToString(), out donGia);

                tongPhong += soPhongChon;
                tongTien += soPhongChon * donGia;
            }
            tongTien = tongTien * Convert.ToInt32(lblNgayDangKi.Text);
            // Cập nhật lên Label
            lblTongTienDuKien.Text = $"{tongTien:N0} ₫";   // định dạng có dấu phẩy
            // Nếu bạn có số đêm (ví dụ từ DateTimePicker)

        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dtpNgayDen.Value = dtpNgayTra.Value = DateTime.Today;
            ReloadData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
           // dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            // Font + màu nền
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.GridColor = Color.LightGray;


            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Height = 55;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.RowTemplate.Height = 50;
        }
        private void ReloadData()
        {
            dataGridView1.DataSource = null;
            LoadDanhSachPhong();
        }
        private void CapNhatSucChuaVaCanhBao()
        {
            int tongSucChua = 0;
            int tongPhongDat = 0;
            int soNguoiDangKy = 0;
            if (!int.TryParse(txtSoNguoiDangKy.Text, out soNguoiDangKy))
                soNguoiDangKy = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int soPhong = 0;
                var cellSoPhong = row.Cells["SoPhongChon"]; // tên cột chính xác
                if (cellSoPhong?.Value != null &&
                    int.TryParse(cellSoPhong.Value.ToString(), out int temp))
                {
                    soPhong = temp;
                }
                int sucChuaMoiPhong = 0;

                var cellSucChua = row.Cells["Số người tối đa"]?.Value; // cột từ proc


                    if (cellSucChua != null && int.TryParse(cellSucChua.ToString(), out sucChuaMoiPhong))
                    {
                    int sucChuaCuaDong = soPhong * sucChuaMoiPhong;
                    tongSucChua += sucChuaCuaDong;
                    tongPhongDat += soPhong;

                    // Cập nhật cột hiện thị sức chứa hiện tại
                    lblTongNguoiToiDa.Text = tongSucChua.ToString();
                    }
                    lblTongNguoiToiDa.Text = tongSucChua.ToString();
                   lblTongPhongDat.Text = tongPhongDat.ToString();
                if (tongSucChua < soNguoiDangKy && tongPhongDat > 0)
                {
                    lblCanhBaoSoNguoi.Text = $"CẢNH BÁO: Thiếu {soNguoiDangKy - tongSucChua} người! " +
                                             $"(Chỉ chứa được {tongSucChua}/{soNguoiDangKy})";
                    lblCanhBaoSoNguoi.ForeColor = Color.Red;
                    lblCanhBaoSoNguoi.Font = new Font(lblCanhBaoSoNguoi.Font, FontStyle.Bold);
                    lblCanhBaoSoNguoi.Visible = true;
                }
                else if (tongPhongDat == 0)
                {
                    lblCanhBaoSoNguoi.Text = "Chưa chọn phòng nào";
                }
                else
                {
                    lblCanhBaoSoNguoi.Text = "Đủ sức chứa";
                    lblCanhBaoSoNguoi.ForeColor = Color.Green;
                    lblCanhBaoSoNguoi.Visible = true;
                }

                }
        }
        private void TinhSoNgay()
        {
            if (dtpNgayTra.Value.Date <= dtpNgayDen.Value.Date)
            {
                lblNgayDangKi.Text = "0";
                return;
            }

            int soNgay = (dtpNgayTra.Value.Date - dtpNgayDen.Value.Date).Days;

            lblNgayDangKi.Text = soNgay.ToString();
        }
        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Ngày đến không được nhỏ hơn hôm nay
            if (dtpNgayDen.Value.Date < today)
            {
                MessageBox.Show("Không thể đặt phòng trước ngày hôm nay");
                dtpNgayDen.Value = today;
                return;
            }
            if (dtpNgayDen.Value.Date > dtpNgayTra.Value.Date)
            {
                MessageBox.Show("Không thể nhận phòng sau ngày trả");
                dtpNgayDen.Value = dtpNgayTra.Value;
                return;
            }

            ReloadData();
            ngayNhan = dtpNgayDen.Value;
            CapNhatTongHop();
            TinhSoNgay();
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Ngày trả không được nhỏ hơn hôm nay
            if (dtpNgayTra.Value.Date < today)
            {
                MessageBox.Show("Không thể đặt phòng trước ngày hôm nay");
                dtpNgayTra.Value = today;
                return;
            }
            if (dtpNgayTra.Value.Date < dtpNgayDen.Value.Date)
            {
                MessageBox.Show("Không thể trả phòng trước ngày nhận");
                dtpNgayTra.Value = dtpNgayDen.Value.Date;
                return;
            }
            ReloadData();
            ngayTra = dtpNgayTra.Value;
            CapNhatTongHop();
            TinhSoNgay();
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb == null) return;

            int soPhongCon = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số phòng trống"].Value);
            int chon = Convert.ToInt32(cb.SelectedItem);

            if (chon > soPhongCon)
            {
                MessageBox.Show($"Chỉ còn {soPhongCon} phòng trống loại này!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb.SelectedItem = soPhongCon;   // tự động giảm về tối đa
            }
            if (txtSoNguoiDangKy.Text != "")
            {
                CapNhatSucChuaVaCanhBao();
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var col = dataGridView1.Columns["colChonPhong"];
            if (col == null) return; // chưa tạo cột → bỏ qua

            if (e.ColumnIndex != col.Index || e.RowIndex < 0)
                return;

            CapNhatTongHop();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["colChonPhong"].Index
        && e.Control is ComboBox cb)
            {
                // Ngắt event cũ để tránh đăng ký nhiều lần
                cb.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                // Lấy số phòng còn lại của dòng hiện tại
                int soPhongCon = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số phòng trống"].Value);

                // Xóa hết item cũ
                cb.Items.Clear();

                // Đổ lại từ 0 đến số phòng còn lại (tối đa 10 cũng được)
                for (int i = 0; i <= soPhongCon && i <= 10; i++)
                {
                    cb.Items.Add(i);
                }

                // Giữ lại giá trị cũ nếu hợp lệ, không thì về 0
                int giaTriHienTai = 0;
                if (dataGridView1.CurrentCell.Value != null && dataGridView1.CurrentCell.Value != DBNull.Value)
                    giaTriHienTai = Convert.ToInt32(dataGridView1.CurrentCell.Value);

                cb.SelectedItem = (giaTriHienTai <= soPhongCon) ? giaTriHienTai : 0;

                cb.DropDownStyle = ComboBoxStyle.DropDownList;

                // Gắn lại event kiểm tra khi người dùng chọn
                cb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtSoNguoiDangKy.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số người dự kiến !!!");
                return;
            }
            if (ngayNhan.ToString() == "1/1/0001 12:00:00 AM" || ngayTra.ToString() == "1/1/0001 12:00:00 AM")
            {
                MessageBox.Show("Vui lòng nhập ngày nhận và trả phòng !!!");
                return;
            }
            if (lblTongPhongDat.Text != "0")
            {
                XMLPhongDat = TaoXMLTuDataGridView();
                if (XMLPhongDat == "<root></root>")
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 loại phòng!", "Chưa chọn phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn đặt !!!");
                return;

            }

            if (lblCanhBaoSoNguoi.Text != "Đủ sức chứa")
            {
                DialogResult result = MessageBox.Show("Số phòng không đáp ứng đủ số người và có thể phát sinh phụ phí !!!", "Tiếp tục ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                {
                    return;
                }
            }
            soNguoi = Convert.ToInt32(txtSoNguoiDangKy.Text);
            frmDienThongTinDatPhong frmDienThongTin = new frmDienThongTinDatPhong(XMLPhongDat,ngayNhan,ngayTra,soNguoi);
            frmDienThongTin.ShowDialog();
        }

        private void txtSoNguoiDangKy_TextChanged(object sender, EventArgs e)
        {
            CapNhatSucChuaVaCanhBao();
        }

        private void txtSoNguoiDangKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;   // chặn ký tự
            }
        }
    }
}
