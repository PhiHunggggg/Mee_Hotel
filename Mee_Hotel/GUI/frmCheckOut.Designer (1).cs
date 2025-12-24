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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelControl1.Location = new System.Drawing.Point(50, 436);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(345, 23);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Danh sách các phòng của Phiếu Đặt ";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblHuHong.Location = new System.Drawing.Point(941, 599);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHuHong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHuHong.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHuHong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHuHong.Location = new System.Drawing.Point(946, 661);
            this.dataGridHuHong.Name = "dataGridHuHong";
            this.dataGridHuHong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHuHong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridHuHong.RowHeadersWidth = 51;
            this.dataGridHuHong.RowTemplate.Height = 40;
            this.dataGridHuHong.Size = new System.Drawing.Size(722, 280);
            this.dataGridHuHong.TabIndex = 13;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDichVu.Location = new System.Drawing.Point(941, 313);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDichVu.ColumnHeadersHeight = 50;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDichVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridDichVu.Location = new System.Drawing.Point(946, 353);
            this.dataGridDichVu.Name = "dataGridDichVu";
            this.dataGridDichVu.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridDichVu.RowHeadersWidth = 51;
            this.dataGridDichVu.RowTemplate.Height = 40;
            this.dataGridDichVu.Size = new System.Drawing.Size(685, 229);
            this.dataGridDichVu.TabIndex = 11;
            // 
            // dgvSoNgayO
            // 
            this.dgvSoNgayO.AllowUserToAddRows = false;
            this.dgvSoNgayO.AllowUserToDeleteRows = false;
            this.dgvSoNgayO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoNgayO.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoNgayO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoNgayO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSoNgayO.ColumnHeadersHeight = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoNgayO.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSoNgayO.Location = new System.Drawing.Point(932, 151);
            this.dgvSoNgayO.Name = "dgvSoNgayO";
            this.dgvSoNgayO.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoNgayO.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSoNgayO.RowHeadersWidth = 51;
            this.dgvSoNgayO.RowTemplate.Height = 40;
            this.dgvSoNgayO.Size = new System.Drawing.Size(681, 126);
            this.dgvSoNgayO.TabIndex = 9;
            // 
            // btnCheckOutBatch
            // 
            this.btnCheckOutBatch.BorderRadius = 19;
            this.btnCheckOutBatch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCheckOutBatch.ForeColor = System.Drawing.Color.White;
            this.btnCheckOutBatch.Location = new System.Drawing.Point(323, 727);
            this.btnCheckOutBatch.Name = "btnCheckOutBatch";
            this.btnCheckOutBatch.Size = new System.Drawing.Size(288, 60);
            this.btnCheckOutBatch.TabIndex = 7;
            this.btnCheckOutBatch.Text = "Check Out ";
            this.btnCheckOutBatch.Click += new System.EventHandler(this.btnCheckOutBatch_Click);
            // 
            // dgvPhongBatch
            // 
            this.dgvPhongBatch.AllowUserToAddRows = false;
            this.dgvPhongBatch.AllowUserToDeleteRows = false;
            this.dgvPhongBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPhongBatch.ColumnHeadersHeight = 50;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongBatch.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPhongBatch.Location = new System.Drawing.Point(55, 471);
            this.dgvPhongBatch.Name = "dgvPhongBatch";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPhongBatch.RowHeadersWidth = 51;
            this.dgvPhongBatch.RowTemplate.Height = 40;
            this.dgvPhongBatch.Size = new System.Drawing.Size(823, 220);
            this.dgvPhongBatch.TabIndex = 5;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPhieuDP.ColumnHeadersHeight = 50;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuDP.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPhieuDP.Location = new System.Drawing.Point(50, 210);
            this.dgvPhieuDP.Name = "dgvPhieuDP";
            this.dgvPhieuDP.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDP.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPhieuDP.RowHeadersWidth = 51;
            this.dgvPhieuDP.RowTemplate.Height = 40;
            this.dgvPhieuDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDP.Size = new System.Drawing.Size(823, 220);
            this.dgvPhieuDP.TabIndex = 4;
            this.dgvPhieuDP.SelectionChanged += new System.EventHandler(this.dgvPhieuDP_SelectionChanged);
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BorderRadius = 19;
            this.btnTimPhieu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieu.Location = new System.Drawing.Point(545, 160);
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
            this.txtSearch.Location = new System.Drawing.Point(180, 160);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(339, 35);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSearch.Location = new System.Drawing.Point(50, 160);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // lblTimPhieu
            // 
            this.lblTimPhieu.AutoSize = true;
            this.lblTimPhieu.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTimPhieu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTimPhieu.Location = new System.Drawing.Point(50, 100);
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