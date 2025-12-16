namespace Mee_Hotel.GUI
{
    partial class frmCheckOutTheoDoan
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { /* ... */ }
        private void InitializeComponent()
        {
            this.dgvPhieuDoan = new System.Windows.Forms.DataGridView();
            this.btnCheckOutDoan = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuDoan
            // 
            this.dgvPhieuDoan.ColumnHeadersHeight = 29;
            this.dgvPhieuDoan.Location = new System.Drawing.Point(16, 15);
            this.dgvPhieuDoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuDoan.Name = "dgvPhieuDoan";
            this.dgvPhieuDoan.RowHeadersWidth = 51;
            this.dgvPhieuDoan.Size = new System.Drawing.Size(1067, 492);
            this.dgvPhieuDoan.TabIndex = 0;
            // 
            // btnCheckOutDoan
            // 
            this.btnCheckOutDoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOutDoan.ForeColor = System.Drawing.Color.White;
            this.btnCheckOutDoan.Location = new System.Drawing.Point(16, 517);
            this.btnCheckOutDoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOutDoan.Name = "btnCheckOutDoan";
            this.btnCheckOutDoan.Size = new System.Drawing.Size(267, 62);
            this.btnCheckOutDoan.TabIndex = 0;
            this.btnCheckOutDoan.Text = "Check Out Đoàn";
            // 
            // frmCheckOutTheoDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 707);
            this.Controls.Add(this.btnCheckOutDoan);
            this.Controls.Add(this.dgvPhieuDoan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCheckOutTheoDoan";
            this.Text = "Check Out Theo Đoàn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvPhieuDoan;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckOutDoan;
    }
}