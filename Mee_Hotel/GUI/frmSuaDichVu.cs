using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mee_Hotel.DAL;
namespace Mee_Hotel.GUI
{
    public partial class frmSuaDichVu : Form
    {
        private string maPhong;
        private string maDichVu;
        private DateTime ngaySuDung;
        public frmSuaDichVu(string maPhong,string maDichVu, DateTime ngaySuDung)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            this.maDichVu = maDichVu;
            this.ngaySuDung = ngaySuDung;
        }

        private void siticoneTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;   // chặn ký tự
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền số lượng mới !!!");
                return;
            }
            var kq = DichVuDAL.Instance.SuaDichVuPhong(maPhong, maDichVu, ngaySuDung.Date, Convert.ToInt32(txtSoLuong.Text), StaticThing.MaNV, txtGhiChu.Text);

            if (kq.Success)
            {
                MessageBox.Show(kq.Message, "Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + kq.Message, "Không thể sửa");
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaDichVu_Load(object sender, EventArgs e)
        {
            if (maDichVu == null || maPhong == null || ngaySuDung == null)
            {
                siticoneButton1.Enabled = false;
            }
            else
            {
                siticoneButton1.Enabled = true;
            }
        }
    }
}
