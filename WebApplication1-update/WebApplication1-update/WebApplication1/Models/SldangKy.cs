using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class SldangKy
    {
        public int MaSldk { get; set; }
        public int MaDl { get; set; }
        public int MaLvs { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public int? SoLuong { get; set; }

        public DaiLy MaDlNavigation { get; set; }
        public LoaiVeSo MaLvsNavigation { get; set; }
    }
}
