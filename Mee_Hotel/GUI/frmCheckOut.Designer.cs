namespace Mee_Hotel.GUI
{
    partial class frmCheckOut
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.dataGridHuHong = new System.Windows.Forms.DataGridView();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.dataGridDichVu = new System.Windows.Forms.DataGridView();
            this.dgvSoNgayO = new System.Windows.Forms.DataGridView();
            this.btnCheckOutBatch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dgvPhongBatch = new System.Windows.Forms.DataGridView();
            this.dgvPhieuDP = new System.Windows.Forms.DataGridView();
            this.btnTimPhieu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTimPhieu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Controls.Add(this.lblChonPhong);
            this.panel1.Controls.Add(this.cmbPhong);
            this.panel1.Controls.Add(this.lblMaPhongLabel);
            this.panel1.Controls.Add(this.lblMaPhong);
            this.panel1.Controls.Add(this.lblTenPhongLabel);
            this.panel1.Controls.Add(this.lblTenPhong);
            this.panel1.Controls.Add(this.lblMaDPLabel);
            this.panel1.Controls.Add(this.lblMaDP);
            this.panel1.Controls.Add(this.lblTenKHLabel);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.lblNgayDenLabel);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.lblNgayTraDuKienLabel);
            this.panel1.Controls.Add(this.lblNgayTraDuKien);
            this.panel1.Controls.Add(this.lblSoNgayOLabel);
            this.panel1.Controls.Add(this.lblSoNgayO);
            this.panel1.Controls.Add(this.lblDichVu);
            this.panel1.Controls.Add(this.dataGridDichVu);
            this.panel1.Controls.Add(this.lblHuHong);
            this.panel1.Controls.Add(this.dataGridHuHong);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(938, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(238, 29);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Số Ngày Ở Thực Tế:";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblHuHong.Location = new System.Drawing.Point(904, 641);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(324, 29);
            this.lblHuHong.TabIndex = 12;
            this.lblHuHong.Text = "Hư hỏng thiết bị (nếu có):";
            // 
            this.lblSoNgayOLabel.AutoSize = true;
            this.lblSoNgayOLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSoNgayOLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSoNgayOLabel.Location = new System.Drawing.Point(100, 540);
            this.lblSoNgayOLabel.Name = "lblSoNgayOLabel";
            this.lblSoNgayOLabel.Size = new System.Drawing.Size(139, 29);
            this.lblSoNgayOLabel.TabIndex = 15;
            this.lblSoNgayOLabel.Text = "Số ngày ở:";
            // 
            this.dataGridHuHong.AllowUserToAddRows = false;
            this.dataGridHuHong.AllowUserToDeleteRows = false;
            this.dataGridHuHong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHuHong.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHuHong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHuHong.ColumnHeadersHeight = 50;
            this.dataGridHuHong.Location = new System.Drawing.Point(742, 674);
            this.dataGridHuHong.Name = "dataGridHuHong";
            this.dataGridHuHong.ReadOnly = true;
            this.dataGridHuHong.RowHeadersWidth = 51;
            this.dataGridHuHong.RowTemplate.Height = 40;
            this.dataGridHuHong.Size = new System.Drawing.Size(699, 225);
            this.dataGridHuHong.TabIndex = 13;
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSoNgayO.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayO.Location = new System.Drawing.Point(320, 540);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(93, 29);
            this.lblSoNgayO.TabIndex = 16;
            this.lblSoNgayO.Text = "0 ngày";
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDichVu.Location = new System.Drawing.Point(951, 290);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(268, 33);
            this.lblDichVu.TabIndex = 17;
            this.lblDichVu.Text = "DỊCH VỤ SỬ DỤNG";
            // 
            // dataGridDichVu
            // 
            this.dataGridDichVu.AllowUserToAddRows = false;
            this.dataGridDichVu.AllowUserToDeleteRows = false;
            this.dataGridDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDichVu.ColumnHeadersHeight = 50;
            this.dataGridDichVu.Location = new System.Drawing.Point(756, 331);
            this.dataGridDichVu.Name = "dataGridDichVu";
            this.dataGridDichVu.ReadOnly = true;
            this.dataGridDichVu.RowHeadersVisible = false;
            this.dataGridDichVu.RowHeadersWidth = 51;
            this.dataGridDichVu.RowTemplate.Height = 40;
            this.dataGridDichVu.Size = new System.Drawing.Size(919, 401);
            this.dataGridDichVu.TabIndex = 18;
            // 
            // lblHuHong
            // 
            this.dgvSoNgayO.AllowUserToAddRows = false;
            this.dgvSoNgayO.AllowUserToDeleteRows = false;
            this.dgvSoNgayO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoNgayO.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoNgayO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoNgayO.ColumnHeadersHeight = 50;
            this.dgvSoNgayO.Location = new System.Drawing.Point(742, 67);
            this.dgvSoNgayO.Name = "dgvSoNgayO";
            this.dgvSoNgayO.ReadOnly = true;
            this.dgvSoNgayO.RowHeadersWidth = 51;
            this.dgvSoNgayO.RowTemplate.Height = 40;
            this.dgvSoNgayO.Size = new System.Drawing.Size(681, 211);
            this.dgvSoNgayO.TabIndex = 9;
            // 
            // dataGridHuHong
            // 
            this.dataGridHuHong.AllowUserToAddRows = false;
            this.dataGridHuHong.AllowUserToDeleteRows = false;
            this.dataGridHuHong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHuHong.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHuHong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHuHong.ColumnHeadersHeight = 50;
            this.dataGridHuHong.Location = new System.Drawing.Point(748, 526);
            this.dataGridHuHong.Name = "dataGridHuHong";
            this.dataGridHuHong.ReadOnly = true;
            this.dataGridHuHong.RowHeadersVisible = false;
            this.dataGridHuHong.RowHeadersWidth = 51;
            this.dataGridHuHong.RowTemplate.Height = 40;
            this.dataGridHuHong.Size = new System.Drawing.Size(913, 359);
            this.dataGridHuHong.TabIndex = 20;
            // 
            // btnCheckOut
            // 
            this.dgvPhongBatch.AllowUserToAddRows = false;
            this.dgvPhongBatch.AllowUserToDeleteRows = false;
            this.dgvPhongBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongBatch.ColumnHeadersHeight = 50;
            this.dgvPhongBatch.Location = new System.Drawing.Point(12, 430);
            this.dgvPhongBatch.Name = "dgvPhongBatch";
            this.dgvPhongBatch.RowHeadersWidth = 51;
            this.dgvPhongBatch.RowTemplate.Height = 40;
            this.dgvPhongBatch.Size = new System.Drawing.Size(665, 220);
            this.dgvPhongBatch.TabIndex = 5;
            this.dgvPhongBatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBatch_CellClick);
            this.dgvPhongBatch.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBatch_CellValueChanged);
            this.dgvPhongBatch.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPhongBatch_CurrentCellDirtyStateChanged);
            // 
            // dgvPhieuDP
            // 
            this.dgvPhieuDP.AllowUserToAddRows = false;
            this.dgvPhieuDP.AllowUserToDeleteRows = false;
            this.dgvPhieuDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDP.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuDP.ColumnHeadersHeight = 50;
            this.dgvPhieuDP.Location = new System.Drawing.Point(12, 204);
            this.dgvPhieuDP.Name = "dgvPhieuDP";
            this.dgvPhieuDP.ReadOnly = true;
            this.dgvPhieuDP.RowHeadersWidth = 51;
            this.dgvPhieuDP.RowTemplate.Height = 40;
            this.dgvPhieuDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDP.Size = new System.Drawing.Size(665, 220);
            this.dgvPhieuDP.TabIndex = 4;
            this.dgvPhieuDP.SelectionChanged += new System.EventHandler(this.dgvPhieuDP_SelectionChanged);
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BorderRadius = 19;
            this.btnTimPhieu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieu.Location = new System.Drawing.Point(542, 126);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(165, 40);
            this.btnTimPhieu.TabIndex = 3;
            this.btnTimPhieu.Text = "Tìm kiếm";
            this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(174, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(339, 35);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSearch.Location = new System.Drawing.Point(45, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(550, 29);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm kiếm (mã phiếu / tên KH / SDT / CCCD):";
            // 
            // lblTimPhieu
            // 
            this.lblTimPhieu.AutoSize = true;
            this.lblTimPhieu.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTimPhieu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTimPhieu.Location = new System.Drawing.Point(136, 27);
            this.lblTimPhieu.Name = "lblTimPhieu";
            this.lblTimPhieu.Size = new System.Drawing.Size(528, 33);
            this.lblTimPhieu.TabIndex = 0;
            this.lblTimPhieu.Text = "CHECK OUT THEO PHIẾU ĐẶT PHÒNG";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out Phòng - Mee Hotel";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChonPhong;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPhong;
        private System.Windows.Forms.Label lblMaPhongLabel;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhongLabel;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaDPLabel;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.Label lblTenKHLabel;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblNgayDenLabel;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayTraDuKienLabel;
        private System.Windows.Forms.Label lblNgayTraDuKien;
        private System.Windows.Forms.Label lblSoNgayOLabel;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.DataGridView dataGridDichVu;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.DataGridView dataGridHuHong;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckOut;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}