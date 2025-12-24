using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Mee_Hotel.DAL;
using Mee_Hotel.Entity;
using System.Collections.Generic;
using Mee_Hotel.GUI.Phong;
namespace Mee_Hotel.GUI.FolderPhong
{
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
            LoadPhongTheoLoai();
            // Tự động cập nhật mỗi 60 giây
        }
        private bool KiemTraDuPhongTheoPhieu()
        {
            if (dgvChiTiet.DataSource == null || dgvChiTiet.Rows.Count == 0)
                return false;

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;

                string loaiPhieu = row.Cells["LoaiPhong"].Value?.ToString() ??
                                   row.Cells["TenLoaiPhong"].Value?.ToString();
                if (string.IsNullOrEmpty(loaiPhieu)) continue;

                int yeuCau = 0;
                if (row.Cells["SoLuong"].Value != null)
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out yeuCau);

                int daChon = listPhongChonTong.Count(x => x.LoaiPhong == loaiPhieu);

                if (daChon != yeuCau)
                    return false;
            }

            return true;
        }
        private void CapNhatNutCheckInVaCanhBao()
        {
            bool duPhong = KiemTraDuPhongTheoPhieu();

            if (listPhongChonTong.Count == 0)
            {
                btnCheckIn.Enabled = false;
                lblCanhBaoCheckIn.Text = "Chưa chọn phòng nào";
                lblCanhBaoCheckIn.ForeColor = Color.Gray;
            }
            else if (!duPhong)
            {
                btnCheckIn.Enabled = false;
                lblCanhBaoCheckIn.Text = "⚠️ Số lượng phòng chưa đúng với phiếu đặt!";
                lblCanhBaoCheckIn.ForeColor = Color.Red;
                lblCanhBaoCheckIn.Font = new Font(lblCanhBaoCheckIn.Font, FontStyle.Bold);
            }
            else
            {
                btnCheckIn.Enabled = true;
                lblCanhBaoCheckIn.Text = "✓ Đủ số lượng – Có thể Check-in";
                lblCanhBaoCheckIn.ForeColor = Color.DarkGreen;
                lblCanhBaoCheckIn.Font = new Font(lblCanhBaoCheckIn.Font, FontStyle.Bold);
            }
        }
        private void CapNhatLabelPhongDaChon(int soLuongYeuCauHienTai)
        {
            if (string.IsNullOrEmpty(loaiPhongHienTai))
            {
                lblPhongDaChon.Text = "Chưa chọn loại phòng";
                lblPhongDaChon.ForeColor = Color.Gray;
                return;
            }

            int soPhongChon = listPhongChonTong.Count(x => x.LoaiPhong == loaiPhongHienTai);

            if (soLuongYeuCauHienTai == 0)
            {
                lblPhongDaChon.Text = $"ĐÃ CHỌN {soPhongChon} phòng {loaiPhongHienTai}";
                lblPhongDaChon.ForeColor = Color.Orange;
            }
            else
            {
                lblPhongDaChon.Text = $"ĐÃ CHỌN {soPhongChon}/{soLuongYeuCauHienTai} phòng {loaiPhongHienTai}";
                lblPhongDaChon.ForeColor = soPhongChon == soLuongYeuCauHienTai ? Color.DarkGreen :
                                           soPhongChon > soLuongYeuCauHienTai ? Color.Red : Color.Orange;
            }

            lblPhongDaChon.Font = new Font(lblPhongDaChon.Font, FontStyle.Bold);
        }
                 private class PhongDaChon
                    {
                        public string MaPhong { get; set; }
                        public string LoaiPhong { get; set; }
                }
        private List<PhongDaChon> listPhongChonTong = new List<PhongDaChon>();
        private List<Mee_Hotel.Entity.Phong> danhSachPhongHienTai = new List<Mee_Hotel.Entity.Phong>(); // lưu tạm khi load loại
        private string loaiPhongHienTai = "";
        private void LoadPhongTheoLoai()
        {
            pnlMain.Controls.Clear();
            pnlMain.FlowDirection = FlowDirection.TopDown;
            pnlMain.WrapContents = false;

            // Gọi proc đã sửa (không truyền tham số hoặc truyền nếu cần)
            DataTable dt = PhongDAL.Instance.CallProcQuery("sp_DanhSachPhongCoCanhBao", null);

            if (dt.Rows.Count == 0)
            {
                Label lblNoData = new Label
                {
                    Text = "Không có dữ liệu phòng hoặc tất cả đều trống hoàn toàn.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                pnlMain.Controls.Add(lblNoData);
                return;
            }

            var danhSachPhong = dt.AsEnumerable().Select(row => new
            {
                MaPhong = row.Field<string>("MaPhong"),
                TenPhong = row.Field<string>("TenPhong"),
                LoaiPhong = row.Field<string>("LoaiPhong"),
                TrangThai = row.Field<string>("TrangThai"),
                ThongBao = row.Field<string>("ThongBao") ?? "Phòng trống - sẵn sàng",
                DuKienNhanPhong = row.Field<DateTime?>("DuKienNhanPhong"),
                DuKienTraPhong = row.Field<DateTime?>("DuKienTraPhong"),
                ThucTeNhanPhong = row.Field<DateTime?>("ThucTeNhanPhong"),
                ThucTeTraPhong = row.Field<DateTime?>("ThucTeTraPhong"),
                MaDP = row.IsNull("MaDP") ? null : row.Field<string>("MaDP")
            }).ToList();

            var nhom = danhSachPhong.GroupBy(p => p.LoaiPhong);

            foreach (var group in nhom.OrderBy(g => g.Key))
            {
                // Đếm phòng TRỐNG (dựa vào ThongBao – chính xác nhất)
                int soPhongTrong = group.Count(p =>
                    p.ThongBao.Contains("Trống") ||
                    p.ThongBao.Contains("sẵn sàng") ||
                    p.ThongBao.Contains("Hôm nay nhận") == false && // Không tính sắp nhận là trống
                    p.TrangThai == "Có sẵn");

                var lblLoai = new Label
                {
                    Text = $"{group.Key} ({soPhongTrong}/{group.Count()} trống)",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 100, 150),
                    AutoSize = true,
                    Margin = new Padding(15, 25, 0, 8)
                };
                pnlMain.Controls.Add(lblLoai);

                var flpRow = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Margin = new Padding(15, 0, 15, 25),
                    Padding = new Padding(10),
                    BackColor = Color.FromArgb(248, 252, 255),
                    BorderStyle = BorderStyle.FixedSingle
                };

                foreach (var phong in group.OrderBy(p => p.TenPhong))
                {
                    var card = new RoomCard
                    {
                        RoomNumber = phong.TenPhong ?? phong.MaPhong,
                        RoomType = phong.LoaiPhong,
                        Margin = new Padding(8)
                    };

                    string thongBao = phong.ThongBao;

                    // XỬ LÝ TRẠNG THÁI VÀ MÀU SẮC DỰA HOÀN TOÀN VÀO ThongBao TỪ PROC
                    if (thongBao.Contains("QUÁ GIỜ TRẢ") || thongBao.Contains("⚠️"))
                    {
                        card.StatusText = "QUÁ GIỜ";
                        card.StatusColor = Color.FromArgb(200, 0, 0);
                        card.BackColor = Color.FromArgb(255, 230, 230);
                        card.Icon = Properties.Resources.warning ?? Properties.Resources.user;
                        card.RoomType = thongBao.Contains(":") ? thongBao.Split(new[] { ':' }, 2)[1].Trim() : "";

                    }
                    else if (thongBao.Contains("HÔM NAY TRẢ") || thongBao.Contains("🔴"))
                    {
                        card.StatusText = "HÔM NAY TRẢ";
                        card.StatusColor = Color.FromArgb(220, 50, 50);
                        card.BackColor = Color.FromArgb(255, 240, 240);
                        card.Icon = Properties.Resources.logout;
                        card.RoomType = "Dự kiến trả hôm nay";
                    }
                    else if (thongBao.Contains("Sắp trả phòng") || thongBao.Contains("🟡"))
                    {
                        card.StatusText = "SẮP TRỐNG";
                        card.StatusColor = Color.Orange;
                        card.Icon = Properties.Resources.clock;
                        card.RoomType = thongBao.Contains(":") ? thongBao.Split(new[] { ':' }, 2)[1].Trim() : "";
                    }
                    else if (thongBao.Contains("Đang có khách"))
                    {
                        card.StatusText = "ĐANG Ở";
                        card.StatusColor = Color.FromArgb(255, 87, 34);
                        card.Icon = Properties.Resources.user;
                        card.RoomType = thongBao.Contains("đến")
                            ? thongBao.Split(new[] { "đến" }, 2, StringSplitOptions.None)[1].Trim()
                            : "";
                    }
                    else if (thongBao.Contains("Đang dọn"))
                    {
                        card.StatusText = "ĐANG DỌN";
                        card.StatusColor = Color.Gold;
                        card.Icon = Properties.Resources.cleaning;
                    }
                    else // Phòng trống hoàn toàn
                    {
                        card.StatusText = "TRỐNG";
                        card.StatusColor = Color.FromArgb(0, 170, 140);
                        card.Icon = Properties.Resources.check;
                        card.RoomType = "Sẵn sàng nhận khách";
                    }

                    // Tooltip chi tiết khi hover
                    string tooltip =
                        $"Phòng: {phong.TenPhong}\n" +
                        $"Loại: {phong.LoaiPhong}\n" +
                        $"Trạng thái hệ thống: {phong.TrangThai}\n" +
                        $"Cảnh báo: {phong.ThongBao}";

                    if (phong.DuKienTraPhong.HasValue)
                        tooltip += $"\nDự kiến trả: {phong.DuKienTraPhong:dd/MM/yyyy}";

                    card.ToolTipInfo = tooltip;

                    // Click vào card → hiện popup chi tiết (có thể mở form chi tiết phòng sau này)
                    card.RoomClicked += (s, e) =>
                    {
                        string msg =
                            $"MÃ PHÒNG: {phong.MaPhong}\n" +
                            $"TÊN PHÒNG: {phong.TenPhong}\n" +
                            $"LOẠI PHÒNG: {phong.LoaiPhong}\n" +
                            $"TRẠNG THÁI: {phong.TrangThai}\n" +
                            $"THÔNG BÁO: {phong.ThongBao}\n\n";

                        if (phong.MaDP != null)
                            msg += $"MÃ ĐẶT PHÒNG: {phong.MaDP}\n";

                        if (phong.DuKienNhanPhong.HasValue)
                            msg += $"Dự kiến nhận: {phong.DuKienNhanPhong:dd/MM/yyyy}\n";
                        if (phong.DuKienTraPhong.HasValue)
                            msg += $"Dự kiến trả: {phong.DuKienTraPhong:dd/MM/yyyy}\n";

                        MessageBox.Show(msg, "Chi tiết phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    flpRow.Controls.Add(card);
                }

                pnlMain.Controls.Add(flpRow);
            }
        }

        private void LoadPhongTrong_CheckIn(string maLoaiPhong, int soLuongYeuCau)
        {
            pnlMain.Controls.Clear();

            DataTable dt = PhongDAL.Instance.getDanhSachPhongTrong_CheckIn(maLoaiPhong);

            if (dt ==null)
            {
                Label lbl = new Label
                {
                    Text = "Không có phòng trống loại này trong khoảng ngày đã chọn",
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                pnlMain.Controls.Add(lbl);
                loaiPhongHienTai = "";
                danhSachPhongHienTai.Clear();
                CapNhatLabelPhongDaChon(soLuongYeuCau);
                CapNhatNutCheckInVaCanhBao();
                return;
            }

            danhSachPhongHienTai = dt.AsEnumerable().Select(row => new Mee_Hotel.Entity.Phong
            {
                MaPhong = row.Field<string>("MaPhong"),
                TenPhong = row.Field<string>("TenPhong"),
                LoaiPhong = row.Field<string>("TenLoaiPhong ")
            }).ToList();

            loaiPhongHienTai = danhSachPhongHienTai.FirstOrDefault()?.LoaiPhong ?? "";

            // Tạo tiêu đề + danh sách phòng
            Label lblLoai = new Label
            {
                Text = $"{loaiPhongHienTai} ({danhSachPhongHienTai.Count} trống)",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 100, 150),
                AutoSize = true,
                Margin = new Padding(10, 20, 0, 5)
            };
            pnlMain.Controls.Add(lblLoai);

            FlowLayoutPanel flpRow = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoSize = true,
                Margin = new Padding(10, 0, 10, 20),
                BackColor = Color.FromArgb(245, 250, 250)
            };

            foreach (var phong in danhSachPhongHienTai)
            {
                Panel pnlItem = new Panel
                {
                    Width = 180,
                    Height = 180,
                    Margin = new Padding(5)
                };

                RoomCard card = new RoomCard
                {
                    RoomNumber = phong.TenPhong,
                    RoomType = phong.LoaiPhong,
                    StatusText = "Có sẵn",
                    StatusColor = Color.FromArgb(0, 170, 140),
                    Icon = Properties.Resources.check,
                    Dock = DockStyle.Top,
                    Height = 150
                };
                pnlItem.Controls.Add(card);

                CheckBox chkTick = new CheckBox
                {
                    Text = "Chọn phòng này",
                    Dock = DockStyle.Bottom,
                    Height = 40,
                    Appearance = Appearance.Button,
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(0, 170, 140),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Checked = listPhongChonTong.Any(x => x.MaPhong == phong.MaPhong)
                };

                chkTick.CheckedChanged += (s, e) =>
                {
                    if (chkTick.Checked)
                    {
                        if (!listPhongChonTong.Any(x => x.MaPhong == phong.MaPhong))
                        {
                            listPhongChonTong.Add(new PhongDaChon
                            {
                                MaPhong = phong.MaPhong,
                                LoaiPhong = phong.LoaiPhong
                            });
                        }
                    }
                    else
                    {
                        listPhongChonTong.RemoveAll(x => x.MaPhong == phong.MaPhong);
                    }

                    CapNhatLabelPhongDaChon(soLuongYeuCau);
                    CapNhatNutCheckInVaCanhBao();
                };

                pnlItem.Controls.Add(chkTick);
                flpRow.Controls.Add(pnlItem);
            }

            pnlMain.Controls.Add(flpRow);

            CapNhatLabelPhongDaChon(soLuongYeuCau);
            CapNhatNutCheckInVaCanhBao();
        }
        private void LoadPhongTrongTheoKhoangNgay(DateTime ngayDen, DateTime ngayTra,string maPhong)
        {
            pnlMain.Controls.Clear();

            DataTable dt = PhongDAL.Instance.getDanhSachPhongTrongTheoNgay(ngayDen,ngayTra,maPhong);

            var danhSachPhong = dt.AsEnumerable().Select(row => new Mee_Hotel.Entity.Phong
            {
                MaPhong = row.Field<string>("MaPhong"),
                TenPhong = row.Field<string>("TenPhong"),
                LoaiPhong = row.Field<string>("LoaiPhong"),
                TrangThai = "Có sẵn",
                ThoiGianTraPhong = row.Field<DateTime?>("ThoiGianTraPhong"),
                ThongBao = row.Field<string>("ThongBao")
            }).ToList();

            var nhom = danhSachPhong.GroupBy(p => p.LoaiPhong);

            foreach (var group in nhom)
            {
                // Tiêu đề loại phòng
                Label lblLoai = new Label
                {
                    Text = $"{group.Key} ({group.Count()} trống)",
                    Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 100, 150),
                    AutoSize = true,
                    Margin = new Padding(10, 20, 0, 5)
                };
                pnlMain.Controls.Add(lblLoai);

                // FlowLayoutPanel cho các phòng + tick
                FlowLayoutPanel flpRow = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    AutoSize = true,
                    Margin = new Padding(10, 0, 10, 20),
                    BackColor = Color.FromArgb(245, 250, 250)
                };

                foreach (var phong in group)
                {
                    // Panel con chứa RoomCard + CheckBox tick
                    Panel pnlItem = new Panel
                    {
                        Width = 180,   // kích thước card
                        Height = 180,
                        Margin = new Padding(5)
                    };

                    RoomCard card = new RoomCard
                    {
                        RoomNumber = phong.TenPhong,
                        RoomType = phong.ThongBao,
                        StatusText = phong.TrangThai,
                        StatusColor = phong.TrangThai == "Có sẵn" ? Color.FromArgb(0,170,140) : Color.FromArgb(255, 87, 34),
                        Dock = DockStyle.Top,
                        Height = 150
                    };

                    pnlItem.Controls.Add(card);

                    // CHECKBOX TICK ĐỂ CHỌN PHÒNG
                    CheckBox chkTick = new CheckBox
                    {
                        Dock = DockStyle.Bottom,
                        Text = "Chọn phòng này",
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    // SỰ KIỆN CHÍNH XÁC 100%
                    chkTick.CheckedChanged += (s, e) =>
                    {
                    };

                        pnlItem.Controls.Add(chkTick);

                    flpRow.Controls.Add(pnlItem);
                }

                pnlMain.Controls.Add(flpRow);
            }
    }


        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            pnlThongTinDatPhong.Visible = false;
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;   // chặn ký tự
            }
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string maDP = txtMaDP.Text.Trim();
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
            pnlThongTinDatPhong.Visible = true;
            var p = kq.ThongTin;
            lblTenKH.Text = p["HoTen"].ToString();
            lblCCCD.Text = p["CCCD"]?.ToString() ?? "";
            lblNgayDen.Text = Convert.ToDateTime(p["NgayNhan"]).ToString("dd/MM/yyyy");
            lblNgayTra.Text = Convert.ToDateTime(p["NgayTra"]).ToString("dd/MM/yyyy");
            lblSoNguoi.Text = p["SoNguoi"].ToString() + " người";
            dgvChiTiet.DataSource = kq.ChiTiet;
            lblTongTien.Text = kq.TongTien.ToString("#,##0") + " đ";
            LoadPhongTrongTheoKhoangNgay(Convert.ToDateTime(p["NgayNhan"]), Convert.ToDateTime(p["NgayTra"]),null);
        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {
            if (!KiemTraDuPhongTheoPhieu())
            {
                MessageBox.Show("Không thể Check-in!\nSố lượng phòng chưa đúng với phiếu đặt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listPhongChonTong.Count == 0)
            {
                MessageBox.Show("Chưa chọn phòng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> dsMaPhong = listPhongChonTong.Select(x => x.MaPhong).ToList();

            string loi;
            bool ok = PhongDAL.Instance.CheckInPhieu(txtMaDP.Text, dsMaPhong, StaticThing.MaNV, out loi);

            if (ok)
            {
                MessageBox.Show($"Check-in thành công {listPhongChonTong.Count} phòng:\n" +
                string.Join(", ", listPhongChonTong.Select(x => x.MaPhong)),
                "HOÀN TẤT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlThongTinDatPhong.Visible = false;
                listPhongChonTong.Clear();
                CapNhatLabelPhongDaChon(0);
                CapNhatNutCheckInVaCanhBao();
                LoadPhongTheoLoai();
            }
            else
            {
                MessageBox.Show(loi, "Check-in thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maLoaiPhong = dgvChiTiet.Rows[e.RowIndex].Cells["MaLoaiPhong"].Value?.ToString();
            if (string.IsNullOrEmpty(maLoaiPhong)) return;

            int soLuong = 0;
            if (dgvChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value != null)
                int.TryParse(dgvChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out soLuong);

            LoadPhongTrong_CheckIn(maLoaiPhong, soLuong);
        }

        private void pnlThongTinDatPhong_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
