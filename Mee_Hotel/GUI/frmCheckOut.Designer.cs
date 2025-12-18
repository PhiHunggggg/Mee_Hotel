namespace Mee_Hotel.GUI
{
    partial class frmCheckOut
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNgayO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lblHuHong);
            this.panel1.Controls.Add(this.dataGridHuHong);
            this.panel1.Controls.Add(this.lblDichVu);
            this.panel1.Controls.Add(this.dataGridDichVu);
            this.panel1.Controls.Add(this.dgvSoNgayO);
            this.panel1.Controls.Add(this.btnCheckOutBatch);
            this.panel1.Controls.Add(this.dgvPhongBatch);
            this.panel1.Controls.Add(this.dgvPhieuDP);
            this.panel1.Controls.Add(this.btnTimPhieu);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.lblTimPhieu);
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
            this.labelControl1.Location = new System.Drawing.Point(742, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 23);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Số Ngày Ở Thực Tế:";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblHuHong.Location = new System.Drawing.Point(748, 581);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(261, 23);
            this.lblHuHong.TabIndex = 12;
            this.lblHuHong.Text = "Hư hỏng thiết bị (nếu có):";
            // 
            // dataGridHuHong
            // 
            this.dataGridHuHong.AllowUserToAddRows = false;
            this.dataGridHuHong.AllowUserToDeleteRows = false;
            this.dataGridHuHong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHuHong.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHuHong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHuHong.ColumnHeadersHeight = 50;
            this.dataGridHuHong.Location = new System.Drawing.Point(753, 640);
            this.dataGridHuHong.Name = "dataGridHuHong";
            this.dataGridHuHong.ReadOnly = true;
            this.dataGridHuHong.RowHeadersWidth = 51;
            this.dataGridHuHong.RowTemplate.Height = 40;
            this.dataGridHuHong.Size = new System.Drawing.Size(699, 239);
            this.dataGridHuHong.TabIndex = 13;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDichVu.Location = new System.Drawing.Point(748, 252);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(200, 23);
            this.lblDichVu.TabIndex = 10;
            this.lblDichVu.Text = "Dịch vụ đã sử dụng:";
            // 
            // dataGridDichVu
            // 
            this.dataGridDichVu.AllowUserToAddRows = false;
            this.dataGridDichVu.AllowUserToDeleteRows = false;
            this.dataGridDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDichVu.ColumnHeadersHeight = 50;
            this.dataGridDichVu.Location = new System.Drawing.Point(742, 284);
            this.dataGridDichVu.Name = "dataGridDichVu";
            this.dataGridDichVu.ReadOnly = true;
            this.dataGridDichVu.RowHeadersWidth = 51;
            this.dataGridDichVu.RowTemplate.Height = 40;
            this.dataGridDichVu.Size = new System.Drawing.Size(685, 294);
            this.dataGridDichVu.TabIndex = 11;
            // 
            // dgvSoNgayO
            // 
            this.dgvSoNgayO.AllowUserToAddRows = false;
            this.dgvSoNgayO.AllowUserToDeleteRows = false;
            this.dgvSoNgayO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoNgayO.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoNgayO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoNgayO.ColumnHeadersHeight = 50;
            this.dgvSoNgayO.Location = new System.Drawing.Point(742, 58);
            this.dgvSoNgayO.Name = "dgvSoNgayO";
            this.dgvSoNgayO.ReadOnly = true;
            this.dgvSoNgayO.RowHeadersWidth = 51;
            this.dgvSoNgayO.RowTemplate.Height = 40;
            this.dgvSoNgayO.Size = new System.Drawing.Size(681, 191);
            this.dgvSoNgayO.TabIndex = 9;
            // 
            // btnCheckOutBatch
            // 
            this.btnCheckOutBatch.BorderRadius = 19;
            this.btnCheckOutBatch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCheckOutBatch.ForeColor = System.Drawing.Color.White;
            this.btnCheckOutBatch.Location = new System.Drawing.Point(201, 674);
            this.btnCheckOutBatch.Name = "btnCheckOutBatch";
            this.btnCheckOutBatch.Size = new System.Drawing.Size(211, 60);
            this.btnCheckOutBatch.TabIndex = 7;
            this.btnCheckOutBatch.Text = "Check Out";
            this.btnCheckOutBatch.Click += new System.EventHandler(this.btnCheckOutBatch_Click);
            // 
            // dgvPhongBatch
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
            this.dgvPhieuDP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDP_CellClick);
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
            this.lblSearch.Size = new System.Drawing.Size(442, 23);
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
            this.lblTimPhieu.Size = new System.Drawing.Size(423, 27);
            this.lblTimPhieu.TabIndex = 0;
            this.lblTimPhieu.Text = "CHECK OUT THEO PHIẾU ĐẶT PHÒNG";
            // 
            // frmCheckOut
            // 
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNgayO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDP)).EndInit();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblTimPhieu;
    private System.Windows.Forms.Label lblSearch;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSearch;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimPhieu;
    private System.Windows.Forms.DataGridView dgvPhieuDP;
    private System.Windows.Forms.DataGridView dgvPhongBatch;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckOutBatch;
    private System.Windows.Forms.DataGridView dgvSoNgayO;
    private System.Windows.Forms.Label lblDichVu;
    private System.Windows.Forms.DataGridView dataGridDichVu;
    private System.Windows.Forms.Label lblHuHong;
    private System.Windows.Forms.DataGridView dataGridHuHong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}