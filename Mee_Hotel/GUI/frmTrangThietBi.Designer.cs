// frmTrangThietBi.Designer.cs
namespace Mee_Hotel.GUI
{
    partial class frmTrangThietBi
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
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cmbPhong = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.cmbThietBi = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblSoLuongGoc = new System.Windows.Forms.Label();
            this.txtSoLuongGoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblSoLuongHienTai = new System.Windows.Forms.Label();
            this.txtSoLuongHienTai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnThem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblLoaiPhong);
            this.panel1.Controls.Add(this.cmbLoaiPhong);
            this.panel1.Controls.Add(this.lblPhong);
            this.panel1.Controls.Add(this.cmbPhong);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblThietBi);
            this.panel1.Controls.Add(this.cmbThietBi);
            this.panel1.Controls.Add(this.lblSoLuongGoc);
            this.panel1.Controls.Add(this.txtSoLuongGoc);
            this.panel1.Controls.Add(this.lblSoLuongHienTai);
            this.panel1.Controls.Add(this.txtSoLuongHienTai);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.siticoneShapes1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 857);
            this.panel1.TabIndex = 0;
            // 
            // siticoneShapes1
            // 
            this.siticoneShapes1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.siticoneShapes1.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes1.FillColor = System.Drawing.Color.White;
            this.siticoneShapes1.Location = new System.Drawing.Point(-108, 0);
            this.siticoneShapes1.Name = "siticoneShapes1";
            this.siticoneShapes1.PolygonSkip = 1;
            this.siticoneShapes1.Rotate = 0F;
            this.siticoneShapes1.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes1.Size = new System.Drawing.Size(1572, 333);
            this.siticoneShapes1.TabIndex = 0;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 80;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.BackColor = System.Drawing.Color.White;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiPhong.Location = new System.Drawing.Point(84, 156);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(99, 21);
            this.lblLoaiPhong.TabIndex = 4;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.BackColor = System.Drawing.Color.White;
            this.cmbLoaiPhong.BorderRadius = 19;
            this.cmbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiPhong.ItemHeight = 30;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(189, 141);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(226, 36);
            this.cmbLoaiPhong.TabIndex = 5;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.BackColor = System.Drawing.Color.White;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.Black;
            this.lblPhong.Location = new System.Drawing.Point(476, 124);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(62, 21);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "Phòng:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.BackColor = System.Drawing.Color.White;
            this.cmbPhong.BorderRadius = 19;
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbPhong.ItemHeight = 30;
            this.cmbPhong.Location = new System.Drawing.Point(641, 114);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(226, 36);
            this.cmbPhong.TabIndex = 7;
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(140, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 520);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.BackColor = System.Drawing.Color.White;
            this.lblThietBi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThietBi.ForeColor = System.Drawing.Color.Black;
            this.lblThietBi.Location = new System.Drawing.Point(476, 184);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(71, 21);
            this.lblThietBi.TabIndex = 9;
            this.lblThietBi.Text = "Thiết bị:";
            // 
            // cmbThietBi
            // 
            this.cmbThietBi.BackColor = System.Drawing.Color.White;
            this.cmbThietBi.BorderRadius = 19;
            this.cmbThietBi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThietBi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbThietBi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbThietBi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbThietBi.ForeColor = System.Drawing.Color.Black;
            this.cmbThietBi.ItemHeight = 30;
            this.cmbThietBi.Location = new System.Drawing.Point(641, 174);
            this.cmbThietBi.Name = "cmbThietBi";
            this.cmbThietBi.Size = new System.Drawing.Size(226, 36);
            this.cmbThietBi.TabIndex = 10;
            // 
            // lblSoLuongGoc
            // 
            this.lblSoLuongGoc.AutoSize = true;
            this.lblSoLuongGoc.BackColor = System.Drawing.Color.White;
            this.lblSoLuongGoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongGoc.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongGoc.Location = new System.Drawing.Point(890, 124);
            this.lblSoLuongGoc.Name = "lblSoLuongGoc";
            this.lblSoLuongGoc.Size = new System.Drawing.Size(115, 21);
            this.lblSoLuongGoc.TabIndex = 11;
            this.lblSoLuongGoc.Text = "Số lượng gốc:";
            // 
            // txtSoLuongGoc
            // 
            this.txtSoLuongGoc.BackColor = System.Drawing.Color.White;
            this.txtSoLuongGoc.BorderRadius = 19;
            this.txtSoLuongGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongGoc.DefaultText = "";
            this.txtSoLuongGoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongGoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongGoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongGoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongGoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongGoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoLuongGoc.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongGoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongGoc.Location = new System.Drawing.Point(1055, 114);
            this.txtSoLuongGoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuongGoc.Name = "txtSoLuongGoc";
            this.txtSoLuongGoc.PasswordChar = '\0';
            this.txtSoLuongGoc.PlaceholderText = "";
            this.txtSoLuongGoc.SelectedText = "";
            this.txtSoLuongGoc.Size = new System.Drawing.Size(226, 36);
            this.txtSoLuongGoc.TabIndex = 12;
            // 
            // lblSoLuongHienTai
            // 
            this.lblSoLuongHienTai.AutoSize = true;
            this.lblSoLuongHienTai.BackColor = System.Drawing.Color.White;
            this.lblSoLuongHienTai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongHienTai.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongHienTai.Location = new System.Drawing.Point(890, 184);
            this.lblSoLuongHienTai.Name = "lblSoLuongHienTai";
            this.lblSoLuongHienTai.Size = new System.Drawing.Size(139, 21);
            this.lblSoLuongHienTai.TabIndex = 13;
            this.lblSoLuongHienTai.Text = "Số lượng hiện tại:";
            // 
            // txtSoLuongHienTai
            // 
            this.txtSoLuongHienTai.BackColor = System.Drawing.Color.White;
            this.txtSoLuongHienTai.BorderRadius = 19;
            this.txtSoLuongHienTai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongHienTai.DefaultText = "";
            this.txtSoLuongHienTai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongHienTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongHienTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongHienTai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongHienTai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongHienTai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoLuongHienTai.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongHienTai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongHienTai.Location = new System.Drawing.Point(1055, 174);
            this.txtSoLuongHienTai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuongHienTai.Name = "txtSoLuongHienTai";
            this.txtSoLuongHienTai.PasswordChar = '\0';
            this.txtSoLuongHienTai.PlaceholderText = "";
            this.txtSoLuongHienTai.SelectedText = "";
            this.txtSoLuongHienTai.Size = new System.Drawing.Size(226, 36);
            this.txtSoLuongHienTai.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 19;
            this.btnThem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnThem.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1214, 378);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 49);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 19;
            this.btnSua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSua.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1214, 473);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(136, 52);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnXoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1214, 551);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 49);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangThietBi";
            this.Text = "Quản Lý Trang Thiết Bị";
            this.Load += new System.EventHandler(this.frmTrangThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private System.Windows.Forms.Label lblLoaiPhong;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label lblPhong;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblThietBi;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbThietBi;
        private System.Windows.Forms.Label lblSoLuongGoc;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoLuongGoc;
        private System.Windows.Forms.Label lblSoLuongHienTai;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoLuongHienTai;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    }
}