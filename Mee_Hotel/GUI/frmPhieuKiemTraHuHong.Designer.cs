namespace Mee_Hotel.GUI
{
    partial class frmPhieuKiemTraHuHong
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
            this.btnXemChiTiet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelLoc = new System.Windows.Forms.Panel();
            this.dtpNgayTim = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.chkTimTheoNgay = new System.Windows.Forms.CheckBox();
            this.txtTimKiem = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnXemChiTiet);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.panelLoc);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1864, 1055);
            this.panel1.TabIndex = 0;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BorderRadius = 19;
            this.btnXemChiTiet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnXemChiTiet.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(726, 184);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(270, 60);
            this.btnXemChiTiet.TabIndex = 32;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 19;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(1296, 184);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(164, 60);
            this.siticoneButton1.TabIndex = 31;
            this.siticoneButton1.Text = "Thêm";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // panelLoc
            // 
            this.panelLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.panelLoc.Controls.Add(this.dtpNgayTim);
            this.panelLoc.Controls.Add(this.chkTimTheoNgay);
            this.panelLoc.Controls.Add(this.txtTimKiem);
            this.panelLoc.Controls.Add(this.lblTimKiem);
            this.panelLoc.Controls.Add(this.btnLamMoi);
            this.panelLoc.Location = new System.Drawing.Point(270, 60);
            this.panelLoc.Name = "panelLoc";
            this.panelLoc.Size = new System.Drawing.Size(1377, 97);
            this.panelLoc.TabIndex = 30;
            // 
            // dtpNgayTim
            // 
            this.dtpNgayTim.BorderThickness = 1;
            this.dtpNgayTim.Checked = true;
            this.dtpNgayTim.FillColor = System.Drawing.Color.White;
            this.dtpNgayTim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayTim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTim.Location = new System.Drawing.Point(985, 3);
            this.dtpNgayTim.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTim.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTim.Name = "dtpNgayTim";
            this.dtpNgayTim.Size = new System.Drawing.Size(182, 59);
            this.dtpNgayTim.TabIndex = 7;
            this.dtpNgayTim.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            this.dtpNgayTim.ValueChanged += new System.EventHandler(this.dtpNgayTim_ValueChanged);
            // 
            // chkTimTheoNgay
            // 
            this.chkTimTheoNgay.AutoSize = true;
            this.chkTimTheoNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.chkTimTheoNgay.Location = new System.Drawing.Point(995, 68);
            this.chkTimTheoNgay.Name = "chkTimTheoNgay";
            this.chkTimTheoNgay.Size = new System.Drawing.Size(172, 31);
            this.chkTimTheoNgay.TabIndex = 9;
            this.chkTimTheoNgay.Text = "Lọc theo ngày";
            this.chkTimTheoNgay.UseVisualStyleBackColor = true;
            this.chkTimTheoNgay.CheckedChanged += new System.EventHandler(this.chkTimTheoNgay_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 19;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(118, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(800, 59);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblTimKiem.Location = new System.Drawing.Point(3, 40);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(109, 27);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 19;
            this.btnLamMoi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLamMoi.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1193, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(181, 64);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnXoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1683, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 60);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 19;
            this.btnSua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSua.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1498, 184);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 58);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 75;
            this.dataGridView1.Location = new System.Drawing.Point(99, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1658, 707);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(542, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 36);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "PHIẾU KIỂM TRA HƯ HỎNG THIẾT BỊ";
            // 
            // frmPhieuKiemTraHuHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuKiemTraHuHong";
            this.Text = "Phiếu Kiểm Tra Hư Hỏng Thiết Bị";
            this.Load += new System.EventHandler(this.frmPhieuKiemTraHuHong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLoc.ResumeLayout(false);
            this.panelLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Panel panelLoc;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpNgayTim;
        private System.Windows.Forms.CheckBox chkTimTheoNgay;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXemChiTiet;
    }
}