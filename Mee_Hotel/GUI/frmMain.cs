using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mee_Hotel.GUI.FolderPhong;
namespace Mee_Hotel.GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietDichVu());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietDichVu());
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mee_Hotel.GUI.Phong.frmDatPhong());
        }

        private void accordionControlElement6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmCheckIn());
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mee_Hotel.GUI.Phong.frmPhieuDP());
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyHoaDon());
        }

        private void panelMain_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuKiemTraHuHong());
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCheckOut());
        }
    }
}
