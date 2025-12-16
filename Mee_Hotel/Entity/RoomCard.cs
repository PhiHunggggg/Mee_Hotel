using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mee_Hotel.Entity
{
    public partial class RoomCard : UserControl
    {
        private ToolTip toolTip = new ToolTip();

        public RoomCard()
        {
            InitializeComponent();

            // Bắt click toàn bộ control (kể cả con)
            this.Click += RoomCard_Click;
            foreach (Control c in this.Controls)
                c.Click += RoomCard_Click;

            // Con trỏ tay khi hover
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;

            // Thiết lập mặc định
            this.Padding = new Padding(10);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.None;

            // Tooltip settings - đẹp như khách sạn 5 sao
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Thông tin phòng";
        }

        // SỰ KIỆN CLICK – BẮN RA NGOÀI FORM CHÍNH
        public event EventHandler RoomClicked;
        private void RoomCard_Click(object sender, EventArgs e)
        {
            RoomClicked?.Invoke(this, e);
        }

        // CÁC PROPERTY CƠ BẢN
        public string RoomNumber
        {
            get => lblRoom.Text;
            set => lblRoom.Text = value;
        }

        public string RoomType
        {
            get => lblType.Text;
            set => lblType.Text = value;
        }

        public string StatusText
        {
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }

        public Image Icon
        {
            get => picIcon.Image;
            set => picIcon.Image = value;
        }

        public Color StatusColor
        {
            get => panelStatus.BackColor;
            set
            {
                panelStatus.BackColor = value;
                panelStatus.Invalidate();
            }
        }

        // PROPERTY MỚI: Tooltip chi tiết
        private string _toolTipText = "";
        public string ToolTipInfo
        {
            get => _toolTipText;
            set
            {
                _toolTipText = value;
                toolTip.SetToolTip(this, value);
                toolTip.SetToolTip(picIcon, value);
                toolTip.SetToolTip(lblRoom, value);
                toolTip.SetToolTip(lblType, value);
                toolTip.SetToolTip(lblStatus, value);
                toolTip.SetToolTip(panelStatus, value);
            }
        }

        // PROPERTY MỚI: Tag để lưu thông tin phòng (MaPhong, MaDP, v.v.)
        public object RoomData { get; set; }

        // VẼ VIỀN + SHADOW ĐẸP
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Viền nhẹ
            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }

            // Shadow dưới + phải
            using (SolidBrush shadow = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(shadow, 4, Height - 4, Width - 8, 4);     // dưới
                e.Graphics.FillRectangle(shadow, Width - 4, 4, 4, Height - 8);     // phải
            }
        }

        // Hover effect - làm nổi bật khi di chuột vào
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(240, 248, 255);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.White;
        }
    }
}