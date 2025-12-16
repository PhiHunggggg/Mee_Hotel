
namespace Mee_Hotel.GUI.Phong
{
    partial class frmDatPhong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayDangKi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongPhongDat = new System.Windows.Forms.Label();
            this.lblCanhBaoSoNguoi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongNguoiToiDa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoNguoiDangKy = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.dtpNgayDen = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnXacNhan = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblTongTienDuKien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNgayDangKi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTongPhongDat);
            this.panel1.Controls.Add(this.lblCanhBaoSoNguoi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTongNguoiToiDa);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtSoNguoiDangKy);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.lblTongTienDuKien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 832);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(985, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Số ngày đăng ký :";
            // 
            // lblNgayDangKi
            // 
            this.lblNgayDangKi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayDangKi.AutoSize = true;
            this.lblNgayDangKi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangKi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayDangKi.Location = new System.Drawing.Point(1160, 411);
            this.lblNgayDangKi.Name = "lblNgayDangKi";
            this.lblNgayDangKi.Size = new System.Drawing.Size(24, 26);
            this.lblNgayDangKi.TabIndex = 48;
            this.lblNgayDangKi.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(970, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số phòng đăng kí :";
            // 
            // lblTongPhongDat
            // 
            this.lblTongPhongDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongPhongDat.AutoSize = true;
            this.lblTongPhongDat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongPhongDat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongPhongDat.Location = new System.Drawing.Point(1151, 32);
            this.lblTongPhongDat.Name = "lblTongPhongDat";
            this.lblTongPhongDat.Size = new System.Drawing.Size(24, 26);
            this.lblTongPhongDat.TabIndex = 46;
            this.lblTongPhongDat.Text = "0";
            // 
            // lblCanhBaoSoNguoi
            // 
            this.lblCanhBaoSoNguoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCanhBaoSoNguoi.AutoSize = true;
            this.lblCanhBaoSoNguoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhBaoSoNguoi.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBaoSoNguoi.Location = new System.Drawing.Point(975, 107);
            this.lblCanhBaoSoNguoi.Name = "lblCanhBaoSoNguoi";
            this.lblCanhBaoSoNguoi.Size = new System.Drawing.Size(0, 22);
            this.lblCanhBaoSoNguoi.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(970, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Số người tối đa :";
            // 
            // lblTongNguoiToiDa
            // 
            this.lblTongNguoiToiDa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongNguoiToiDa.AutoSize = true;
            this.lblTongNguoiToiDa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNguoiToiDa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongNguoiToiDa.Location = new System.Drawing.Point(1122, 67);
            this.lblTongNguoiToiDa.Name = "lblTongNguoiToiDa";
            this.lblTongNguoiToiDa.Size = new System.Drawing.Size(24, 26);
            this.lblTongNguoiToiDa.TabIndex = 43;
            this.lblTongNguoiToiDa.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(969, 830);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // txtSoNguoiDangKy
            // 
            this.txtSoNguoiDangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNguoiDangKy.BorderColor = System.Drawing.Color.Black;
            this.txtSoNguoiDangKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNguoiDangKy.DefaultText = "";
            this.txtSoNguoiDangKy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoNguoiDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoNguoiDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoiDangKy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoiDangKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoiDangKy.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSoNguoiDangKy.ForeColor = System.Drawing.Color.Black;
            this.txtSoNguoiDangKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoiDangKy.Location = new System.Drawing.Point(1369, 336);
            this.txtSoNguoiDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoNguoiDangKy.Name = "txtSoNguoiDangKy";
            this.txtSoNguoiDangKy.PasswordChar = '\0';
            this.txtSoNguoiDangKy.PlaceholderText = "";
            this.txtSoNguoiDangKy.SelectedText = "";
            this.txtSoNguoiDangKy.Size = new System.Drawing.Size(191, 48);
            this.txtSoNguoiDangKy.TabIndex = 41;
            this.txtSoNguoiDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoNguoiDangKy.TextChanged += new System.EventHandler(this.txtSoNguoiDangKy_TextChanged);
            this.txtSoNguoiDangKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNguoiDangKy_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(1142, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(252, 31);
            this.label14.TabIndex = 40;
            this.label14.Text = "Thông tin đặt phòng";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(1419, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "Số người";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(1226, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "Ngày trả ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(1032, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Ngày đến";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayTra.BorderThickness = 1;
            this.dtpNgayTra.Checked = true;
            this.dtpNgayTra.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.dtpNgayTra.FillColor = System.Drawing.Color.White;
            this.dtpNgayTra.FocusedColor = System.Drawing.Color.White;
            this.dtpNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(1178, 336);
            this.dtpNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(191, 48);
            this.dtpNgayTra.TabIndex = 36;
            this.dtpNgayTra.Value = new System.DateTime(2025, 12, 5, 15, 55, 26, 944);
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.dtpNgayTra_ValueChanged);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayDen.BorderThickness = 1;
            this.dtpNgayDen.Checked = true;
            this.dtpNgayDen.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.dtpNgayDen.FillColor = System.Drawing.Color.White;
            this.dtpNgayDen.FocusedColor = System.Drawing.Color.White;
            this.dtpNgayDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(987, 336);
            this.dtpNgayDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(191, 48);
            this.dtpNgayDen.TabIndex = 35;
            this.dtpNgayDen.Value = new System.DateTime(2025, 12, 5, 15, 55, 26, 944);
            this.dtpNgayDen.ValueChanged += new System.EventHandler(this.dtpNgayDen_ValueChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BorderRadius = 19;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(1178, 504);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(180, 45);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblTongTienDuKien
            // 
            this.lblTongTienDuKien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongTienDuKien.AutoSize = true;
            this.lblTongTienDuKien.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienDuKien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTongTienDuKien.Location = new System.Drawing.Point(1173, 465);
            this.lblTongTienDuKien.Name = "lblTongTienDuKien";
            this.lblTongTienDuKien.Size = new System.Drawing.Size(136, 25);
            this.lblTongTienDuKien.TabIndex = 3;
            this.lblTongTienDuKien.Text = "000000.00$";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(985, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền dự kiến :";
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataMember = "Voucher";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 832);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXacNhan;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private System.Windows.Forms.Label lblTongTienDuKien;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoNguoiDangKy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpNgayTra;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpNgayDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongNguoiToiDa;
        private System.Windows.Forms.Label lblCanhBaoSoNguoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongPhongDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayDangKi;
    }
}