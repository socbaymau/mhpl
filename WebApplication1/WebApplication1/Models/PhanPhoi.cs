using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PhanPhoi
    {
        public int MaPp { get; set; }
        public int MaLvs { get; set; }
        public int MaDl { get; set; }
        public DateTime? Ngay { get; set; }
        public int? SoLuongGiao { get; set; }
        public int? SoLuongBan { get; set; }
        public double? TiLe { get; set; }

        public DaiLy MaDlNavigation { get; set; }
        public LoaiVeSo MaLvsNavigation { get; set; }
    }
}
