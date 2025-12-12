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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelLoc = new System.Windows.Forms.Panel();
            this.btnTim = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dtpNgayTim = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.lblNgayTim = new System.Windows.Forms.Label();
            this.txtNhanVienTim = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblNhanVienTim = new System.Windows.Forms.Label();
            this.cmbPhongTim = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblPhongTim = new System.Windows.Forms.Label();
            this.txtMaPhieuTim = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMaPhieuTim = new System.Windows.Forms.Label();
            this.btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.panelLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.panelLoc);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1864, 1055);
            this.panel1.TabIndex = 0;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 19;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(1074, 161);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(164, 60);
            this.siticoneButton1.TabIndex = 31;
            this.siticoneButton1.Text = "Thêm";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // panelLoc
            // 
            this.panelLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.panelLoc.Controls.Add(this.btnTim);
            this.panelLoc.Controls.Add(this.dtpNgayTim);
            this.panelLoc.Controls.Add(this.lblNgayTim);
            this.panelLoc.Controls.Add(this.txtNhanVienTim);
            this.panelLoc.Controls.Add(this.lblNhanVienTim);
            this.panelLoc.Controls.Add(this.cmbPhongTim);
            this.panelLoc.Controls.Add(this.lblPhongTim);
            this.panelLoc.Controls.Add(this.txtMaPhieuTim);
            this.panelLoc.Controls.Add(this.lblMaPhieuTim);
            this.panelLoc.Location = new System.Drawing.Point(51, 60);
            this.panelLoc.Name = "panelLoc";
            this.panelLoc.Size = new System.Drawing.Size(1377, 97);
            this.panelLoc.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 19;
            this.btnTim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTim.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1191, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(165, 60);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpNgayTim
            // 
            this.dtpNgayTim.BorderThickness = 1;
            this.dtpNgayTim.Checked = true;
            this.dtpNgayTim.FillColor = System.Drawing.Color.White;
            this.dtpNgayTim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayTim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTim.Location = new System.Drawing.Point(975, 23);
            this.dtpNgayTim.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTim.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTim.Name = "dtpNgayTim";
            this.dtpNgayTim.Size = new System.Drawing.Size(182, 59);
            this.dtpNgayTim.TabIndex = 7;
            this.dtpNgayTim.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // lblNgayTim
            // 
            this.lblNgayTim.AutoSize = true;
            this.lblNgayTim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblNgayTim.Location = new System.Drawing.Point(900, 40);
            this.lblNgayTim.Name = "lblNgayTim";
            this.lblNgayTim.Size = new System.Drawing.Size(69, 27);
            this.lblNgayTim.TabIndex = 6;
            this.lblNgayTim.Text = "Ngày:";
            // 
            // txtNhanVienTim
            // 
            this.txtNhanVienTim.BorderRadius = 19;
            this.txtNhanVienTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanVienTim.DefaultText = "";
            this.txtNhanVienTim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNhanVienTim.Location = new System.Drawing.Point(358, 27);
            this.txtNhanVienTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhanVienTim.Name = "txtNhanVienTim";
            this.txtNhanVienTim.PasswordChar = '\0';
            this.txtNhanVienTim.PlaceholderText = "";
            this.txtNhanVienTim.SelectedText = "";
            this.txtNhanVienTim.Size = new System.Drawing.Size(278, 44);
            this.txtNhanVienTim.TabIndex = 5;
            // 
            // lblNhanVienTim
            // 
            this.lblNhanVienTim.AutoSize = true;
            this.lblNhanVienTim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblNhanVienTim.Location = new System.Drawing.Point(245, 40);
            this.lblNhanVienTim.Name = "lblNhanVienTim";
            this.lblNhanVienTim.Size = new System.Drawing.Size(117, 27);
            this.lblNhanVienTim.TabIndex = 4;
            this.lblNhanVienTim.Text = "Nhân viên:";
            // 
            // cmbPhongTim
            // 
            this.cmbPhongTim.BackColor = System.Drawing.Color.Transparent;
            this.cmbPhongTim.BorderRadius = 19;
            this.cmbPhongTim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhongTim.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPhongTim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPhongTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPhongTim.ItemHeight = 36;
            this.cmbPhongTim.Location = new System.Drawing.Point(750, 27);
            this.cmbPhongTim.Name = "cmbPhongTim";
            this.cmbPhongTim.Size = new System.Drawing.Size(118, 42);
            this.cmbPhongTim.TabIndex = 3;
            // 
            // lblPhongTim
            // 
            this.lblPhongTim.AutoSize = true;
            this.lblPhongTim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblPhongTim.Location = new System.Drawing.Point(676, 40);
            this.lblPhongTim.Name = "lblPhongTim";
            this.lblPhongTim.Size = new System.Drawing.Size(79, 27);
            this.lblPhongTim.TabIndex = 2;
            this.lblPhongTim.Text = "Phòng:";
            // 
            // txtMaPhieuTim
            // 
            this.txtMaPhieuTim.BorderRadius = 19;
            this.txtMaPhieuTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuTim.DefaultText = "";
            this.txtMaPhieuTim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaPhieuTim.Location = new System.Drawing.Point(108, 24);
            this.txtMaPhieuTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuTim.Name = "txtMaPhieuTim";
            this.txtMaPhieuTim.PasswordChar = '\0';
            this.txtMaPhieuTim.PlaceholderText = "";
            this.txtMaPhieuTim.SelectedText = "";
            this.txtMaPhieuTim.Size = new System.Drawing.Size(130, 45);
            this.txtMaPhieuTim.TabIndex = 1;
            // 
            // lblMaPhieuTim
            // 
            this.lblMaPhieuTim.AutoSize = true;
            this.lblMaPhieuTim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lblMaPhieuTim.Location = new System.Drawing.Point(3, 40);
            this.lblMaPhieuTim.Name = "lblMaPhieuTim";
            this.lblMaPhieuTim.Size = new System.Drawing.Size(109, 27);
            this.lblMaPhieuTim.TabIndex = 0;
            this.lblMaPhieuTim.Text = "Mã phiếu:";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnXoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1492, 163);
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
            this.btnSua.Location = new System.Drawing.Point(1286, 163);
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
            this.dataGridView1.Location = new System.Drawing.Point(78, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1435, 738);
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
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 19;
            this.btnLamMoi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLamMoi.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1463, 79);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(181, 64);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 19;
            this.btnIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnIn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(850, 161);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(181, 60);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "In Phiếu";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTim;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpNgayTim;
        private System.Windows.Forms.Label lblNgayTim;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNhanVienTim;
        private System.Windows.Forms.Label lblNhanVienTim;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPhongTim;
        private System.Windows.Forms.Label lblPhongTim;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaPhieuTim;
        private System.Windows.Forms.Label lblMaPhieuTim;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnIn;
    }
}