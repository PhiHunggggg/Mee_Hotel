
namespace Mee_Hotel.GUI.FolderPhong
{
    partial class frmCheckIn
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
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtMaDP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlThongTinDatPhong = new System.Windows.Forms.Panel();
            this.lblPhongDaChon = new System.Windows.Forms.Label();
            this.lblCanhBaoCheckIn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.btnCheckIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlThongTinDatPhong.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 99);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1404, 878);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.siticoneButton2);
            this.pnlMenu.Controls.Add(this.txtMaDP);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1705, 93);
            this.pnlMenu.TabIndex = 1;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 18;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.LimeGreen;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(1465, 31);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(109, 36);
            this.siticoneButton2.TabIndex = 5;
            this.siticoneButton2.Text = "Check";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // txtMaDP
            // 
            this.txtMaDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDP.DefaultText = "";
            this.txtMaDP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDP.Location = new System.Drawing.Point(1259, 31);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.PasswordChar = '\0';
            this.txtMaDP.PlaceholderText = "";
            this.txtMaDP.SelectedText = "";
            this.txtMaDP.Size = new System.Drawing.Size(200, 36);
            this.txtMaDP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1170, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã DP :";
            // 
            // pnlThongTinDatPhong
            // 
            this.pnlThongTinDatPhong.Controls.Add(this.lblPhongDaChon);
            this.pnlThongTinDatPhong.Controls.Add(this.lblCanhBaoCheckIn);
            this.pnlThongTinDatPhong.Controls.Add(this.label10);
            this.pnlThongTinDatPhong.Controls.Add(this.lblTongTien);
            this.pnlThongTinDatPhong.Controls.Add(this.panel2);
            this.pnlThongTinDatPhong.Controls.Add(this.btnCheckIn);
            this.pnlThongTinDatPhong.Controls.Add(this.lblTenKH);
            this.pnlThongTinDatPhong.Controls.Add(this.label5);
            this.pnlThongTinDatPhong.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThongTinDatPhong.Location = new System.Drawing.Point(1357, 93);
            this.pnlThongTinDatPhong.Name = "pnlThongTinDatPhong";
            this.pnlThongTinDatPhong.Size = new System.Drawing.Size(348, 884);
            this.pnlThongTinDatPhong.TabIndex = 2;
            this.pnlThongTinDatPhong.Visible = false;
            this.pnlThongTinDatPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTinDatPhong_Paint);
            // 
            // lblPhongDaChon
            // 
            this.lblPhongDaChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhongDaChon.AutoSize = true;
            this.lblPhongDaChon.BackColor = System.Drawing.Color.White;
            this.lblPhongDaChon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongDaChon.Location = new System.Drawing.Point(16, 638);
            this.lblPhongDaChon.Name = "lblPhongDaChon";
            this.lblPhongDaChon.Size = new System.Drawing.Size(114, 19);
            this.lblPhongDaChon.TabIndex = 66;
            this.lblPhongDaChon.Text = "Phòng chọn :";
            // 
            // lblCanhBaoCheckIn
            // 
            this.lblCanhBaoCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCanhBaoCheckIn.AutoSize = true;
            this.lblCanhBaoCheckIn.BackColor = System.Drawing.Color.White;
            this.lblCanhBaoCheckIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhBaoCheckIn.Location = new System.Drawing.Point(16, 692);
            this.lblCanhBaoCheckIn.Name = "lblCanhBaoCheckIn";
            this.lblCanhBaoCheckIn.Size = new System.Drawing.Size(98, 19);
            this.lblCanhBaoCheckIn.TabIndex = 68;
            this.lblCanhBaoCheckIn.Text = "Tổng tiền :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tổng tiền :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(111, 589);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 19);
            this.lblTongTien.TabIndex = 65;
            this.lblTongTien.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dgvChiTiet);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblSoNguoi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNgayTra);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblNgayDen);
            this.panel2.Controls.Add(this.lblCCCD);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 431);
            this.panel2.TabIndex = 62;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvChiTiet.ColumnHeadersHeight = 30;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTiet.Location = new System.Drawing.Point(0, 203);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(342, 228);
            this.dgvChiTiet.TabIndex = 64;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Số người :";
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.BackColor = System.Drawing.Color.White;
            this.lblSoNguoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi.Location = new System.Drawing.Point(111, 153);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(16, 19);
            this.lblSoNguoi.TabIndex = 63;
            this.lblSoNguoi.Text = "-";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ngày đến:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ngày trả :";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.BackColor = System.Drawing.Color.White;
            this.lblNgayTra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(112, 115);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(16, 19);
            this.lblNgayTra.TabIndex = 60;
            this.lblNgayTra.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "CCCD: ";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.BackColor = System.Drawing.Color.White;
            this.lblNgayDen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.Location = new System.Drawing.Point(112, 77);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(16, 19);
            this.lblNgayDen.TabIndex = 59;
            this.lblNgayDen.Text = "-";
            // 
            // lblCCCD
            // 
            this.lblCCCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.BackColor = System.Drawing.Color.White;
            this.lblCCCD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(87, 39);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(16, 19);
            this.lblCCCD.TabIndex = 58;
            this.lblCCCD.Text = "-";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.BorderRadius = 18;
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(124, 740);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(109, 36);
            this.btnCheckIn.TabIndex = 11;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.Click += new System.EventHandler(this.siticoneButton3_Click_1);
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.Color.White;
            this.lblTenKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(90, 100);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(143, 19);
            this.lblTenKH.TabIndex = 54;
            this.lblTenKH.Text = "Tên khách hàng ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(43, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin đặt phòng";
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1705, 977);
            this.Controls.Add(this.pnlThongTinDatPhong);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmCheckIn";
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlThongTinDatPhong.ResumeLayout(false);
            this.pnlThongTinDatPhong.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaDP;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.Panel pnlThongTinDatPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblCCCD;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckIn;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblPhongDaChon;
        private System.Windows.Forms.Label lblCanhBaoCheckIn;
    }
}