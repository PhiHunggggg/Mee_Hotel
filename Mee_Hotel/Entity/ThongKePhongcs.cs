using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mee_Hotel.Entity
{
    class ThongKePhongcs
    {
            public int TongPhong { get; set; }
            public int PhongTrong { get; set; }       // TinhTrang = 1 (Có sẵn)
            public int PhongDangO { get; set; }       // TinhTrang = 3 (Đang có khách)
            public int PhongDangDon { get; set; }     // TinhTrang = 2 (Đang dọn)

            public int TyLeTrong => TongPhong > 0 ?PhongTrong * 100 / TongPhong : 0;
            public int TyLeDangO => TongPhong > 0 ? PhongDangO * 100 / TongPhong : 0;
            public int TyLeDangDon => TongPhong > 0 ? PhongDangDon * 100 / TongPhong : 0;
            public int TyLeLapDay => TyLeDangO; // Tỷ lệ lấp đầy = % đang ở
    }
}
