
namespace Mee_Hotel.GUI
{
    partial class frmThanhToan
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
            this.PTcb = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTienHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianTT = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTongTienTra = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTcb
            // 
            this.PTcb.BackColor = System.Drawing.Color.Transparent;
            this.PTcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PTcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PTcb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PTcb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PTcb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PTcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PTcb.ItemHeight = 30;
            this.PTcb.Items.AddRange(new object[] {
            "Thanh toán thẻ",
            "Chuyển khoản\'",
            "Tiền mặt"});
            this.PTcb.Location = new System.Drawing.Point(315, 58);
            this.PTcb.Name = "PTcb";
            this.PTcb.Size = new System.Drawing.Size(140, 36);
            this.PTcb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Chọn phương thức trả:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(315, 243);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 43);
            this.btnLogin.TabIndex = 71;
            this.btnLogin.Text = "OK";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tổng tiền theo hóa đơn:";
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.BorderRadius = 19;
            this.txtTongTienHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienHD.DefaultText = "0 VND";
            this.txtTongTienHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTongTienHD.ForeColor = System.Drawing.Color.Red;
            this.txtTongTienHD.Location = new System.Drawing.Point(13, 58);
            this.txtTongTienHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.PasswordChar = '\0';
            this.txtTongTienHD.PlaceholderText = "";
            this.txtTongTienHD.ReadOnly = true;
            this.txtTongTienHD.SelectedText = "";
            this.txtTongTienHD.Size = new System.Drawing.Size(251, 48);
            this.txtTongTienHD.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Thời gian thanh toán:";
            // 
            // txtThoiGianTT
            // 
            this.txtThoiGianTT.BorderRadius = 19;
            this.txtThoiGianTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGianTT.DefaultText = "";
            this.txtThoiGianTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtThoiGianTT.ForeColor = System.Drawing.Color.Black;
            this.txtThoiGianTT.Location = new System.Drawing.Point(13, 154);
            this.txtThoiGianTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThoiGianTT.Name = "txtThoiGianTT";
            this.txtThoiGianTT.PasswordChar = '\0';
            this.txtThoiGianTT.PlaceholderText = "";
            this.txtThoiGianTT.ReadOnly = true;
            this.txtThoiGianTT.SelectedText = "";
            this.txtThoiGianTT.Size = new System.Drawing.Size(251, 48);
            this.txtThoiGianTT.TabIndex = 75;
            // 
            // txtTongTienTra
            // 
            this.txtTongTienTra.BorderRadius = 19;
            this.txtTongTienTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienTra.DefaultText = "0 VND";
            this.txtTongTienTra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTongTienTra.ForeColor = System.Drawing.Color.Red;
            this.txtTongTienTra.Location = new System.Drawing.Point(13, 254);
            this.txtTongTienTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienTra.Name = "txtTongTienTra";
            this.txtTongTienTra.PasswordChar = '\0';
            this.txtTongTienTra.PlaceholderText = "";
            this.txtTongTienTra.ReadOnly = true;
            this.txtTongTienTra.SelectedText = "";
            this.txtTongTienTra.Size = new System.Drawing.Size(251, 48);
            this.txtTongTienTra.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Phải trả:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(297, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 44);
            this.label6.TabIndex = 78;
            this.label6.Text = "* Thanh toán muộn bồi \r\nthường 5% hóa đơn gốc\r\n";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTienTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThoiGianTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTienHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PTcb);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox PTcb;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTongTienHD;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtThoiGianTT;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTongTienTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}