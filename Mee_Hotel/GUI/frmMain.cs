using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void accordionControKiemTraHuHong_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlKiemTraHuHong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuKiemTraHuHong());
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

        }
    }
}
