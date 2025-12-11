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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cmbPhong = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayTraDuKien = new System.Windows.Forms.Label();
            this.lblSoNgayO = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.dataGridDichVu = new System.Windows.Forms.DataGridView();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.dataGridHuHong = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.siticoneShapes1);
            this.panel1.Controls.Add(this.lblPhong);
            this.panel1.Controls.Add(this.cmbPhong);
            this.panel1.Controls.Add(this.lblMaPhong);
            this.panel1.Controls.Add(this.lblTenPhong);
            this.panel1.Controls.Add(this.lblMaDP);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.lblNgayTraDuKien);
            this.panel1.Controls.Add(this.lblSoNgayO);
            this.panel1.Controls.Add(this.lblDichVu);
            this.panel1.Controls.Add(this.dataGridDichVu);
            this.panel1.Controls.Add(this.lblHuHong);
            this.panel1.Controls.Add(this.dataGridHuHong);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 0;
            // 
            // siticoneShapes1
            // 
            this.siticoneShapes1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.siticoneShapes1.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes1.FillColor = System.Drawing.Color.White;
            this.siticoneShapes1.Location = new System.Drawing.Point(-65, -56);
            this.siticoneShapes1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneShapes1.Name = "siticoneShapes1";
            this.siticoneShapes1.PolygonSkip = 1;
            this.siticoneShapes1.Rotate = 0F;
            this.siticoneShapes1.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes1.Size = new System.Drawing.Size(2372, 369);
            this.siticoneShapes1.TabIndex = 0;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 80;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.Black;
            this.lblPhong.Location = new System.Drawing.Point(187, 74);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(135, 27);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Chọn phòng:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.BackColor = System.Drawing.Color.Transparent;
            this.cmbPhong.BorderRadius = 19;
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPhong.ForeColor = System.Drawing.Color.Black;
            this.cmbPhong.ItemHeight = 30;
            this.cmbPhong.Location = new System.Drawing.Point(400, 62);
            this.cmbPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(300, 36);
            this.cmbPhong.TabIndex = 3;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMaPhong.Location = new System.Drawing.Point(400, 123);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(0, 26);
            this.lblMaPhong.TabIndex = 4;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenPhong.Location = new System.Drawing.Point(400, 185);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(0, 26);
            this.lblTenPhong.TabIndex = 5;
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMaDP.Location = new System.Drawing.Point(1200, 62);
            this.lblMaDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(0, 26);
            this.lblMaDP.TabIndex = 6;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenKH.Location = new System.Drawing.Point(1200, 123);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(0, 26);
            this.lblTenKH.TabIndex = 7;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayDen.Location = new System.Drawing.Point(1200, 185);
            this.lblNgayDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(0, 26);
            this.lblNgayDen.TabIndex = 8;
            // 
            // lblNgayTraDuKien
            // 
            this.lblNgayTraDuKien.AutoSize = true;
            this.lblNgayTraDuKien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraDuKien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayTraDuKien.Location = new System.Drawing.Point(1200, 246);
            this.lblNgayTraDuKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTraDuKien.Name = "lblNgayTraDuKien";
            this.lblNgayTraDuKien.Size = new System.Drawing.Size(0, 26);
            this.lblNgayTraDuKien.TabIndex = 9;
            // 
            // lblSoNgayO
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayO.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSoNgayO.Location = new System.Drawing.Point(1200, 308);
            this.lblSoNgayO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(0, 26);
            this.lblSoNgayO.TabIndex = 10;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.ForeColor = System.Drawing.Color.Black;
            this.lblDichVu.Location = new System.Drawing.Point(187, 431);
            this.lblDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(204, 27);
            this.lblDichVu.TabIndex = 11;
            this.lblDichVu.Text = "Dịch vụ đã sử dụng:";
            // 
            // dataGridDichVu
            // 
            this.dataGridDichVu.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDichVu.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDichVu.Location = new System.Drawing.Point(153, 492);
            this.dataGridDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridDichVu.Name = "dataGridDichVu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDichVu.RowHeadersVisible = false;
            this.dataGridDichVu.RowHeadersWidth = 51;
            this.dataGridDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDichVu.Size = new System.Drawing.Size(933, 431);
            this.dataGridDichVu.TabIndex = 12;
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuHong.ForeColor = System.Drawing.Color.Black;
            this.lblHuHong.Location = new System.Drawing.Point(1200, 431);
            this.lblHuHong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(242, 27);
            this.lblHuHong.TabIndex = 13;
            this.lblHuHong.Text = "Phiếu kiểm tra hư hỏng:";
            // 
            // dataGridHuHong
            // 
            this.dataGridHuHong.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridHuHong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridHuHong.ColumnHeadersHeight = 30;
            this.dataGridHuHong.Location = new System.Drawing.Point(1116, 492);
            this.dataGridHuHong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridHuHong.Name = "dataGridHuHong";
            this.dataGridHuHong.RowHeadersVisible = false;
            this.dataGridHuHong.RowHeadersWidth = 51;
            this.dataGridHuHong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHuHong.Size = new System.Drawing.Size(933, 431);
            this.dataGridHuHong.TabIndex = 14;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 19;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(1023, 959);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(267, 74);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "Check Out";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCheckOut";
            this.Text = "Check Out Phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuHong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private System.Windows.Forms.Label lblPhong;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayTraDuKien;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.DataGridView dataGridDichVu;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.DataGridView dataGridHuHong;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckOut;
    }
}