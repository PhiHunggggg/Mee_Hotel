
namespace Mee_Hotel.GUI
{
    partial class frmKiemTraDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChonPhongcbb = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.TSDVlb = new System.Windows.Forms.Label();
            this.MaDP_DVlb = new System.Windows.Forms.Label();
            this.TenKH_DVlb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GiaLucDatlb = new System.Windows.Forms.Label();
            this.NgayDatlb = new System.Windows.Forms.Label();
            this.SDTlb = new System.Windows.Forms.Label();
            this.SoPhongDatlb = new System.Windows.Forms.Label();
            this.LoaiPhonglb = new System.Windows.Forms.Label();
            this.TenKHlb = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneShapes2 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Data_DV_KT = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SlDVlb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DV_KT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.SlDVlb);
            this.panel1.Controls.Add(this.ChonPhongcbb);
            this.panel1.Controls.Add(this.TSDVlb);
            this.panel1.Controls.Add(this.MaDP_DVlb);
            this.panel1.Controls.Add(this.TenKH_DVlb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GiaLucDatlb);
            this.panel1.Controls.Add(this.NgayDatlb);
            this.panel1.Controls.Add(this.SDTlb);
            this.panel1.Controls.Add(this.SoPhongDatlb);
            this.panel1.Controls.Add(this.LoaiPhonglb);
            this.panel1.Controls.Add(this.TenKHlb);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.lblNgayTra);
            this.panel1.Controls.Add(this.lblPhong);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.siticoneShapes2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.Data_DV_KT);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 540);
            this.panel1.TabIndex = 1;
            // 
            // ChonPhongcbb
            // 
            this.ChonPhongcbb.BackColor = System.Drawing.Color.Transparent;
            this.ChonPhongcbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChonPhongcbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChonPhongcbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChonPhongcbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChonPhongcbb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChonPhongcbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ChonPhongcbb.ItemHeight = 30;
            this.ChonPhongcbb.Location = new System.Drawing.Point(789, 256);
            this.ChonPhongcbb.Name = "ChonPhongcbb";
            this.ChonPhongcbb.Size = new System.Drawing.Size(161, 36);
            this.ChonPhongcbb.TabIndex = 75;
            this.ChonPhongcbb.SelectedIndexChanged += new System.EventHandler(this.ChonPhongcbb_SelectedIndexChanged);
            this.ChonPhongcbb.StyleChanged += new System.EventHandler(this.ChonPhongcbb_StyleChanged);
            // 
            // TSDVlb
            // 
            this.TSDVlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TSDVlb.AutoSize = true;
            this.TSDVlb.BackColor = System.Drawing.Color.White;
            this.TSDVlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSDVlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TSDVlb.Location = new System.Drawing.Point(801, 332);
            this.TSDVlb.Name = "TSDVlb";
            this.TSDVlb.Size = new System.Drawing.Size(0, 19);
            this.TSDVlb.TabIndex = 74;
            // 
            // MaDP_DVlb
            // 
            this.MaDP_DVlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaDP_DVlb.AutoSize = true;
            this.MaDP_DVlb.BackColor = System.Drawing.Color.White;
            this.MaDP_DVlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDP_DVlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MaDP_DVlb.Location = new System.Drawing.Point(791, 205);
            this.MaDP_DVlb.Name = "MaDP_DVlb";
            this.MaDP_DVlb.Size = new System.Drawing.Size(0, 19);
            this.MaDP_DVlb.TabIndex = 72;
            // 
            // TenKH_DVlb
            // 
            this.TenKH_DVlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TenKH_DVlb.AutoSize = true;
            this.TenKH_DVlb.BackColor = System.Drawing.Color.White;
            this.TenKH_DVlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH_DVlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TenKH_DVlb.Location = new System.Drawing.Point(809, 147);
            this.TenKH_DVlb.Name = "TenKH_DVlb";
            this.TenKH_DVlb.Size = new System.Drawing.Size(0, 19);
            this.TenKH_DVlb.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tổng số dịch vụ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Chọn phòng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mã đặt phòng :";
            // 
            // GiaLucDatlb
            // 
            this.GiaLucDatlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GiaLucDatlb.AutoSize = true;
            this.GiaLucDatlb.BackColor = System.Drawing.Color.White;
            this.GiaLucDatlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaLucDatlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GiaLucDatlb.Location = new System.Drawing.Point(738, 465);
            this.GiaLucDatlb.Name = "GiaLucDatlb";
            this.GiaLucDatlb.Size = new System.Drawing.Size(0, 19);
            this.GiaLucDatlb.TabIndex = 67;
            // 
            // NgayDatlb
            // 
            this.NgayDatlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NgayDatlb.AutoSize = true;
            this.NgayDatlb.BackColor = System.Drawing.Color.White;
            this.NgayDatlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDatlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NgayDatlb.Location = new System.Drawing.Point(724, 399);
            this.NgayDatlb.Name = "NgayDatlb";
            this.NgayDatlb.Size = new System.Drawing.Size(0, 19);
            this.NgayDatlb.TabIndex = 66;
            // 
            // SDTlb
            // 
            this.SDTlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SDTlb.AutoSize = true;
            this.SDTlb.BackColor = System.Drawing.Color.White;
            this.SDTlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SDTlb.Location = new System.Drawing.Point(757, 335);
            this.SDTlb.Name = "SDTlb";
            this.SDTlb.Size = new System.Drawing.Size(0, 19);
            this.SDTlb.TabIndex = 65;
            // 
            // SoPhongDatlb
            // 
            this.SoPhongDatlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SoPhongDatlb.AutoSize = true;
            this.SoPhongDatlb.BackColor = System.Drawing.Color.White;
            this.SoPhongDatlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoPhongDatlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SoPhongDatlb.Location = new System.Drawing.Point(757, 272);
            this.SoPhongDatlb.Name = "SoPhongDatlb";
            this.SoPhongDatlb.Size = new System.Drawing.Size(0, 19);
            this.SoPhongDatlb.TabIndex = 64;
            // 
            // LoaiPhonglb
            // 
            this.LoaiPhonglb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoaiPhonglb.AutoSize = true;
            this.LoaiPhonglb.BackColor = System.Drawing.Color.White;
            this.LoaiPhonglb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiPhonglb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoaiPhonglb.Location = new System.Drawing.Point(740, 209);
            this.LoaiPhonglb.Name = "LoaiPhonglb";
            this.LoaiPhonglb.Size = new System.Drawing.Size(0, 19);
            this.LoaiPhonglb.TabIndex = 63;
            // 
            // TenKHlb
            // 
            this.TenKHlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TenKHlb.AutoSize = true;
            this.TenKHlb.BackColor = System.Drawing.Color.White;
            this.TenKHlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKHlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TenKHlb.Location = new System.Drawing.Point(785, 146);
            this.TenKHlb.Name = "TenKHlb";
            this.TenKHlb.Size = new System.Drawing.Size(0, 19);
            this.TenKHlb.TabIndex = 62;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.BackColor = System.Drawing.Color.White;
            this.lblNgayDen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayDen.Location = new System.Drawing.Point(726, 269);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(0, 23);
            this.lblNgayDen.TabIndex = 59;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.BackColor = System.Drawing.Color.White;
            this.lblNgayTra.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayTra.Location = new System.Drawing.Point(726, 332);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(0, 23);
            this.lblNgayTra.TabIndex = 58;
            // 
            // lblPhong
            // 
            this.lblPhong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhong.AutoSize = true;
            this.lblPhong.BackColor = System.Drawing.Color.White;
            this.lblPhong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPhong.Location = new System.Drawing.Point(701, 205);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(0, 23);
            this.lblPhong.TabIndex = 57;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.Color.White;
            this.lblTenKH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenKH.Location = new System.Drawing.Point(785, 143);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(0, 23);
            this.lblTenKH.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên khách hàng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // siticoneShapes2
            // 
            this.siticoneShapes2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.siticoneShapes2.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes2.FillColor = System.Drawing.Color.White;
            this.siticoneShapes2.Location = new System.Drawing.Point(567, 63);
            this.siticoneShapes2.Name = "siticoneShapes2";
            this.siticoneShapes2.PolygonSkip = 1;
            this.siticoneShapes2.Rotate = 0F;
            this.siticoneShapes2.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes2.Size = new System.Drawing.Size(474, 385);
            this.siticoneShapes2.TabIndex = 51;
            this.siticoneShapes2.Text = "siticoneShapes2";
            this.siticoneShapes2.Zoom = 80;
            this.siticoneShapes2.Click += new System.EventHandler(this.siticoneShapes2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(28, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "DANH SÁCH DỊCH VỤ ĐÃ DÙNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(38, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Tổng tiền dịch vụ:";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 19;
            this.btnLuu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(191, 480);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 49);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 19;
            this.btnHuy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(412, 480);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 49);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            // 
            // Data_DV_KT
            // 
            this.Data_DV_KT.BackgroundColor = System.Drawing.Color.White;
            this.Data_DV_KT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_DV_KT.ColumnHeadersHeight = 75;
            this.Data_DV_KT.Location = new System.Drawing.Point(32, 98);
            this.Data_DV_KT.Margin = new System.Windows.Forms.Padding(2);
            this.Data_DV_KT.Name = "Data_DV_KT";
            this.Data_DV_KT.RowHeadersVisible = false;
            this.Data_DV_KT.RowHeadersWidth = 51;
            this.Data_DV_KT.RowTemplate.Height = 50;
            this.Data_DV_KT.Size = new System.Drawing.Size(530, 309);
            this.Data_DV_KT.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderRadius = 19;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "0 VND";
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(248, 422);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(251, 48);
            this.txtTongTien.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(300, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(448, 29);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "CHI TIẾT PHIẾU KIỂM TRA DỊCH VỤ";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // SlDVlb
            // 
            this.SlDVlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SlDVlb.AutoSize = true;
            this.SlDVlb.BackColor = System.Drawing.Color.White;
            this.SlDVlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlDVlb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SlDVlb.Location = new System.Drawing.Point(807, 332);
            this.SlDVlb.Name = "SlDVlb";
            this.SlDVlb.Size = new System.Drawing.Size(0, 19);
            this.SlDVlb.TabIndex = 76;
            // 
            // frmKiemTraDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 540);
            this.Controls.Add(this.panel1);
            this.Name = "frmKiemTraDV";
            this.Text = "frmKiemTraDV";
            this.Load += new System.EventHandler(this.frmKiemTraDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DV_KT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
        private System.Windows.Forms.DataGridView Data_DV_KT;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTongTien;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label GiaLucDatlb;
        private System.Windows.Forms.Label NgayDatlb;
        private System.Windows.Forms.Label SDTlb;
        private System.Windows.Forms.Label SoPhongDatlb;
        private System.Windows.Forms.Label LoaiPhonglb;
        private System.Windows.Forms.Label TenKHlb;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ChonPhongcbb;
        private System.Windows.Forms.Label TSDVlb;
        private System.Windows.Forms.Label MaDP_DVlb;
        private System.Windows.Forms.Label TenKH_DVlb;
        private System.Windows.Forms.Label SlDVlb;
    }
}