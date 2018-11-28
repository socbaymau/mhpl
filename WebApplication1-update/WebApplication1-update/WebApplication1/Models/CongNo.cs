using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class CongNo
    {
        public int MaCn { get; set; }
        public int? MaDl { get; set; }
        public DateTime? Ngay { get; set; }
        public double? SoTien { get; set; }
        public int? HoaHong { get; set; }
        public double? TongTien { get; set; }

        public DaiLy MaDlNavigation { get; set; }
    }
}
