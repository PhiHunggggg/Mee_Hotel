using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mee_Hotel.Entity
{
    class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }

        public string LoaiPhong { get; set; }        // Twin Bedroom, Single, VIP...
        public string TrangThai { get; set; }        // Trống, Đang ở, Đang dọn
        public int? PhutConLai { get; set; }         // null = không phải kiểu giờ, còn lại là phút
        public DateTime? ThoiGianTraPhong { get; set; } // để tính tự động còn bao lâu

        public String ThongBao { get; set; } 

    }
}
