using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Mee_Hotel.DAL;

namespace Mee_Hotel.GUI
{
    public partial class frmCheckOutTheoDoan : Form
    {
        public frmCheckOutTheoDoan()
        {
            InitializeComponent();
        }

        private void frmCheckOutTheoDoan_Load(object sender, EventArgs e)
        {
            // Load tất phiếu đã check in
            dgvPhieuDoan.DataSource = CheckOutDAL.Instance.GetPhieuDaCheckIn();
            dgvPhieuDoan.Columns.Insert(0, new DataGridViewCheckBoxColumn() { HeaderText = "Chọn" });
        }

        private void btnCheckOutDoan_Click(object sender, EventArgs e)
        {
            string maDPList = "";
            foreach (DataGridViewRow row in dgvPhieuDoan.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    maDPList += row.Cells["MaDP"].Value.ToString() + ",";
                }
            }
            if (string.IsNullOrEmpty(maDPList))
            {
                MessageBox.Show("Chọn ít nhất 1 phiếu!");
                return;
            }
            maDPList = maDPList.TrimEnd(',');

            // Logic check out all rooms of selected DPs (need new DAL/proc for batch DPs)
            // For simplicity, loop call CheckOutTheoPhieu with all rooms per DP
            bool success = true;
            string[] maDPs = maDPList.Split(',');
            foreach (string maDP in maDPs)
            {
                DataTable dtPhong = CheckOutDAL.Instance.GetPhongCuaPhieu(maDP);
                string maPhongSubList = "";
                foreach (DataRow r in dtPhong.Rows)
                {
                    maPhongSubList += r["MaPhong"] + ",";
                }
                maPhongSubList = maPhongSubList.TrimEnd(',');
                if (!CheckOutDAL.Instance.CheckOutTheoPhieu(maDP, 0, 0, maPhongSubList))
                {
                    success = false;
                }
            }
            MessageBox.Show(success ? "Check out đoàn thành công!" : "Có lỗi khi check out!");
            this.Close();
        }
    }
}