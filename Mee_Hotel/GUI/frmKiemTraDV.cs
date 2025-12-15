using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mee_Hotel.GUI
{
    public partial class frmKiemTraDV : Form
    {
        public frmKiemTraDV()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadFullDichVu()
        {
            
        }

        private void LoadDVTheoPhong()
        {

        }

        private void frmKiemTraDV_Load(object sender, EventArgs e)
        {
            Data_DV_KT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_DV_KT.AllowUserToResizeColumns = false;
            Data_DV_KT.AllowUserToResizeRows = false;
            Data_DV_KT.AllowUserToAddRows = false;
            Data_DV_KT.AllowUserToDeleteRows = false;
            Data_DV_KT.ReadOnly = true;
            Data_DV_KT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_DV_KT.MultiSelect = false;
            Data_DV_KT.BorderStyle = BorderStyle.None;
            // Font + màu nền
            Data_DV_KT.Font = new Font("Segoe UI", 10F);
            Data_DV_KT.BackgroundColor = Color.White;
            Data_DV_KT.GridColor = Color.LightGray;

            // Header
            Data_DV_KT.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            Data_DV_KT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Data_DV_KT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_DV_KT.EnableHeadersVisualStyles = false;
            Data_DV_KT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Data_DV_KT.ColumnHeadersHeight = 75;   // bạn muốn cao bao nhiêu thì ghi vào đây
            Data_DV_KT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Căn giữa tất cả cột
            foreach (DataGridViewColumn col in Data_DV_KT.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (Data_DV_KT.Rows.Count > 0)
            {
                Data_DV_KT.Rows[0].Height = 55;
                Data_DV_KT.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                Data_DV_KT.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 215);
            }
            Data_DV_KT.RowTemplate.Height = 50;
        }
    }
}
